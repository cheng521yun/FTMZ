namespace 福田民政.Forms.Comm.人员
{
    partial class F添加人员
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
            this.uc人员 = new UI.Dlg.人员.人员();
            this.SuspendLayout();
            // 
            // uc人员
            // 
            this.uc人员.Location = new System.Drawing.Point(20, 44);
            this.uc人员.Name = "uc人员";
            this.uc人员.Size = new System.Drawing.Size(475, 288);
            this.uc人员.TabIndex = 4;
            // 
            // F添加人员
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 375);
            this.Controls.Add(this.uc人员);
            this.Name = "F添加人员";
            this.Text = "添加人员";
            this.Load += new System.EventHandler(this.添加人员_Load);
            this.Controls.SetChildIndex(this.uc人员, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private UI.Dlg.人员.人员 uc人员;
    }
}