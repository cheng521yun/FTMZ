using UI.Ctrl.TextBox;

namespace UI.UC.事务科.专项救助
{
    partial class 疾病救助
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose( bool disposing )
        {
            if ( disposing && ( components != null ) )
            {
                components.Dispose();
            }
            base.Dispose( disposing );
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            FrontFlag.FUN.POPEDOMBYTE popedombyte1 = new FrontFlag.FUN.POPEDOMBYTE();
            FrontFlag.FUN.POPEDOMBYTE popedombyte2 = new FrontFlag.FUN.POPEDOMBYTE();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt低保证号 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt发放类型 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dat发放年月 = new FrontFlag.Control.PickerDate.XDatePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dat审批时间 = new FrontFlag.Control.PickerDate.XDatePicker();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.cmb性别 = new UI.Ctrl.Cmb.性别();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "所属街道：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(99, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "姓名：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(99, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "性别：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(75, 148);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 12;
            this.label6.Text = "救助原因：";
            // 
            // txt低保证号
            // 
            this.txt低保证号.Location = new System.Drawing.Point(144, 112);
            this.txt低保证号.Name = "txt低保证号";
            this.txt低保证号.Size = new System.Drawing.Size(100, 21);
            this.txt低保证号.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(75, 116);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 12);
            this.label7.TabIndex = 10;
            this.label7.Text = "联系电话：";
            // 
            // txt发放类型
            // 
            this.txt发放类型.Location = new System.Drawing.Point(144, 175);
            this.txt发放类型.Name = "txt发放类型";
            this.txt发放类型.Size = new System.Drawing.Size(100, 21);
            this.txt发放类型.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(99, 179);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 12);
            this.label9.TabIndex = 14;
            this.label9.Text = "金额：";
            // 
            // dat发放年月
            // 
            this.dat发放年月.bShowTime = false;
            this.dat发放年月.Location = new System.Drawing.Point(144, 144);
            this.dat发放年月.Name = "dat发放年月";
            popedombyte1.CanAll = false;
            popedombyte1.CanCreate = false;
            popedombyte1.CanDelete = false;
            popedombyte1.CanModify = false;
            popedombyte1.CanRead = false;
            popedombyte1.p = ((byte)(0));
            this.dat发放年月.PopedomByte = popedombyte1;
            this.dat发放年月.Size = new System.Drawing.Size(100, 20);
            this.dat发放年月.strDate = "";
            this.dat发放年月.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(75, 211);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 19;
            this.label2.Text = "救助时间：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(99, 242);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 20;
            this.label5.Text = "类别：";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(99, 274);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 12);
            this.label8.TabIndex = 21;
            this.label8.Text = "备注：";
            // 
            // dat审批时间
            // 
            this.dat审批时间.bShowTime = false;
            this.dat审批时间.Location = new System.Drawing.Point(144, 207);
            this.dat审批时间.Name = "dat审批时间";
            popedombyte2.CanAll = false;
            popedombyte2.CanCreate = false;
            popedombyte2.CanDelete = false;
            popedombyte2.CanModify = false;
            popedombyte2.CanRead = false;
            popedombyte2.p = ((byte)(0));
            this.dat审批时间.PopedomByte = popedombyte2;
            this.dat审批时间.Size = new System.Drawing.Size(100, 20);
            this.dat审批时间.strDate = "";
            this.dat审批时间.TabIndex = 22;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(145, 17);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 21);
            this.textBox1.TabIndex = 23;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(144, 49);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 21);
            this.textBox2.TabIndex = 24;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(144, 238);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 21);
            this.textBox3.TabIndex = 25;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(144, 270);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 21);
            this.textBox4.TabIndex = 26;
            // 
            // cmb性别
            // 
            this.cmb性别.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb性别.DropDownWidth = 80;
            this.cmb性别.FormattingEnabled = true;
            this.cmb性别.Items.AddRange(new object[] {
            " ",
            "男",
            "女",
            " ",
            "男",
            "女",
            " ",
            "男",
            "女",
            " ",
            "男",
            "女",
            "",
            "男",
            "女"});
            this.cmb性别.Location = new System.Drawing.Point(145, 81);
            this.cmb性别.Name = "cmb性别";
            this.cmb性别.Size = new System.Drawing.Size(80, 20);
            this.cmb性别.TabIndex = 27;
            this.cmb性别.Value = "False";
            // 
            // 意外救助
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.cmb性别);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dat审批时间);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dat发放年月);
            this.Controls.Add(this.txt发放类型);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt低保证号);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "意外救助";
            this.Size = new System.Drawing.Size(369, 330);
            this.Load += new System.EventHandler(this.低收入居民_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt低保证号;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt发放类型;
        private System.Windows.Forms.Label label9;
        private FrontFlag.Control.PickerDate.XDatePicker dat发放年月;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private FrontFlag.Control.PickerDate.XDatePicker dat审批时间;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private Ctrl.Cmb.性别 cmb性别;
    }
}
