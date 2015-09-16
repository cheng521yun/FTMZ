using FrontFlag.Control;

namespace 福田民政.Forms.Comm
{
    partial class FExcelIn2
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose ( bool disposing )
        {
            if ( disposing && ( components != null ) )
            {
                components.Dispose ();
            }
            base.Dispose ( disposing );
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent ()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FExcelIn2));
            this.captonNote = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.butConvert = new System.Windows.Forms.Button();
            this.btnCompany2Left = new System.Windows.Forms.Button();
            this.btnCompany2Right = new System.Windows.Forms.Button();
            this.lstExcel = new System.Windows.Forms.ListView();
            this.colExle = new System.Windows.Forms.ColumnHeader();
            this.lstMatch = new System.Windows.Forms.ListView();
            this.colDB = new System.Windows.Forms.ColumnHeader();
            this.colExcl = new System.Windows.Forms.ColumnHeader();
            this.cmbSheetName = new System.Windows.Forms.ComboBox();
            this.datgrdExcel = new System.Windows.Forms.DataGridView();
            this.txtInfo = new System.Windows.Forms.TextBox();
            this.captonNote.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datgrdExcel)).BeginInit();
            this.SuspendLayout();
            // 
            // captonNote
            // 
            this.captonNote.BackColor = System.Drawing.SystemColors.Info;
            this.captonNote.Controls.Add(this.txtInfo);
            this.captonNote.Dock = System.Windows.Forms.DockStyle.Top;
            this.captonNote.Location = new System.Drawing.Point(0, 0);
            this.captonNote.Name = "captonNote";
            this.captonNote.Size = new System.Drawing.Size(922, 60);
            this.captonNote.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gainsboro;
            this.panel3.Controls.Add(this.btnExit);
            this.panel3.Controls.Add(this.butConvert);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 404);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(922, 40);
            this.panel3.TabIndex = 2;
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(565, 9);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // butConvert
            // 
            this.butConvert.Location = new System.Drawing.Point(283, 9);
            this.butConvert.Name = "butConvert";
            this.butConvert.Size = new System.Drawing.Size(75, 23);
            this.butConvert.TabIndex = 0;
            this.butConvert.Text = "Convert";
            this.butConvert.UseVisualStyleBackColor = true;
            this.butConvert.Click += new System.EventHandler(this.butConvert_Click_1);
            // 
            // btnCompany2Left
            // 
            this.btnCompany2Left.Location = new System.Drawing.Point(232, 192);
            this.btnCompany2Left.Name = "btnCompany2Left";
            this.btnCompany2Left.Size = new System.Drawing.Size(30, 23);
            this.btnCompany2Left.TabIndex = 16;
            this.btnCompany2Left.Text = "<=";
            this.btnCompany2Left.UseVisualStyleBackColor = true;
            this.btnCompany2Left.Click += new System.EventHandler(this.btnCompany2Left_Click);
            // 
            // btnCompany2Right
            // 
            this.btnCompany2Right.Location = new System.Drawing.Point(232, 239);
            this.btnCompany2Right.Name = "btnCompany2Right";
            this.btnCompany2Right.Size = new System.Drawing.Size(30, 23);
            this.btnCompany2Right.TabIndex = 15;
            this.btnCompany2Right.Text = "=>";
            this.btnCompany2Right.UseVisualStyleBackColor = true;
            this.btnCompany2Right.Click += new System.EventHandler(this.btnCompany2Right_Click);
            // 
            // lstExcel
            // 
            this.lstExcel.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colExle});
            this.lstExcel.FullRowSelect = true;
            this.lstExcel.GridLines = true;
            this.lstExcel.HideSelection = false;
            this.lstExcel.Location = new System.Drawing.Point(274, 76);
            this.lstExcel.Name = "lstExcel";
            this.lstExcel.Size = new System.Drawing.Size(109, 307);
            this.lstExcel.TabIndex = 14;
            this.lstExcel.UseCompatibleStateImageBehavior = false;
            this.lstExcel.View = System.Windows.Forms.View.Details;
            // 
            // colExle
            // 
            this.colExle.Text = "Excel Colums";
            this.colExle.Width = 100;
            // 
            // lstMatch
            // 
            this.lstMatch.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colDB,
            this.colExcl});
            this.lstMatch.FullRowSelect = true;
            this.lstMatch.GridLines = true;
            this.lstMatch.HideSelection = false;
            this.lstMatch.Location = new System.Drawing.Point(16, 76);
            this.lstMatch.Name = "lstMatch";
            this.lstMatch.Size = new System.Drawing.Size(205, 307);
            this.lstMatch.TabIndex = 13;
            this.lstMatch.UseCompatibleStateImageBehavior = false;
            this.lstMatch.View = System.Windows.Forms.View.Details;
            // 
            // colDB
            // 
            this.colDB.Text = "DB Colums";
            this.colDB.Width = 100;
            // 
            // colExcl
            // 
            this.colExcl.Text = "Excel Colums";
            this.colExcl.Width = 100;
            // 
            // cmbSheetName
            // 
            this.cmbSheetName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSheetName.FormattingEnabled = true;
            this.cmbSheetName.Location = new System.Drawing.Point(407, 76);
            this.cmbSheetName.Name = "cmbSheetName";
            this.cmbSheetName.Size = new System.Drawing.Size(144, 20);
            this.cmbSheetName.TabIndex = 14;
            this.cmbSheetName.SelectedIndexChanged += new System.EventHandler(this.cmbSheetName_Change);
            // 
            // datgrdExcel
            // 
            this.datgrdExcel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datgrdExcel.Location = new System.Drawing.Point(407, 102);
            this.datgrdExcel.Name = "datgrdExcel";
            this.datgrdExcel.RowTemplate.Height = 23;
            this.datgrdExcel.Size = new System.Drawing.Size(501, 281);
            this.datgrdExcel.TabIndex = 13;
            // 
            // txtInfo
            // 
            this.txtInfo.BackColor = System.Drawing.SystemColors.Info;
            this.txtInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtInfo.Location = new System.Drawing.Point(13, 4);
            this.txtInfo.Multiline = true;
            this.txtInfo.Name = "txtInfo";
            this.txtInfo.Size = new System.Drawing.Size(895, 53);
            this.txtInfo.TabIndex = 0;
            // 
            // FExcelIn2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 444);
            this.Controls.Add(this.lstExcel);
            this.Controls.Add(this.btnCompany2Right);
            this.Controls.Add(this.btnCompany2Left);
            this.Controls.Add(this.datgrdExcel);
            this.Controls.Add(this.cmbSheetName);
            this.Controls.Add(this.lstMatch);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.captonNote);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            //this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FExcelIn2";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ExcelIn";
            this.Load += new System.EventHandler(this.OnLoad);
            this.captonNote.ResumeLayout(false);
            this.captonNote.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.datgrdExcel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel captonNote;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button butConvert;
        private System.Windows.Forms.ComboBox cmbSheetName;
        private System.Windows.Forms.DataGridView datgrdExcel;
        private System.Windows.Forms.Button btnCompany2Left;
        private System.Windows.Forms.Button btnCompany2Right;
        private System.Windows.Forms.ListView lstExcel;
        private System.Windows.Forms.ColumnHeader colExle;
        private System.Windows.Forms.ListView lstMatch;
        private System.Windows.Forms.ColumnHeader colDB;
        private System.Windows.Forms.ColumnHeader colExcl;
        private System.Windows.Forms.TextBox txtInfo;
    }
}