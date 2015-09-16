namespace 福田民政.Forms.Work.数据管理.老龄办.老龄津贴_统计
{
    partial class FFind
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
            this.btnFind = new UI.Ctrl.Btn.btnFind();
            this.label5 = new System.Windows.Forms.Label();
            this.dat统计月份 = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(177, 10);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(20, 20);
            this.btnFind.TabIndex = 315;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 12);
            this.label5.TabIndex = 313;
            this.label5.Text = "统计月份:";
            // 
            // dat统计月份
            // 
            this.dat统计月份.CustomFormat = "yyyy-MM";
            this.dat统计月份.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dat统计月份.Location = new System.Drawing.Point(86, 9);
            this.dat统计月份.Name = "dat统计月份";
            this.dat统计月份.Size = new System.Drawing.Size(81, 21);
            this.dat统计月份.TabIndex = 316;
            // 
            // FFind
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 40);
            this.Controls.Add(this.dat统计月份);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.label5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FFind";
            this.Text = "Find";
            this.Load += new System.EventHandler(this.FFind_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UI.Ctrl.Btn.btnFind btnFind;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dat统计月份;
    }
}