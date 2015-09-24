namespace 福田民政.Forms.Work.数据管理.基层科.民主管理
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
            DB.Stru.基层科.民主管理信息管理 民主管理信息管理1 = new DB.Stru.基层科.民主管理信息管理();
            this.uc = new UI.UC.基层科.民主管理();
            this.SuspendLayout();
            // 
            // uc
            // 
            this.uc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uc.Location = new System.Drawing.Point(0, 40);
            this.uc.Name = "uc";
            this.uc.Size = new System.Drawing.Size(487, 251);
            民主管理信息管理1.办公电话 = "";
            民主管理信息管理1.面积 = "";
            民主管理信息管理1.人口数 = "";
            民主管理信息管理1.委员会地址 = "";
            民主管理信息管理1.委员会名称 = "";
            民主管理信息管理1.辖区范围 = "";
            民主管理信息管理1.组织机构代码 = "";
            民主管理信息管理1.所属街道1 = "";
            民主管理信息管理1.所属街道2 = "";


            this.uc.stru = 民主管理信息管理1;
            this.uc.TabIndex = 0;
            // 
            // FEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 331);
            this.Controls.Add(this.uc);
            this.Name = "FEdit";
            this.Text = "Edit";
            this.Load += new System.EventHandler(this.Edit_Load);
            this.Controls.SetChildIndex(this.uc, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private UI.UC.基层科.民主管理 uc;

    }
}