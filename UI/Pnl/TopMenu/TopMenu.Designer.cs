namespace UI.Pnl.TopMenu
{
    partial class TopMenu
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn10 = new UI.Ctrl.Btn.TopMenuBtn();
            this.btn06 = new UI.Ctrl.Btn.TopMenuBtn();
            this.btn05 = new UI.Ctrl.Btn.TopMenuBtn();
            this.btn04 = new UI.Ctrl.Btn.TopMenuBtn();
            this.btn03 = new UI.Ctrl.Btn.TopMenuBtn();
            this.btn02 = new UI.Ctrl.Btn.TopMenuBtn();
            this.btn01 = new UI.Ctrl.Btn.TopMenuBtn();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn10);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(659, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(108, 80);
            this.panel1.TabIndex = 1;
            // 
            // btn10
            // 
            this.btn10.BackColor = System.Drawing.Color.Transparent;
            this.btn10.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn10.Location = new System.Drawing.Point(24, 10);
            this.btn10.Name = "btn10";
            this.btn10.Size = new System.Drawing.Size(60, 60);
            this.btn10.TabIndex = 1;
            // 
            // btn06
            // 
            this.btn06.BackColor = System.Drawing.Color.Transparent;
            this.btn06.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn06.Location = new System.Drawing.Point(449, 10);
            this.btn06.Name = "btn06";
            this.btn06.Size = new System.Drawing.Size(60, 60);
            this.btn06.TabIndex = 6;
            // 
            // btn05
            // 
            this.btn05.BackColor = System.Drawing.Color.Transparent;
            this.btn05.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn05.Location = new System.Drawing.Point(365, 10);
            this.btn05.Name = "btn05";
            this.btn05.Size = new System.Drawing.Size(60, 60);
            this.btn05.TabIndex = 5;
            // 
            // btn04
            // 
            this.btn04.BackColor = System.Drawing.Color.Transparent;
            this.btn04.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn04.Location = new System.Drawing.Point(280, 10);
            this.btn04.Name = "btn04";
            this.btn04.Size = new System.Drawing.Size(60, 60);
            this.btn04.TabIndex = 4;
            // 
            // btn03
            // 
            this.btn03.BackColor = System.Drawing.Color.Transparent;
            this.btn03.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn03.Location = new System.Drawing.Point(195, 10);
            this.btn03.Name = "btn03";
            this.btn03.Size = new System.Drawing.Size(60, 60);
            this.btn03.TabIndex = 3;
            // 
            // btn02
            // 
            this.btn02.BackColor = System.Drawing.Color.Transparent;
            this.btn02.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn02.Location = new System.Drawing.Point(110, 10);
            this.btn02.Name = "btn02";
            this.btn02.Size = new System.Drawing.Size(60, 60);
            this.btn02.TabIndex = 2;
            // 
            // btn01
            // 
            this.btn01.BackColor = System.Drawing.Color.Transparent;
            this.btn01.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn01.Location = new System.Drawing.Point(25, 10);
            this.btn01.Name = "btn01";
            this.btn01.Size = new System.Drawing.Size(60, 60);
            this.btn01.TabIndex = 0;
            // 
            // TopMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn06);
            this.Controls.Add(this.btn05);
            this.Controls.Add(this.btn04);
            this.Controls.Add(this.btn03);
            this.Controls.Add(this.btn02);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn01);
            this.Name = "TopMenu";
            this.Size = new System.Drawing.Size(767, 80);
            this.Load += new System.EventHandler(this.TopMenu_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Ctrl.Btn.TopMenuBtn btn01;
        private System.Windows.Forms.Panel panel1;
        private Ctrl.Btn.TopMenuBtn btn10;
        private Ctrl.Btn.TopMenuBtn btn02;
        private Ctrl.Btn.TopMenuBtn btn03;
        private Ctrl.Btn.TopMenuBtn btn04;
        private Ctrl.Btn.TopMenuBtn btn05;
        private Ctrl.Btn.TopMenuBtn btn06;
    }
}
