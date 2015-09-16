namespace FrontFlag.Control
{
    partial class FindList2
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose ( bool disposing )
        {
            if ( disposing && ( components != null ) )
            {
                components.Dispose ();
            }
            base.Dispose ( disposing );
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent ()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            FrontFlag.FUN.POPEDOMBYTE popedombyte1 = new FrontFlag.FUN.POPEDOMBYTE();
            this.pnlTitleBar = new System.Windows.Forms.Panel();
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.labTitleMsg = new System.Windows.Forms.Label();
            this.pnlTitle = new System.Windows.Forms.Panel();
            this.labTitle = new System.Windows.Forms.Label();
            this.pnlPrint = new System.Windows.Forms.Panel();
            this.btnPrint = new System.Windows.Forms.Label();
            this.pnlExcel = new System.Windows.Forms.Panel();
            this.btnExcel = new System.Windows.Forms.Label();
            this.menuExcel = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuExcel_Import = new System.Windows.Forms.ToolStripMenuItem();
            this.menuExcel_Sample = new System.Windows.Forms.ToolStripMenuItem();
            this.splitExcelOut = new System.Windows.Forms.ToolStripSeparator();
            this.menuExcel_Export = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlSwitchFind = new System.Windows.Forms.Panel();
            this.pnlExtern = new System.Windows.Forms.Panel();
            this.pnlFind = new System.Windows.Forms.Panel();
            this.pnlButtom = new System.Windows.Forms.Panel();
            this.pnlFoot = new System.Windows.Forms.Panel();
            this.pnlGrd = new System.Windows.Forms.Panel();
            this.splt = new System.Windows.Forms.Splitter();
            this.pnlDown = new System.Windows.Forms.Panel();
            this.bindSrc = new System.Windows.Forms.BindingSource(this.components);
            this.grd = new FrontFlag.Control.XDataGridView(this.components);
            this.btnShowFind = new FrontFlag.Control.XButton();
            this.pnlTitleBar.SuspendLayout();
            this.pnlLeft.SuspendLayout();
            this.pnlMenu.SuspendLayout();
            this.pnlTitle.SuspendLayout();
            this.pnlPrint.SuspendLayout();
            this.pnlExcel.SuspendLayout();
            this.menuExcel.SuspendLayout();
            this.pnlSwitchFind.SuspendLayout();
            this.pnlButtom.SuspendLayout();
            this.pnlGrd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindSrc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grd)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTitleBar
            // 
            this.pnlTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(224)))), ((int)(((byte)(255)))));
            this.pnlTitleBar.Controls.Add(this.pnlLeft);
            this.pnlTitleBar.Controls.Add(this.pnlPrint);
            this.pnlTitleBar.Controls.Add(this.pnlExcel);
            this.pnlTitleBar.Controls.Add(this.pnlSwitchFind);
            this.pnlTitleBar.Controls.Add(this.pnlExtern);
            this.pnlTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitleBar.Location = new System.Drawing.Point(0, 0);
            this.pnlTitleBar.Name = "pnlTitleBar";
            this.pnlTitleBar.Size = new System.Drawing.Size(917, 32);
            this.pnlTitleBar.TabIndex = 0;
            // 
            // pnlLeft
            // 
            this.pnlLeft.BackColor = System.Drawing.Color.Transparent;
            this.pnlLeft.Controls.Add(this.pnlMenu);
            this.pnlLeft.Controls.Add(this.pnlTitle);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlLeft.ForeColor = System.Drawing.Color.Red;
            this.pnlLeft.Location = new System.Drawing.Point(0, 0);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(737, 32);
            this.pnlLeft.TabIndex = 9;
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.Transparent;
            this.pnlMenu.Controls.Add(this.labTitleMsg);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMenu.Location = new System.Drawing.Point(260, 0);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(477, 32);
            this.pnlMenu.TabIndex = 9;
            // 
            // labTitleMsg
            // 
            this.labTitleMsg.AutoSize = true;
            this.labTitleMsg.Location = new System.Drawing.Point(412, 11);
            this.labTitleMsg.Name = "labTitleMsg";
            this.labTitleMsg.Size = new System.Drawing.Size(41, 12);
            this.labTitleMsg.TabIndex = 0;
            this.labTitleMsg.Text = "      ";
            // 
            // pnlTitle
            // 
            this.pnlTitle.BackColor = System.Drawing.Color.Transparent;
            this.pnlTitle.Controls.Add(this.labTitle);
            this.pnlTitle.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlTitle.Location = new System.Drawing.Point(0, 0);
            this.pnlTitle.Name = "pnlTitle";
            this.pnlTitle.Size = new System.Drawing.Size(260, 32);
            this.pnlTitle.TabIndex = 8;
            // 
            // labTitle
            // 
            this.labTitle.AutoSize = true;
            this.labTitle.Font = new System.Drawing.Font("宋体", 14F);
            this.labTitle.ForeColor = System.Drawing.Color.MintCream;
            this.labTitle.Location = new System.Drawing.Point(8, 7);
            this.labTitle.Name = "labTitle";
            this.labTitle.Size = new System.Drawing.Size(79, 19);
            this.labTitle.TabIndex = 2;
            this.labTitle.Text = "       ";
            // 
            // pnlPrint
            // 
            this.pnlPrint.BackColor = System.Drawing.Color.Transparent;
            this.pnlPrint.Controls.Add(this.btnPrint);
            this.pnlPrint.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlPrint.Location = new System.Drawing.Point(737, 0);
            this.pnlPrint.Name = "pnlPrint";
            this.pnlPrint.Size = new System.Drawing.Size(50, 32);
            this.pnlPrint.TabIndex = 7;
            this.pnlPrint.Visible = false;
            // 
            // btnPrint
            // 
            this.btnPrint.AutoSize = true;
            this.btnPrint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrint.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnPrint.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnPrint.Location = new System.Drawing.Point(9, 10);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(29, 12);
            this.btnPrint.TabIndex = 5;
            this.btnPrint.Text = "打印";
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // pnlExcel
            // 
            this.pnlExcel.BackColor = System.Drawing.Color.Transparent;
            this.pnlExcel.Controls.Add(this.btnExcel);
            this.pnlExcel.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlExcel.Location = new System.Drawing.Point(787, 0);
            this.pnlExcel.Name = "pnlExcel";
            this.pnlExcel.Size = new System.Drawing.Size(50, 32);
            this.pnlExcel.TabIndex = 6;
            this.pnlExcel.Visible = false;
            // 
            // btnExcel
            // 
            this.btnExcel.AutoSize = true;
            this.btnExcel.ContextMenuStrip = this.menuExcel;
            this.btnExcel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExcel.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnExcel.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnExcel.Location = new System.Drawing.Point(8, 10);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(29, 12);
            this.btnExcel.TabIndex = 4;
            this.btnExcel.Text = "导出";
            this.btnExcel.Click += new System.EventHandler(this.btnExcelClick);
            // 
            // menuExcel
            // 
            this.menuExcel.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuExcel_Import,
            this.menuExcel_Sample,
            this.splitExcelOut,
            this.menuExcel_Export});
            this.menuExcel.Name = "menuExcel";
            this.menuExcel.Size = new System.Drawing.Size(186, 76);
            // 
            // menuExcel_Import
            // 
            this.menuExcel_Import.Name = "menuExcel_Import";
            this.menuExcel_Import.Size = new System.Drawing.Size(185, 22);
            this.menuExcel_Import.Text = "Import From File";
            this.menuExcel_Import.Visible = false;
            this.menuExcel_Import.Click += new System.EventHandler(this.menuExcel_ImportClick);
            // 
            // menuExcel_Sample
            // 
            this.menuExcel_Sample.Name = "menuExcel_Sample";
            this.menuExcel_Sample.Size = new System.Drawing.Size(185, 22);
            this.menuExcel_Sample.Text = "Load Sample Excel";
            this.menuExcel_Sample.Visible = false;
            this.menuExcel_Sample.Click += new System.EventHandler(this.menuExcel_SampleClick);
            // 
            // splitExcelOut
            // 
            this.splitExcelOut.Name = "splitExcelOut";
            this.splitExcelOut.Size = new System.Drawing.Size(182, 6);
            this.splitExcelOut.Visible = false;
            // 
            // menuExcel_Export
            // 
            this.menuExcel_Export.Name = "menuExcel_Export";
            this.menuExcel_Export.Size = new System.Drawing.Size(185, 22);
            this.menuExcel_Export.Text = "Export To File";
            this.menuExcel_Export.Visible = false;
            this.menuExcel_Export.Click += new System.EventHandler(this.menuExcel_ExportClick);
            // 
            // pnlSwitchFind
            // 
            this.pnlSwitchFind.BackColor = System.Drawing.Color.Transparent;
            this.pnlSwitchFind.Controls.Add(this.btnShowFind);
            this.pnlSwitchFind.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlSwitchFind.Location = new System.Drawing.Point(837, 0);
            this.pnlSwitchFind.Name = "pnlSwitchFind";
            this.pnlSwitchFind.Size = new System.Drawing.Size(40, 32);
            this.pnlSwitchFind.TabIndex = 5;
            this.pnlSwitchFind.Visible = false;
            // 
            // pnlExtern
            // 
            this.pnlExtern.BackColor = System.Drawing.Color.Transparent;
            this.pnlExtern.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlExtern.Location = new System.Drawing.Point(877, 0);
            this.pnlExtern.Name = "pnlExtern";
            this.pnlExtern.Size = new System.Drawing.Size(40, 32);
            this.pnlExtern.TabIndex = 8;
            this.pnlExtern.Visible = false;
            // 
            // pnlFind
            // 
            this.pnlFind.BackColor = System.Drawing.Color.White;
            this.pnlFind.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFind.Location = new System.Drawing.Point(0, 32);
            this.pnlFind.Name = "pnlFind";
            this.pnlFind.Size = new System.Drawing.Size(917, 40);
            this.pnlFind.TabIndex = 1;
            // 
            // pnlButtom
            // 
            this.pnlButtom.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlButtom.Controls.Add(this.pnlFoot);
            this.pnlButtom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlButtom.Location = new System.Drawing.Point(0, 339);
            this.pnlButtom.Name = "pnlButtom";
            this.pnlButtom.Size = new System.Drawing.Size(917, 26);
            this.pnlButtom.TabIndex = 2;
            // 
            // pnlFoot
            // 
            this.pnlFoot.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlFoot.Location = new System.Drawing.Point(0, 0);
            this.pnlFoot.Name = "pnlFoot";
            this.pnlFoot.Size = new System.Drawing.Size(200, 26);
            this.pnlFoot.TabIndex = 0;
            // 
            // pnlGrd
            // 
            this.pnlGrd.BackColor = System.Drawing.Color.Transparent;
            this.pnlGrd.Controls.Add(this.grd);
            this.pnlGrd.Controls.Add(this.splt);
            this.pnlGrd.Controls.Add(this.pnlDown);
            this.pnlGrd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGrd.Location = new System.Drawing.Point(0, 72);
            this.pnlGrd.Name = "pnlGrd";
            this.pnlGrd.Size = new System.Drawing.Size(917, 267);
            this.pnlGrd.TabIndex = 3;
            // 
            // splt
            // 
            this.splt.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splt.Location = new System.Drawing.Point(0, 161);
            this.splt.Name = "splt";
            this.splt.Size = new System.Drawing.Size(917, 6);
            this.splt.TabIndex = 1;
            this.splt.TabStop = false;
            // 
            // pnlDown
            // 
            this.pnlDown.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlDown.Location = new System.Drawing.Point(0, 167);
            this.pnlDown.Name = "pnlDown";
            this.pnlDown.Size = new System.Drawing.Size(917, 100);
            this.pnlDown.TabIndex = 0;
            // 
            // grd
            // 
            this.grd.AllowAddRows = false;
            this.grd.AllowCheckBoxCol = false;
            this.grd.AllowDeleteRows = false;
            this.grd.AllowMultiSelect = false;
            this.grd.AllowUserToAddRows = false;
            this.grd.AllowUserToDeleteRows = false;
            this.grd.AllowUserToOrderColumns = true;
            this.grd.AllowUserToResizeRows = false;
            this.grd.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.grd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grd.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            this.grd.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkSeaGreen;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grd.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grd.ColumnHeadersHeight = 30;
            this.grd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grd.DefaultCellStyle = dataGridViewCellStyle2;
            this.grd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grd.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.grd.LineHight = 20;
            this.grd.Location = new System.Drawing.Point(0, 0);
            this.grd.MultiSelect = false;
            this.grd.Name = "grd";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grd.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.grd.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Gainsboro;
            this.grd.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.grd.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.grd.RowTemplate.Height = 20;
            this.grd.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grd.ShowRowHeader = false;
            this.grd.Size = new System.Drawing.Size(917, 161);
            this.grd.strIDCol = "";
            this.grd.TabIndex = 2;
            // 
            // btnShowFind
            // 
            this.btnShowFind.FlatStyle = false;
            this.btnShowFind.Location = new System.Drawing.Point(14, 10);
            this.btnShowFind.Name = "btnShowFind";
            popedombyte1.CanAll = false;
            popedombyte1.CanCreate = false;
            popedombyte1.CanDelete = false;
            popedombyte1.CanModify = false;
            popedombyte1.CanRead = false;
            popedombyte1.p = ((byte)(0));
            this.btnShowFind.PopedomByte = popedombyte1;
            this.btnShowFind.SelectTable = false;
            this.btnShowFind.Size = new System.Drawing.Size(12, 12);
            this.btnShowFind.TabIndex = 3;
            this.btnShowFind.Text = "  ";
            this.btnShowFind.UseVisualStyleBackColor = true;
            this.btnShowFind.Click += new System.EventHandler(this.btnShowFindClick);
            // 
            // FindList2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlGrd);
            this.Controls.Add(this.pnlButtom);
            this.Controls.Add(this.pnlFind);
            this.Controls.Add(this.pnlTitleBar);
            this.Name = "FindList2";
            this.Size = new System.Drawing.Size(917, 365);
            this.Load += new System.EventHandler(this.OnLoad);
            this.SizeChanged += new System.EventHandler(this.OnSizeChange);
            this.pnlTitleBar.ResumeLayout(false);
            this.pnlLeft.ResumeLayout(false);
            this.pnlMenu.ResumeLayout(false);
            this.pnlMenu.PerformLayout();
            this.pnlTitle.ResumeLayout(false);
            this.pnlTitle.PerformLayout();
            this.pnlPrint.ResumeLayout(false);
            this.pnlPrint.PerformLayout();
            this.pnlExcel.ResumeLayout(false);
            this.pnlExcel.PerformLayout();
            this.menuExcel.ResumeLayout(false);
            this.pnlSwitchFind.ResumeLayout(false);
            this.pnlButtom.ResumeLayout(false);
            this.pnlGrd.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bindSrc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grd)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTitleBar;
        private System.Windows.Forms.Panel pnlExtern;
        private System.Windows.Forms.Panel pnlFind;
        private System.Windows.Forms.Panel pnlButtom;
        private System.Windows.Forms.Panel pnlGrd;
        public System.Windows.Forms.BindingSource bindSrc;
        private System.Windows.Forms.Label labTitleMsg;
        private System.Windows.Forms.Label labTitle;
        private XButton btnShowFind;
        private System.Windows.Forms.Label btnExcel;
        private System.Windows.Forms.Panel pnlPrint;
        private System.Windows.Forms.Label btnPrint;
        private System.Windows.Forms.Panel pnlExcel;
        private System.Windows.Forms.Panel pnlSwitchFind;
        private System.Windows.Forms.Panel pnlFoot;
        private System.Windows.Forms.Panel pnlDown;
        public XDataGridView grd;
        private System.Windows.Forms.Splitter splt;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ContextMenuStrip menuExcel;
        private System.Windows.Forms.ToolStripMenuItem menuExcel_Import;
        private System.Windows.Forms.ToolStripMenuItem menuExcel_Export;
        private System.Windows.Forms.ToolStripSeparator splitExcelOut;
        private System.Windows.Forms.ToolStripMenuItem menuExcel_Sample;
        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.Panel pnlTitle;
        private System.Windows.Forms.Panel pnlMenu;

    }
}
