namespace UI.Ctrl.Btn
{
    partial class LeftMenuBtn
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
            this.labCaption.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labCaption.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labCaption.ForeColor = System.Drawing.Color.MediumBlue;
            this.labCaption.Location = new System.Drawing.Point(4, 9);
            this.labCaption.Name = "labCaption";
            this.labCaption.Size = new System.Drawing.Size(47, 12);
            this.labCaption.TabIndex = 0;
            this.labCaption.Text = "label1";
            this.labCaption.Click += new System.EventHandler(this.labCaption_Click);
            this.labCaption.MouseEnter += new System.EventHandler(this.labCaption_MouseEnter);
            this.labCaption.MouseLeave += new System.EventHandler(this.labCaption_MouseLeave);
            // 
            // LeftMenuBtn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labCaption);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "LeftMenuBtn";
            this.Size = new System.Drawing.Size(158, 30);
            this.Click += new System.EventHandler(this.LeftMenuBtn_Click);
            this.MouseEnter += new System.EventHandler(this.LeftMenuBtn_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.LeftMenuBtn_MouseLeave);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labCaption;
    }
}
