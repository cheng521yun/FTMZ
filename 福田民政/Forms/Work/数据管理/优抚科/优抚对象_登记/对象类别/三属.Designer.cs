namespace 福田民政.Forms.Work.数据管理.优抚科.优抚对象_登记.对象类别
{
    partial class 三属
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
            this.伤残人员_基本信息1 = new UI.UC.优抚科.伤残人员.伤残人员_基本信息();
            this.pag类别信息 = new System.Windows.Forms.TabPage();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.pag生活来源 = new System.Windows.Forms.TabPage();
            this.伤残人员_生活费1 = new UI.UC.优抚科.伤残人员.伤残人员_生活费();
            this.ctrl.SuspendLayout();
            this.pag基本信息.SuspendLayout();
            this.pag类别信息.SuspendLayout();
            this.pag生活来源.SuspendLayout();
            this.SuspendLayout();
            // 
            // ctrl
            // 
            this.ctrl.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.ctrl.Controls.Add(this.pag基本信息);
            this.ctrl.Controls.Add(this.pag类别信息);
            this.ctrl.Controls.Add(this.pag生活来源);
            this.ctrl.Cursor = System.Windows.Forms.Cursors.Default;
            this.ctrl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctrl.ItemSize = new System.Drawing.Size(100, 30);
            this.ctrl.Location = new System.Drawing.Point(0, 0);
            this.ctrl.Name = "ctrl";
            this.ctrl.SelectedIndex = 0;
            this.ctrl.Size = new System.Drawing.Size(587, 496);
            this.ctrl.TabIndex = 1;
            this.ctrl.Visible = false;
            // 
            // pag基本信息
            // 
            this.pag基本信息.Controls.Add(this.伤残人员_基本信息1);
            this.pag基本信息.Location = new System.Drawing.Point(4, 34);
            this.pag基本信息.Name = "pag基本信息";
            this.pag基本信息.Padding = new System.Windows.Forms.Padding(3);
            this.pag基本信息.Size = new System.Drawing.Size(579, 458);
            this.pag基本信息.TabIndex = 0;
            this.pag基本信息.Text = "基本信息";
            this.pag基本信息.UseVisualStyleBackColor = true;
            // 
            // 伤残人员_基本信息1
            // 
            this.伤残人员_基本信息1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.伤残人员_基本信息1.Location = new System.Drawing.Point(3, 3);
            this.伤残人员_基本信息1.Name = "伤残人员_基本信息1";
            this.伤残人员_基本信息1.Size = new System.Drawing.Size(573, 452);
            this.伤残人员_基本信息1.TabIndex = 0;
            // 
            // pag类别信息
            // 
            this.pag类别信息.Controls.Add(this.checkBox1);
            this.pag类别信息.Location = new System.Drawing.Point(4, 34);
            this.pag类别信息.Name = "pag类别信息";
            this.pag类别信息.Padding = new System.Windows.Forms.Padding(3);
            this.pag类别信息.Size = new System.Drawing.Size(579, 474);
            this.pag类别信息.TabIndex = 1;
            this.pag类别信息.Text = "类别信息";
            this.pag类别信息.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(38, 25);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(72, 16);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "是否孤儿";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // pag生活来源
            // 
            this.pag生活来源.Controls.Add(this.伤残人员_生活费1);
            this.pag生活来源.Location = new System.Drawing.Point(4, 34);
            this.pag生活来源.Name = "pag生活来源";
            this.pag生活来源.Size = new System.Drawing.Size(579, 474);
            this.pag生活来源.TabIndex = 2;
            this.pag生活来源.Text = "生活来源";
            this.pag生活来源.UseVisualStyleBackColor = true;
            // 
            // 伤残人员_生活费1
            // 
            this.伤残人员_生活费1.Location = new System.Drawing.Point(23, 18);
            this.伤残人员_生活费1.Name = "伤残人员_生活费1";
            this.伤残人员_生活费1.Size = new System.Drawing.Size(258, 240);
            this.伤残人员_生活费1.TabIndex = 0;
            // 
            // 三属
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 496);
            this.Controls.Add(this.ctrl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "三属";
            this.Text = "伤残人员";
            this.ctrl.ResumeLayout(false);
            this.pag基本信息.ResumeLayout(false);
            this.pag类别信息.ResumeLayout(false);
            this.pag类别信息.PerformLayout();
            this.pag生活来源.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private FrontFlag.Control.XTableCtrl ctrl;
        private System.Windows.Forms.TabPage pag基本信息;
        private System.Windows.Forms.TabPage pag生活来源;
        private UI.UC.优抚科.伤残人员.伤残人员_生活费 伤残人员_生活费1;
        private UI.UC.优抚科.伤残人员.伤残人员_基本信息 伤残人员_基本信息1;
        private System.Windows.Forms.TabPage pag类别信息;
        private System.Windows.Forms.CheckBox checkBox1;

    }
}