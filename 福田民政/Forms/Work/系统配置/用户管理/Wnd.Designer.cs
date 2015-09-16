namespace 福田民政.Forms.Work.系统配置.用户管理
{
    partial class Wnd
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
            this.pnlEdit = new System.Windows.Forms.Panel();
            this.pnlList = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // pnlEdit
            // 
            this.pnlEdit.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlEdit.Location = new System.Drawing.Point(0, 0);
            this.pnlEdit.Name = "pnlEdit";
            this.pnlEdit.Size = new System.Drawing.Size(519, 200);
            this.pnlEdit.TabIndex = 0;
            // 
            // pnlList
            // 
            this.pnlList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlList.Location = new System.Drawing.Point(0, 200);
            this.pnlList.Name = "pnlList";
            this.pnlList.Size = new System.Drawing.Size(519, 252);
            this.pnlList.TabIndex = 1;
            // 
            // Wnd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 452);
            this.Controls.Add(this.pnlList);
            this.Controls.Add(this.pnlEdit);
            this.Name = "Wnd";
            this.Text = "Wnd";
            this.Load += new System.EventHandler(this.Wnd_Load_1);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlEdit;
        private System.Windows.Forms.Panel pnlList;

    }
}