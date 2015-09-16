namespace 福田民政
{
    partial class MainForm
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

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.pnlMid = new System.Windows.Forms.Panel();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.pnlCaption = new System.Windows.Forms.Panel();
            this.split = new System.Windows.Forms.Splitter();
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.ucCaptionBar = new UI.Pnl.CaptionBar.CaptionBar();
            this.pnlMid.SuspendLayout();
            this.pnlCaption.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMid
            // 
            this.pnlMid.Controls.Add(this.pnlContent);
            this.pnlMid.Controls.Add(this.pnlCaption);
            this.pnlMid.Controls.Add(this.split);
            this.pnlMid.Controls.Add(this.pnlLeft);
            this.pnlMid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMid.Location = new System.Drawing.Point(0, 80);
            this.pnlMid.Name = "pnlMid";
            this.pnlMid.Padding = new System.Windows.Forms.Padding(5);
            this.pnlMid.Size = new System.Drawing.Size(1084, 652);
            this.pnlMid.TabIndex = 1;
            // 
            // pnlContent
            // 
            this.pnlContent.BackColor = System.Drawing.Color.DarkGray;
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(191, 45);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(888, 602);
            this.pnlContent.TabIndex = 3;
            // 
            // pnlCaption
            // 
            this.pnlCaption.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlCaption.Controls.Add(this.ucCaptionBar);
            this.pnlCaption.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCaption.Location = new System.Drawing.Point(191, 5);
            this.pnlCaption.Name = "pnlCaption";
            this.pnlCaption.Size = new System.Drawing.Size(888, 40);
            this.pnlCaption.TabIndex = 2;
            // 
            // split
            // 
            this.split.BackColor = System.Drawing.SystemColors.Control;
            this.split.Location = new System.Drawing.Point(185, 5);
            this.split.Name = "split";
            this.split.Size = new System.Drawing.Size(6, 642);
            this.split.TabIndex = 0;
            this.split.TabStop = false;
            // 
            // pnlLeft
            // 
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.Location = new System.Drawing.Point(5, 5);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(180, 642);
            this.pnlLeft.TabIndex = 0;
            // 
            // pnlBottom
            // 
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Location = new System.Drawing.Point(0, 732);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(1084, 30);
            this.pnlBottom.TabIndex = 2;
            // 
            // pnlTop
            // 
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(1084, 80);
            this.pnlTop.TabIndex = 0;
            // 
            // ucCaptionBar
            // 
            this.ucCaptionBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucCaptionBar.Location = new System.Drawing.Point(0, 0);
            this.ucCaptionBar.Name = "ucCaptionBar";
            this.ucCaptionBar.Size = new System.Drawing.Size(888, 40);
            this.ucCaptionBar.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 762);
            this.Controls.Add(this.pnlMid);
            this.Controls.Add(this.pnlBottom);
            this.Controls.Add(this.pnlTop);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "深圳福田民政数据管理系统";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.pnlMid.ResumeLayout(false);
            this.pnlCaption.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Panel pnlMid;
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.Panel pnlCaption;
        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.Panel pnlBottom;
        private UI.Pnl.CaptionBar.CaptionBar ucCaptionBar;
        private System.Windows.Forms.Splitter split;
    }
}

