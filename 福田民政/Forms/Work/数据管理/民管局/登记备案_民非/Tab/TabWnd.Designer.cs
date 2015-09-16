namespace 福田民政.Forms.Work.数据管理.民管局.登记备案.Tab
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
            this.pag变更记录 = new System.Windows.Forms.TabPage();
            this.pag年检记录 = new System.Windows.Forms.TabPage();
            this.pag换证记录 = new System.Windows.Forms.TabPage();
            this.pag行政执法记录 = new System.Windows.Forms.TabPage();
            this.pag备案 = new System.Windows.Forms.TabPage();
            this.pag评估 = new System.Windows.Forms.TabPage();
            this.ctrl.SuspendLayout();
            this.SuspendLayout();
            // 
            // ctrl
            // 
            this.ctrl.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.ctrl.Controls.Add(this.pag行政执法记录);
            this.ctrl.Controls.Add(this.pag变更记录);
            this.ctrl.Controls.Add(this.pag年检记录);
            this.ctrl.Controls.Add(this.pag评估);
            this.ctrl.Controls.Add(this.pag换证记录);
            this.ctrl.Controls.Add(this.pag备案);
            this.ctrl.Cursor = System.Windows.Forms.Cursors.Default;
            this.ctrl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctrl.ItemSize = new System.Drawing.Size(100, 30);
            this.ctrl.Location = new System.Drawing.Point(0, 0);
            this.ctrl.Name = "ctrl";
            this.ctrl.SelectedIndex = 0;
            this.ctrl.Size = new System.Drawing.Size(585, 276);
            this.ctrl.TabIndex = 0;
            // 
            // pag变更记录
            // 
            this.pag变更记录.Location = new System.Drawing.Point(4, 34);
            this.pag变更记录.Name = "pag变更记录";
            this.pag变更记录.Padding = new System.Windows.Forms.Padding(3);
            this.pag变更记录.Size = new System.Drawing.Size(577, 238);
            this.pag变更记录.TabIndex = 1;
            this.pag变更记录.Text = "变更记录";
            this.pag变更记录.UseVisualStyleBackColor = true;
            // 
            // pag年检记录
            // 
            this.pag年检记录.Location = new System.Drawing.Point(4, 34);
            this.pag年检记录.Name = "pag年检记录";
            this.pag年检记录.Size = new System.Drawing.Size(577, 238);
            this.pag年检记录.TabIndex = 2;
            this.pag年检记录.Text = "年检记录";
            this.pag年检记录.UseVisualStyleBackColor = true;
            // 
            // pag换证记录
            // 
            this.pag换证记录.Location = new System.Drawing.Point(4, 34);
            this.pag换证记录.Name = "pag换证记录";
            this.pag换证记录.Size = new System.Drawing.Size(577, 238);
            this.pag换证记录.TabIndex = 3;
            this.pag换证记录.Text = "换证记录";
            this.pag换证记录.UseVisualStyleBackColor = true;
            // 
            // pag行政执法记录
            // 
            this.pag行政执法记录.Location = new System.Drawing.Point(4, 34);
            this.pag行政执法记录.Name = "pag行政执法记录";
            this.pag行政执法记录.Size = new System.Drawing.Size(577, 238);
            this.pag行政执法记录.TabIndex = 4;
            this.pag行政执法记录.Text = "行政执法记录";
            this.pag行政执法记录.UseVisualStyleBackColor = true;
            // 
            // pag备案
            // 
            this.pag备案.Location = new System.Drawing.Point(4, 34);
            this.pag备案.Name = "pag备案";
            this.pag备案.Size = new System.Drawing.Size(577, 238);
            this.pag备案.TabIndex = 5;
            this.pag备案.Text = "备案";
            this.pag备案.UseVisualStyleBackColor = true;
            // 
            // pag评估
            // 
            this.pag评估.Location = new System.Drawing.Point(4, 34);
            this.pag评估.Name = "pag评估";
            this.pag评估.Size = new System.Drawing.Size(577, 238);
            this.pag评估.TabIndex = 6;
            this.pag评估.Text = "评估";
            this.pag评估.UseVisualStyleBackColor = true;
            // 
            // TabWnd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 276);
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
        private System.Windows.Forms.TabPage pag变更记录;
        private System.Windows.Forms.TabPage pag年检记录;
        private System.Windows.Forms.TabPage pag换证记录;
        private System.Windows.Forms.TabPage pag行政执法记录;
        private System.Windows.Forms.TabPage pag备案;
        private System.Windows.Forms.TabPage pag评估;
    }
}