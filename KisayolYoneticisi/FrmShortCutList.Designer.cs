namespace KisayolYoneticisi
{
    partial class FrmShortCutList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmShortCutList));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lstShortCuts = new System.Windows.Forms.ListView();
            this.clmnName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmnPath = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmnDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ctxMnLstVw = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToExceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.elementsAtListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openInFileExplorerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.grpBxSearch = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.cmbxTur = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtArama = new System.Windows.Forms.TextBox();
            this.grpBxOperations = new System.Windows.Forms.GroupBox();
            this.tblLytOperations = new System.Windows.Forms.TableLayoutPanel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.mnStrpMain = new System.Windows.Forms.MenuStrip();
            this.genelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutUsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shortcutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shortcutListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1.SuspendLayout();
            this.ctxMnLstVw.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.grpBxSearch.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.grpBxOperations.SuspendLayout();
            this.tblLytOperations.SuspendLayout();
            this.mnStrpMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.lstShortCuts, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel5, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 24);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 73.62386F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 26.37615F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(720, 473);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lstShortCuts
            // 
            this.lstShortCuts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstShortCuts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmnName,
            this.clmnPath,
            this.clmnDate});
            this.lstShortCuts.ContextMenuStrip = this.ctxMnLstVw;
            this.lstShortCuts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstShortCuts.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lstShortCuts.FullRowSelect = true;
            this.lstShortCuts.GridLines = true;
            this.lstShortCuts.Location = new System.Drawing.Point(3, 4);
            this.lstShortCuts.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lstShortCuts.MultiSelect = false;
            this.lstShortCuts.Name = "lstShortCuts";
            this.lstShortCuts.Size = new System.Drawing.Size(714, 340);
            this.lstShortCuts.TabIndex = 0;
            this.lstShortCuts.UseCompatibleStateImageBehavior = false;
            this.lstShortCuts.View = System.Windows.Forms.View.Details;
            this.lstShortCuts.DoubleClick += new System.EventHandler(this.lstShortCuts_DoubleClick);
            this.lstShortCuts.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyDownMethod);
            // 
            // clmnName
            // 
            this.clmnName.Text = "Shortcut Name";
            this.clmnName.Width = 99;
            // 
            // clmnPath
            // 
            this.clmnPath.Text = "Shortcut Path";
            this.clmnPath.Width = 385;
            // 
            // clmnDate
            // 
            this.clmnDate.Text = "Creation Date";
            this.clmnDate.Width = 137;
            // 
            // ctxMnLstVw
            // 
            this.ctxMnLstVw.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ctxMnLstVw.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.updateToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.exportToExceToolStripMenuItem,
            this.openInFileExplorerToolStripMenuItem});
            this.ctxMnLstVw.Name = "ctxMnLstVw";
            this.ctxMnLstVw.Size = new System.Drawing.Size(206, 124);
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(205, 24);
            this.addToolStripMenuItem.Text = "Add";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.Add);
            // 
            // updateToolStripMenuItem
            // 
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            this.updateToolStripMenuItem.Size = new System.Drawing.Size(205, 24);
            this.updateToolStripMenuItem.Text = "Update";
            this.updateToolStripMenuItem.Click += new System.EventHandler(this.Update);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(205, 24);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.Delete);
            // 
            // exportToExceToolStripMenuItem
            // 
            this.exportToExceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.elementsAtListToolStripMenuItem,
            this.allListToolStripMenuItem});
            this.exportToExceToolStripMenuItem.Name = "exportToExceToolStripMenuItem";
            this.exportToExceToolStripMenuItem.Size = new System.Drawing.Size(205, 24);
            this.exportToExceToolStripMenuItem.Text = "Export To Excel";
            // 
            // elementsAtListToolStripMenuItem
            // 
            this.elementsAtListToolStripMenuItem.Name = "elementsAtListToolStripMenuItem";
            this.elementsAtListToolStripMenuItem.Size = new System.Drawing.Size(176, 24);
            this.elementsAtListToolStripMenuItem.Text = "Elements At List";
            this.elementsAtListToolStripMenuItem.Click += new System.EventHandler(this.elementsAtListToolStripMenuItem_Click);
            // 
            // allListToolStripMenuItem
            // 
            this.allListToolStripMenuItem.Name = "allListToolStripMenuItem";
            this.allListToolStripMenuItem.Size = new System.Drawing.Size(176, 24);
            this.allListToolStripMenuItem.Text = "All List";
            this.allListToolStripMenuItem.Click += new System.EventHandler(this.allListToolStripMenuItem_Click);
            // 
            // openInFileExplorerToolStripMenuItem
            // 
            this.openInFileExplorerToolStripMenuItem.Name = "openInFileExplorerToolStripMenuItem";
            this.openInFileExplorerToolStripMenuItem.Size = new System.Drawing.Size(205, 24);
            this.openInFileExplorerToolStripMenuItem.Text = "Open In File Explorer";
            this.openInFileExplorerToolStripMenuItem.Click += new System.EventHandler(this.openInFileExplorer);
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Controls.Add(this.grpBxSearch, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.grpBxOperations, 1, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 351);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(714, 119);
            this.tableLayoutPanel5.TabIndex = 1;
            // 
            // grpBxSearch
            // 
            this.grpBxSearch.Controls.Add(this.tableLayoutPanel4);
            this.grpBxSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpBxSearch.Location = new System.Drawing.Point(3, 3);
            this.grpBxSearch.Name = "grpBxSearch";
            this.grpBxSearch.Size = new System.Drawing.Size(351, 113);
            this.grpBxSearch.TabIndex = 4;
            this.grpBxSearch.TabStop = false;
            this.grpBxSearch.Text = "Search";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 3;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 140F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.cmbxTur, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.txtArama, 1, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 19);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(345, 91);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // cmbxTur
            // 
            this.cmbxTur.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbxTur.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxTur.FormattingEnabled = true;
            this.cmbxTur.Items.AddRange(new object[] {
            "Name",
            "Path"});
            this.cmbxTur.Location = new System.Drawing.Point(123, 57);
            this.cmbxTur.Name = "cmbxTur";
            this.cmbxTur.Size = new System.Drawing.Size(134, 24);
            this.cmbxTur.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 60);
            this.label2.Margin = new System.Windows.Forms.Padding(10, 0, 3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Search Type:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(10, 0, 3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Search String :";
            // 
            // txtArama
            // 
            this.txtArama.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtArama.Location = new System.Drawing.Point(123, 11);
            this.txtArama.Name = "txtArama";
            this.txtArama.Size = new System.Drawing.Size(134, 23);
            this.txtArama.TabIndex = 3;
            this.txtArama.TextChanged += new System.EventHandler(this.Search);
            this.txtArama.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtArama_KeyDown);
            // 
            // grpBxOperations
            // 
            this.grpBxOperations.Controls.Add(this.tblLytOperations);
            this.grpBxOperations.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpBxOperations.Location = new System.Drawing.Point(360, 3);
            this.grpBxOperations.Name = "grpBxOperations";
            this.grpBxOperations.Size = new System.Drawing.Size(351, 113);
            this.grpBxOperations.TabIndex = 5;
            this.grpBxOperations.TabStop = false;
            this.grpBxOperations.Text = "Operations";
            // 
            // tblLytOperations
            // 
            this.tblLytOperations.ColumnCount = 3;
            this.tblLytOperations.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblLytOperations.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblLytOperations.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblLytOperations.Controls.Add(this.btnAdd, 0, 0);
            this.tblLytOperations.Controls.Add(this.btnGuncelle, 1, 0);
            this.tblLytOperations.Controls.Add(this.btnSil, 2, 0);
            this.tblLytOperations.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLytOperations.Location = new System.Drawing.Point(3, 19);
            this.tblLytOperations.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tblLytOperations.Name = "tblLytOperations";
            this.tblLytOperations.RowCount = 1;
            this.tblLytOperations.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLytOperations.Size = new System.Drawing.Size(345, 91);
            this.tblLytOperations.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAdd.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAdd.Location = new System.Drawing.Point(14, 31);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(87, 28);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.Add);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGuncelle.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGuncelle.Location = new System.Drawing.Point(129, 31);
            this.btnGuncelle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(87, 28);
            this.btnGuncelle.TabIndex = 1;
            this.btnGuncelle.Text = "Update";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.Update);
            // 
            // btnSil
            // 
            this.btnSil.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSil.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.Location = new System.Drawing.Point(244, 31);
            this.btnSil.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(87, 28);
            this.btnSil.TabIndex = 2;
            this.btnSil.Text = "Delete";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.Delete);
            // 
            // mnStrpMain
            // 
            this.mnStrpMain.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.mnStrpMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.genelToolStripMenuItem});
            this.mnStrpMain.Location = new System.Drawing.Point(0, 0);
            this.mnStrpMain.Name = "mnStrpMain";
            this.mnStrpMain.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.mnStrpMain.Size = new System.Drawing.Size(720, 24);
            this.mnStrpMain.TabIndex = 1;
            this.mnStrpMain.Text = "menuStrip1";
            // 
            // genelToolStripMenuItem
            // 
            this.genelToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutUsToolStripMenuItem,
            this.shortcutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.genelToolStripMenuItem.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.genelToolStripMenuItem.Name = "genelToolStripMenuItem";
            this.genelToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.genelToolStripMenuItem.Text = "&General";
            // 
            // aboutUsToolStripMenuItem
            // 
            this.aboutUsToolStripMenuItem.Name = "aboutUsToolStripMenuItem";
            this.aboutUsToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.aboutUsToolStripMenuItem.Text = "&About Us";
            this.aboutUsToolStripMenuItem.Click += new System.EventHandler(this.toolItemAbout);
            // 
            // shortcutToolStripMenuItem
            // 
            this.shortcutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createToolStripMenuItem,
            this.shortcutListToolStripMenuItem});
            this.shortcutToolStripMenuItem.Name = "shortcutToolStripMenuItem";
            this.shortcutToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.shortcutToolStripMenuItem.Text = "Shortcut";
            // 
            // createToolStripMenuItem
            // 
            this.createToolStripMenuItem.Name = "createToolStripMenuItem";
            this.createToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.createToolStripMenuItem.Text = "Create Shortcut";
            this.createToolStripMenuItem.Click += new System.EventHandler(this.createToolStripMenuItem_Click);
            // 
            // shortcutListToolStripMenuItem
            // 
            this.shortcutListToolStripMenuItem.Name = "shortcutListToolStripMenuItem";
            this.shortcutListToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.shortcutListToolStripMenuItem.Text = "Shortcut List";
            this.shortcutListToolStripMenuItem.Click += new System.EventHandler(this.shortcutListToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.exitToolStripMenuItem.Text = "&Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // FrmShortCutList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 497);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.mnStrpMain);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mnStrpMain;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(740, 540);
            this.MinimumSize = new System.Drawing.Size(740, 540);
            this.Name = "FrmShortCutList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Shortcut Manager";
            this.Load += new System.EventHandler(this.FrmShortCutList_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ctxMnLstVw.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.grpBxSearch.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.grpBxOperations.ResumeLayout(false);
            this.tblLytOperations.ResumeLayout(false);
            this.mnStrpMain.ResumeLayout(false);
            this.mnStrpMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ListView lstShortCuts;
        private System.Windows.Forms.ColumnHeader clmnName;
        private System.Windows.Forms.ColumnHeader clmnPath;
        private System.Windows.Forms.ColumnHeader clmnDate;
        private System.Windows.Forms.MenuStrip mnStrpMain;
        private System.Windows.Forms.ToolStripMenuItem genelToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tblLytOperations;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbxTur;
        private System.Windows.Forms.TextBox txtArama;
        private System.Windows.Forms.ContextMenuStrip ctxMnLstVw;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutUsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.GroupBox grpBxSearch;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.GroupBox grpBxOperations;
        private System.Windows.Forms.ToolStripMenuItem exportToExceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem shortcutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem shortcutListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openInFileExplorerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem elementsAtListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allListToolStripMenuItem;
    }
}

