﻿using System;
using System.Collections.Generic;
using System.Linq;
using static LiteDB.Constants;

namespace LiteDB.Engine
{
    /// <summary>
    /// Class that optimize query transforming QueryDefinition into QueryPlan
    /// </summary>
    internal class QueryOptimization
    {
        private readonly Snapshot _snapshot;
        private readonly QueryDefinition _queryDefinition;
        private readonly QueryPlan _query;

        public QueryOptimization(Snapshot snapshot, QueryDefinition queryDefinition, IEnumerable<BsonDocument> source)
        {
            _snapshot = snapshot;
            _queryDefinition = queryDefinition;

            _query = new QueryPlan(snapshot.CollectionPage.CollectionName)
            {
                // define index only if source are external collection
                Index = source != null ? new IndexVirtual(source) : null,
                Select = new Select(queryDefinition.Select, queryDefinition.SelectAll),
                ForUpdate = queryDefinition.ForUpdate,
                Limit = queryDefinition.Limit,
                Offset = queryDefinition.Offset
            };
        }

        /// <summary>
        /// Build QueryPlan instance based on QueryBuilder fields
        /// - Load used fields in all expressions
        /// - Select best index option
        /// - Fill includes 
        /// - Define orderBy
        /// - Define groupBy
        /// </summary>
        public QueryPlan ProcessQuery()
        {
            // define Fields
            this.DefineQueryFields();

            // define Index, IndexCost, IndexExpression, IsIndexKeyOnly + Where (filters - index)
            this.DefineIndex();

            // define OrderBy
            this.DefineOrderBy();

            // define GroupBy
            this.DefineGroupBy();

            // define IncludeBefore + IncludeAfter
            this.DefineIncludes();

            return _query;
        }

        #region Document Fields

        /// <summary>
        /// Load all fields that must be deserialize from document.
        /// </summary>
        private void DefineQueryFields()
        {
            // load only query fields (null return all document)
            var fields = new HashSet<string>(StringComparer.OrdinalIgnoreCase);

            // include all fields detected in all used expressions
            fields.AddRange(_queryDefinition.Select?.Fields ?? new HashSet<string>(StringComparer.OrdinalIgnoreCase) { "$" });
            fields.AddRange(_queryDefinition.Where.SelectMany(x => x.Fields));
            fields.AddRange(_queryDefinition.Includes.SelectMany(x => x.Fields));
            fields.AddRange(_queryDefinition.GroupBy?.Fields);
            fields.AddRange(_queryDefinition.Having?.Fields);
            fields.AddRange(_queryDefinition.OrderBy?.Fields);

            // if contains $, all fields must be deserialized
            if (fields.Contains("$"))
            {
                fields.Clear();
            }

            _query.Fields = fields;
        }

        #endregion

        #region Index Definition

        private void DefineIndex()
        {
            // selected expression to be used as index
            BsonExpression selected = null;

            // if index are not defined yet, get index
            if (_query.Index == null)
            {
                // try select best index (or any index)
                var indexCost = this.ChooseIndex(_query.Fields);

                // if found an index, use-it
                if (indexCost != null)
                {
                    _query.Index = indexCost.Index;
                    _query.IndexCost = indexCost.Cost;
                    _query.IndexExpression = indexCost.IndexExpression;
                }
                else
                {
                    // if has no index to use, use full scan over _id
                    var pk = _snapshot.CollectionPage.GetIndex(0);

                    _query.Index = new IndexAll("_id", Query.Ascending);
                    _query.IndexCost = _query.Index.GetCost(pk);
                    _query.IndexExpression = "$._id";
                }

                // get selected expression used as index
                selected = indexCost?.Expression;
            }
            else
            {
                // find query user defined index (must exists)
                var idx = _snapshot.CollectionPage.GetIndex(_query.Index.Name);

                if (idx == null) throw LiteException.IndexNotFound(_query.Index.Name, _snapshot.CollectionPage.CollectionName);

                _query.IndexCost = _query.Index.GetCost(idx);
                _query.IndexExpression = idx.Expression;
            }

            // if is only 1 field to deserialize and this field are same as index, use IndexKeyOnly = rue
            if (_query.Fields.Count == 1 && _query.IndexExpression == "$." + _query.Fields.First())
            {
                _query.IsIndexKeyOnly = true;
            }

            // fill filter using all expressions
            _query.Filters.AddRange(_queryDefinition.Where.Where(x => x != selected));
        }

