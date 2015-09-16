namespace 福田民政.Layout.LeftPnl.数据管理
{
    partial class 福利中心
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
            this.uc = new UI.Pnl.LeftMenu.LeftMenu();
            this.MenuTree = new UI.Ctrl.Tree.LeftMenu();
            this.SuspendLayout();
            // 
            // uc
            // 
            this.uc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(219)))), ((int)(((byte)(205)))));
            this.uc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.uc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uc.Location = new System.Drawing.Point(0, 0);
            this.uc.Name = "uc";
            this.uc.Size = new System.Drawing.Size(263, 428);
            this.uc.TabIndex = 0;
            // 
            // MenuTree
            // 
            this.MenuTree.BackColor = System.Drawing.Color.Transparent;
            this.MenuTree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MenuTree.Location = new System.Drawing.Point(0, 0);
            this.MenuTree.Name = "MenuTree";
            this.MenuTree.Padding = new System.Windows.Forms.Padding(20, 0, 20, 20);
            this.MenuTree.Size = new System.Drawing.Size(263, 428);
            this.MenuTree.TabIndex = 8;
            // 
            // 福利中心
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(263, 428);
            this.Controls.Add(this.MenuTree);
            this.Controls.Add(this.uc);
            this.Name = "福利中心";
            this.Text = "老龄办";
            this.Controls.SetChildIndex(this.uc, 0);
            this.Controls.SetChildIndex(this.MenuTree, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private UI.Pnl.LeftMenu.LeftMenu uc;
        private UI.Ctrl.Tree.LeftMenu MenuTree;

    }
}