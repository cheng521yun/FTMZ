namespace UI.UC.民管局.登记_民非
{
    partial class 组织管理架构
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
            this.tabCtrl = new FrontFlag.Control.XTableCtrl();
            this.pag机构负责人 = new System.Windows.Forms.TabPage();
            this.pag从业人数 = new System.Windows.Forms.TabPage();
            this.fl02 = new FrontFlag.Control.FindList2();
            this.pag执业人数 = new System.Windows.Forms.TabPage();
            this.fl03 = new FrontFlag.Control.FindList2();
            this.pag党建工作情况 = new System.Windows.Forms.TabPage();
            this.fl04 = new FrontFlag.Control.FindList2();
            this.机构负责人1 = new UI.UC.民管局.登记_民非.机构负责人();
            this.tabCtrl.SuspendLayout();
            this.pag机构负责人.SuspendLayout();
            this.pag从业人数.SuspendLayout();
            this.pag执业人数.SuspendLayout();
            this.pag党建工作情况.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabCtrl
            // 
            this.tabCtrl.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabCtrl.Controls.Add(this.pag机构负责人);
            this.tabCtrl.Controls.Add(this.pag从业人数);
            this.tabCtrl.Controls.Add(this.pag执业人数);
            this.tabCtrl.Controls.Add(this.pag党建工作情况);
            this.tabCtrl.Cursor = System.Windows.Forms.Cursors.Default;
            this.tabCtrl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabCtrl.ItemSize = new System.Drawing.Size(100, 30);
            this.tabCtrl.Location = new System.Drawing.Point(0, 0);
            this.tabCtrl.Name = "tabCtrl";
            this.tabCtrl.SelectedIndex = 0;
            this.tabCtrl.Size = new System.Drawing.Size(558, 345);
            this.tabCtrl.TabIndex = 0;
            // 
            // pag机构负责人
            // 
            this.pag机构负责人.Controls.Add(this.机构负责人1);
            this.pag机构负责人.Location = new System.Drawing.Point(4, 34);
            this.pag机构负责人.Name = "pag机构负责人";
            this.pag机构负责人.Padding = new System.Windows.Forms.Padding(3);
            this.pag机构负责人.Size = new System.Drawing.Size(550, 307);
            this.pag机构负责人.TabIndex = 0;
            this.pag机构负责人.Text = "机构负责人";
            this.pag机构负责人.UseVisualStyleBackColor = true;
            // 
            // pag从业人数
            // 
            this.pag从业人数.Controls.Add(this.fl02);
            this.pag从业人数.Location = new System.Drawing.Point(4, 34);
            this.pag从业人数.Name = "pag从业人数";
            this.pag从业人数.Padding = new System.Windows.Forms.Padding(3);
            this.pag从业人数.Size = new System.Drawing.Size(550, 307);
            this.pag从业人数.TabIndex = 1;
            this.pag从业人数.Text = "从业人数";
            this.pag从业人数.UseVisualStyleBackColor = true;
            // 
            // fl02
            // 
            this.fl02.AllowAddRows = false;
            this.fl02.AllowCheckBoxCol = false;
            this.fl02.AllowDeleteRows = false;
            this.fl02.AllowMultiSelect = false;
            this.fl02.DataSource = null;
            this.fl02.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fl02.DownHeight = 100;
            this.fl02.FindHeight = 40;
            this.fl02.FootHeight = 26;
            this.fl02.Location = new System.Drawing.Point(3, 3);
            this.fl02.Name = "fl02";
            this.fl02.pnlExternWidth = 40;
            this.fl02.ShowButtonPnl = false;
            this.fl02.ShowExcel = false;
            this.fl02.ShowFind = false;
            this.fl02.ShowMenuBar = false;
            this.fl02.ShowNavi = false;
            this.fl02.ShowPrint = false;
            this.fl02.ShowRowHeader = false;
            this.fl02.ShowSwitchFind = false;
            this.fl02.ShowTitle = false;
            this.fl02.Size = new System.Drawing.Size(544, 301);
            this.fl02.TabIndex = 1;
            this.fl02.Title = "       ";
            // 
            // pag执业人数
            // 
            this.pag执业人数.Controls.Add(this.fl03);
            this.pag执业人数.Location = new System.Drawing.Point(4, 34);
            this.pag执业人数.Name = "pag执业人数";
            this.pag执业人数.Size = new System.Drawing.Size(550, 307);
            this.pag执业人数.TabIndex = 2;
            this.pag执业人数.Text = "执业人数";
            this.pag执业人数.UseVisualStyleBackColor = true;
            // 
            // fl03
            // 
            this.fl03.AllowAddRows = false;
            this.fl03.AllowCheckBoxCol = false;
            this.fl03.AllowDeleteRows = false;
            this.fl03.AllowMultiSelect = false;
            this.fl03.DataSource = null;
            this.fl03.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fl03.DownHeight = 100;
            this.fl03.FindHeight = 40;
            this.fl03.FootHeight = 26;
            this.fl03.Location = new System.Drawing.Point(0, 0);
            this.fl03.Name = "fl03";
            this.fl03.pnlExternWidth = 40;
            this.fl03.ShowButtonPnl = false;
            this.fl03.ShowExcel = false;
            this.fl03.ShowFind = false;
            this.fl03.ShowMenuBar = false;
            this.fl03.ShowNavi = false;
            this.fl03.ShowPrint = false;
            this.fl03.ShowRowHeader = false;
            this.fl03.ShowSwitchFind = false;
            this.fl03.ShowTitle = false;
            this.fl03.Size = new System.Drawing.Size(550, 307);
            this.fl03.TabIndex = 1;
            this.fl03.Title = "       ";
            // 
            // pag党建工作情况
            // 
            this.pag党建工作情况.Controls.Add(this.fl04);
            this.pag党建工作情况.Location = new System.Drawing.Point(4, 34);
            this.pag党建工作情况.Name = "pag党建工作情况";
            this.pag党建工作情况.Size = new System.Drawing.Size(550, 307);
            this.pag党建工作情况.TabIndex = 3;
            this.pag党建工作情况.Text = "党建工作情况";
            this.pag党建工作情况.UseVisualStyleBackColor = true;
            // 
            // fl04
            // 
            this.fl04.AllowAddRows = false;
            this.fl04.AllowCheckBoxCol = false;
            this.fl04.AllowDeleteRows = false;
            this.fl04.AllowMultiSelect = false;
            this.fl04.DataSource = null;
            this.fl04.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fl04.DownHeight = 100;
            this.fl04.FindHeight = 40;
            this.fl04.FootHeight = 26;
            this.fl04.Location = new System.Drawing.Point(0, 0);
            this.fl04.Name = "fl04";
            this.fl04.pnlExternWidth = 40;
            this.fl04.ShowButtonPnl = false;
            this.fl04.ShowExcel = false;
            this.fl04.ShowFind = false;
            this.fl04.ShowMenuBar = false;
            this.fl04.ShowNavi = false;
            this.fl04.ShowPrint = false;
            this.fl04.ShowRowHeader = false;
            this.fl04.ShowSwitchFind = false;
            this.fl04.ShowTitle = false;
            this.fl04.Size = new System.Drawing.Size(550, 307);
            this.fl04.TabIndex = 2;
            this.fl04.Title = "       ";
            // 
            // 机构负责人1
            // 
            this.机构负责人1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.机构负责人1.Location = new System.Drawing.Point(3, 3);
            this.机构负责人1.Name = "机构负责人1";
            this.机构负责人1.Size = new System.Drawing.Size(544, 301);
            this.机构负责人1.TabIndex = 0;
            // 
            // 组织管理架构
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(558, 345);
            this.Controls.Add(this.tabCtrl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "组织管理架构";
            this.Text = "组织管理架构";
            this.Load += new System.EventHandler(this.组织管理架构_Load);
            this.tabCtrl.ResumeLayout(false);
            this.pag机构负责人.ResumeLayout(false);
            this.pag从业人数.ResumeLayout(false);
            this.pag执业人数.ResumeLayout(false);
            this.pag党建工作情况.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private FrontFlag.Control.XTableCtrl tabCtrl;
        private System.Windows.Forms.TabPage pag机构负责人;
        private System.Windows.Forms.TabPage pag从业人数;
        private System.Windows.Forms.TabPage pag执业人数;
        private System.Windows.Forms.TabPage pag党建工作情况;
        private FrontFlag.Control.FindList2 fl02;
        private FrontFlag.Control.FindList2 fl03;
        private FrontFlag.Control.FindList2 fl04;
        private 机构负责人 机构负责人1;
    }
}