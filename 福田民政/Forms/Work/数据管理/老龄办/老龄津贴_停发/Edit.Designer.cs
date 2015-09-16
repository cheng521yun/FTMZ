namespace 福田民政.Forms.Work.数据管理.老龄办.老龄津贴_停发
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
            DB.Stru.老龄办.停发老龄津贴 停发老龄津贴2 = new DB.Stru.老龄办.停发老龄津贴();
            this.uc = new UI.UC.老龄办.停发老龄津贴();
            this.SuspendLayout();
            // 
            // uc
            // 
            this.uc.Location = new System.Drawing.Point(15, 52);
            this.uc.Name = "uc";
            this.uc.Size = new System.Drawing.Size(440, 153);
            停发老龄津贴2.CreateDate = "";
            停发老龄津贴2.Creator = "";
            停发老龄津贴2.DelFlag = "";
            停发老龄津贴2.ID = "";
            停发老龄津贴2.停发原因 = "";
            停发老龄津贴2.停发日期 = "";
            停发老龄津贴2.姓名 = "";
            停发老龄津贴2.街道 = "园岭街道办";
            停发老龄津贴2.身份证 = "";
            this.uc.stru = 停发老龄津贴2;
            this.uc.TabIndex = 4;
            // 
            // FEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 250);
            this.Controls.Add(this.uc);
            this.Name = "FEdit";
            this.Text = "Edit";
            this.Load += new System.EventHandler(this.Edit_Load);
            this.Controls.SetChildIndex(this.uc, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private UI.UC.老龄办.停发老龄津贴 uc;


    }
}