namespace 福田民政.Forms.数据管理.福利中心.老人入住.Tab
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
            this.pag监护人 = new System.Windows.Forms.TabPage();
            this.pag担保人 = new System.Windows.Forms.TabPage();
            this.ctrl.SuspendLayout();
            this.SuspendLayout();
            // 
            // ctrl
            // 
            this.ctrl.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.ctrl.Controls.Add(this.pag监护人);
            this.ctrl.Controls.Add(this.pag担保人);
            this.ctrl.Cursor = System.Windows.Forms.Cursors.Default;
            this.ctrl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctrl.ItemSize = new System.Drawing.Size(100, 30);
            this.ctrl.Location = new System.Drawing.Point(0, 0);
            this.ctrl.Name = "ctrl";
            this.ctrl.SelectedIndex = 0;
            this.ctrl.Size = new System.Drawing.Size(639, 325);
            this.ctrl.TabIndex = 0;
            // 
            // pag监护人
            // 
            this.pag监护人.Location = new System.Drawing.Point(4, 34);
            this.pag监护人.Name = "pag监护人";
            this.pag监护人.Size = new System.Drawing.Size(631, 287);
            this.pag监护人.TabIndex = 0;
            this.pag监护人.Text = "监护人";
            this.pag监护人.UseVisualStyleBackColor = true;
            // 
            // pag担保人
            // 
            this.pag担保人.Location = new System.Drawing.Point(4, 34);
            this.pag担保人.Name = "pag担保人";
            this.pag担保人.Size = new System.Drawing.Size(631, 287);
            this.pag担保人.TabIndex = 1;
            this.pag担保人.Text = "担保人";
            this.pag担保人.UseVisualStyleBackColor = true;
            // 
            // TabWnd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 325);
            this.Controls.Add(this.ctrl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TabWnd";
            this.Text = "TabWnd";
            this.Load += new System.EventHandler(this.TabWnd_Load);
            this.ctrl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private FrontFlag.Control.XTableCtrl ctrl;
        private System.Windows.Forms.TabPage pag监护人;
        private System.Windows.Forms.TabPage pag担保人;
    }
}