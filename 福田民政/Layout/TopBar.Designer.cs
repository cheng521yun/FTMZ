namespace 福田民政.Layout
{
    partial class FTopBar
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
            this.topPnl1 = new UI.Pnl.Top.TopPnl();
            this.SuspendLayout();
            // 
            // topPnl1
            // 
            this.topPnl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.topPnl1.Location = new System.Drawing.Point(0, 0);
            this.topPnl1.Name = "topPnl1";
            this.topPnl1.Size = new System.Drawing.Size(953, 80);
            this.topPnl1.TabIndex = 0;
            // 
            // FTopBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 80);
            this.Controls.Add(this.topPnl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FTopBar";
            this.Text = "TopBar";
            this.Load += new System.EventHandler(this.FTopBar_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private UI.Pnl.Top.TopPnl topPnl1;

        //private System.Windows.Forms.Button btn01;
    }
}