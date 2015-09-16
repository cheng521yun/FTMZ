namespace 福田民政.Forms.Work.数据管理.事务科.社会救助.Tab
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
            this.pag成员信息 = new System.Windows.Forms.TabPage();
            this.pag发放记录 = new System.Windows.Forms.TabPage();
            this.ctrl.SuspendLayout();
            this.SuspendLayout();
            // 
            // ctrl
            // 
            this.ctrl.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.ctrl.Controls.Add(this.pag成员信息);
            this.ctrl.Controls.Add(this.pag发放记录);
            this.ctrl.Cursor = System.Windows.Forms.Cursors.Default;
            this.ctrl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctrl.ItemSize = new System.Drawing.Size(100, 30);
            this.ctrl.Location = new System.Drawing.Point(0, 0);
            this.ctrl.Name = "ctrl";
            this.ctrl.SelectedIndex = 0;
            this.ctrl.Size = new System.Drawing.Size(510, 276);
            this.ctrl.TabIndex = 0;
            // 
            // pag成员信息
            // 
            this.pag成员信息.Location = new System.Drawing.Point(4, 34);
            this.pag成员信息.Name = "pag成员信息";
            this.pag成员信息.Padding = new System.Windows.Forms.Padding(3);
            this.pag成员信息.Size = new System.Drawing.Size(502, 238);
            this.pag成员信息.TabIndex = 0;
            this.pag成员信息.Text = "成员信息";
            this.pag成员信息.UseVisualStyleBackColor = true;
            // 
            // pag发放记录
            // 
            this.pag发放记录.Location = new System.Drawing.Point(4, 34);
            this.pag发放记录.Name = "pag发放记录";
            this.pag发放记录.Padding = new System.Windows.Forms.Padding(3);
            this.pag发放记录.Size = new System.Drawing.Size(502, 238);
            this.pag发放记录.TabIndex = 1;
            this.pag发放记录.Text = "发放记录";
            this.pag发放记录.UseVisualStyleBackColor = true;
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

        private FrontFlag.Control.XTableCtrl ctrl;
        private System.Windows.Forms.TabPage pag成员信息;
        private System.Windows.Forms.TabPage pag发放记录;
    }
}