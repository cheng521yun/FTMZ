namespace 福田民政.Forms.Work.数据管理.民管局.登记备案_社团.Edit
{
    partial class Edit
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
            this.uc = new UI.UC.民管局.民管局登记_社团();
            this.SuspendLayout();
            // 
            // uc
            // 
            this.uc.BackColor = System.Drawing.Color.White;
            this.uc.Location = new System.Drawing.Point(37, 50);
            this.uc.Name = "uc";
            this.uc.Size = new System.Drawing.Size(624, 354);
            this.uc.TabIndex = 5;
            // 
            // Edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 564);
            this.Controls.Add(this.uc);
            this.Name = "Edit";
            this.Text = "Edit";
            this.Load += new System.EventHandler(this.Edit_Load);
            this.Controls.SetChildIndex(this.uc, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private UI.UC.民管局.民管局登记_社团 uc;


        //private UI.UC.民管局.民管局登记_民非 民管局登记_民非1;
        //private UI.UC.民管局.民管局登记_民非 民管局登记_民非2;

        //private UI.UC.民管局.登记_民非 登记_民非1;
    }
}