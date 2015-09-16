namespace FrontFlag.Control.UserCtrl
{
    partial class SelectTwoList
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
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.lstAll = new System.Windows.Forms.ListView();
            this.col = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pnlLeftTitle = new System.Windows.Forms.Panel();
            this.pnlArraw = new System.Windows.Forms.Panel();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.pnlRigth = new System.Windows.Forms.Panel();
            this.lstSelect = new System.Windows.Forms.ListView();
            this.colSelect = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pnlBtn = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.labLeftTitle = new System.Windows.Forms.Label();
            this.pnlRightTitle = new System.Windows.Forms.Panel();
            this.labRightTitle = new System.Windows.Forms.Label();
            this.pnlLeft.SuspendLayout();
            this.pnlLeftTitle.SuspendLayout();
            this.pnlArraw.SuspendLayout();
            this.pnlRigth.SuspendLayout();
            this.pnlBtn.SuspendLayout();
            this.pnlRightTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlLeft
            // 
            this.pnlLeft.Controls.Add(this.lstAll);
            this.pnlLeft.Controls.Add(this.pnlLeftTitle);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.Location = new System.Drawing.Point(0, 0);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Padding = new System.Windows.Forms.Padding(10);
            this.pnlLeft.Size = new System.Drawing.Size(181, 344);
            this.pnlLeft.TabIndex = 0;
            // 
            // lstAll
            // 
            this.lstAll.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.col});
            this.lstAll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstAll.Location = new System.Drawing.Point(10, 40);
            this.lstAll.Name = "lstAll";
            this.lstAll.Size = new System.Drawing.Size(161, 294);
            this.lstAll.TabIndex = 1;
            this.lstAll.UseCompatibleStateImageBehavior = false;
            this.lstAll.View = System.Windows.Forms.View.Details;
            // 
            // col
            // 
            this.col.Text = "All";
            this.col.Width = 110;
            // 
            // pnlLeftTitle
            // 
            this.pnlLeftTitle.Controls.Add(this.labLeftTitle);
            this.pnlLeftTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLeftTitle.Location = new System.Drawing.Point(10, 10);
            this.pnlLeftTitle.Name = "pnlLeftTitle";
            this.pnlLeftTitle.Size = new System.Drawing.Size(161, 30);
            this.pnlLeftTitle.TabIndex = 2;
            // 
            // pnlArraw
            // 
            this.pnlArraw.Controls.Add(this.btnRemove);
            this.pnlArraw.Controls.Add(this.btnAdd);
            this.pnlArraw.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlArraw.Location = new System.Drawing.Point(181, 0);
            this.pnlArraw.Name = "pnlArraw";
            this.pnlArraw.Padding = new System.Windows.Forms.Padding(10);
            this.pnlArraw.Size = new System.Drawing.Size(60, 344);
            this.pnlArraw.TabIndex = 1;
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(10, 165);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(41, 23);
            this.btnRemove.TabIndex = 5;
            this.btnRemove.Text = "<";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(10, 106);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(41, 23);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = ">";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // pnlRigth
            // 
            this.pnlRigth.Controls.Add(this.lstSelect);
            this.pnlRigth.Controls.Add(this.pnlRightTitle);
            this.pnlRigth.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlRigth.Location = new System.Drawing.Point(241, 0);
            this.pnlRigth.Name = "pnlRigth";
            this.pnlRigth.Padding = new System.Windows.Forms.Padding(10);
            this.pnlRigth.Size = new System.Drawing.Size(183, 344);
            this.pnlRigth.TabIndex = 2;
            // 
            // lstSelect
            // 
            this.lstSelect.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colSelect});
            this.lstSelect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstSelect.Location = new System.Drawing.Point(10, 40);
            this.lstSelect.Name = "lstSelect";
            this.lstSelect.Size = new System.Drawing.Size(163, 294);
            this.lstSelect.TabIndex = 2;
            this.lstSelect.UseCompatibleStateImageBehavior = false;
            this.lstSelect.View = System.Windows.Forms.View.Details;
            // 
            // colSelect
            // 
            this.colSelect.Text = "Selected";
            this.colSelect.Width = 110;
            // 
            // pnlBtn
            // 
            this.pnlBtn.Controls.Add(this.btnCancel);
            this.pnlBtn.Controls.Add(this.btnOK);
            this.pnlBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBtn.Location = new System.Drawing.Point(424, 0);
            this.pnlBtn.Name = "pnlBtn";
            this.pnlBtn.Padding = new System.Windows.Forms.Padding(10);
            this.pnlBtn.Size = new System.Drawing.Size(103, 344);
            this.pnlBtn.TabIndex = 3;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(19, 87);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(64, 23);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(19, 40);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(64, 23);
            this.btnOK.TabIndex = 6;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // labLeftTitle
            // 
            this.labLeftTitle.AutoSize = true;
            this.labLeftTitle.Location = new System.Drawing.Point(4, 8);
            this.labLeftTitle.Name = "labLeftTitle";
            this.labLeftTitle.Size = new System.Drawing.Size(29, 12);
            this.labLeftTitle.TabIndex = 0;
            this.labLeftTitle.Text = "    ";
            // 
            // pnlRightTitle
            // 
            this.pnlRightTitle.Controls.Add(this.labRightTitle);
            this.pnlRightTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlRightTitle.Location = new System.Drawing.Point(10, 10);
            this.pnlRightTitle.Name = "pnlRightTitle";
            this.pnlRightTitle.Size = new System.Drawing.Size(163, 30);
            this.pnlRightTitle.TabIndex = 3;
            // 
            // labRightTitle
            // 
            this.labRightTitle.AutoSize = true;
            this.labRightTitle.Location = new System.Drawing.Point(4, 8);
            this.labRightTitle.Name = "labRightTitle";
            this.labRightTitle.Size = new System.Drawing.Size(41, 12);
            this.labRightTitle.TabIndex = 0;
            this.labRightTitle.Text = "      ";
            // 
            // SelectTwoList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlBtn);
            this.Controls.Add(this.pnlRigth);
            this.Controls.Add(this.pnlArraw);
            this.Controls.Add(this.pnlLeft);
            this.Name = "SelectTwoList";
            this.Size = new System.Drawing.Size(527, 344);
            this.Load += new System.EventHandler(this.SelectTwoList_Load);
            this.pnlLeft.ResumeLayout(false);
            this.pnlLeftTitle.ResumeLayout(false);
            this.pnlLeftTitle.PerformLayout();
            this.pnlArraw.ResumeLayout(false);
            this.pnlRigth.ResumeLayout(false);
            this.pnlBtn.ResumeLayout(false);
            this.pnlRightTitle.ResumeLayout(false);
            this.pnlRightTitle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.Panel pnlArraw;
        private System.Windows.Forms.Panel pnlRigth;
        private System.Windows.Forms.Panel pnlBtn;
        private System.Windows.Forms.ListView lstAll;
        private System.Windows.Forms.ColumnHeader col;
        private System.Windows.Forms.ListView lstSelect;
        private System.Windows.Forms.ColumnHeader colSelect;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Panel pnlLeftTitle;
        private System.Windows.Forms.Label labLeftTitle;
        private System.Windows.Forms.Panel pnlRightTitle;
        private System.Windows.Forms.Label labRightTitle;
    }
}
