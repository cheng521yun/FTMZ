namespace 福田民政.Forms.Work.数据管理.事务科.临时救助
{
    partial class Find
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose( bool disposing )
        {
            if ( disposing && ( components != null ) )
            {
                components.Dispose();
            }
            base.Dispose( disposing );
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Find));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAdd = new UI.Ctrl.Btn.SmallIconBtn();
            this.btnExcelOut = new UI.Ctrl.Btn.SmallIconBtn();
            this.btnExcelIn = new UI.Ctrl.Btn.SmallIconBtn();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnExcelOut);
            this.panel1.Controls.Add(this.btnExcelIn);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(427, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 40);
            this.panel1.TabIndex = 1;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnAdd.BtnImg = ((System.Drawing.Image)(resources.GetObject("btnAdd.BtnImg")));
            this.btnAdd.BtnTexT = "新加";
            this.btnAdd.CommandId = -1;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnAdd.Location = new System.Drawing.Point(8, 7);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(72, 25);
            this.btnAdd.TabIndex = 3;
            // 
            // btnExcelOut
            // 
            this.btnExcelOut.BackColor = System.Drawing.Color.Transparent;
            this.btnExcelOut.BtnImg = ((System.Drawing.Image)(resources.GetObject("btnExcelOut.BtnImg")));
            this.btnExcelOut.BtnTexT = "导出";
            this.btnExcelOut.CommandId = -1;
            this.btnExcelOut.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnExcelOut.Location = new System.Drawing.Point(131, 8);
            this.btnExcelOut.Name = "btnExcelOut";
            this.btnExcelOut.Size = new System.Drawing.Size(66, 25);
            this.btnExcelOut.TabIndex = 10;
            // 
            // btnExcelIn
            // 
            this.btnExcelIn.BackColor = System.Drawing.Color.Transparent;
            this.btnExcelIn.BtnImg = ((System.Drawing.Image)(resources.GetObject("btnExcelIn.BtnImg")));
            this.btnExcelIn.BtnTexT = "导入";
            this.btnExcelIn.CommandId = -1;
            this.btnExcelIn.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnExcelIn.Location = new System.Drawing.Point(67, 8);
            this.btnExcelIn.Name = "btnExcelIn";
            this.btnExcelIn.Size = new System.Drawing.Size(56, 25);
            this.btnExcelIn.TabIndex = 9;
            // 
            // Find
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 40);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Find";
            this.Text = "Find";
            this.Load += new System.EventHandler(this.Find_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private UI.Ctrl.Btn.SmallIconBtn btnAdd;
        private UI.Ctrl.Btn.SmallIconBtn btnExcelOut;
        private UI.Ctrl.Btn.SmallIconBtn btnExcelIn;
    }
}