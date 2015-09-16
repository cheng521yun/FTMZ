namespace 福田民政.Forms.Work.数据管理.事务科.低收入居民数据.Tab.家庭成员
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
            DB.Stru.事务科.低收入居民_成员信息 低收入居民_成员信息1 = new DB.Stru.事务科.低收入居民_成员信息();
            this.uc = new UI.UC.事务科.低收入居民.低收入居民_成员信息();
            this.SuspendLayout();
            // 
            // uc
            // 
            this.uc.BackColor = System.Drawing.Color.White;
            this.uc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uc.Location = new System.Drawing.Point(0, 40);
            this.uc.Name = "uc";
            this.uc.Size = new System.Drawing.Size(401, 255);
            低收入居民_成员信息1.ID = "";
            低收入居民_成员信息1.保障人数 = "";
            低收入居民_成员信息1.姓名 = "";
            低收入居民_成员信息1.家庭人数 = "";
            低收入居民_成员信息1.家庭月收入 = "";
            低收入居民_成员信息1.性别 = "False";
            低收入居民_成员信息1.成员类型 = "";
            低收入居民_成员信息1.父ID = "";
            低收入居民_成员信息1.身份证 = "";
            this.uc.stru = 低收入居民_成员信息1;
            this.uc.TabIndex = 0;
            // 
            // Edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 335);
            this.Controls.Add(this.uc);
            this.Name = "Edit";
            this.Text = "编辑";
            this.Controls.SetChildIndex(this.uc, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private UI.UC.事务科.低收入居民.低收入居民_成员信息 uc;
    }
}