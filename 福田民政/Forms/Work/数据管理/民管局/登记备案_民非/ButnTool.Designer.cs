namespace 福田民政.Forms.Work.数据管理.民管局.登记备案.Tab
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
            this.labDelete = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labAdd
            // 
            this.labAdd.AutoSize = true;
            this.labAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labAdd.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labAdd.ForeColor = System.Drawing.Color.ForestGreen;
            this.labAdd.Location = new System.Drawing.Point(13, 10);
            this.labAdd.Name = "labAdd";
            this.labAdd.Size = new System.Drawing.Size(29, 12);
            this.labAdd.TabIndex = 0;
            this.labAdd.Text = "添加";
            this.labAdd.Click += new System.EventHandler(this.labAdd_Click);
            // 
            // labDelete
            // 
            this.labDelete.AutoSize = true;
            this.labDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labDelete.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labDelete.ForeColor = System.Drawing.Color.DarkRed;
            this.labDelete.Location = new System.Drawing.Point(75, 10);
            this.labDelete.Name = "labDelete";
            this.labDelete.Size = new System.Drawing.Size(29, 12);
            this.labDelete.TabIndex = 1;
            this.labDelete.Text = "删除";
            this.labDelete.Click += new System.EventHandler(this.label2_Click);
            // 
            // ButnTool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 34);
            this.Controls.Add(this.labDelete);
            this.Controls.Add(this.labAdd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ButnTool";
            this.Text = "ButnTool";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labAdd;
        private System.Windows.Forms.Label labDelete;
    }
}