using FrontFlag.Control.Tree;

namespace UI.Ctrl.Tree
{
    partial class LeftMenu
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose( bool disposing )
        {
            if ( disposing && ( components != null ) )
            {
                components.Dispose();
            }
            base.Dispose( disposing );
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.tree = new FrontFlag.Control.Tree.XTreeCtrl();
            this.SuspendLayout();
            // 
            // tree
            // 
            this.tree.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tree.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tree.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tree.FullRowSelect = true;
            this.tree.Location = new System.Drawing.Point(0, 0);
            this.tree.Margin = new System.Windows.Forms.Padding(0);
            this.tree.Name = "tree";
            this.tree.Size = new System.Drawing.Size(200, 388);
            this.tree.TabIndex = 0;
            this.tree.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tree_AfterSelect);
            // 
            // LeftMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.tree);
            this.Name = "LeftMenu";
            this.Size = new System.Drawing.Size(200, 388);
            this.ResumeLayout(false);

        }

        #endregion

        private XTreeCtrl tree;
    }
}
