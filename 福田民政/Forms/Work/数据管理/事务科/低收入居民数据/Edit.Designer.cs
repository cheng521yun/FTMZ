namespace 福田民政.Forms.Work.数据管理.事务科.低收入居民数据
{
    partial class FEdit
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
            this.uc = new UI.UC.事务科.低收入居民.低收入居民();
            this.SuspendLayout();
            // 
            // uc
            // 
            this.uc.BackColor = System.Drawing.Color.White;
            this.uc.Location = new System.Drawing.Point(32, 50);
            this.uc.Name = "uc";
            this.uc.Size = new System.Drawing.Size(369, 276);
            this.uc.TabIndex = 5;
            // 
            // FEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 372);
            this.Controls.Add(this.uc);
            this.Name = "FEdit";
            this.Text = "Edit";
            this.Load += new System.EventHandler(this.Edit_Load);
            this.Controls.SetChildIndex(this.uc, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private UI.UC.事务科.低收入居民.低收入居民 uc;
    }
}