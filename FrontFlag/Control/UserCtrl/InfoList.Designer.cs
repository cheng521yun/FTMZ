namespace FrontFlag.Control.UserCtrl
{
    partial class InfoList
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grd = new FrontFlag.Control.XDataGridView(this.components);
            this.bindSrc = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.grd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindSrc)).BeginInit();
            this.SuspendLayout();
            // 
            // grd
            // 
            this.grd.AllowAddRows = false;
            this.grd.AllowCheckBoxCol = false;
            this.grd.AllowDeleteRows = false;
            this.grd.AllowMultiSelect = false;
            this.grd.AllowUserToAddRows = false;
            this.grd.AllowUserToDeleteRows = false;
            this.grd.AllowUserToResizeColumns = false;
            this.grd.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.grd.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grd.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.grd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grd.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.grd.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.grd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grd.ColumnHeadersVisible = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(10, 2, 10, 2);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grd.DefaultCellStyle = dataGridViewCellStyle2;
            this.grd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grd.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.grd.EnableHeadersVisualStyles = false;
            this.grd.LineHight = 26;
            this.grd.Location = new System.Drawing.Point(0, 0);
            this.grd.MultiSelect = false;
            this.grd.Name = "grd";
            this.grd.ReadOnly = true;
            this.grd.RowHeadersVisible = false;
            this.grd.RowTemplate.Height = 26;
            this.grd.ShowRowHeader = false;
            this.grd.Size = new System.Drawing.Size(417, 337);
            this.grd.strIDCol = "";
            this.grd.TabIndex = 1;
            this.grd.SelectionChanged += new System.EventHandler(this.grd_SelectionChanged);
            // 
            // InfoList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grd);
            this.Name = "InfoList";
            this.Size = new System.Drawing.Size(417, 337);
            this.Load += new System.EventHandler(this.InfoList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindSrc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public XDataGridView grd;
        private System.Windows.Forms.BindingSource bindSrc;

    }
}
