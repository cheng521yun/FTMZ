namespace UI.Pnl.Status
{
    partial class StatusPnl
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose( bool disposing )
        {
            if ( disposing && ( components != null ) )
            {
                components.Dispose();
            }
            base.Dispose( disposing );
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.loginUserInfo1 = new UI.Pnl.Login.LoginUserInfo();
            this.labVersion = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.loginUserInfo1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(603, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(152, 30);
            this.panel1.TabIndex = 0;
            // 
            // loginUserInfo1
            // 
            this.loginUserInfo1.Dock = System.Windows.Forms.DockStyle.Left;
            this.loginUserInfo1.Location = new System.Drawing.Point(0, 0);
            this.loginUserInfo1.Name = "loginUserInfo1";
            this.loginUserInfo1.Size = new System.Drawing.Size(151, 30);
            this.loginUserInfo1.TabIndex = 0;
            // 
            // labVersion
            // 
            this.labVersion.AutoSize = true;
            this.labVersion.ForeColor = System.Drawing.Color.White;
            this.labVersion.Location = new System.Drawing.Point(23, 9);
            this.labVersion.Name = "labVersion";
            this.labVersion.Size = new System.Drawing.Size(47, 12);
            this.labVersion.TabIndex = 1;
            this.labVersion.Text = "Version";
            // 
            // StatusPnl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labVersion);
            this.Controls.Add(this.panel1);
            this.Name = "StatusPnl";
            this.Size = new System.Drawing.Size(755, 30);
            this.Load += new System.EventHandler(this.StatusPnl_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Login.LoginUserInfo loginUserInfo1;
        private System.Windows.Forms.Label labVersion;
    }
}
