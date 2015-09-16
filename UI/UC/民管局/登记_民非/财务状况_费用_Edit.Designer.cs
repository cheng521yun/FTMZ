namespace UI.UC.民管局.登记_民非
{
    partial class 财务状况_费用_Edit
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
            this.label37 = new System.Windows.Forms.Label();
            this.label45 = new System.Windows.Forms.Label();
            this.label46 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label37.Location = new System.Drawing.Point(254, 14);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(59, 12);
            this.label37.TabIndex = 25;
            this.label37.Text = "管理费用:";
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label45.Location = new System.Drawing.Point(16, 14);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(83, 12);
            this.label45.TabIndex = 24;
            this.label45.Text = "业务活动成本:";
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label46.Location = new System.Drawing.Point(16, 31);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(59, 12);
            this.label46.TabIndex = 23;
            this.label46.Text = "其他费用:";
            // 
            // 财务状况_费用_Edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label37);
            this.Controls.Add(this.label45);
            this.Controls.Add(this.label46);
            this.Name = "财务状况_费用_Edit";
            this.Size = new System.Drawing.Size(356, 69);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.Label label46;
    }
}
