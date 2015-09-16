namespace 福田民政.Forms.Work.数据管理.优抚科.优抚对象_登记
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
            this.btnDelete = new UI.Ctrl.Btn.SmallIconBtn();
            this.btnSave = new UI.Ctrl.Btn.SmallIconBtn();
            this.btnExcelIn = new UI.Ctrl.Btn.SmallIconBtn();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Transparent;
            this.btnDelete.BtnImg = ((System.Drawing.Image)(resources.GetObject("btnDelete.BtnImg")));
            this.btnDelete.BtnTexT = "删除";
            this.btnDelete.CommandId = -1;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnDelete.Location = new System.Drawing.Point(117, 3);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(74, 25);
            this.btnDelete.TabIndex = 4;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSave.BtnImg = ((System.Drawing.Image)(resources.GetObject("btnSave.BtnImg")));
            this.btnSave.BtnTexT = "保存";
            this.btnSave.CommandId = -1;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnSave.Location = new System.Drawing.Point(21, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(74, 25);
            this.btnSave.TabIndex = 3;
            // 
            // btnExcelIn
            // 
            this.btnExcelIn.BackColor = System.Drawing.Color.Transparent;
            this.btnExcelIn.BtnImg = ((System.Drawing.Image)(resources.GetObject("btnExcelIn.BtnImg")));
            this.btnExcelIn.BtnTexT = "Excel导入";
            this.btnExcelIn.CommandId = -1;
            this.btnExcelIn.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnExcelIn.Location = new System.Drawing.Point(213, 3);
            this.btnExcelIn.Name = "btnExcelIn";
            this.btnExcelIn.Size = new System.Drawing.Size(90, 25);
            this.btnExcelIn.TabIndex = 5;
            //this.btnExcelIn.Load += new System.EventHandler(this.btnExcelIn_Load);
            // 
            // Tool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 30);
            this.Controls.Add(this.btnExcelIn);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Tool";
            this.Text = "Tool";
            this.Load += new System.EventHandler(this.Tool_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private UI.Ctrl.Btn.SmallIconBtn btnSave;
        private UI.Ctrl.Btn.SmallIconBtn btnDelete;
        private UI.Ctrl.Btn.SmallIconBtn btnExcelIn;

    }
}