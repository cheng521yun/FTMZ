namespace 福田民政.Layout.LeftPnl
{
    partial class XLeftPnl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XLeftPnl));
            this.uc = new UI.Pnl.LeftMenu.LeftMenu();
            this.SuspendLayout();
            // 
            // uc
            // 
            this.uc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(219)))), ((int)(((byte)(205)))));
            this.uc.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("uc.BackgroundImage")));
            this.uc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.uc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uc.Location = new System.Drawing.Point(0, 0);
            this.uc.Name = "uc";
            this.uc.Size = new System.Drawing.Size(174, 365);
            this.uc.TabIndex = 3;
            // 
            // XLeftPnl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(174, 365);
            this.Controls.Add(this.uc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "XLeftPnl";
            this.Text = "XLeftPnl";
            this.Load += new System.EventHandler(this.XLeftPnl_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private UI.Pnl.LeftMenu.LeftMenu uc;
    }
}