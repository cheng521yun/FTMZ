namespace 福田民政.Forms.Work.数据管理.老龄办.老龄优待证_发放
{
    partial class FFind
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
            this.txt姓名 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnFind = new UI.Ctrl.Btn.btnFind();
            this.uclistTool = new UI.UC.Comm.ListTool();
            this.txtSFZ = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt姓名
            // 
            this.txt姓名.Location = new System.Drawing.Point(57, 11);
            this.txt姓名.Name = "txt姓名";
            this.txt姓名.Size = new System.Drawing.Size(80, 21);
            this.txt姓名.TabIndex = 308;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 12);
            this.label5.TabIndex = 307;
            this.label5.Text = "姓名:";
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(334, 11);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(20, 20);
            this.btnFind.TabIndex = 309;
            // 
            // uclistTool
            // 
            this.uclistTool.Dock = System.Windows.Forms.DockStyle.Right;
            this.uclistTool.Location = new System.Drawing.Point(462, 0);
            this.uclistTool.Name = "uclistTool";
            this.uclistTool.Size = new System.Drawing.Size(300, 41);
            this.uclistTool.TabIndex = 310;
            // 
            // txtSFZ
            // 
            this.txtSFZ.Location = new System.Drawing.Point(199, 11);
            this.txtSFZ.Name = "txtSFZ";
            this.txtSFZ.Size = new System.Drawing.Size(120, 21);
            this.txtSFZ.TabIndex = 312;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(147, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 12);
            this.label1.TabIndex = 311;
            this.label1.Text = "身份证:";
            // 
            // FFind
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 41);
            this.Controls.Add(this.txtSFZ);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.uclistTool);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.txt姓名);
            this.Controls.Add(this.label5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FFind";
            this.Text = "Find";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt姓名;
        private System.Windows.Forms.Label label5;
        private UI.Ctrl.Btn.btnFind btnFind;
        private UI.UC.Comm.ListTool uclistTool;
        private System.Windows.Forms.TextBox txtSFZ;
        private System.Windows.Forms.Label label1;
    }
}