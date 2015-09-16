namespace 福田民政.Forms.数据管理.事务科
{
    partial class 居家养老服务补贴
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
            this.pnlList = new System.Windows.Forms.Panel();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // pnlList
            // 
            this.pnlList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlList.Location = new System.Drawing.Point(0, 40);
            this.pnlList.Name = "pnlList";
            this.pnlList.Size = new System.Drawing.Size(476, 266);
            this.pnlList.TabIndex = 14;
            // 
            // pnlTop
            // 
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(476, 40);
            this.pnlTop.TabIndex = 13;
            // 
            // pnlBottom
            // 
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Location = new System.Drawing.Point(0, 306);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(476, 42);
            this.pnlBottom.TabIndex = 12;
            // 
            // 居家养老服务补贴
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 348);
            this.Controls.Add(this.pnlList);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.pnlBottom);
            this.Name = "居家养老服务补贴";
            this.Text = "社会救助";
            this.Load += new System.EventHandler(this.居家养老服务补贴_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlList;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Panel pnlBottom;

    }
}