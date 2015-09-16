namespace 福田民政.Forms.Comm.人员
{
    partial class F查找人员
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
            this.fl = new FrontFlag.Control.FindList2();
            this.SuspendLayout();
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
            this.fl.Location = new System.Drawing.Point(0, 40);
            this.fl.Name = "fl";
            this.fl.pnlExternWidth = 40;
            this.fl.ShowButtonPnl = true;
            this.fl.ShowExcel = false;
            this.fl.ShowFind = true;
            this.fl.ShowMenuBar = false;
            this.fl.ShowNavi = true;
            this.fl.ShowPrint = false;
            this.fl.ShowRowHeader = false;
            this.fl.ShowSwitchFind = false;
            this.fl.ShowTitle = false;
            this.fl.Size = new System.Drawing.Size(647, 320);
            this.fl.TabIndex = 5;
            this.fl.Title = "       ";
            // 
            // F查找人员
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 400);
            this.Controls.Add(this.fl);
            this.Name = "F查找人员";
            this.Text = "查找人员";
            this.Controls.SetChildIndex(this.fl, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private FrontFlag.Control.FindList2 fl;
    }
}