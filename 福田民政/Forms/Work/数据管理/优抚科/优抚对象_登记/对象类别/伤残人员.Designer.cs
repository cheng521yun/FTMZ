namespace 福田民政.Forms.Work.数据管理.优抚科.优抚对象_登记.对象类别
{
    partial class 伤残人员
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
            this.pag基本信息 = new System.Windows.Forms.TabPage();
            this.uc基本信息 = new UI.UC.优抚科.伤残人员.伤残人员_基本信息();
            this.pag生活来源 = new System.Windows.Forms.TabPage();
            this.伤残人员_生活费1 = new UI.UC.优抚科.伤残人员.伤残人员_生活费();
            this.ctrl.SuspendLayout();
            this.pag基本信息.SuspendLayout();
            this.pag生活来源.SuspendLayout();
            this.SuspendLayout();
            // 
            // ctrl
            // 
            this.ctrl.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.ctrl.Controls.Add(this.pag基本信息);
            this.ctrl.Controls.Add(this.pag生活来源);
            this.ctrl.Cursor = System.Windows.Forms.Cursors.Default;
            this.ctrl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctrl.ItemSize = new System.Drawing.Size(100, 30);
            this.ctrl.Location = new System.Drawing.Point(0, 0);
            this.ctrl.Name = "ctrl";
            this.ctrl.SelectedIndex = 0;
            this.ctrl.Size = new System.Drawing.Size(691, 495);
            this.ctrl.TabIndex = 1;
            // 
            // pag基本信息
            // 
            this.pag基本信息.Controls.Add(this.uc基本信息);
            this.pag基本信息.Location = new System.Drawing.Point(4, 34);
            this.pag基本信息.Name = "pag基本信息";
            this.pag基本信息.Padding = new System.Windows.Forms.Padding(3);
            this.pag基本信息.Size = new System.Drawing.Size(683, 457);
            this.pag基本信息.TabIndex = 0;
            this.pag基本信息.Text = "基本信息";
            this.pag基本信息.UseVisualStyleBackColor = true;
            // 
            // uc基本信息
            // 
            this.uc基本信息.Location = new System.Drawing.Point(0, 0);
            this.uc基本信息.Name = "uc基本信息";
            this.uc基本信息.Size = new System.Drawing.Size(610, 375);
            this.uc基本信息.TabIndex = 0;
            // 
            // pag生活来源
            // 
            this.pag生活来源.Controls.Add(this.伤残人员_生活费1);
            this.pag生活来源.Location = new System.Drawing.Point(4, 34);
            this.pag生活来源.Name = "pag生活来源";
            this.pag生活来源.Size = new System.Drawing.Size(683, 388);
            this.pag生活来源.TabIndex = 2;
            this.pag生活来源.Text = "生活来源";
            this.pag生活来源.UseVisualStyleBackColor = true;
            // 
            // 伤残人员_生活费1
            // 
            this.伤残人员_生活费1.Location = new System.Drawing.Point(0, 0);
            this.伤残人员_生活费1.Name = "伤残人员_生活费1";
            this.伤残人员_生活费1.Size = new System.Drawing.Size(619, 332);
            this.伤残人员_生活费1.TabIndex = 0;
            // 
            // 伤残人员
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 495);
            this.Controls.Add(this.ctrl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "伤残人员";
            this.Text = "伤残人员";
            this.ctrl.ResumeLayout(false);
            this.pag基本信息.ResumeLayout(false);
            this.pag生活来源.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private FrontFlag.Control.XTableCtrl ctrl;
        private System.Windows.Forms.TabPage pag基本信息;
        private System.Windows.Forms.TabPage pag生活来源;
        private UI.UC.优抚科.伤残人员.伤残人员_生活费 伤残人员_生活费1;
        private UI.UC.优抚科.伤残人员.伤残人员_基本信息 uc基本信息;

    }
}