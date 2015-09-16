namespace FrontFlag.Control.Button
{
    partial class XFindButton
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.labMode = new System.Windows.Forms.Label();
            this.menu_JQ = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_FIx = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_MH = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFind = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnFind = new FrontFlag.Control.XImgButton();
            this.menu_HL = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFind.SuspendLayout();
            this.SuspendLayout();
            // 
            // labMode
            // 
            this.labMode.AutoSize = true;
            this.labMode.Location = new System.Drawing.Point(19, 4);
            this.labMode.Name = "labMode";
            this.labMode.Size = new System.Drawing.Size(11, 12);
            this.labMode.TabIndex = 27;
            this.labMode.Text = "=";
            this.labMode.Click += new System.EventHandler(this.OnlabModeClick);
            this.labMode.MouseEnter += new System.EventHandler(this.OnlabModeEnter);
            this.labMode.MouseLeave += new System.EventHandler(this.OnlabModeLeave);
            // 
            // menu_JQ
            // 
            this.menu_JQ.Name = "menu_JQ";
            this.menu_JQ.Size = new System.Drawing.Size(159, 22);
            this.menu_JQ.Text = "=   精确查询";
            this.menu_JQ.Click += new System.EventHandler(this.menu_JQ_Click);
            // 
            // menu_FIx
            // 
            this.menu_FIx.Name = "menu_FIx";
            this.menu_FIx.Size = new System.Drawing.Size(159, 22);
            this.menu_FIx.Text = "=≈ 首部匹配查询";
            this.menu_FIx.Click += new System.EventHandler(this.menu_FIx_Click);
            // 
            // menu_MH
            // 
            this.menu_MH.Name = "menu_MH";
            this.menu_MH.Size = new System.Drawing.Size(159, 22);
            this.menu_MH.Text = "≈   模糊查询";
            this.menu_MH.Click += new System.EventHandler(this.menu_MH_Click);
            // 
            // menuFind
            // 
            this.menuFind.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_JQ,
            this.menu_FIx,
            this.menu_MH,
            this.menu_HL});
            this.menuFind.Name = "menu";
            this.menuFind.Size = new System.Drawing.Size(160, 92);
            // 
            // btnFind
            // 
            this.btnFind.BackColor = System.Drawing.Color.Transparent;
            this.btnFind.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnFind.FlatAppearance.BorderSize = 0;
            this.btnFind.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnFind.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnFind.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFind.Image = global::FrontFlag.Properties.Resources.Find;
            this.btnFind.Location = new System.Drawing.Point(0, 0);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(20, 20);
            this.btnFind.TabIndex = 26;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = false;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // menu_HL
            // 
            this.menu_HL.Name = "menu_HL";
            this.menu_HL.Size = new System.Drawing.Size(159, 22);
            this.menu_HL.Text = "≈≈   忽略关键字符";
            this.menu_HL.Click += new System.EventHandler( this.menu_HL_Click );
            // 
            // XFindButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.labMode);
            this.Controls.Add(this.btnFind);
            this.Name = "XFindButton";
            this.Size = new System.Drawing.Size(40, 20);
            this.Load += new System.EventHandler(this.XFindButton_Load);
            this.menuFind.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private XImgButton btnFind;
        private System.Windows.Forms.Label labMode;
        private System.Windows.Forms.ToolStripMenuItem menu_JQ;
        private System.Windows.Forms.ToolStripMenuItem menu_FIx;
        private System.Windows.Forms.ToolStripMenuItem menu_MH;
        private System.Windows.Forms.ContextMenuStrip menuFind;
        private System.Windows.Forms.ToolStripMenuItem menu_HL;
    }
}
