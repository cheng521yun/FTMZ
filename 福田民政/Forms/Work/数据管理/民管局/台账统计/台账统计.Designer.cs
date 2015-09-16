namespace 福田民政.Forms.数据管理.民管局
{
    partial class 台账统计
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
            this.pnl01 = new System.Windows.Forms.Panel();
            this.pnl02 = new System.Windows.Forms.Panel();
            this.pnl03 = new System.Windows.Forms.Panel();
            this.pnl04 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // pnl01
            // 
            this.pnl01.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl01.Location = new System.Drawing.Point(0, 0);
            this.pnl01.Name = "pnl01";
            this.pnl01.Size = new System.Drawing.Size(556, 99);
            this.pnl01.TabIndex = 0;
            // 
            // pnl02
            // 
            this.pnl02.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl02.Location = new System.Drawing.Point(0, 99);
            this.pnl02.Name = "pnl02";
            this.pnl02.Size = new System.Drawing.Size(556, 99);
            this.pnl02.TabIndex = 1;
            // 
            // pnl03
            // 
            this.pnl03.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl03.Location = new System.Drawing.Point(0, 198);
            this.pnl03.Name = "pnl03";
            this.pnl03.Size = new System.Drawing.Size(556, 99);
            this.pnl03.TabIndex = 2;
            // 
            // pnl04
            // 
            this.pnl04.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl04.Location = new System.Drawing.Point(0, 297);
            this.pnl04.Name = "pnl04";
            this.pnl04.Size = new System.Drawing.Size(556, 99);
            this.pnl04.TabIndex = 3;
            // 
            // 台账统计
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 408);
            this.Controls.Add(this.pnl04);
            this.Controls.Add(this.pnl03);
            this.Controls.Add(this.pnl02);
            this.Controls.Add(this.pnl01);
            this.Name = "台账统计";
            this.Text = "登记备案";
            this.Load += new System.EventHandler(this.台账统计_Load);
            this.SizeChanged += new System.EventHandler(this.台账统计_SizeChanged);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl01;
        private System.Windows.Forms.Panel pnl02;
        private System.Windows.Forms.Panel pnl03;
        private System.Windows.Forms.Panel pnl04;

    }
}