namespace 福田民政.Forms.Work.数据管理.民管局.登记备案_社团.Tab
{
    partial class ButnTool
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
            this.labAdd = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labAdd
            // 
            this.labAdd.AutoSize = true;
            this.labAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labAdd.Font = new System.Drawing.Font("宋体", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labAdd.ForeColor = System.Drawing.Color.ForestGreen;
            this.labAdd.Location = new System.Drawing.Point(13, 10);
            this.labAdd.Name = "labAdd";
            this.labAdd.Size = new System.Drawing.Size(31, 12);
            this.labAdd.TabIndex = 0;
            this.labAdd.Text = "登记";
            this.labAdd.Click += new System.EventHandler(this.labAdd_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Font = new System.Drawing.Font("宋体", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.DarkRed;
            this.label2.Location = new System.Drawing.Point(75, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "注销";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // ButnTool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 34);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labAdd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ButnTool";
            this.Text = "ButnTool";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labAdd;
        private System.Windows.Forms.Label label2;
    }
}