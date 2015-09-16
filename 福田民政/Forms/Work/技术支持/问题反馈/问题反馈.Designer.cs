namespace 福田民政.Forms.技术支持
{
    partial class 问题反馈
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
            FrontFlag.FUN.POPEDOMBYTE popedombyte1 = new FrontFlag.FUN.POPEDOMBYTE();
            FrontFlag.FUN.POPEDOMBYTE popedombyte2 = new FrontFlag.FUN.POPEDOMBYTE();
            this.pnlMid = new System.Windows.Forms.Panel();
            this.txtContent = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.btnCancel = new FrontFlag.Control.XButton();
            this.btnOK = new FrontFlag.Control.XButton();
            this.pnlMid.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMid
            // 
            this.pnlMid.Controls.Add(this.txtContent);
            this.pnlMid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMid.Location = new System.Drawing.Point(0, 54);
            this.pnlMid.Name = "pnlMid";
            this.pnlMid.Padding = new System.Windows.Forms.Padding(10);
            this.pnlMid.Size = new System.Drawing.Size(458, 188);
            this.pnlMid.TabIndex = 1;
            // 
            // txtContent
            // 
            this.txtContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtContent.Location = new System.Drawing.Point(10, 10);
            this.txtContent.Margin = new System.Windows.Forms.Padding(10);
            this.txtContent.Multiline = true;
            this.txtContent.Name = "txtContent";
            this.txtContent.Size = new System.Drawing.Size(438, 168);
            this.txtContent.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(458, 54);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label2.Location = new System.Drawing.Point(12, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(291, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "您的问题描述越详细，越对我们有帮助，谢谢！。";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(356, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "如果您在使用此软件时，遇到任何问题，请下方输入您问题。";
            // 
            // pnlBottom
            // 
            this.pnlBottom.Controls.Add(this.btnCancel);
            this.pnlBottom.Controls.Add(this.btnOK);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Location = new System.Drawing.Point(0, 242);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(458, 40);
            this.pnlBottom.TabIndex = 2;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.FlatStyle = true;
            this.btnCancel.Location = new System.Drawing.Point(263, 9);
            this.btnCancel.Name = "btnCancel";
            popedombyte1.CanAll = false;
            popedombyte1.CanCreate = false;
            popedombyte1.CanDelete = false;
            popedombyte1.CanModify = false;
            popedombyte1.CanRead = false;
            popedombyte1.p = ((byte)(0));
            this.btnCancel.PopedomByte = popedombyte1;
            this.btnCancel.SelectTable = true;
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "清空";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.FlatStyle = true;
            this.btnOK.Location = new System.Drawing.Point(87, 9);
            this.btnOK.Name = "btnOK";
            popedombyte2.CanAll = false;
            popedombyte2.CanCreate = false;
            popedombyte2.CanDelete = false;
            popedombyte2.CanModify = false;
            popedombyte2.CanRead = false;
            popedombyte2.p = ((byte)(0));
            this.btnOK.PopedomByte = popedombyte2;
            this.btnOK.SelectTable = true;
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 2;
            this.btnOK.Text = "提交";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // 问题反馈
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 282);
            this.Controls.Add(this.pnlMid);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlBottom);
            this.Name = "问题反馈";
            this.Text = "问题反馈";
            this.pnlMid.ResumeLayout(false);
            this.pnlMid.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlBottom.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlMid;
        private System.Windows.Forms.TextBox txtContent;
        private System.Windows.Forms.Panel pnlBottom;
        private FrontFlag.Control.XButton btnCancel;
        private FrontFlag.Control.XButton btnOK;

    }
}