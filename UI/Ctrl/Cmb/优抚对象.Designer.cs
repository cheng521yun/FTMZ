namespace UI.Ctrl.Cmb
{
    partial class 优抚对象
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
            this.cmb对象类别 = new System.Windows.Forms.ComboBox();
            this.cmb子对象类别 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmb对象类别
            // 
            this.cmb对象类别.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb对象类别.FormattingEnabled = true;
            this.cmb对象类别.Location = new System.Drawing.Point(75, 6);
            this.cmb对象类别.Name = "cmb对象类别";
            this.cmb对象类别.Size = new System.Drawing.Size(200, 20);
            this.cmb对象类别.TabIndex = 0;
            this.cmb对象类别.SelectedIndexChanged += new System.EventHandler(this.cmb对象类别_SelectedIndexChanged);
            // 
            // cmb子对象类别
            // 
            this.cmb子对象类别.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb子对象类别.FormattingEnabled = true;
            this.cmb子对象类别.Location = new System.Drawing.Point(280, 6);
            this.cmb子对象类别.Name = "cmb子对象类别";
            this.cmb子对象类别.Size = new System.Drawing.Size(200, 20);
            this.cmb子对象类别.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "优抚对象：";
            // 
            // 优抚对象
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmb子对象类别);
            this.Controls.Add(this.cmb对象类别);
            this.Name = "优抚对象";
            this.Size = new System.Drawing.Size(493, 31);
            this.Load += new System.EventHandler(this.优抚对象_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb对象类别;
        private System.Windows.Forms.ComboBox cmb子对象类别;
        private System.Windows.Forms.Label label1;
    }
}
