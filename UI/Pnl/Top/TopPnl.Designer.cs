namespace UI.Pnl.Top
{
    partial class TopPnl
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
            this.topMenu1 = new UI.Pnl.TopMenu.TopMenu();
            this.topCompany1 = new UI.Pnl.TopMenu.TopCompany();
            this.SuspendLayout();
            // 
            // topMenu1
            // 
            this.topMenu1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.topMenu1.Location = new System.Drawing.Point(320, 0);
            this.topMenu1.Name = "topMenu1";
            this.topMenu1.Size = new System.Drawing.Size(535, 80);
            this.topMenu1.TabIndex = 2;
            // 
            // topCompany1
            // 
            this.topCompany1.Dock = System.Windows.Forms.DockStyle.Left;
            this.topCompany1.Location = new System.Drawing.Point(0, 0);
            this.topCompany1.Name = "topCompany1";
            this.topCompany1.Size = new System.Drawing.Size(320, 80);
            this.topCompany1.TabIndex = 1;
            // 
            // TopPnl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.topMenu1);
            this.Controls.Add(this.topCompany1);
            this.Name = "TopPnl";
            this.Size = new System.Drawing.Size(855, 80);
            this.Load += new System.EventHandler(this.TopPnl_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private TopMenu.TopCompany topCompany1;
        private TopMenu.TopMenu topMenu1;

    }
}
