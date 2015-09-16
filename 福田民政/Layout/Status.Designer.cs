namespace 福田民政.Layout
{
    partial class FStatusBar
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
            this.ucStatus = new UI.Pnl.Status.StatusPnl();
            this.SuspendLayout();
            // 
            // ucStatus
            // 
            this.ucStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(197)))), ((int)(((byte)(153)))));
            this.ucStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucStatus.Location = new System.Drawing.Point(0, 0);
            this.ucStatus.Name = "ucStatus";
            this.ucStatus.Size = new System.Drawing.Size(667, 30);
            this.ucStatus.TabIndex = 0;
            // 
            // FStatusBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 30);
            this.Controls.Add(this.ucStatus);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FStatusBar";
            this.Text = "Status";
            this.ResumeLayout(false);

        }

        #endregion

        private UI.Pnl.Status.StatusPnl ucStatus;
    }
}