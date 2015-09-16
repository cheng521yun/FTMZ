namespace 福田民政.Forms.Work.数据管理.基层科.社区服务
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
            DB.Stru.老龄办.发放老龄津贴 发放老龄津贴1 = new DB.Stru.老龄办.发放老龄津贴();
            this.uc = new UI.UC.基层科.社区服务();
            this.SuspendLayout();
            // 
            // uc
            // 
            this.uc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uc.Location = new System.Drawing.Point(0, 40);
            this.uc.Name = "uc";
            this.uc.Size = new System.Drawing.Size(437, 412);
            发放老龄津贴1.CreateDate = "2015-06-29 12:38:11";
            发放老龄津贴1.Creator = "";
            发放老龄津贴1.datCreateDate = new System.DateTime(2015, 6, 29, 12, 38, 11, 0);
            发放老龄津贴1.dat出生日期 = new System.DateTime(2015, 6, 29, 13, 30, 34, 320);
            发放老龄津贴1.dat领取时间 = new System.DateTime(2015, 6, 29, 13, 30, 34, 320);
            发放老龄津贴1.DelFlag = "";
            发放老龄津贴1.ID = "";
            发放老龄津贴1.出生日期 = "";
            发放老龄津贴1.姓名 = "";
            发放老龄津贴1.死亡 = "";
            发放老龄津贴1.状态 = "";
            发放老龄津贴1.类别 = "";
            发放老龄津贴1.街道 = "";
            发放老龄津贴1.身份证 = "";
            发放老龄津贴1.银行账号 = "";
            发放老龄津贴1.领取时间 = "";
            this.uc.stru = 发放老龄津贴1;
            this.uc.TabIndex = 0;
            // 
            // FEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 492);
            this.Controls.Add(this.uc);
            this.Name = "FEdit";
            this.Text = "Edit";
            this.Load += new System.EventHandler(this.Edit_Load);
            this.Controls.SetChildIndex(this.uc, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private UI.UC.基层科.社区服务 uc;

    }
}