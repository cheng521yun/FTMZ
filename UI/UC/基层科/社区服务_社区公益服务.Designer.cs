using System.Windows.Forms;

namespace UI.UC.基层科
{
    public partial class 社区服务_社区公益服务 : UserControl

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
            this.label5.Location = new System.Drawing.Point(62, 22);
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
            this.label2.Location = new System.Drawing.Point(26, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 12);
            this.label2.TabIndex = 180;
            this.label2.Text = "已开展服务项目：";
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
            this.label1.Location = new System.Drawing.Point(26, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 12);
            this.label1.TabIndex = 192;
            this.label1.Text = "已开展服务社区：";
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
            this.label3.Location = new System.Drawing.Point(26, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 12);
            this.label3.TabIndex = 194;
            this.label3.Text = "未开展服务社区：";
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
            this.label4.Location = new System.Drawing.Point(38, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 12);
            this.label4.TabIndex = 196;
            this.label4.Text = "参与服务人员：";
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
            this.label6.Location = new System.Drawing.Point(50, 157);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 12);
            this.label6.TabIndex = 198;
            this.label6.Text = "已发生费用：";
            // 
            // 社区服务_社区公益服务
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
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
            this.Name = "社区服务_社区公益服务";
            this.Size = new System.Drawing.Size(394, 223);
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
    }
}
