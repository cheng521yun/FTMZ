namespace UI.Ctrl.Btn
{
    partial class btnFind
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(btnFind));
            this.xImgButton1 = new FrontFlag.Control.XImgButton();
            this.SuspendLayout();
            // 
            // xImgButton1
            // 
            this.xImgButton1.BackColor = System.Drawing.Color.Transparent;
            this.xImgButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.xImgButton1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.xImgButton1.FlatAppearance.BorderSize = 0;
            this.xImgButton1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.xImgButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.xImgButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.xImgButton1.Image = ((System.Drawing.Image)(resources.GetObject("xImgButton1.Image")));
            this.xImgButton1.Location = new System.Drawing.Point(0, 0);
            this.xImgButton1.Name = "xImgButton1";
            this.xImgButton1.Size = new System.Drawing.Size(20, 20);
            this.xImgButton1.TabIndex = 307;
            this.xImgButton1.Text = "Find";
            this.xImgButton1.UseVisualStyleBackColor = false;
            this.xImgButton1.Click += new System.EventHandler(this.xImgButton1_Click);
            // 
            // btnFind
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.xImgButton1);
            this.Name = "btnFind";
            this.Size = new System.Drawing.Size(20, 20);
            this.ResumeLayout(false);

        }

        #endregion

        private FrontFlag.Control.XImgButton xImgButton1;
    }
}
