namespace UI.UC.民管局.登记_民非
{
    partial class 财务状况_资产
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labDelete = new System.Windows.Forms.Label();
            this.labAdd = new System.Windows.Forms.Label();
            this.fl = new FrontFlag.Control.FindList2();
            this.财务状况_资产_Edit1 = new UI.UC.民管局.登记_民非.财务状况_资产_Edit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.labDelete);
            this.panel3.Controls.Add(this.labAdd);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 304);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(547, 30);
            this.panel3.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.财务状况_资产_Edit1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 99);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(547, 205);
            this.panel2.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.fl);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(547, 99);
            this.panel1.TabIndex = 3;
            // 
            // labDelete
            // 
            this.labDelete.AutoSize = true;
            this.labDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labDelete.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labDelete.ForeColor = System.Drawing.Color.Brown;
            this.labDelete.Location = new System.Drawing.Point(93, 9);
            this.labDelete.Name = "labDelete";
            this.labDelete.Size = new System.Drawing.Size(29, 12);
            this.labDelete.TabIndex = 5;
            this.labDelete.Text = "删除";
            // 
            // labAdd
            // 
            this.labAdd.AutoSize = true;
            this.labAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labAdd.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labAdd.ForeColor = System.Drawing.Color.Green;
            this.labAdd.Location = new System.Drawing.Point(21, 9);
            this.labAdd.Name = "labAdd";
            this.labAdd.Size = new System.Drawing.Size(29, 12);
            this.labAdd.TabIndex = 4;
            this.labAdd.Text = "新加";
            // 
            // fl
            // 
            this.fl.AllowAddRows = false;
            this.fl.AllowCheckBoxCol = false;
            this.fl.AllowDeleteRows = false;
            this.fl.AllowMultiSelect = false;
            this.fl.DataSource = null;
            this.fl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fl.DownHeight = 100;
            this.fl.FindHeight = 40;
            this.fl.FootHeight = 26;
            this.fl.Location = new System.Drawing.Point(0, 0);
            this.fl.Name = "fl";
            this.fl.pnlExternWidth = 40;
            this.fl.ShowButtonPnl = false;
            this.fl.ShowExcel = false;
            this.fl.ShowFind = false;
            this.fl.ShowMenuBar = false;
            this.fl.ShowNavi = false;
            this.fl.ShowPrint = false;
            this.fl.ShowRowHeader = false;
            this.fl.ShowSwitchFind = false;
            this.fl.ShowTitle = false;
            this.fl.Size = new System.Drawing.Size(547, 99);
            this.fl.TabIndex = 3;
            this.fl.Title = "       ";
            // 
            // 财务状况_资产_Edit1
            // 
            this.财务状况_资产_Edit1.Location = new System.Drawing.Point(23, 6);
            this.财务状况_资产_Edit1.Name = "财务状况_资产_Edit1";
            this.财务状况_资产_Edit1.Size = new System.Drawing.Size(416, 202);
            this.财务状况_资产_Edit1.TabIndex = 0;
            // 
            // 财务状况_资产
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Name = "财务状况_资产";
            this.Size = new System.Drawing.Size(547, 334);
            this.Load += new System.EventHandler(this.财务状况_资产_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labDelete;
        private System.Windows.Forms.Label labAdd;
        private FrontFlag.Control.FindList2 fl;
        private 财务状况_资产_Edit 财务状况_资产_Edit1;

    }
}
