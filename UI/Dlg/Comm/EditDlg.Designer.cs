namespace UI.Dlg
{
    partial class EditDlg
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
            FrontFlag.FUN.POPEDOMBYTE popedombyte3 = new FrontFlag.FUN.POPEDOMBYTE();
            this.pnlTitle = new System.Windows.Forms.Panel();
            this.labCaption = new System.Windows.Forms.Label();
            this.pnlButton = new System.Windows.Forms.Panel();
            this.btnDelete = new FrontFlag.Control.XButton();
            this.btnCancel = new FrontFlag.Control.XButton();
            this.btnOK = new FrontFlag.Control.XButton();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.pnlTitle.SuspendLayout();
            this.pnlButton.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTitle
            // 
            this.pnlTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(93)))), ((int)(((byte)(135)))));
            this.pnlTitle.Controls.Add(this.labCaption);
            this.pnlTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitle.Location = new System.Drawing.Point(0, 0);
            this.pnlTitle.Name = "pnlTitle";
            this.pnlTitle.Size = new System.Drawing.Size(504, 40);
            this.pnlTitle.TabIndex = 2;
            // 
            // labCaption
            // 
            this.labCaption.AutoSize = true;
            this.labCaption.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labCaption.ForeColor = System.Drawing.Color.White;
            this.labCaption.Location = new System.Drawing.Point(13, 13);
            this.labCaption.Name = "labCaption";
            this.labCaption.Size = new System.Drawing.Size(72, 16);
            this.labCaption.TabIndex = 0;
            this.labCaption.Text = "        ";
            // 
            // pnlButton
            // 
            this.pnlButton.BackColor = System.Drawing.Color.Gainsboro;
            this.pnlButton.Controls.Add(this.btnDelete);
            this.pnlButton.Controls.Add(this.btnCancel);
            this.pnlButton.Controls.Add(this.btnOK);
            this.pnlButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlButton.Location = new System.Drawing.Point(0, 274);
            this.pnlButton.Name = "pnlButton";
            this.pnlButton.Size = new System.Drawing.Size(504, 40);
            this.pnlButton.TabIndex = 3;
            // 
            // btnDelete
            // 
            this.btnDelete.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnDelete.FlatStyle = true;
            this.btnDelete.Location = new System.Drawing.Point(207, 9);
            this.btnDelete.Name = "btnDelete";
            popedombyte1.CanAll = false;
            popedombyte1.CanCreate = false;
            popedombyte1.CanDelete = false;
            popedombyte1.CanModify = false;
            popedombyte1.CanRead = false;
            popedombyte1.p = ((byte)(0));
            this.btnDelete.PopedomByte = popedombyte1;
            this.btnDelete.SelectTable = true;
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "删除";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.FlatStyle = true;
            this.btnCancel.Location = new System.Drawing.Point(292, 9);
            this.btnCancel.Name = "btnCancel";
            popedombyte2.CanAll = false;
            popedombyte2.CanCreate = false;
            popedombyte2.CanDelete = false;
            popedombyte2.CanModify = false;
            popedombyte2.CanRead = false;
            popedombyte2.p = ((byte)(0));
            this.btnCancel.PopedomByte = popedombyte2;
            this.btnCancel.SelectTable = true;
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "放弃";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.FlatStyle = true;
            this.btnOK.Location = new System.Drawing.Point(116, 9);
            this.btnOK.Name = "btnOK";
            popedombyte3.CanAll = false;
            popedombyte3.CanCreate = false;
            popedombyte3.CanDelete = false;
            popedombyte3.CanModify = false;
            popedombyte3.CanRead = false;
            popedombyte3.p = ((byte)(0));
            this.btnOK.PopedomByte = popedombyte3;
            this.btnOK.SelectTable = true;
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 0;
            this.btnOK.Text = "保存";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // pnlContent
            // 
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(0, 40);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(504, 234);
            this.pnlContent.TabIndex = 4;
            // 
            // EditDlg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(504, 314);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.pnlTitle);
            this.Controls.Add(this.pnlButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "EditDlg";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.CommDlg_Load);
            this.Resize += new System.EventHandler(this.CommDlg_Resize);
            this.pnlTitle.ResumeLayout(false);
            this.pnlTitle.PerformLayout();
            this.pnlButton.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTitle;
        private System.Windows.Forms.Label labCaption;
        private System.Windows.Forms.Panel pnlButton;
        private FrontFlag.Control.XButton btnCancel;
        private FrontFlag.Control.XButton btnOK;
        private FrontFlag.Control.XButton btnDelete;
        private System.Windows.Forms.Panel pnlContent;
    }
}