﻿namespace 福田民政.Forms.Work.数据管理.民管局.台账统计
{
    partial class 人员管理
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
            this.fl.Location = new System.Drawing.Point(0, 0);
            this.fl.Name = "fl";
            this.fl.pnlExternWidth = 40;
            this.fl.ShowButtonPnl = false;
            this.fl.ShowExcel = false;
            this.fl.ShowFind = false;
            this.fl.ShowMenuBar = true;
            this.fl.ShowNavi = false;
            this.fl.ShowPrint = false;
            this.fl.ShowRowHeader = false;
            this.fl.ShowSwitchFind = false;
            this.fl.ShowTitle = true;
            this.fl.Size = new System.Drawing.Size(611, 220);
            this.fl.TabIndex = 0;
            this.fl.Title = "       ";
            // 
            // 人员管理统计
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 220);
            this.Controls.Add(this.fl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "人员管理统计";
            this.Text = "人员管理统计";
            this.Load += new System.EventHandler(this.人员管理统计_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private FrontFlag.Control.FindList2 fl;
    }
}