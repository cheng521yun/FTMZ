namespace 福田民政.Forms.Work.数据管理.老龄办.老龄优待证_发放
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
            this.uc优待证 = new UI.UC.老龄办.优待证();
            this.SuspendLayout();
            // 
            // uc优待证
            // 
            this.uc优待证.Location = new System.Drawing.Point(11, 46);
            this.uc优待证.Name = "uc优待证";
            this.uc优待证.Size = new System.Drawing.Size(489, 276);
            this.uc优待证.TabIndex = 4;
            // 
            // FEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 372);
            this.Controls.Add(this.uc优待证);
            this.Name = "FEdit";
            this.Text = "Edit";
            this.Load += new System.EventHandler(this.Edit_Load);
            this.Controls.SetChildIndex(this.uc优待证, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private UI.UC.老龄办.优待证 uc优待证;
    }
}