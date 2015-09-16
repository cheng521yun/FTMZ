namespace 福田民政.Forms.Work.数据管理.基层科.数据统计.Tab
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
            this.pag民主管理信息管理 = new System.Windows.Forms.TabPage();
            this.pag社区基础服务设施情况 = new System.Windows.Forms.TabPage();
            this.pag福田区社工岗位社会工作 = new System.Windows.Forms.TabPage();
            this.ctrl.SuspendLayout();
            this.SuspendLayout();
            // 
            // ctrl
            // 
            this.ctrl.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.ctrl.Controls.Add(this.pag民主管理信息管理);
            this.ctrl.Controls.Add(this.pag社区基础服务设施情况);
            this.ctrl.Controls.Add(this.pag福田区社工岗位社会工作);
            this.ctrl.Cursor = System.Windows.Forms.Cursors.Default;
            this.ctrl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctrl.ItemSize = new System.Drawing.Size(100, 30);
            this.ctrl.Location = new System.Drawing.Point(0, 0);
            this.ctrl.Name = "ctrl";
            this.ctrl.SelectedIndex = 0;
            this.ctrl.Size = new System.Drawing.Size(639, 325);
            this.ctrl.TabIndex = 0;
            // 
            // pag民主管理信息管理
            // 
            this.pag民主管理信息管理.Location = new System.Drawing.Point(4, 34);
            this.pag民主管理信息管理.Name = "pag民主管理信息管理";
            this.pag民主管理信息管理.Size = new System.Drawing.Size(631, 287);
            this.pag民主管理信息管理.TabIndex = 0;
            this.pag民主管理信息管理.Text = "民主管理信息管理";
            this.pag民主管理信息管理.UseVisualStyleBackColor = true;
            // 
            // pag社区基础服务设施情况
            // 
            this.pag社区基础服务设施情况.Location = new System.Drawing.Point(4, 34);
            this.pag社区基础服务设施情况.Name = "pag社区基础服务设施情况";
            this.pag社区基础服务设施情况.Size = new System.Drawing.Size(502, 238);
            this.pag社区基础服务设施情况.TabIndex = 1;
            this.pag社区基础服务设施情况.Text = "社区基础服务设施情况";
            this.pag社区基础服务设施情况.UseVisualStyleBackColor = true;
            // 
            // pag福田区社工岗位社会工作
            // 
            this.pag福田区社工岗位社会工作.Location = new System.Drawing.Point(4, 34);
            this.pag福田区社工岗位社会工作.Name = "pag福田区社工岗位社会工作";
            this.pag福田区社工岗位社会工作.Size = new System.Drawing.Size(502, 238);
            this.pag福田区社工岗位社会工作.TabIndex = 2;
            this.pag福田区社工岗位社会工作.Text = "福田区社工岗位社会工作";
            this.pag福田区社工岗位社会工作.UseVisualStyleBackColor = true;
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
        private System.Windows.Forms.TabPage pag民主管理信息管理;
        private System.Windows.Forms.TabPage pag社区基础服务设施情况;
        private System.Windows.Forms.TabPage pag福田区社工岗位社会工作;
    }
}