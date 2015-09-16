using System.Windows.Forms;

namespace UI.UC.基层科
{
    public partial class 社区服务 : UserControl

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
            this.uc街道办 = new UI.Ctrl.Cmb.街道办();
            this.label5 = new System.Windows.Forms.Label();
            this.txt身份证号码 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // uc街道办
            // 
            this.uc街道办.Location = new System.Drawing.Point(132, 17);
            this.uc街道办.Name = "uc街道办";
            this.uc街道办.Size = new System.Drawing.Size(264, 22);
            this.uc街道办.str工作站 = "园东";
            this.uc街道办.str街道办 = "园岭街道办";
            this.uc街道办.TabIndex = 191;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(61, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 186;
            this.label5.Text = "所属街道：";
            // 
            // txt身份证号码
            // 
            this.txt身份证号码.Location = new System.Drawing.Point(132, 45);
            this.txt身份证号码.Name = "txt身份证号码";
            this.txt身份证号码.Size = new System.Drawing.Size(221, 21);
            this.txt身份证号码.TabIndex = 181;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 12);
            this.label2.TabIndex = 180;
            this.label2.Text = "社区服务中心：";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(132, 72);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(221, 21);
            this.textBox1.TabIndex = 193;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 192;
            this.label1.Text = "管理人员：";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(132, 99);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(221, 21);
            this.textBox2.TabIndex = 195;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 194;
            this.label3.Text = "专业社工：";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(132, 126);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(221, 21);
            this.textBox3.TabIndex = 197;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(61, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 196;
            this.label4.Text = "辅助人员：";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(132, 153);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(221, 21);
            this.textBox4.TabIndex = 199;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(85, 157);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 198;
            this.label6.Text = "个案：";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(132, 180);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(221, 21);
            this.textBox5.TabIndex = 201;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(85, 184);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 12);
            this.label7.TabIndex = 200;
            this.label7.Text = "结案：";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(132, 207);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(221, 21);
            this.textBox6.TabIndex = 203;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(85, 211);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 12);
            this.label8.TabIndex = 202;
            this.label8.Text = "建档：";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(132, 288);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(221, 21);
            this.textBox7.TabIndex = 209;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(85, 292);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 12);
            this.label9.TabIndex = 208;
            this.label9.Text = "家访：";
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(132, 261);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(221, 21);
            this.textBox8.TabIndex = 207;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(61, 265);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 12);
            this.label10.TabIndex = 206;
            this.label10.Text = "社区活动：";
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(132, 234);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(221, 21);
            this.textBox9.TabIndex = 205;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(61, 238);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 12);
            this.label11.TabIndex = 204;
            this.label11.Text = "小组活动：";
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(132, 369);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(221, 21);
            this.textBox10.TabIndex = 215;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(61, 373);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 12);
            this.label12.TabIndex = 214;
            this.label12.Text = "服务机构：";
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(132, 342);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(221, 21);
            this.textBox11.TabIndex = 213;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(85, 346);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(41, 12);
            this.label13.TabIndex = 212;
            this.label13.Text = "咨询：";
            // 
            // textBox12
            // 
            this.textBox12.Location = new System.Drawing.Point(132, 315);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(221, 21);
            this.textBox12.TabIndex = 211;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(61, 319);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(65, 12);
            this.label14.TabIndex = 210;
            this.label14.Text = "即时辅导：";
            // 
            // 社区服务
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBox10);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.textBox11);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.textBox12);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.uc街道办);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt身份证号码);
            this.Controls.Add(this.label2);
            this.Name = "社区服务";
            this.Size = new System.Drawing.Size(416, 410);
            this.Load += new System.EventHandler(this.民主管理_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Ctrl.Cmb.街道办 uc街道办;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt身份证号码;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label7;
        private TextBox textBox6;
        private Label label8;
        private TextBox textBox7;
        private Label label9;
        private TextBox textBox8;
        private Label label10;
        private TextBox textBox9;
        private Label label11;
        private TextBox textBox10;
        private Label label12;
        private TextBox textBox11;
        private Label label13;
        private TextBox textBox12;
        private Label label14;
    }
}
