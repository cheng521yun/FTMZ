namespace UI.Ctrl.Btn
{
    partial class SmallIconBtn
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
            this.labText = new System.Windows.Forms.Label();
            this.picbox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picbox)).BeginInit();
            this.SuspendLayout();
            // 
            // labText
            // 
            this.labText.AutoSize = true;
            this.labText.BackColor = System.Drawing.Color.Transparent;
            this.labText.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labText.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labText.Location = new System.Drawing.Point(25, 4);
            this.labText.Name = "labText";
            this.labText.Size = new System.Drawing.Size(32, 17);
            this.labText.TabIndex = 0;
            this.labText.Text = "Text";
            this.labText.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labCaption_MouseDown);
            this.labText.MouseEnter += new System.EventHandler(this.labCaption_MouseEnter);
            this.labText.MouseLeave += new System.EventHandler(this.labCaption_MouseLeave);
            // 
            // picbox
            // 
            this.picbox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picbox.Location = new System.Drawing.Point(2, 2);
            this.picbox.Name = "picbox";
            this.picbox.Size = new System.Drawing.Size(20, 20);
            this.picbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picbox.TabIndex = 1;
            this.picbox.TabStop = false;
            this.picbox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picbox_MouseDown);
            this.picbox.MouseEnter += new System.EventHandler(this.picbox_MouseEnter);
            this.picbox.MouseLeave += new System.EventHandler(this.picbox_MouseLeave);
            // 
            // SmallIconBtn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.picbox);
            this.Controls.Add(this.labText);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "SmallIconBtn";
            this.Size = new System.Drawing.Size(120, 25);
            this.Load += new System.EventHandler(this.TopMenuBtn_Load);
            this.SizeChanged += new System.EventHandler(this.TopMenuBtn_SizeChanged);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopMenuBtn_MouseDown);
            this.MouseEnter += new System.EventHandler(this.TopMenuBtn_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.TopMenuBtn_MouseLeave);
            ((System.ComponentModel.ISupportInitialize)(this.picbox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labText;
        private System.Windows.Forms.PictureBox picbox;
    }
}
