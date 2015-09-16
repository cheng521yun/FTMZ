namespace FrontFlag.Control
{
    partial class XDataGridView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose ( bool disposing )
        {
            if ( disposing && ( components != null ) )
            {
                components.Dispose ();
            }
            base.Dispose ( disposing );
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent ()
        {
            this.components = new System.ComponentModel.Container ();
            this.menuSelectCheck = new System.Windows.Forms.ContextMenuStrip ( this.components );
            this.menuSelectAll = new System.Windows.Forms.ToolStripMenuItem ();
            this.menuUnSelectAll = new System.Windows.Forms.ToolStripMenuItem ();
            this.menuReverse = new System.Windows.Forms.ToolStripMenuItem ();
            this.menuSelectCheck.SuspendLayout ();
            ( (System.ComponentModel.ISupportInitialize) ( this ) ).BeginInit ();
            this.SuspendLayout ();
            // 
            // menuSelectCheck
            // 
            this.menuSelectCheck.Items.AddRange ( new System.Windows.Forms.ToolStripItem [] {
            this.menuSelectAll,
            this.menuUnSelectAll,
            this.menuReverse} );
            this.menuSelectCheck.Name = "menuSelectCheck";
            this.menuSelectCheck.Size = new System.Drawing.Size ( 119 , 70 );
            // 
            // menuSelectAll
            // 
            this.menuSelectAll.Name = "menuSelectAll";
            this.menuSelectAll.Size = new System.Drawing.Size ( 118 , 22 );
            this.menuSelectAll.Text = "全部选中";
            this.menuSelectAll.Click += new System.EventHandler ( this.OnClickmenuSelectAll );
            // 
            // menuUnSelectAll
            // 
            this.menuUnSelectAll.Name = "menuUnSelectAll";
            this.menuUnSelectAll.Size = new System.Drawing.Size ( 118 , 22 );
            this.menuUnSelectAll.Text = "全部取消";
            this.menuUnSelectAll.Click += new System.EventHandler ( this.OnClickmenuUnSelectAll );
            // 
            // menuReverse
            // 
            this.menuReverse.Name = "menuReverse";
            this.menuReverse.Size = new System.Drawing.Size ( 118 , 22 );
            this.menuReverse.Text = "反选";
            this.menuReverse.Click += new System.EventHandler ( this.OnClickmenuReverse );
            // 
            // XDataGridView
            // 
            this.RowTemplate.Height = 23;
            this.menuSelectCheck.ResumeLayout ( false );
            ( (System.ComponentModel.ISupportInitialize) ( this ) ).EndInit ();
            this.ResumeLayout ( false );

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip menuSelectCheck;
        private System.Windows.Forms.ToolStripMenuItem menuSelectAll;
        private System.Windows.Forms.ToolStripMenuItem menuUnSelectAll;
        private System.Windows.Forms.ToolStripMenuItem menuReverse;

    }
}
