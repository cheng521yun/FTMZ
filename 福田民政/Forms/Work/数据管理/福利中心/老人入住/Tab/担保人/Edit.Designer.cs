namespace 福田民政.Forms.Work.数据管理.福利中心.老人入住.Tab.担保人
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
            DB.Stru.事务科.低收入居民_发放记录 低收入居民_发放记录2 = new DB.Stru.事务科.低收入居民_发放记录();
            this.uc = new UI.UC.福利中心.老人入住管理.老人入住管理_担保人();
            this.SuspendLayout();
            // 
            // uc
            // 
            this.uc.BackColor = System.Drawing.Color.White;
            this.uc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uc.Location = new System.Drawing.Point(0, 40);
            this.uc.Name = "uc";
            this.uc.Size = new System.Drawing.Size(439, 251);
            低收入居民_发放记录2.dat审批时间 = new System.DateTime(2015, 5, 10, 11, 34, 14, 233);
            低收入居民_发放记录2.dat待遇截止日期 = new System.DateTime(2015, 5, 10, 11, 34, 14, 233);
            低收入居民_发放记录2.ID = "";
            低收入居民_发放记录2.低保证号 = "";
            低收入居民_发放记录2.发放年月 = "";
            低收入居民_发放记录2.发放类型 = "";
            低收入居民_发放记录2.审批时间 = "";
            低收入居民_发放记录2.待遇截止日期 = "";
            低收入居民_发放记录2.接收人 = "";
            低收入居民_发放记录2.父ID = "";
            this.uc.stru = 低收入居民_发放记录2;
            this.uc.TabIndex = 5;
            // 
            // Edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 331);
            this.Controls.Add(this.uc);
            this.Name = "Edit";
            this.Text = "编辑";
            this.Controls.SetChildIndex(this.uc, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private UI.UC.福利中心.老人入住管理.老人入住管理_担保人 uc;
    }
}