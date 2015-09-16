using FrontFlag.Control.Menu;

namespace 福田民政
{
    partial class Test
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
            this.components = new System.ComponentModel.Container();
            this.menu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.MenuItem01 = new FrontFlag.Control.Menu.XToolStripMenuItem();
            this.MenuItem02 = new FrontFlag.Control.Menu.XToolStripMenuItem();
            this.MenuItem03 = new FrontFlag.Control.Menu.XToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.qqqToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItem01,
            this.MenuItem02,
            this.MenuItem03,
            this.qqqToolStripMenuItem});
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(117, 92);
            // 
            // MenuItem01
            // 
            this.MenuItem01.Name = "MenuItem01";
            this.MenuItem01.Size = new System.Drawing.Size(116, 22);
            this.MenuItem01.Text = "Item01";
            this.MenuItem01.Click += new System.EventHandler(this.menuItem01ToolStripMenuItem_Click);
            this.MenuItem01.DisplayStyleChanged += new System.EventHandler(this.menuItem01ToolStripMenuItem_DisplayStyleChanged);
            // 
            // MenuItem02
            // 
            this.MenuItem02.Name = "MenuItem02";
            this.MenuItem02.Size = new System.Drawing.Size(116, 22);
            this.MenuItem02.Text = "Item02";
            // 
            // MenuItem03
            // 
            this.MenuItem03.Name = "MenuItem03";
            this.MenuItem03.Size = new System.Drawing.Size(116, 22);
            this.MenuItem03.Text = "Item03";
            // 
            // button1
            // 
            this.button1.ContextMenuStrip = this.menu;
            this.button1.Location = new System.Drawing.Point(50, 24);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button1_MouseDown);
            // 
            // qqqToolStripMenuItem
            // 
            this.qqqToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.toolStripMenuItem3});
            this.qqqToolStripMenuItem.Name = "qqqToolStripMenuItem";
            this.qqqToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.qqqToolStripMenuItem.Text = "qqq";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(152, 22);
            this.toolStripMenuItem2.Text = "111";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(152, 22);
            this.toolStripMenuItem3.Text = "222";
            // 
            // Test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.button1);
            this.Name = "Test";
            this.Text = "Test";
            this.Load += new System.EventHandler(this.Test_Load);
            this.menu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip menu;
        private XToolStripMenuItem MenuItem01;
        private XToolStripMenuItem MenuItem02;
        private XToolStripMenuItem MenuItem03;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem qqqToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
    }
}