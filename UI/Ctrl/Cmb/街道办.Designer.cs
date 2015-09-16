namespace UI.Ctrl.Cmb
{
    partial class 街道办
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
            this.cmb街道办 = new System.Windows.Forms.ComboBox();
            this.cmb工作站 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // cmb街道办
            // 
            this.cmb街道办.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb街道办.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmb街道办.FormattingEnabled = true;
            this.cmb街道办.ItemHeight = 12;
            this.cmb街道办.Location = new System.Drawing.Point(0, 0);
            this.cmb街道办.Name = "cmb街道办";
            this.cmb街道办.Size = new System.Drawing.Size(120, 20);
            this.cmb街道办.TabIndex = 0;
            this.cmb街道办.SelectedIndexChanged += new System.EventHandler(this.cmb街道办_SelectedIndexChanged);
            // 
            // cmb工作站
            // 
            this.cmb工作站.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb工作站.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmb工作站.FormattingEnabled = true;
            this.cmb工作站.Location = new System.Drawing.Point(122, 0);
            this.cmb工作站.Name = "cmb工作站";
            this.cmb工作站.Size = new System.Drawing.Size(100, 20);
            this.cmb工作站.TabIndex = 1;
            // 
            // 街道办
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cmb工作站);
            this.Controls.Add(this.cmb街道办);
            this.Name = "街道办";
            this.Size = new System.Drawing.Size(225, 22);
            this.Load += new System.EventHandler(this.街道办_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb街道办;
        private System.Windows.Forms.ComboBox cmb工作站;
    }
}
