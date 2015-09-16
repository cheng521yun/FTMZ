namespace FrontFlag.Control
{
    partial class XFloatForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // XFloatForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(613, 170);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "XFloatForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "FloatForm";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FloatForm_Load);
            this.MouseEnter += new System.EventHandler(this.FloatForm_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.FloatForm_MouseLeave);
            this.ResumeLayout(false);

        }

        #endregion
    }
}