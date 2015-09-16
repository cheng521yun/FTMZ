namespace 福田民政.Forms.Work.数据管理.事务科.社会救助
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
            this.txtSFZ = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFind = new UI.Ctrl.Btn.btnFind();
            this.txt姓名 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
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
            this.panel1.Location = new System.Drawing.Point(422, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(205, 40);
            this.panel1.TabIndex = 2;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnAdd.BtnImg = ((System.Drawing.Image)(resources.GetObject("btnAdd.BtnImg")));
            this.btnAdd.BtnTexT = "新加";
            this.btnAdd.CommandId = -1;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnAdd.Location = new System.Drawing.Point(0, 7);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(72, 25);
            this.btnAdd.TabIndex = 3;
            // 
            // txtSFZ
            // 
            this.txtSFZ.Location = new System.Drawing.Point(199, 11);
            this.txtSFZ.Name = "txtSFZ";
            this.txtSFZ.Size = new System.Drawing.Size(120, 21);
            this.txtSFZ.TabIndex = 317;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(147, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 12);
            this.label1.TabIndex = 316;
            this.label1.Text = "身份证:";
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(334, 11);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(20, 20);
            this.btnFind.TabIndex = 315;
            // 
            // txt姓名
            // 
            this.txt姓名.Location = new System.Drawing.Point(57, 11);
            this.txt姓名.Name = "txt姓名";
            this.txt姓名.Size = new System.Drawing.Size(80, 21);
            this.txt姓名.TabIndex = 314;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 12);
            this.label5.TabIndex = 313;
            this.label5.Text = "姓名:";
            // 
            // btnExcelOut
            // 
            this.btnExcelOut.BackColor = System.Drawing.Color.Transparent;
            this.btnExcelOut.BtnImg = ((System.Drawing.Image)(resources.GetObject("btnExcelOut.BtnImg")));
            this.btnExcelOut.BtnTexT = "导出";
            this.btnExcelOut.CommandId = -1;
            this.btnExcelOut.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnExcelOut.Location = new System.Drawing.Point(135, 8);
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
            this.btnExcelIn.Location = new System.Drawing.Point(71, 8);
            this.btnExcelIn.Name = "btnExcelIn";
            this.btnExcelIn.Size = new System.Drawing.Size(56, 25);
            this.btnExcelIn.TabIndex = 9;
            // 
            // Find
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 40);
            this.Controls.Add(this.txtSFZ);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.txt姓名);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Find";
            this.Text = "Find";
            this.Load += new System.EventHandler(this.Find_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private UI.Ctrl.Btn.SmallIconBtn btnAdd;
        private System.Windows.Forms.TextBox txtSFZ;
        private System.Windows.Forms.Label label1;
        private UI.Ctrl.Btn.btnFind btnFind;
        private System.Windows.Forms.TextBox txt姓名;
        private System.Windows.Forms.Label label5;
        private UI.Ctrl.Btn.SmallIconBtn btnExcelOut;
        private UI.Ctrl.Btn.SmallIconBtn btnExcelIn;

    }
}