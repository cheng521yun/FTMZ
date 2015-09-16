namespace 福田民政.Forms.Work.数据管理.老龄办.老龄津贴_停发
{
    partial class Tool
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tool));
            this.btn停发 = new UI.Ctrl.Btn.SmallIconBtn();
            this.SuspendLayout();
            // 
            // btn停发
            // 
            this.btn停发.BackColor = System.Drawing.Color.Transparent;
            this.btn停发.BtnImg = ((System.Drawing.Image)(resources.GetObject("btn停发.BtnImg")));
            this.btn停发.BtnTexT = "停发津贴";
            this.btn停发.CommandId = -1;
            this.btn停发.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn停发.Location = new System.Drawing.Point(12, 7);
            this.btn停发.Name = "btn停发";
            this.btn停发.Size = new System.Drawing.Size(120, 25);
            this.btn停发.TabIndex = 3;
            // 
            // Tool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 38);
            this.Controls.Add(this.btn停发);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Tool";
            this.Text = "发放";
            this.Load += new System.EventHandler(this.发放_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private UI.Ctrl.Btn.SmallIconBtn btn停发;

    }
}