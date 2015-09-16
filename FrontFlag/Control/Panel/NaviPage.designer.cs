namespace FrontFlag.Control
{
    partial class NaviPageDlg
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose ( bool disposing )
        {
            if ( disposing && ( components != null ) )
            {
                components.Dispose ();
            }
            base.Dispose ( disposing );
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent ()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager ( typeof ( NaviPageDlg ) );
            this.cmbPage = new System.Windows.Forms.ComboBox ();
            this.btnLast = new FrontFlag.Control.XImgButton ();
            this.btnNext = new FrontFlag.Control.XImgButton ();
            this.btnPre = new FrontFlag.Control.XImgButton ();
            this.btnFirst = new FrontFlag.Control.XImgButton ();
            this.labCount = new System.Windows.Forms.Label ();
            this.SuspendLayout ();
            // 
            // cmbPage
            // 
            this.cmbPage.FormattingEnabled = true;
            this.cmbPage.Location = new System.Drawing.Point ( 69 , 2 );
            this.cmbPage.Name = "cmbPage";
            this.cmbPage.Size = new System.Drawing.Size ( 45 , 20 );
            this.cmbPage.TabIndex = 4;
            this.cmbPage.SelectedIndexChanged += new System.EventHandler ( this.OnSelChange );
            this.cmbPage.KeyDown += new System.Windows.Forms.KeyEventHandler ( this.OnKeyDown );
            // 
            // btnLast
            // 
            this.btnLast.BackColor = System.Drawing.Color.Transparent;
            this.btnLast.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLast.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb ( ( ( int ) ( ( ( byte ) ( 0 ) ) ) ) , ( ( int ) ( ( ( byte ) ( 255 ) ) ) ) , ( ( int ) ( ( ( byte ) ( 0 ) ) ) ) , ( ( int ) ( ( ( byte ) ( 0 ) ) ) ) );
            this.btnLast.FlatAppearance.BorderSize = 0;
            this.btnLast.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnLast.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnLast.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLast.Image = ( ( System.Drawing.Image ) ( resources.GetObject ( "btnLast.Image" ) ) );
            this.btnLast.Location = new System.Drawing.Point ( 132 , 2 );
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size ( 16 , 20 );
            this.btnLast.TabIndex = 3;
            this.btnLast.Text = "Last";
            this.btnLast.UseVisualStyleBackColor = false;
            this.btnLast.Click += new System.EventHandler ( this.btnLast_Click );
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.Transparent;
            this.btnNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNext.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb ( ( ( int ) ( ( ( byte ) ( 0 ) ) ) ) , ( ( int ) ( ( ( byte ) ( 255 ) ) ) ) , ( ( int ) ( ( ( byte ) ( 0 ) ) ) ) , ( ( int ) ( ( ( byte ) ( 0 ) ) ) ) );
            this.btnNext.FlatAppearance.BorderSize = 0;
            this.btnNext.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnNext.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Image = ( ( System.Drawing.Image ) ( resources.GetObject ( "btnNext.Image" ) ) );
            this.btnNext.Location = new System.Drawing.Point ( 116 , 2 );
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size ( 16 , 20 );
            this.btnNext.TabIndex = 2;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler ( this.btnNext_Click );
            // 
            // btnPre
            // 
            this.btnPre.BackColor = System.Drawing.Color.Transparent;
            this.btnPre.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPre.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb ( ( ( int ) ( ( ( byte ) ( 0 ) ) ) ) , ( ( int ) ( ( ( byte ) ( 255 ) ) ) ) , ( ( int ) ( ( ( byte ) ( 0 ) ) ) ) , ( ( int ) ( ( ( byte ) ( 0 ) ) ) ) );
            this.btnPre.FlatAppearance.BorderSize = 0;
            this.btnPre.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnPre.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnPre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPre.Image = ( ( System.Drawing.Image ) ( resources.GetObject ( "btnPre.Image" ) ) );
            this.btnPre.Location = new System.Drawing.Point ( 51 , 2 );
            this.btnPre.Name = "btnPre";
            this.btnPre.Size = new System.Drawing.Size ( 16 , 20 );
            this.btnPre.TabIndex = 1;
            this.btnPre.Text = "Previous";
            this.btnPre.UseVisualStyleBackColor = false;
            this.btnPre.Click += new System.EventHandler ( this.btnPre_Click );
            // 
            // btnFirst
            // 
            this.btnFirst.BackColor = System.Drawing.Color.Transparent;
            this.btnFirst.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFirst.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb ( ( ( int ) ( ( ( byte ) ( 0 ) ) ) ) , ( ( int ) ( ( ( byte ) ( 255 ) ) ) ) , ( ( int ) ( ( ( byte ) ( 0 ) ) ) ) , ( ( int ) ( ( ( byte ) ( 0 ) ) ) ) );
            this.btnFirst.FlatAppearance.BorderSize = 0;
            this.btnFirst.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnFirst.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnFirst.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFirst.Image = ( ( System.Drawing.Image ) ( resources.GetObject ( "btnFirst.Image" ) ) );
            this.btnFirst.Location = new System.Drawing.Point ( 35 , 2 );
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size ( 16 , 20 );
            this.btnFirst.TabIndex = 0;
            this.btnFirst.Text = "First";
            this.btnFirst.UseVisualStyleBackColor = false;
            this.btnFirst.Click += new System.EventHandler ( this.btnFirst_Click );
            // 
            // labCount
            // 
            this.labCount.AutoSize = true;
            this.labCount.Font = new System.Drawing.Font ( "宋体" , 9F , System.Drawing.FontStyle.Bold , System.Drawing.GraphicsUnit.Point , ( ( byte ) ( 134 ) ) );
            this.labCount.Location = new System.Drawing.Point ( 3 , 5 );
            this.labCount.Name = "labCount";
            this.labCount.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labCount.Size = new System.Drawing.Size ( 12 , 12 );
            this.labCount.TabIndex = 5;
            this.labCount.Text = "0";
            this.labCount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // NaviPageDlg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF ( 6F , 12F );
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size ( 151 , 25 );
            this.Controls.Add ( this.labCount );
            this.Controls.Add ( this.cmbPage );
            this.Controls.Add ( this.btnLast );
            this.Controls.Add ( this.btnNext );
            this.Controls.Add ( this.btnPre );
            this.Controls.Add ( this.btnFirst );
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NaviPageDlg";
            this.Text = "NaviPage";
            this.Load += new System.EventHandler ( this.OnLoad );
            this.ResumeLayout ( false );
            this.PerformLayout ();

        }

        #endregion

        private XImgButton btnFirst;
        private XImgButton btnPre;
        private XImgButton btnNext;
        private XImgButton btnLast;
        private System.Windows.Forms.ComboBox cmbPage;
        private System.Windows.Forms.Label labCount;
    }
}