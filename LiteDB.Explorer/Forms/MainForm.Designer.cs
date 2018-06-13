﻿namespace LiteDB.Explorer
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tvwDatabase = new System.Windows.Forms.TreeView();
            this.imgList = new System.Windows.Forms.ImageList(this.components);
            this.splitRight = new System.Windows.Forms.SplitContainer();
            this.tabResult = new System.Windows.Forms.TabControl();
            this.tabGrid = new System.Windows.Forms.TabPage();
            this.grdResult = new System.Windows.Forms.DataGridView();
            this.tabText = new System.Windows.Forms.TabPage();
            this.txtResult = new System.Windows.Forms.RichTextBox();
            this.stbStatus = new System.Windows.Forms.StatusStrip();
            this.lblCursor = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblResultCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.prgRunning = new System.Windows.Forms.ToolStripProgressBar();
            this.lblElapsed = new System.Windows.Forms.ToolStripStatusLabel();
            this.tlbMain = new System.Windows.Forms.ToolStrip();
            this.btnConnect = new System.Windows.Forms.ToolStripButton();
            this.tlbSep1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnRefresh = new System.Windows.Forms.ToolStripButton();
            this.tlbSep2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnAdd = new System.Windows.Forms.ToolStripButton();
            this.btnRun = new System.Windows.Forms.ToolStripButton();
            this.ctxMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuIndexes = new System.Windows.Forms.ToolStripMenuItem();
            this.txtSql = new System.Windows.Forms.RichTextBox();
            this.tabSql = new System.Windows.Forms.TabControl();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitRight)).BeginInit();
            this.splitRight.Panel1.SuspendLayout();
            this.splitRight.Panel2.SuspendLayout();
            this.splitRight.SuspendLayout();
            this.tabResult.SuspendLayout();
            this.tabGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdResult)).BeginInit();
            this.tabText.SuspendLayout();
            this.stbStatus.SuspendLayout();
            this.tlbMain.SuspendLayout();
            this.ctxMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtFileName
            // 
            this.txtFileName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFileName.Location = new System.Drawing.Point(5, 37);
            this.txtFileName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(1033, 23);
            this.txtFileName.TabIndex = 0;
            this.txtFileName.Text = ":memory:";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(5, 69);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tvwDatabase);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitRight);
            this.splitContainer1.Panel2.Controls.Add(this.tabSql);
            this.splitContainer1.Size = new System.Drawing.Size(1033, 567);
            this.splitContainer1.SplitterDistance = 280;
            this.splitContainer1.TabIndex = 10;
            this.splitContainer1.TabStop = false;
            // 
            // tvwDatabase
            // 
            this.tvwDatabase.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tvwDatabase.ImageIndex = 0;
            this.tvwDatabase.ImageList = this.imgList;
            this.tvwDatabase.Location = new System.Drawing.Point(0, 0);
            this.tvwDatabase.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tvwDatabase.Name = "tvwDatabase";
            this.tvwDatabase.SelectedImageIndex = 0;
            this.tvwDatabase.Size = new System.Drawing.Size(277, 565);
            this.tvwDatabase.TabIndex = 9;
            this.tvwDatabase.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.TvwCols_NodeMouseDoubleClick);
            this.tvwDatabase.MouseUp += new System.Windows.Forms.MouseEventHandler(this.tvwCols_MouseUp);
            // 
            // imgList
            // 
            this.imgList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgList.ImageStream")));
            this.imgList.TransparentColor = System.Drawing.Color.Transparent;
            this.imgList.Images.SetKeyName(0, "database");
            this.imgList.Images.SetKeyName(1, "folder");
            this.imgList.Images.SetKeyName(2, "table");
            this.imgList.Images.SetKeyName(3, "table_gear");
            // 
            // splitRight
            // 
            this.splitRight.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitRight.Location = new System.Drawing.Point(7, 26);
            this.splitRight.Name = "splitRight";
            this.splitRight.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitRight.Panel1
            // 
            this.splitRight.Panel1.BackColor = System.Drawing.SystemColors.Control;
            this.splitRight.Panel1.Controls.Add(this.txtSql);
            // 
            // splitRight.Panel2
            // 
            this.splitRight.Panel2.Controls.Add(this.tabResult);
            this.splitRight.Size = new System.Drawing.Size(735, 534);
            this.splitRight.SplitterDistance = 163;
            this.splitRight.TabIndex = 8;
            // 
            // tabResult
            // 
            this.tabResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabResult.Controls.Add(this.tabGrid);
            this.tabResult.Controls.Add(this.tabText);
            this.tabResult.Location = new System.Drawing.Point(3, 3);
            this.tabResult.Name = "tabResult";
            this.tabResult.SelectedIndex = 0;
            this.tabResult.Size = new System.Drawing.Size(728, 359);
            this.tabResult.TabIndex = 0;
            this.tabResult.Selected += new System.Windows.Forms.TabControlEventHandler(this.TabResult_Selected);
            // 
            // tabGrid
            // 
            this.tabGrid.Controls.Add(this.grdResult);
            this.tabGrid.Location = new System.Drawing.Point(4, 24);
            this.tabGrid.Name = "tabGrid";
            this.tabGrid.Padding = new System.Windows.Forms.Padding(3);
            this.tabGrid.Size = new System.Drawing.Size(720, 331);
            this.tabGrid.TabIndex = 0;
            this.tabGrid.Text = "Grid";
            this.tabGrid.UseVisualStyleBackColor = true;
            // 
            // grdResult
            // 
            this.grdResult.AllowUserToAddRows = false;
            this.grdResult.AllowUserToDeleteRows = false;
            this.grdResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdResult.Location = new System.Drawing.Point(6, 5);
            this.grdResult.Name = "grdResult";
            this.grdResult.Size = new System.Drawing.Size(708, 324);
            this.grdResult.TabIndex = 0;
            this.grdResult.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.GrdResult_CellBeginEdit);
            this.grdResult.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.GrdResult_CellEndEdit);
            this.grdResult.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.GrdResult_RowPostPaint);
            // 
            // tabText
            // 
            this.tabText.Controls.Add(this.txtResult);
            this.tabText.Location = new System.Drawing.Point(4, 22);
            this.tabText.Name = "tabText";
            this.tabText.Padding = new System.Windows.Forms.Padding(3);
            this.tabText.Size = new System.Drawing.Size(738, 358);
            this.tabText.TabIndex = 3;
            this.tabText.Text = "Text";
            this.tabText.UseVisualStyleBackColor = true;
            // 
            // txtResult
            // 
            this.txtResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtResult.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResult.Location = new System.Drawing.Point(6, 5);
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.Size = new System.Drawing.Size(726, 353);
            this.txtResult.TabIndex = 0;
            this.txtResult.Text = "";
            // 
            // stbStatus
            // 
            this.stbStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblCursor,
            this.lblResultCount,
            this.prgRunning,
            this.lblElapsed});
            this.stbStatus.Location = new System.Drawing.Point(0, 638);
            this.stbStatus.Name = "stbStatus";
            this.stbStatus.Size = new System.Drawing.Size(1043, 22);
            this.stbStatus.TabIndex = 11;
            this.stbStatus.Text = "statusStrip1";
            // 
            // lblCursor
            // 
            this.lblCursor.Name = "lblCursor";
            this.lblCursor.Size = new System.Drawing.Size(666, 17);
            this.lblCursor.Spring = true;
            this.lblCursor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblResultCount
            // 
            this.lblResultCount.AutoSize = false;
            this.lblResultCount.Name = "lblResultCount";
            this.lblResultCount.Size = new System.Drawing.Size(150, 17);
            this.lblResultCount.Text = "0 documents";
            // 
            // prgRunning
            // 
            this.prgRunning.Name = "prgRunning";
            this.prgRunning.Size = new System.Drawing.Size(100, 16);
            // 
            // lblElapsed
            // 
            this.lblElapsed.AutoSize = false;
            this.lblElapsed.Name = "lblElapsed";
            this.lblElapsed.Size = new System.Drawing.Size(110, 17);
            this.lblElapsed.Text = "00:00:00.0000";
            this.lblElapsed.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tlbMain
            // 
            this.tlbMain.GripMargin = new System.Windows.Forms.Padding(3);
            this.tlbMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnConnect,
            this.tlbSep1,
            this.btnRefresh,
            this.tlbSep2,
            this.btnAdd,
            this.btnRun});
            this.tlbMain.Location = new System.Drawing.Point(0, 0);
            this.tlbMain.Name = "tlbMain";
            this.tlbMain.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.tlbMain.Size = new System.Drawing.Size(1043, 33);
            this.tlbMain.TabIndex = 12;
            this.tlbMain.Text = "toolStrip";
            // 
            // btnConnect
            // 
            this.btnConnect.Image = ((System.Drawing.Image)(resources.GetObject("btnConnect.Image")));
            this.btnConnect.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Padding = new System.Windows.Forms.Padding(3);
            this.btnConnect.Size = new System.Drawing.Size(78, 26);
            this.btnConnect.Text = "Connect";
            this.btnConnect.Click += new System.EventHandler(this.BtnConnect_Click);
            // 
            // tlbSep1
            // 
            this.tlbSep1.Name = "tlbSep1";
            this.tlbSep1.Size = new System.Drawing.Size(6, 29);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Image")));
            this.btnRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Padding = new System.Windows.Forms.Padding(3);
            this.btnRefresh.Size = new System.Drawing.Size(72, 26);
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // tlbSep2
            // 
            this.tlbSep2.Name = "tlbSep2";
            this.tlbSep2.Size = new System.Drawing.Size(6, 29);
            // 
            // btnAdd
            // 
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Padding = new System.Windows.Forms.Padding(3);
            this.btnAdd.Size = new System.Drawing.Size(57, 26);
            this.btnAdd.Text = "New";
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // btnRun
            // 
            this.btnRun.Image = ((System.Drawing.Image)(resources.GetObject("btnRun.Image")));
            this.btnRun.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRun.Name = "btnRun";
            this.btnRun.Padding = new System.Windows.Forms.Padding(3);
            this.btnRun.Size = new System.Drawing.Size(54, 26);
            this.btnRun.Text = "Run";
            this.btnRun.Click += new System.EventHandler(this.BtnRun_Click);
            // 
            // ctxMenu
            // 
            this.ctxMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuIndexes});
            this.ctxMenu.Name = "ctxMenu";
            this.ctxMenu.Size = new System.Drawing.Size(114, 26);
            this.ctxMenu.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.ctxMenu_ItemClicked);
            // 
            // mnuIndexes
            // 
            this.mnuIndexes.Image = ((System.Drawing.Image)(resources.GetObject("mnuIndexes.Image")));
            this.mnuIndexes.Name = "mnuIndexes";
            this.mnuIndexes.Size = new System.Drawing.Size(113, 22);
            this.mnuIndexes.Tag = "SELECT $ FROM $indexes WHERE collection = \"{0}\"";
            this.mnuIndexes.Text = "Indexes";
            // 
            // txtSql
            // 
            this.txtSql.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSql.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSql.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSql.Location = new System.Drawing.Point(3, 3);
            this.txtSql.Name = "txtSql";
            this.txtSql.Size = new System.Drawing.Size(728, 157);
            this.txtSql.TabIndex = 2;
            this.txtSql.Text = "";
            // 
            // tabSql
            // 
            this.tabSql.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabSql.Location = new System.Drawing.Point(0, 0);
            this.tabSql.Name = "tabSql";
            this.tabSql.SelectedIndex = 0;
            this.tabSql.Size = new System.Drawing.Size(749, 567);
            this.tabSql.TabIndex = 9;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1043, 660);
            this.Controls.Add(this.tlbMain);
            this.Controls.Add(this.stbStatus);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.txtFileName);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LiteDB.Explorer";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitRight.Panel1.ResumeLayout(false);
            this.splitRight.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitRight)).EndInit();
            this.splitRight.ResumeLayout(false);
            this.tabResult.ResumeLayout(false);
            this.tabGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdResult)).EndInit();
            this.tabText.ResumeLayout(false);
            this.stbStatus.ResumeLayout(false);
            this.stbStatus.PerformLayout();
            this.tlbMain.ResumeLayout(false);
            this.tlbMain.PerformLayout();
            this.ctxMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TreeView tvwDatabase;
        private System.Windows.Forms.StatusStrip stbStatus;
        private System.Windows.Forms.SplitContainer splitRight;
        private System.Windows.Forms.ToolStripStatusLabel lblElapsed;
        private System.Windows.Forms.TabControl tabResult;
        private System.Windows.Forms.TabPage tabGrid;
        private System.Windows.Forms.DataGridView grdResult;
        private System.Windows.Forms.TabPage tabText;
        private System.Windows.Forms.RichTextBox txtResult;
        private System.Windows.Forms.ToolStripStatusLabel lblResultCount;
        private System.Windows.Forms.ToolStrip tlbMain;
        private System.Windows.Forms.ToolStripButton btnConnect;
        private System.Windows.Forms.ToolStripButton btnAdd;
        private System.Windows.Forms.ToolStripButton btnRun;
        private System.Windows.Forms.ToolStripSeparator tlbSep1;
        private System.Windows.Forms.ToolStripButton btnRefresh;
        private System.Windows.Forms.ToolStripSeparator tlbSep2;
        private System.Windows.Forms.ToolStripStatusLabel lblCursor;
        private System.Windows.Forms.ToolStripProgressBar prgRunning;
        private System.Windows.Forms.ImageList imgList;
        private System.Windows.Forms.ContextMenuStrip ctxMenu;
        private System.Windows.Forms.ToolStripMenuItem mnuIndexes;
        private System.Windows.Forms.RichTextBox txtSql;
        private System.Windows.Forms.TabControl tabSql;
    }
}

