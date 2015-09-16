namespace FrontFlag.Control
{
    partial class FindList
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
            this.components = new System.ComponentModel.Container ();
            FrontFlag.FUN.POPEDOMBYTE popedombyte1 = new FrontFlag.FUN.POPEDOMBYTE ();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle ();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle ();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle ();
            this.pnlTitle = new System.Windows.Forms.Panel ();
            this.pnlPrint = new System.Windows.Forms.Panel ();
            this.btnPrint = new System.Windows.Forms.Label ();
            this.pnlExcel = new System.Windows.Forms.Panel ();
            this.btnSaveExcel = new System.Windows.Forms.Label ();
            this.pnlSwitchFind = new System.Windows.Forms.Panel ();
            this.btnShowFind = new FrontFlag.Control.XButton ();
            this.pnlExtern = new System.Windows.Forms.Panel ();
            this.labTitle = new System.Windows.Forms.Label ();
            this.labTitleMsg = new System.Windows.Forms.Label ();
            this.pnlFind = new System.Windows.Forms.Panel ();
            this.pnlButtom = new System.Windows.Forms.Panel ();
            this.pnlFoot = new System.Windows.Forms.Panel ();
            this.pnlGrd = new System.Windows.Forms.Panel ();
            this.grd = new FrontFlag.Control.XDataGridView ( this.components );
            this.splt = new System.Windows.Forms.Splitter ();
            this.pnlDown = new System.Windows.Forms.Panel ();
            this.bindSrc = new System.Windows.Forms.BindingSource ( this.components );
            this.pnlTitle.SuspendLayout ();
            this.pnlPrint.SuspendLayout ();
            this.pnlExcel.SuspendLayout ();
            this.pnlSwitchFind.SuspendLayout ();
            this.pnlButtom.SuspendLayout ();
            this.pnlGrd.SuspendLayout ();
            ( (System.ComponentModel.ISupportInitialize) ( this.grd ) ).BeginInit ();
            ( (System.ComponentModel.ISupportInitialize) ( this.bindSrc ) ).BeginInit ();
            this.SuspendLayout ();
            // 
            // pnlTitle
            // 
            this.pnlTitle.BackColor = System.Drawing.Color.FromArgb ( ( (int) ( ( (byte) ( 190 ) ) ) ), ( (int) ( ( (byte) ( 206 ) ) ) ), ( (int) ( ( (byte) ( 183 ) ) ) ) );
            this.pnlTitle.Controls.Add ( this.pnlPrint );
            this.pnlTitle.Controls.Add ( this.pnlExcel );
            this.pnlTitle.Controls.Add ( this.pnlSwitchFind );
            this.pnlTitle.Controls.Add ( this.pnlExtern );
            this.pnlTitle.Controls.Add ( this.labTitle );
            this.pnlTitle.Controls.Add ( this.labTitleMsg );
            this.pnlTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitle.Location = new System.Drawing.Point ( 0, 0 );
            this.pnlTitle.Name = "pnlTitle";
            this.pnlTitle.Size = new System.Drawing.Size ( 685, 32 );
            this.pnlTitle.TabIndex = 0;
            // 
            // pnlPrint
            // 
            this.pnlPrint.BackColor = System.Drawing.Color.Transparent;
            this.pnlPrint.Controls.Add ( this.btnPrint );
            this.pnlPrint.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlPrint.Location = new System.Drawing.Point ( 445, 0 );
            this.pnlPrint.Name = "pnlPrint";
            this.pnlPrint.Size = new System.Drawing.Size ( 80, 32 );
            this.pnlPrint.TabIndex = 7;
            this.pnlPrint.Visible = false;
            // 
            // btnPrint
            // 
            this.btnPrint.AutoSize = true;
            this.btnPrint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrint.Font = new System.Drawing.Font ( "SimSun", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ( (byte) ( 134 ) ) );
            this.btnPrint.ForeColor = System.Drawing.Color.Blue;
            this.btnPrint.Location = new System.Drawing.Point ( 26, 10 );
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size ( 29, 12 );
            this.btnPrint.TabIndex = 5;
            this.btnPrint.Text = "打印";
            this.btnPrint.Click += new System.EventHandler ( this.btnPrint_Click );
            // 
            // pnlExcel
            // 
            this.pnlExcel.BackColor = System.Drawing.Color.Transparent;
            this.pnlExcel.Controls.Add ( this.btnSaveExcel );
            this.pnlExcel.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlExcel.Location = new System.Drawing.Point ( 525, 0 );
            this.pnlExcel.Name = "pnlExcel";
            this.pnlExcel.Size = new System.Drawing.Size ( 80, 32 );
            this.pnlExcel.TabIndex = 6;
            this.pnlExcel.Visible = false;
            // 
            // btnSaveExcel
            // 
            this.btnSaveExcel.AutoSize = true;
            this.btnSaveExcel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveExcel.Font = new System.Drawing.Font ( "SimSun", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ( (byte) ( 134 ) ) );
            this.btnSaveExcel.ForeColor = System.Drawing.Color.Blue;
            this.btnSaveExcel.Location = new System.Drawing.Point ( 11, 10 );
            this.btnSaveExcel.Name = "btnSaveExcel";
            this.btnSaveExcel.Size = new System.Drawing.Size ( 59, 12 );
            this.btnSaveExcel.TabIndex = 4;
            this.btnSaveExcel.Text = "导出Excel";
            this.btnSaveExcel.Click += new System.EventHandler ( this.OnbtnSaveExcelClick );
            // 
            // pnlSwitchFind
            // 
            this.pnlSwitchFind.BackColor = System.Drawing.Color.Transparent;
            this.pnlSwitchFind.Controls.Add ( this.btnShowFind );
            this.pnlSwitchFind.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlSwitchFind.Location = new System.Drawing.Point ( 605, 0 );
            this.pnlSwitchFind.Name = "pnlSwitchFind";
            this.pnlSwitchFind.Size = new System.Drawing.Size ( 40, 32 );
            this.pnlSwitchFind.TabIndex = 5;
            this.pnlSwitchFind.Visible = false;
            // 
            // btnShowFind
            // 
            this.btnShowFind.FlatStyle = false;
            this.btnShowFind.Location = new System.Drawing.Point ( 14, 10 );
            this.btnShowFind.Name = "btnShowFind";
            popedombyte1.CanAll = false;
            popedombyte1.CanCreate = false;
            popedombyte1.CanDelete = false;
            popedombyte1.CanModify = false;
            popedombyte1.CanRead = false;
            popedombyte1.p = ( (byte) ( 0 ) );
            this.btnShowFind.PopedomByte = popedombyte1;
            this.btnShowFind.SelectTable = false;
            this.btnShowFind.Size = new System.Drawing.Size ( 12, 12 );
            this.btnShowFind.TabIndex = 3;
            this.btnShowFind.Text = "  ";
            this.btnShowFind.UseVisualStyleBackColor = true;
            this.btnShowFind.Click += new System.EventHandler ( this.btnShowFindClick );
            // 
            // pnlExtern
            // 
            this.pnlExtern.BackColor = System.Drawing.Color.Transparent;
            this.pnlExtern.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlExtern.Location = new System.Drawing.Point ( 645, 0 );
            this.pnlExtern.Name = "pnlExtern";
            this.pnlExtern.Size = new System.Drawing.Size ( 40, 32 );
            this.pnlExtern.TabIndex = 8;
            this.pnlExtern.Visible = false;
            // 
            // labTitle
            // 
            this.labTitle.AutoSize = true;
            this.labTitle.Font = new System.Drawing.Font ( "SimSun", 14F );
            this.labTitle.ForeColor = System.Drawing.Color.MintCream;
            this.labTitle.Location = new System.Drawing.Point ( 12, 7 );
            this.labTitle.Name = "labTitle";
            this.labTitle.Size = new System.Drawing.Size ( 79, 19 );
            this.labTitle.TabIndex = 2;
            this.labTitle.Text = "       ";
            // 
            // labTitleMsg
            // 
            this.labTitleMsg.AutoSize = true;
            this.labTitleMsg.Location = new System.Drawing.Point ( 116, 10 );
            this.labTitleMsg.Name = "labTitleMsg";
            this.labTitleMsg.Size = new System.Drawing.Size ( 47, 12 );
            this.labTitleMsg.TabIndex = 0;
            this.labTitleMsg.Text = "       ";
            // 
            // pnlFind
            // 
            this.pnlFind.BackColor = System.Drawing.Color.White;
            this.pnlFind.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFind.Location = new System.Drawing.Point ( 0, 32 );
            this.pnlFind.Name = "pnlFind";
            this.pnlFind.Size = new System.Drawing.Size ( 685, 40 );
            this.pnlFind.TabIndex = 1;
            // 
            // pnlButtom
            // 
            this.pnlButtom.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlButtom.Controls.Add ( this.pnlFoot );
            this.pnlButtom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlButtom.Location = new System.Drawing.Point ( 0, 339 );
            this.pnlButtom.Name = "pnlButtom";
            this.pnlButtom.Size = new System.Drawing.Size ( 685, 26 );
            this.pnlButtom.TabIndex = 2;
            // 
            // pnlFoot
            // 
            this.pnlFoot.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlFoot.Location = new System.Drawing.Point ( 0, 0 );
            this.pnlFoot.Name = "pnlFoot";
            this.pnlFoot.Size = new System.Drawing.Size ( 200, 26 );
            this.pnlFoot.TabIndex = 0;
            // 
            // pnlGrd
            // 
            this.pnlGrd.BackColor = System.Drawing.Color.Transparent;
            this.pnlGrd.Controls.Add ( this.grd );
            this.pnlGrd.Controls.Add ( this.splt );
            this.pnlGrd.Controls.Add ( this.pnlDown );
            this.pnlGrd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGrd.Location = new System.Drawing.Point ( 0, 72 );
            this.pnlGrd.Name = "pnlGrd";
            this.pnlGrd.Size = new System.Drawing.Size ( 685, 267 );
            this.pnlGrd.TabIndex = 3;
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
            this.grd.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font ( "SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( (byte) ( 134 ) ) );
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding ( 0, 3, 0, 3 );
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grd.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle2.Font = new System.Drawing.Font ( "SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( (byte) ( 134 ) ) );
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grd.DefaultCellStyle = dataGridViewCellStyle2;
            this.grd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grd.GridColor = System.Drawing.Color.FromArgb ( ( (int) ( ( (byte) ( 240 ) ) ) ), ( (int) ( ( (byte) ( 240 ) ) ) ), ( (int) ( ( (byte) ( 240 ) ) ) ) );
            this.grd.LineHight = 20;
            this.grd.Location = new System.Drawing.Point ( 0, 0 );
            this.grd.MultiSelect = false;
            this.grd.Name = "grd";
            this.grd.RowHeadersVisible = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Gainsboro;
            this.grd.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.grd.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding ( 2, 0, 0, 0 );
            this.grd.RowTemplate.Height = 20;
            this.grd.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grd.ShowRowHeader = false;
            this.grd.Size = new System.Drawing.Size ( 685, 161 );
            this.grd.strIDCol = "";
            this.grd.TabIndex = 2;
            // 
            // splt
            // 
            this.splt.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splt.Location = new System.Drawing.Point ( 0, 161 );
            this.splt.Name = "splt";
            this.splt.Size = new System.Drawing.Size ( 685, 6 );
            this.splt.TabIndex = 1;
            this.splt.TabStop = false;
            // 
            // pnlDown
            // 
            this.pnlDown.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlDown.Location = new System.Drawing.Point ( 0, 167 );
            this.pnlDown.Name = "pnlDown";
            this.pnlDown.Size = new System.Drawing.Size ( 685, 100 );
            this.pnlDown.TabIndex = 0;
            // 
            // FindList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF ( 6F, 12F );
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add ( this.pnlGrd );
            this.Controls.Add ( this.pnlButtom );
            this.Controls.Add ( this.pnlFind );
            this.Controls.Add ( this.pnlTitle );
            this.Name = "FindList";
            this.Size = new System.Drawing.Size ( 685, 365 );
            this.Load += new System.EventHandler ( this.OnLoad );
            this.SizeChanged += new System.EventHandler ( this.OnSizeChange );
            this.pnlTitle.ResumeLayout ( false );
            this.pnlTitle.PerformLayout ();
            this.pnlPrint.ResumeLayout ( false );
            this.pnlPrint.PerformLayout ();
            this.pnlExcel.ResumeLayout ( false );
            this.pnlExcel.PerformLayout ();
            this.pnlSwitchFind.ResumeLayout ( false );
            this.pnlButtom.ResumeLayout ( false );
            this.pnlGrd.ResumeLayout ( false );
            ( (System.ComponentModel.ISupportInitialize) ( this.grd ) ).EndInit ();
            ( (System.ComponentModel.ISupportInitialize) ( this.bindSrc ) ).EndInit ();
            this.ResumeLayout ( false );

        }

        #endregion

        private System.Windows.Forms.Panel pnlTitle;
        private System.Windows.Forms.Panel pnlExtern;
        private System.Windows.Forms.Panel pnlFind;
        private System.Windows.Forms.Panel pnlButtom;
        private System.Windows.Forms.Panel pnlGrd;
        public System.Windows.Forms.BindingSource bindSrc;
        private System.Windows.Forms.Label labTitleMsg;
        private System.Windows.Forms.Label labTitle;
        private XButton btnShowFind;
        private System.Windows.Forms.Label btnSaveExcel;
        private System.Windows.Forms.Panel pnlPrint;
        private System.Windows.Forms.Label btnPrint;
        private System.Windows.Forms.Panel pnlExcel;
        private System.Windows.Forms.Panel pnlSwitchFind;
        private System.Windows.Forms.Panel pnlFoot;
        private System.Windows.Forms.Panel pnlDown;
        public XDataGridView grd;
        private System.Windows.Forms.Splitter splt;

    }
}
