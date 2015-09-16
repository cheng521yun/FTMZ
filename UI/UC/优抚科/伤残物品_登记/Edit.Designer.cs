using UI.DefCtrl.Cmb.老龄办;

namespace UI.UC.优抚科.伤残物品_登记
{
    partial class 伤残物品_登记_Edit
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
            this.txt姓名 = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.txt银行账号 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dat领取时间 = new FrontFlag.Control.PickerDate.XDatePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt姓名
            // 
            this.txt姓名.Location = new System.Drawing.Point(106, 21);
            this.txt姓名.Name = "txt姓名";
            this.txt姓名.Size = new System.Drawing.Size(120, 21);
            this.txt姓名.TabIndex = 148;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(49, 25);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(53, 12);
            this.label20.TabIndex = 147;
            this.label20.Text = "登记人：";
            // 
            // txt银行账号
            // 
            this.txt银行账号.Location = new System.Drawing.Point(106, 53);
            this.txt银行账号.Name = "txt银行账号";
            this.txt银行账号.Size = new System.Drawing.Size(120, 21);
            this.txt银行账号.TabIndex = 162;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 161;
            this.label3.Text = "物品名称：";
            // 
            // dat领取时间
            // 
            this.dat领取时间.bShowTime = false;
            this.dat领取时间.Location = new System.Drawing.Point(327, 21);
            this.dat领取时间.Name = "dat领取时间";
            popedombyte1.CanAll = false;
            popedombyte1.CanCreate = false;
            popedombyte1.CanDelete = false;
            popedombyte1.CanModify = false;
            popedombyte1.CanRead = false;
            popedombyte1.p = ((byte)(0));
            this.dat领取时间.PopedomByte = popedombyte1;
            this.dat领取时间.Size = new System.Drawing.Size(100, 20);
            this.dat领取时间.strDate = "";
            this.dat领取时间.TabIndex = 166;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(258, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 165;
            this.label4.Text = "登记日期：";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(106, 85);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(120, 21);
            this.textBox1.TabIndex = 168;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 167;
            this.label1.Text = "物品数量：";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(106, 117);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(120, 21);
            this.textBox2.TabIndex = 170;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 169;
            this.label2.Text = "使用期限：";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(106, 149);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(321, 40);
            this.textBox3.TabIndex = 172;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 171;
            this.label5.Text = "物品描述：";
            // 
            // 伤残物品_登记_Edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dat领取时间);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt银行账号);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt姓名);
            this.Controls.Add(this.label20);
            this.Name = "伤残物品_登记_Edit";
            this.Size = new System.Drawing.Size(475, 249);
            this.Load += new System.EventHandler(this.Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt姓名;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txt银行账号;
        private System.Windows.Forms.Label label3;
        private FrontFlag.Control.PickerDate.XDatePicker dat领取时间;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label5;
        //private DefCtrl.Cmb.Comm.Cmb所属街道 cmb所属街道;
    }
}
