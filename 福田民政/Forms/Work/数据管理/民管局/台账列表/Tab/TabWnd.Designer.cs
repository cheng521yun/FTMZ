namespace 福田民政.Forms.Work.数据管理.民管局.台账列表.Tab
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
            this.pag人员管理 = new System.Windows.Forms.TabPage();
            this.pag会员管理 = new System.Windows.Forms.TabPage();
            this.pag资产管理 = new System.Windows.Forms.TabPage();
            this.pag其他管理 = new System.Windows.Forms.TabPage();
            this.ctrl.SuspendLayout();
            this.SuspendLayout();
            // 
            // ctrl
            // 
            this.ctrl.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.ctrl.Controls.Add(this.pag人员管理);
            this.ctrl.Controls.Add(this.pag会员管理);
            this.ctrl.Controls.Add(this.pag资产管理);
            this.ctrl.Controls.Add(this.pag其他管理);
            this.ctrl.Cursor = System.Windows.Forms.Cursors.Default;
            this.ctrl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctrl.ItemSize = new System.Drawing.Size(100, 30);
            this.ctrl.Location = new System.Drawing.Point(0, 0);
            this.ctrl.Name = "ctrl";
            this.ctrl.SelectedIndex = 0;
            this.ctrl.Size = new System.Drawing.Size(510, 276);
            this.ctrl.TabIndex = 0;
            // 
            // pag人员管理
            // 
            this.pag人员管理.Location = new System.Drawing.Point(4, 34);
            this.pag人员管理.Name = "pag人员管理";
            this.pag人员管理.Padding = new System.Windows.Forms.Padding(3);
            this.pag人员管理.Size = new System.Drawing.Size(502, 238);
            this.pag人员管理.TabIndex = 0;
            this.pag人员管理.Text = "人员管理";
            this.pag人员管理.UseVisualStyleBackColor = true;
            // 
            // pag会员管理
            // 
            this.pag会员管理.Location = new System.Drawing.Point(4, 34);
            this.pag会员管理.Name = "pag会员管理";
            this.pag会员管理.Padding = new System.Windows.Forms.Padding(3);
            this.pag会员管理.Size = new System.Drawing.Size(502, 238);
            this.pag会员管理.TabIndex = 1;
            this.pag会员管理.Text = "会员管理";
            this.pag会员管理.UseVisualStyleBackColor = true;
            // 
            // pag资产管理
            // 
            this.pag资产管理.Location = new System.Drawing.Point(4, 34);
            this.pag资产管理.Name = "pag资产管理";
            this.pag资产管理.Size = new System.Drawing.Size(502, 238);
            this.pag资产管理.TabIndex = 2;
            this.pag资产管理.Text = "资产管理";
            this.pag资产管理.UseVisualStyleBackColor = true;
            // 
            // pag其他管理
            // 
            this.pag其他管理.Location = new System.Drawing.Point(4, 34);
            this.pag其他管理.Name = "pag其他管理";
            this.pag其他管理.Size = new System.Drawing.Size(502, 238);
            this.pag其他管理.TabIndex = 3;
            this.pag其他管理.Text = "其他管理";
            this.pag其他管理.UseVisualStyleBackColor = true;
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
        private System.Windows.Forms.TabPage pag人员管理;
        private System.Windows.Forms.TabPage pag会员管理;
        private System.Windows.Forms.TabPage pag资产管理;
        private System.Windows.Forms.TabPage pag其他管理;
    }
}