namespace 福田民政.Forms.数据管理.民管局.登记备案_社团
{
    partial class 登记备案_社团
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
            this.pnlList = new System.Windows.Forms.Panel();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.pnlTool = new System.Windows.Forms.Panel();
            this.pnlBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlList
            // 
            this.pnlList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlList.Location = new System.Drawing.Point(0, 40);
            this.pnlList.Name = "pnlList";
            this.pnlList.Size = new System.Drawing.Size(519, 117);
            this.pnlList.TabIndex = 5;
            // 
            // pnlTop
            // 
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(519, 40);
            this.pnlTop.TabIndex = 4;
            // 
            // pnlBottom
            // 
            
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Location = new System.Drawing.Point(0, 157);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(519, 200);
            this.pnlBottom.TabIndex = 3;
            // 
            // pnlTool
            // 
            this.pnlTool.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlTool.Location = new System.Drawing.Point(0, 160);
            this.pnlTool.Name = "pnlTool";
            this.pnlTool.Size = new System.Drawing.Size(519, 40);
            this.pnlTool.TabIndex = 5;
            // 
            // 登记备案_社团
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 357);
            this.Controls.Add(this.pnlList);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.pnlBottom);
            this.Controls.Add( this.pnlTool );
            this.Name = "登记备案_社团";
            this.Text = "登记备案";
            this.pnlBottom.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlList;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.Panel pnlTool;

    }
}