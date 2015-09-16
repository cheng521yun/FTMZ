namespace UI.Pnl.CaptionBar
{
    partial class CaptionBar
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
            this.labCaption = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labCaption
            // 
            this.labCaption.AutoSize = true;
            this.labCaption.Font = new System.Drawing.Font("宋体", 14F);
            this.labCaption.ForeColor = System.Drawing.Color.White;
            this.labCaption.Location = new System.Drawing.Point(16, 10);
            this.labCaption.Name = "labCaption";
            this.labCaption.Size = new System.Drawing.Size(79, 19);
            this.labCaption.TabIndex = 0;
            this.labCaption.Text = "Caption";
            // 
            // CaptionBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labCaption);
            this.Name = "CaptionBar";
            this.Size = new System.Drawing.Size(690, 43);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labCaption;
    }
}
