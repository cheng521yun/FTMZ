namespace 福田民政.Forms.Work.数据管理.福利中心.老人入住.Tab.监护人
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
            DB.Stru.福利中心.老人入住管理_监护人 监护人 = new DB.Stru.福利中心.老人入住管理_监护人();
            this.uc = new UI.UC.福利中心.老人入住管理.老人入住管理_监护人();
            this.SuspendLayout();
            // 
            // uc
            // 
            this.uc.BackColor = System.Drawing.Color.White;
            this.uc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uc.Location = new System.Drawing.Point(0, 40);
            this.uc.Name = "uc";
            this.uc.Size = new System.Drawing.Size(439, 251);
            监护人.地址或工作单位 = "";
            监护人.父ID = "";
            监护人.关系 = "";
            监护人.联系电话 = "";
            监护人.姓名 = "";
            this.uc.stru = 监护人;
            this.uc.TabIndex = 5;
            // 
            // Edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 331);
            this.Controls.Add(this.uc);
            this.Name = "监护人";
            this.Text = "监护人";
            this.Load += new System.EventHandler(this.Edit_Load);
            this.Controls.SetChildIndex(this.uc, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private UI.UC.福利中心.老人入住管理.老人入住管理_监护人 uc;
    }
}