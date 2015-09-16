namespace 福田民政.Forms.Work.数据管理.事务科.临时救助.Tab
{
    partial class TabWnd
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
            this.ctrl = new FrontFlag.Control.XTableCtrl();
            this.pag意外或其他救助 = new System.Windows.Forms.TabPage();
            this.pag疾病救助 = new System.Windows.Forms.TabPage();
            this.pag低保边缘户 = new System.Windows.Forms.TabPage();
            this.ctrl.SuspendLayout();
            this.SuspendLayout();
            // 
            // ctrl
            // 
            this.ctrl.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.ctrl.Controls.Add(this.pag意外或其他救助);
            this.ctrl.Controls.Add(this.pag疾病救助);
            this.ctrl.Controls.Add(this.pag低保边缘户);
            this.ctrl.Cursor = System.Windows.Forms.Cursors.Default;
            this.ctrl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctrl.ItemSize = new System.Drawing.Size(100, 30);
            this.ctrl.Location = new System.Drawing.Point(0, 0);
            this.ctrl.Name = "ctrl";
            this.ctrl.SelectedIndex = 0;
            this.ctrl.Size = new System.Drawing.Size(510, 276);
            this.ctrl.TabIndex = 0;
            // 
            // pag意外或其他救助
            // 
            this.pag意外或其他救助.Location = new System.Drawing.Point(4, 34);
            this.pag意外或其他救助.Name = "pag意外或其他救助";
            this.pag意外或其他救助.Padding = new System.Windows.Forms.Padding(3);
            this.pag意外或其他救助.Size = new System.Drawing.Size(502, 238);
            this.pag意外或其他救助.TabIndex = 1;
            this.pag意外或其他救助.Text = "意外或其他救助";
            this.pag意外或其他救助.UseVisualStyleBackColor = true;
            // 
            // pag疾病救助
            // 
            this.pag疾病救助.Location = new System.Drawing.Point(4, 34);
            this.pag疾病救助.Name = "pag疾病救助";
            this.pag疾病救助.Size = new System.Drawing.Size(502, 238);
            this.pag疾病救助.TabIndex = 2;
            this.pag疾病救助.Text = "疾病救助";
            this.pag疾病救助.UseVisualStyleBackColor = true;
            // 
            // pag低保边缘户
            // 
            this.pag低保边缘户.Location = new System.Drawing.Point(4, 34);
            this.pag低保边缘户.Name = "pag低保边缘户";
            this.pag低保边缘户.Size = new System.Drawing.Size(502, 238);
            this.pag低保边缘户.TabIndex = 3;
            this.pag低保边缘户.Text = "低保边缘户";
            this.pag低保边缘户.UseVisualStyleBackColor = true;
            // 
            // TabWnd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 276);
            this.Controls.Add(this.ctrl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TabWnd";
            this.Text = "TabWnd";
            this.Load += new System.EventHandler(this.TabWnd_Load);
            this.ctrl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public FrontFlag.Control.XTableCtrl ctrl;
        private System.Windows.Forms.TabPage pag意外或其他救助;
        private System.Windows.Forms.TabPage pag疾病救助;
        private System.Windows.Forms.TabPage pag低保边缘户;
    }
}