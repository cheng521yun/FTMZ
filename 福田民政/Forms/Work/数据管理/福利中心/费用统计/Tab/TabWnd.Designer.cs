namespace 福田民政.Forms.数据管理.福利中心.费用统计.Tab
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
            this.pag养老服务费 = new System.Windows.Forms.TabPage();
            this.pag老人伙食费 = new System.Windows.Forms.TabPage();
            this.pag老人药费 = new System.Windows.Forms.TabPage();
            this.pag老人电费 = new System.Windows.Forms.TabPage();
            this.pag应收金额 = new System.Windows.Forms.TabPage();
            this.ctrl.SuspendLayout();
            this.SuspendLayout();
            // 
            // ctrl
            // 
            this.ctrl.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.ctrl.Controls.Add(this.pag养老服务费);
            this.ctrl.Controls.Add(this.pag老人伙食费);
            this.ctrl.Controls.Add(this.pag老人药费);
            this.ctrl.Controls.Add(this.pag老人电费);
            this.ctrl.Controls.Add(this.pag应收金额);
            this.ctrl.Cursor = System.Windows.Forms.Cursors.Default;
            this.ctrl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctrl.ItemSize = new System.Drawing.Size(100, 30);
            this.ctrl.Location = new System.Drawing.Point(0, 0);
            this.ctrl.Name = "ctrl";
            this.ctrl.SelectedIndex = 0;
            this.ctrl.Size = new System.Drawing.Size(639, 325);
            this.ctrl.TabIndex = 0;
            // 
            // pag养老服务费
            // 
            this.pag养老服务费.Location = new System.Drawing.Point(4, 34);
            this.pag养老服务费.Name = "pag养老服务费";
            this.pag养老服务费.Size = new System.Drawing.Size(631, 287);
            this.pag养老服务费.TabIndex = 0;
            this.pag养老服务费.Text = "养老服务费";
            this.pag养老服务费.UseVisualStyleBackColor = true;
            // 
            // pag老人伙食费
            // 
            this.pag老人伙食费.Location = new System.Drawing.Point(4, 34);
            this.pag老人伙食费.Name = "pag老人伙食费";
            this.pag老人伙食费.Size = new System.Drawing.Size(631, 287);
            this.pag老人伙食费.TabIndex = 1;
            this.pag老人伙食费.Text = "老人伙食费";
            this.pag老人伙食费.UseVisualStyleBackColor = true;
            // 
            // pag老人药费
            // 
            this.pag老人药费.Location = new System.Drawing.Point(4, 34);
            this.pag老人药费.Name = "pag老人药费";
            this.pag老人药费.Size = new System.Drawing.Size(631, 287);
            this.pag老人药费.TabIndex = 2;
            this.pag老人药费.Text = "老人药费";
            this.pag老人药费.UseVisualStyleBackColor = true;
            // 
            // pag老人电费
            // 
            this.pag老人电费.Location = new System.Drawing.Point(4, 34);
            this.pag老人电费.Name = "pag老人电费";
            this.pag老人电费.Size = new System.Drawing.Size(631, 287);
            this.pag老人电费.TabIndex = 3;
            this.pag老人电费.Text = "老人电费";
            this.pag老人电费.UseVisualStyleBackColor = true;
            // 
            // pag应收金额
            // 
            this.pag应收金额.Location = new System.Drawing.Point(4, 34);
            this.pag应收金额.Name = "pag应收金额";
            this.pag应收金额.Size = new System.Drawing.Size(631, 287);
            this.pag应收金额.TabIndex = 4;
            this.pag应收金额.Text = "应收金额";
            this.pag应收金额.UseVisualStyleBackColor = true;
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
        private System.Windows.Forms.TabPage pag养老服务费;
        private System.Windows.Forms.TabPage pag老人伙食费;
        private System.Windows.Forms.TabPage pag老人药费;
        private System.Windows.Forms.TabPage pag老人电费;
        private System.Windows.Forms.TabPage pag应收金额;
    }
}