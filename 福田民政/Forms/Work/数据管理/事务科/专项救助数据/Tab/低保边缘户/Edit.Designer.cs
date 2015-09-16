namespace 福田民政.Forms.Work.数据管理.事务科.专项救助数据.Tab.低保边缘户
{
    partial class Edit
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
            DB.Stru.事务科.专项救助_低保边缘户 专项救助_低保边缘户1 = new DB.Stru.事务科.专项救助_低保边缘户();
            this.uc = new UI.UC.事务科.专项救助.低保边缘户();
            this.SuspendLayout();
            // 
            // uc
            // 
            this.uc.BackColor = System.Drawing.Color.White;
            this.uc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uc.Location = new System.Drawing.Point(0, 0);
            this.uc.Name = "uc";
            this.uc.Size = new System.Drawing.Size(372, 330);
            专项救助_低保边缘户1.dat有效期 = new System.DateTime(2015, 5, 11, 6, 43, 25, 319);
            专项救助_低保边缘户1.ID = "";
            专项救助_低保边缘户1.备注 = "";
            专项救助_低保边缘户1.姓名 = "";
            专项救助_低保边缘户1.家庭成员 = "";
            专项救助_低保边缘户1.性别 = "";
            专项救助_低保边缘户1.所属街道 = "";
            专项救助_低保边缘户1.有效期 = "";
            专项救助_低保边缘户1.联系电话 = "";
            专项救助_低保边缘户1.身份证 = "";
            专项救助_低保边缘户1.边缘证号 = "";
            this.uc.stru = 专项救助_低保边缘户1;
            this.uc.TabIndex = 0;
            // 
            // Edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 380);
            this.Controls.Add(this.uc);
            this.Controls.SetChildIndex( this.uc, 0 );
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Edit";
            this.Text = "编辑";
            this.ResumeLayout(false);

        }

        #endregion

        private UI.UC.事务科.专项救助.低保边缘户 uc;
    }
}