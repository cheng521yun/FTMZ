namespace FrontFlag.Control.PickerDate
{
    partial class XDatePicker
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn = new System.Windows.Forms.Button();
            this.txt = new System.Windows.Forms.TextBox();
            this.dat = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // btn
            // 
            this.btn.Location = new System.Drawing.Point(80, 20);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(20, 21);
            this.btn.TabIndex = 0;
            this.btn.Text = "X";
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Click += new System.EventHandler(this.OnBtnClick);
            // 
            // txt
            // 
            this.txt.BackColor = System.Drawing.Color.White;
            this.txt.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txt.Location = new System.Drawing.Point(0, 0);
            this.txt.Name = "txt";
            this.txt.ReadOnly = true;
            this.txt.Size = new System.Drawing.Size(100, 21);
            this.txt.TabIndex = 1;
            this.txt.Click += new System.EventHandler(this.OntxtClick);
            // 
            // dat
            // 
            this.dat.CustomFormat = "yyyy-MM-dd";
            this.dat.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dat.Location = new System.Drawing.Point(1, 20);
            this.dat.Name = "dat";
            this.dat.Size = new System.Drawing.Size(80, 21);
            this.dat.TabIndex = 2;
            this.dat.ValueChanged += new System.EventHandler(this.OnDatChange);
            // 
            // XDatePicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dat);
            this.Controls.Add(this.txt);
            this.Controls.Add(this.btn);
            this.Name = "XDatePicker";
            this.Size = new System.Drawing.Size(100, 20);
            this.Load += new System.EventHandler(this.OnLoad);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.TextBox txt;
        public System.Windows.Forms.DateTimePicker dat;
    }
}
