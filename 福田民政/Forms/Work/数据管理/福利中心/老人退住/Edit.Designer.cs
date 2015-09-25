namespace 福田民政.Forms.Work.数据管理.福利中心.老人退住管理
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
            DB.Stru.福利中心.老人退住管理 老人退住管理 = new DB.Stru.福利中心.老人退住管理();
            this.uc = new UI.UC.福利中心.老人退住管理.老人退住管理();
            this.SuspendLayout();
            // 
            // uc
            // 
            this.uc.BackColor = System.Drawing.Color.White;
            this.uc.Location = new System.Drawing.Point(32, 50);
            this.uc.Name = "uc";
            this.uc.Size = new System.Drawing.Size(369, 316);
            老人退住管理.CreateDate = "";
            老人退住管理.Creator = "";
            老人退住管理.datCreateDate = new System.DateTime(2015, 9, 24, 22, 12, 35, 66);
            老人退住管理.ID = "";
            老人退住管理.姓名 = "";
            老人退住管理.性别 = "";
            老人退住管理.退住级别 = "";
            老人退住管理.身份证 = "";
            老人退住管理.申请时间 = "";
            老人退住管理.入住时间 = "";
            老人退住管理.入住级别 = "";
            
            this.uc.stru = 老人退住管理;
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

        private UI.UC.福利中心.老人退住管理.老人退住管理 uc;
    }
}