        /// <summary>
        /// Try select best index (lowest cost) to this list of where expressions
        /// </summary>
        private IndexCost ChooseIndex(HashSet<string> fields)
        {
            var indexes = _snapshot.CollectionPage.GetIndexes(true).ToArray();

            // if query contains a single field used, give preferred if this index exists
            var preferred = fields.Count == 1 ? "$." + fields.First() : null;

            // otherwise, check for lowest index cost
            IndexCost lowest = null;

            // test all possible predicates in where (exclude OR/ANR)
            foreach (var expr in _queryDefinition.Where.Where(x => x.IsPredicate))
            {
                DEBUG(expr.Left == null || expr.Right == null, "predicate expression must has left/right expressions");

                // get index that match with expression left/right side 
                var index = indexes
                    .Where(x => x.Expression == expr.Left.Source && expr.Right.IsValue)
                    .Select(x => Tuple.Create(x, expr.Right))
                    .Union(indexes
                        .Where(x => x.Expression == expr.Right.Source && expr.Left.IsValue)
                        .Select(x => Tuple.Create(x, expr.Left))
                    ).FirstOrDefault();

                if (index == null) continue;

                // calculate index score and store highest score
                var current = new IndexCost(index.Item1, expr, index.Item2);

                if (lowest == null || current.Cost < lowest.Cost)
                {
                    lowest = current;
                }
            }

            // if no index found, try use same index in orderby/groupby/preferred
            if (lowest == null && (_queryDefinition.OrderBy != null || _queryDefinition.GroupBy != null || preferred != null))
            {
                var index = 
                    indexes.FirstOrDefault(x => x.Expression == _queryDefinition.OrderBy?.Source) ??
                    indexes.FirstOrDefault(x => x.Expression == _queryDefinition.GroupBy?.Source) ??
                    indexes.FirstOrDefault(x => x.Expression == preferred);

                if (index != null)
                {
                    lowest = new IndexCost(index);
                }
            }

            return lowest;
        }

        #endregion

        #region OrderBy / GroupBy Definition

        /// <summary>
        /// Define OrderBy optimization (try re-use index)
        /// </summary>
        private void DefineOrderBy()
        {
            // if has no order by, returns null
            if (_queryDefinition.OrderBy == null) return;

            var orderBy = new OrderBy(_queryDefinition.OrderBy, _queryDefinition.Order);

            // if index expression are same as orderBy, use index to sort - just update index order
            if (orderBy.Expression.Source == _query.IndexExpression)
            {
                // re-use index order and no not run OrderBy
                _query.Index.Order = orderBy.Order;

                // in this case "query.OrderBy" will be null
            }
            else
            {
                // otherwise, query.OrderBy will be setted according user defined
                _query.OrderBy = orderBy;
            }
        }

        /// <summary>
        /// Define GroupBy optimization (try re-use index)
        /// </summary>
        private void DefineGroupBy()
        {
            if (_queryDefinition.GroupBy == null) return;

            var groupBy = new GroupBy(_queryDefinition.GroupBy, _queryDefinition.Select, _queryDefinition.Having);

            // if groupBy use same expression in index, set group by order to MaxValue to not run
            if (groupBy.Expression.Source == _query.IndexExpression)
            {
                // do not sort when run groupBy (already sorted by index)
                groupBy.Order = 0;
            }
            else
            {
                // by default, groupBy sort as ASC only
                groupBy.Order = Query.Ascending;
            }

            _query.GroupBy = groupBy;
        }

        #endregion

        /// <summary>
        /// Will define each include to be run BEFORE where (worst) OR AFTER where (best)
        /// </summary>
        private void DefineIncludes()
        {
            foreach(var include in _queryDefinition.Includes)
            {
                // includes always has one single field
                var field = include.Fields.Single();

                // test if field are using in any filter
                var used = _query.Filters.Any(x => x.Fields.Contains(field));

                if (used)
                {
                    _query.IncludeBefore.Add(include);
                }
                else
                {
                    _query.IncludeAfter.Add(include);
                }
            }
        }
    }
}