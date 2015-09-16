namespace UI.UC.Comm
{
    partial class ListTool
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose( bool disposing )
        {
            if ( disposing && ( components != null ) )
            {
                components.Dispose();
            }
            base.Dispose( disposing );
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListTool));
            this.btnExcelOut = new UI.Ctrl.Btn.SmallIconBtn();
            this.btnExcelIn = new UI.Ctrl.Btn.SmallIconBtn();
            this.btnDelete = new UI.Ctrl.Btn.SmallIconBtn();
            this.btnAdd = new UI.Ctrl.Btn.SmallIconBtn();
            this.SuspendLayout();
            // 
            // btnExcelOut
            // 
            this.btnExcelOut.BackColor = System.Drawing.Color.Transparent;
            this.btnExcelOut.BtnImg = ((System.Drawing.Image)(resources.GetObject("btnExcelOut.BtnImg")));
            this.btnExcelOut.BtnTexT = "导出";
            this.btnExcelOut.CommandId = -1;
            this.btnExcelOut.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnExcelOut.Location = new System.Drawing.Point(229, 9);
            this.btnExcelOut.Name = "btnExcelOut";
            this.btnExcelOut.Size = new System.Drawing.Size(66, 25);
            this.btnExcelOut.TabIndex = 8;
            // 
            // btnExcelIn
            // 
            this.btnExcelIn.BackColor = System.Drawing.Color.Transparent;
            this.btnExcelIn.BtnImg = ((System.Drawing.Image)(resources.GetObject("btnExcelIn.BtnImg")));
            this.btnExcelIn.BtnTexT = "导入";
            this.btnExcelIn.CommandId = -1;
            this.btnExcelIn.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnExcelIn.Location = new System.Drawing.Point(165, 9);
            this.btnExcelIn.Name = "btnExcelIn";
            this.btnExcelIn.Size = new System.Drawing.Size(56, 25);
            this.btnExcelIn.TabIndex = 7;
            //this.btnExcelIn.Load += new System.EventHandler(this.btnExcelIn_Load);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Transparent;
            this.btnDelete.BtnImg = ((System.Drawing.Image)(resources.GetObject("btnDelete.BtnImg")));
            this.btnDelete.BtnTexT = "删除";
            this.btnDelete.CommandId = -1;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnDelete.Location = new System.Drawing.Point(78, 9);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(67, 25);
            this.btnDelete.TabIndex = 6;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnAdd.BtnImg = ((System.Drawing.Image)(resources.GetObject("btnAdd.BtnImg")));
            this.btnAdd.BtnTexT = "新加";
            this.btnAdd.CommandId = -1;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnAdd.Location = new System.Drawing.Point(5, 9);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(72, 25);
            this.btnAdd.TabIndex = 5;
            //this.btnAdd.Load += new System.EventHandler(this.btnAdd_Load);
            // 
            // ListTool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnExcelOut);
            this.Controls.Add(this.btnExcelIn);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Name = "ListTool";
            this.Size = new System.Drawing.Size(300, 40);
            this.Load += new System.EventHandler(this.ListTool_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Ctrl.Btn.SmallIconBtn btnDelete;
        private Ctrl.Btn.SmallIconBtn btnAdd;
        private Ctrl.Btn.SmallIconBtn btnExcelIn;
        private Ctrl.Btn.SmallIconBtn btnExcelOut;
    }
}
