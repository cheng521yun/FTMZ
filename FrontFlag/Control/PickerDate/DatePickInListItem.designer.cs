namespace FrontFlag.Control
{
    partial class DatePickInListItem
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose ( bool disposing )
        {
            if ( disposing && ( components != null ) )
            {
                components.Dispose ();
            }
            base.Dispose ( disposing );
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent ()
        {
            this.dat = new System.Windows.Forms.DateTimePicker ();
            this.btnClear = new System.Windows.Forms.Button ();
            this.SuspendLayout ();
            // 
            // dat
            // 
            this.dat.CustomFormat = "yyyy-MM-dd";
            this.dat.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dat.Location = new System.Drawing.Point ( 1, 0 );
            this.dat.Name = "dat";
            this.dat.Size = new System.Drawing.Size ( 82, 21 );
            this.dat.TabIndex = 1;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point ( 82, 0 );
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size ( 20, 21 );
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "X";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler ( this.btnClear_Click );
            // 
            // MyDatePick
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF ( 6F, 12F );
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add ( this.btnClear );
            this.Controls.Add ( this.dat );
            this.Margin = new System.Windows.Forms.Padding ( 0 );
            this.Name = "MyDatePick";
            this.Size = new System.Drawing.Size ( 102, 21 );
            this.ResumeLayout ( false );

        }

        #endregion

        public System.Windows.Forms.DateTimePicker dat;
        public System.Windows.Forms.Button btnClear;
    }
}
