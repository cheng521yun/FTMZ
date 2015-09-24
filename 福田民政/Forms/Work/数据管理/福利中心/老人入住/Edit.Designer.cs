namespace 福田民政.Forms.Work.数据管理.福利中心.老人入住
{
    partial class FEdit
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
            DB.Stru.福利中心.老人入住管理 老人入住管理1 = new DB.Stru.福利中心.老人入住管理();
            this.uc = new UI.UC.福利中心.老人入住管理.老人入住管理();
            this.SuspendLayout();
            // 
            // uc
            // 
            this.uc.BackColor = System.Drawing.Color.White;
            this.uc.Location = new System.Drawing.Point(32, 50);
            this.uc.Name = "uc";
            this.uc.Size = new System.Drawing.Size(369, 316);
            老人入住管理1.CreateDate = "";
            老人入住管理1.Creator = "";
            老人入住管理1.datCreateDate = new System.DateTime(2015, 9, 24, 22, 12, 35, 66);
            老人入住管理1.ID = "";
            老人入住管理1.姓名 = "";
            老人入住管理1.家庭住址 = "";
            老人入住管理1.性别 = "False";
            老人入住管理1.户籍所在地 = "";
            老人入住管理1.押金费用 = "";
            老人入住管理1.本人成份 = "";
            老人入住管理1.申请事由 = "";
            老人入住管理1.籍贯 = "";
            老人入住管理1.身份证 = "";
            老人入住管理1.身体状况 = "";
            this.uc.stru = 老人入住管理1;
            this.uc.TabIndex = 5;
            // 
            // FEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 421);
            this.Controls.Add(this.uc);
            this.Name = "FEdit";
            this.Text = "Edit";
            this.Load += new System.EventHandler(this.Edit_Load);
            this.Controls.SetChildIndex(this.uc, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private UI.UC.福利中心.老人入住管理.老人入住管理 uc;
    }
}