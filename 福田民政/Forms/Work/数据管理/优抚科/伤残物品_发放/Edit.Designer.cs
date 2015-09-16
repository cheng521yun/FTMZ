namespace 福田民政.Forms.Work.数据管理.优抚科.伤残物品_发放
{
    partial class Edit
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
            this.伤残物品_发放_Edit1 = new UI.UC.优抚科.伤残物品_发放.伤残物品_发放_Edit();
            this.SuspendLayout();
            // 
            // 伤残物品_发放_Edit1
            // 
            this.伤残物品_发放_Edit1.Location = new System.Drawing.Point(0, 45);
            this.伤残物品_发放_Edit1.Name = "伤残物品_发放_Edit1";
            this.伤残物品_发放_Edit1.Size = new System.Drawing.Size(568, 213);
            this.伤残物品_发放_Edit1.TabIndex = 0;
            // 
            // Edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 299);
            this.Controls.Add(this.伤残物品_发放_Edit1);
            this.Name = "Edit";
            this.Text = "编辑";
            this.Load += new System.EventHandler(this.Edit_Load);
            this.Controls.SetChildIndex(this.伤残物品_发放_Edit1, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private UI.UC.优抚科.伤残物品_发放.伤残物品_发放_Edit 伤残物品_发放_Edit1;
    }
}