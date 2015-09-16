namespace 福田民政.Forms.Work.数据管理.基层科.社区服务.Tab
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
            this.pag社工岗位 = new System.Windows.Forms.TabPage();
            this.pag社区公益服务 = new System.Windows.Forms.TabPage();
            this.ctrl.SuspendLayout();
            this.SuspendLayout();
            // 
            // ctrl
            // 
            this.ctrl.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.ctrl.Controls.Add(this.pag社工岗位);
            this.ctrl.Controls.Add(this.pag社区公益服务);
            this.ctrl.Cursor = System.Windows.Forms.Cursors.Default;
            this.ctrl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctrl.ItemSize = new System.Drawing.Size(100, 30);
            this.ctrl.Location = new System.Drawing.Point(0, 0);
            this.ctrl.Name = "ctrl";
            this.ctrl.SelectedIndex = 0;
            this.ctrl.Size = new System.Drawing.Size(510, 276);
            this.ctrl.TabIndex = 0;
            // 
            // pag社工岗位
            // 
            this.pag社工岗位.Location = new System.Drawing.Point(4, 34);
            this.pag社工岗位.Name = "pag社工岗位";
            this.pag社工岗位.Size = new System.Drawing.Size(502, 238);
            this.pag社工岗位.TabIndex = 0;
            this.pag社工岗位.Text = "社工岗位";
            this.pag社工岗位.UseVisualStyleBackColor = true;
            // 
            // pag社区公益服务
            // 
            this.pag社区公益服务.Location = new System.Drawing.Point(4, 34);
            this.pag社区公益服务.Name = "pag社区公益服务";
            this.pag社区公益服务.Size = new System.Drawing.Size(502, 238);
            this.pag社区公益服务.TabIndex = 1;
            this.pag社区公益服务.Text = "社区公益服务";
            this.pag社区公益服务.UseVisualStyleBackColor = true;
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
        private System.Windows.Forms.TabPage pag社工岗位;
        private System.Windows.Forms.TabPage pag社区公益服务;
    }
}