namespace 福田民政.Forms.Work.数据管理.老龄办.老龄津贴_发放
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
            this.uc = new UI.UC.老龄办.发放老龄津贴();
            this.SuspendLayout();
            // 
            // uc
            // 
            this.uc.Location = new System.Drawing.Point(12, 47);
            this.uc.Name = "uc";
            this.uc.Size = new System.Drawing.Size(469, 200);
            发放老龄津贴1.CreateDate = "";
            发放老龄津贴1.Creator = "";
            发放老龄津贴1.datCreateDate = new System.DateTime(2015, 5, 10, 11, 23, 51, 208);
            发放老龄津贴1.dat出生日期 = new System.DateTime(1800, 1, 1, 0, 0, 0, 0);
            发放老龄津贴1.dat领取时间 = new System.DateTime(2015, 5, 10, 11, 23, 51, 210);
            发放老龄津贴1.DelFlag = "";
            发放老龄津贴1.ID = "";
            发放老龄津贴1.出生日期 = "1800-01-01 00:00:00";
            发放老龄津贴1.姓名 = "";
            发放老龄津贴1.死亡 = "";
            发放老龄津贴1.状态 = "";
            发放老龄津贴1.类别 = "";
            发放老龄津贴1.街道 = "园岭街道办";
            发放老龄津贴1.身份证 = "";
            发放老龄津贴1.银行账号 = "";
            发放老龄津贴1.领取时间 = "";
            this.uc.stru = 发放老龄津贴1;
            this.uc.TabIndex = 4;
            // 
            // FEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 291);
            this.Controls.Add(this.uc);
            this.Name = "FEdit";
            this.Text = "Edit";
            this.Load += new System.EventHandler(this.Edit_Load);
            this.Controls.SetChildIndex(this.uc, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private UI.UC.老龄办.发放老龄津贴 uc;

    }
}