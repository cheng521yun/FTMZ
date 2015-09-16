using UI.Ctrl.Btn;

namespace UI.UC.民管局.登记_民非
{
    partial class Left
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
            this.btn机构章程 = new UI.Ctrl.Btn.LeftMenuBtn();
            this.btn财务状况 = new UI.Ctrl.Btn.LeftMenuBtn();
            this.btn组织管理架构 = new UI.Ctrl.Btn.LeftMenuBtn();
            this.btn联系信息 = new UI.Ctrl.Btn.LeftMenuBtn();
            this.btn法定代表人 = new UI.Ctrl.Btn.LeftMenuBtn();
            this.SuspendLayout();
            // 
            // btn机构章程
            // 
            this.btn机构章程.AutoSize = true;
            this.btn机构章程.btnCaption = "机构章程";
            this.btn机构章程.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn机构章程.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn机构章程.ForeColor = System.Drawing.Color.Maroon;
            this.btn机构章程.Location = new System.Drawing.Point(6, 167);
            this.btn机构章程.Name = "btn机构章程";
            this.btn机构章程.Size = new System.Drawing.Size(65, 21);
            this.btn机构章程.TabIndex = 9;
            // 
            // btn财务状况
            // 
            this.btn财务状况.AutoSize = true;
            this.btn财务状况.btnCaption = "财务状况";
            this.btn财务状况.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn财务状况.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn财务状况.ForeColor = System.Drawing.Color.Maroon;
            this.btn财务状况.Location = new System.Drawing.Point(6, 129);
            this.btn财务状况.Name = "btn财务状况";
            this.btn财务状况.Size = new System.Drawing.Size(65, 21);
            this.btn财务状况.TabIndex = 8;
            // 
            // btn组织管理架构
            // 
            this.btn组织管理架构.AutoSize = true;
            this.btn组织管理架构.btnCaption = "组织管理架构";
            this.btn组织管理架构.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn组织管理架构.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn组织管理架构.ForeColor = System.Drawing.Color.Maroon;
            this.btn组织管理架构.Location = new System.Drawing.Point(6, 91);
            this.btn组织管理架构.Name = "btn组织管理架构";
            this.btn组织管理架构.Size = new System.Drawing.Size(91, 21);
            this.btn组织管理架构.TabIndex = 7;
            // 
            // btn联系信息
            // 
            this.btn联系信息.AutoSize = true;
            this.btn联系信息.btnCaption = "联系信息";
            this.btn联系信息.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn联系信息.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn联系信息.ForeColor = System.Drawing.Color.Maroon;
            this.btn联系信息.Location = new System.Drawing.Point(6, 53);
            this.btn联系信息.Name = "btn联系信息";
            this.btn联系信息.Size = new System.Drawing.Size(65, 21);
            this.btn联系信息.TabIndex = 6;
            // 
            // btn法定代表人
            // 
            this.btn法定代表人.AutoSize = true;
            this.btn法定代表人.btnCaption = "法定代表人";
            this.btn法定代表人.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn法定代表人.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn法定代表人.ForeColor = System.Drawing.Color.Maroon;
            this.btn法定代表人.Location = new System.Drawing.Point(6, 15);
            this.btn法定代表人.Name = "btn法定代表人";
            this.btn法定代表人.Size = new System.Drawing.Size(78, 21);
            this.btn法定代表人.TabIndex = 5;
            // 
            // Left
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(193)))), ((int)(((byte)(150)))));
            this.ClientSize = new System.Drawing.Size(102, 360);
            this.Controls.Add(this.btn机构章程);
            this.Controls.Add(this.btn财务状况);
            this.Controls.Add(this.btn组织管理架构);
            this.Controls.Add(this.btn联系信息);
            this.Controls.Add(this.btn法定代表人);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Left";
            this.Text = "Left";
            this.Load += new System.EventHandler(this.Left_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LeftMenuBtn btn机构章程;
        private LeftMenuBtn btn财务状况;
        private LeftMenuBtn btn组织管理架构;
        private LeftMenuBtn btn联系信息;
        private LeftMenuBtn btn法定代表人;
    }
}