namespace 福田民政.Forms.数据管理.优抚科
{
    partial class 优抚对象_登记
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
            this.pnlContent = new System.Windows.Forms.Panel();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.ucCmb优抚对象 = new UI.Ctrl.Cmb.优抚对象();
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.pnlTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlContent
            // 
            this.pnlContent.BackColor = System.Drawing.Color.White;
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(0, 43);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(664, 432);
            this.pnlContent.TabIndex = 8;
            // 
            // pnlTop
            // 
            this.pnlTop.Controls.Add(this.ucCmb优抚对象);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(664, 43);
            this.pnlTop.TabIndex = 9;
            // 
            // ucCmb优抚对象
            // 
            this.ucCmb优抚对象.Location = new System.Drawing.Point(4, 4);
            this.ucCmb优抚对象.Name = "ucCmb优抚对象";
            this.ucCmb优抚对象.Size = new System.Drawing.Size(501, 31);
            this.ucCmb优抚对象.TabIndex = 0;
            // 
            // pnlBottom
            // 
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Location = new System.Drawing.Point(0, 475);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(664, 40);
            this.pnlBottom.TabIndex = 6;
            // 
            // 优抚对象_登记
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 515);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.pnlBottom);
            this.Name = "优抚对象_登记";
            this.Text = "优抚对象_登记";
            this.pnlTop.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.Panel pnlTop;
        private UI.Ctrl.Cmb.优抚对象 ucCmb优抚对象;

    }
}