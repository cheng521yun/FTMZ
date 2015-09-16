namespace UI.Dlg
{
    partial class WarnDlg
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WarnDlg));
            this.pnlTitle = new System.Windows.Forms.Panel();
            this.labCaption = new System.Windows.Forms.Label();
            this.pnlButton = new System.Windows.Forms.Panel();
            this.btnCancel = new FrontFlag.Control.XButton();
            this.btnOK = new FrontFlag.Control.XButton();
            this.labNote = new System.Windows.Forms.Label();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlTitle.SuspendLayout();
            this.pnlButton.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTitle
            // 
            this.pnlTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(93)))), ((int)(((byte)(135)))));
            this.pnlTitle.Controls.Add(this.labCaption);
            this.pnlTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitle.Location = new System.Drawing.Point(0, 0);
            this.pnlTitle.Name = "pnlTitle";
            this.pnlTitle.Size = new System.Drawing.Size(384, 40);
            this.pnlTitle.TabIndex = 2;
            // 
            // labCaption
            // 
            this.labCaption.AutoSize = true;
            this.labCaption.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labCaption.ForeColor = System.Drawing.Color.White;
            this.labCaption.Location = new System.Drawing.Point(13, 13);
            this.labCaption.Name = "labCaption";
            this.labCaption.Size = new System.Drawing.Size(56, 16);
            this.labCaption.TabIndex = 0;
            this.labCaption.Text = "请确认";
            // 
            // pnlButton
            // 
            this.pnlButton.BackColor = System.Drawing.Color.Gainsboro;
            this.pnlButton.Controls.Add(this.btnCancel);
            this.pnlButton.Controls.Add(this.btnOK);
            this.pnlButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlButton.Location = new System.Drawing.Point(0, 174);
            this.pnlButton.Name = "pnlButton";
            this.pnlButton.Size = new System.Drawing.Size(384, 40);
            this.pnlButton.TabIndex = 3;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.FlatStyle = true;
            this.btnCancel.Location = new System.Drawing.Point(292, 9);
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
            popedombyte2.CanAll = false;
            popedombyte2.CanCreate = false;
            popedombyte2.CanDelete = false;
            popedombyte2.CanModify = false;
            popedombyte2.CanRead = false;
            popedombyte2.p = ((byte)(0));
            this.btnOK.PopedomByte = popedombyte2;
            this.btnOK.SelectTable = true;
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 0;
            this.btnOK.Text = "确定";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // labNote
            // 
            this.labNote.AutoSize = true;
            this.labNote.Location = new System.Drawing.Point(234, 122);
            this.labNote.Name = "labNote";
            this.labNote.Size = new System.Drawing.Size(161, 12);
            this.labNote.TabIndex = 6;
            this.labNote.Text = "                          ";
            // 
            // txtNote
            // 
            this.txtNote.BackColor = System.Drawing.Color.White;
            this.txtNote.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNote.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtNote.Location = new System.Drawing.Point(114, 82);
            this.txtNote.Multiline = true;
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(250, 50);
            this.txtNote.TabIndex = 7;
            this.txtNote.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(16, 67);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(80, 80);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // WarnDlg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(384, 214);
            this.Controls.Add(this.txtNote);
            this.Controls.Add(this.labNote);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pnlTitle);
            this.Controls.Add(this.pnlButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "WarnDlg";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.CommDlg_Load);
            this.Resize += new System.EventHandler(this.CommDlg_Resize);
            this.pnlTitle.ResumeLayout(false);
            this.pnlTitle.PerformLayout();
            this.pnlButton.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlTitle;
        private System.Windows.Forms.Label labCaption;
        private System.Windows.Forms.Panel pnlButton;
        private FrontFlag.Control.XButton btnCancel;
        private FrontFlag.Control.XButton btnOK;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labNote;
        private System.Windows.Forms.TextBox txtNote;
    }
}