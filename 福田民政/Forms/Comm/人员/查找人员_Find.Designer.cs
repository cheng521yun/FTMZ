namespace 福田民政.Forms.Comm.人员
{
    partial class 查找人员_Find
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(查找人员_Find));
            this.label1 = new System.Windows.Forms.Label();
            this.pnlAddNew = new System.Windows.Forms.Panel();
            this.btnAddNew = new UI.Ctrl.Btn.SmallIconBtn();
            this.txt姓名 = new System.Windows.Forms.TextBox();
            this.txt身份证 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt手机 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnFind = new FrontFlag.Control.XImgButton();
            this.pnlAddNew.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "姓名：";
            // 
            // pnlAddNew
            // 
            this.pnlAddNew.Controls.Add(this.btnAddNew);
            this.pnlAddNew.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlAddNew.Location = new System.Drawing.Point(632, 0);
            this.pnlAddNew.Name = "pnlAddNew";
            this.pnlAddNew.Size = new System.Drawing.Size(106, 42);
            this.pnlAddNew.TabIndex = 1;
            // 
            // btnAddNew
            // 
            this.btnAddNew.BackColor = System.Drawing.Color.Transparent;
            this.btnAddNew.BtnImg = ((System.Drawing.Image)(resources.GetObject("btnAddNew.BtnImg")));
            this.btnAddNew.BtnTexT = "新加人员";
            this.btnAddNew.CommandId = -1;
            this.btnAddNew.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnAddNew.Location = new System.Drawing.Point(9, 8);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(89, 25);
            this.btnAddNew.TabIndex = 0;
            // 
            // txt姓名
            // 
            this.txt姓名.Location = new System.Drawing.Point(57, 9);
            this.txt姓名.Name = "txt姓名";
            this.txt姓名.Size = new System.Drawing.Size(80, 21);
            this.txt姓名.TabIndex = 2;
            // 
            // txt身份证
            // 
            this.txt身份证.Location = new System.Drawing.Point(206, 9);
            this.txt身份证.Name = "txt身份证";
            this.txt身份证.Size = new System.Drawing.Size(113, 21);
            this.txt身份证.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(152, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 14;
            this.label2.Text = "身份证：";
            // 
            // txt手机
            // 
            this.txt手机.Location = new System.Drawing.Point(377, 9);
            this.txt手机.Name = "txt手机";
            this.txt手机.Size = new System.Drawing.Size(80, 21);
            this.txt手机.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(333, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 16;
            this.label3.Text = "手机：";
            // 
            // btnFind
            // 
            this.btnFind.BackColor = System.Drawing.Color.Transparent;
            this.btnFind.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnFind.FlatAppearance.BorderSize = 0;
            this.btnFind.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnFind.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnFind.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFind.Image = ((System.Drawing.Image)(resources.GetObject("btnFind.Image")));
            this.btnFind.Location = new System.Drawing.Point(468, 9);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(20, 20);
            this.btnFind.TabIndex = 13;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = false;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // 查找人员_Find
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 42);
            this.Controls.Add(this.txt手机);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt身份证);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.txt姓名);
            this.Controls.Add(this.pnlAddNew);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "查找人员_Find";
            this.Text = "查找人员_Find";
            this.Load += new System.EventHandler(this.查找人员_Find_Load);
            this.pnlAddNew.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlAddNew;
        private System.Windows.Forms.TextBox txt姓名;
        private UI.Ctrl.Btn.SmallIconBtn btnAddNew;
        private FrontFlag.Control.XImgButton btnFind;
        private System.Windows.Forms.TextBox txt身份证;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt手机;
        private System.Windows.Forms.Label label3;

    }
}