namespace UI.UC.民管局.登记_民非
{
    partial class 联系信息
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
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.fl = new FrontFlag.Control.FindList2();
            this.labAdd = new System.Windows.Forms.Label();
            this.labDelete = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(114, 78);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(447, 21);
            this.textBox10.TabIndex = 39;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(48, 79);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 12);
            this.label10.TabIndex = 38;
            this.label10.Text = "机构网站：";
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(114, 47);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(100, 21);
            this.textBox8.TabIndex = 35;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(24, 49);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 12);
            this.label8.TabIndex = 34;
            this.label8.Text = "公开办公电话：";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(114, 12);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(447, 21);
            this.textBox4.TabIndex = 31;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(72, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 30;
            this.label4.Text = "住所：";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(114, 109);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 21);
            this.textBox6.TabIndex = 27;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 115);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 12);
            this.label6.TabIndex = 26;
            this.label6.Text = "机构固定联系人：";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBox4);
            this.panel1.Controls.Add(this.textBox10);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.textBox6);
            this.panel1.Controls.Add(this.textBox8);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(663, 145);
            this.panel1.TabIndex = 40;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.labDelete);
            this.panel2.Controls.Add(this.labAdd);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 353);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(663, 30);
            this.panel2.TabIndex = 41;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.fl);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 145);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(5);
            this.panel3.Size = new System.Drawing.Size(663, 208);
            this.panel3.TabIndex = 42;
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
            this.fl.Location = new System.Drawing.Point(5, 5);
            this.fl.Name = "fl";
            this.fl.pnlExternWidth = 40;
            this.fl.ShowButtonPnl = false;
            this.fl.ShowExcel = false;
            this.fl.ShowFind = false;
            this.fl.ShowMenuBar = false;
            this.fl.ShowNavi = false;
            this.fl.ShowPrint = false;
            this.fl.ShowRowHeader = false;
            this.fl.ShowSwitchFind = false;
            this.fl.ShowTitle = false;
            this.fl.Size = new System.Drawing.Size(653, 198);
            this.fl.TabIndex = 1;
            this.fl.Title = "       ";
            // 
            // labAdd
            // 
            this.labAdd.AutoSize = true;
            this.labAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labAdd.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labAdd.ForeColor = System.Drawing.Color.Green;
            this.labAdd.Location = new System.Drawing.Point(23, 10);
            this.labAdd.Name = "labAdd";
            this.labAdd.Size = new System.Drawing.Size(29, 12);
            this.labAdd.TabIndex = 0;
            this.labAdd.Text = "新加";
            // 
            // labDelete
            // 
            this.labDelete.AutoSize = true;
            this.labDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labDelete.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labDelete.ForeColor = System.Drawing.Color.Brown;
            this.labDelete.Location = new System.Drawing.Point(95, 10);
            this.labDelete.Name = "labDelete";
            this.labDelete.Size = new System.Drawing.Size(29, 12);
            this.labDelete.TabIndex = 1;
            this.labDelete.Text = "删除";
            // 
            // 联系信息
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(663, 383);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "联系信息";
            this.Text = "联系信息";
            this.Load += new System.EventHandler(this.联系信息_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label labDelete;
        private System.Windows.Forms.Label labAdd;
        private FrontFlag.Control.FindList2 fl;

    }
}