namespace 福田民政.Forms.Work.数据管理.基层科.民主管理
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
            this.ucListTool = new UI.UC.Comm.ListTool();
            this.SuspendLayout();
            // 
            // ucListTool
            // 
            this.ucListTool.Dock = System.Windows.Forms.DockStyle.Right;
            this.ucListTool.Location = new System.Drawing.Point(327, 0);
            this.ucListTool.Name = "ucListTool";
            this.ucListTool.ShowDelete = false;
            this.ucListTool.Size = new System.Drawing.Size(300, 40);
            this.ucListTool.TabIndex = 0;
            // 
            // FFind
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 40);
            this.Controls.Add(this.ucListTool);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FFind";
            this.Text = "Find";
            this.ResumeLayout(false);

        }

        #endregion

        private UI.UC.Comm.ListTool ucListTool;

    }
}