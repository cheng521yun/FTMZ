using UI.Ctrl.TextBox;

namespace UI.UC.事务科.专项救助
{
    partial class 低保边缘户
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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt联系电话 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dat有效期 = new FrontFlag.Control.PickerDate.XDatePicker();
            this.txt所属街道 = new System.Windows.Forms.TextBox();
            this.txt姓名 = new System.Windows.Forms.TextBox();
            this.txt家庭成员 = new System.Windows.Forms.TextBox();
            this.txt备注 = new System.Windows.Forms.TextBox();
            this.cmb性别 = new UI.Ctrl.Cmb.性别();
            this.txt身份证 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt边缘证号 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "所属街道：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "姓名：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(221, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "性别：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 153);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 12;
            this.label6.Text = "家庭成员：";
            // 
            // txt联系电话
            // 
            this.txt联系电话.Location = new System.Drawing.Point(99, 116);
            this.txt联系电话.Name = "txt联系电话";
            this.txt联系电话.Size = new System.Drawing.Size(100, 21);
            this.txt联系电话.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(30, 120);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 12);
            this.label7.TabIndex = 10;
            this.label7.Text = "联系电话：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 219);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 19;
            this.label2.Text = "有效期：";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(54, 251);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 12);
            this.label8.TabIndex = 21;
            this.label8.Text = "备注：";
            // 
            // dat有效期
            // 
            this.dat有效期.bShowTime = false;
            this.dat有效期.Location = new System.Drawing.Point(99, 215);
            this.dat有效期.Name = "dat有效期";
            popedombyte1.CanAll = false;
            popedombyte1.CanCreate = false;
            popedombyte1.CanDelete = false;
            popedombyte1.CanModify = false;
            popedombyte1.CanRead = false;
            popedombyte1.p = ((byte)(0));
            this.dat有效期.PopedomByte = popedombyte1;
            this.dat有效期.Size = new System.Drawing.Size(100, 20);
            this.dat有效期.strDate = "";
            this.dat有效期.TabIndex = 22;
            // 
            // txt所属街道
            // 
            this.txt所属街道.Location = new System.Drawing.Point(100, 17);
            this.txt所属街道.Name = "txt所属街道";
            this.txt所属街道.Size = new System.Drawing.Size(100, 21);
            this.txt所属街道.TabIndex = 23;
            // 
            // txt姓名
            // 
            this.txt姓名.Location = new System.Drawing.Point(99, 50);
            this.txt姓名.Name = "txt姓名";
            this.txt姓名.Size = new System.Drawing.Size(100, 21);
            this.txt姓名.TabIndex = 24;
            // 
            // txt家庭成员
            // 
            this.txt家庭成员.Location = new System.Drawing.Point(99, 149);
            this.txt家庭成员.Name = "txt家庭成员";
            this.txt家庭成员.Size = new System.Drawing.Size(100, 21);
            this.txt家庭成员.TabIndex = 25;
            // 
            // txt备注
            // 
            this.txt备注.Location = new System.Drawing.Point(99, 247);
            this.txt备注.Name = "txt备注";
            this.txt备注.Size = new System.Drawing.Size(100, 21);
            this.txt备注.TabIndex = 26;
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
            " ",
            "男",
            "女",
            " ",
            "男",
            "女",
            "",
            "男",
            "女"});
            this.cmb性别.Location = new System.Drawing.Point(267, 50);
            this.cmb性别.Name = "cmb性别";
            this.cmb性别.Size = new System.Drawing.Size(80, 20);
            this.cmb性别.TabIndex = 27;
            this.cmb性别.Value = "False";
            // 
            // txt身份证
            // 
            this.txt身份证.Location = new System.Drawing.Point(99, 83);
            this.txt身份证.Name = "txt身份证";
            this.txt身份证.Size = new System.Drawing.Size(100, 21);
            this.txt身份证.TabIndex = 29;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(42, 87);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 12);
            this.label10.TabIndex = 28;
            this.label10.Text = "身份证：";
            // 
            // txt边缘证号
            // 
            this.txt边缘证号.Location = new System.Drawing.Point(99, 182);
            this.txt边缘证号.Name = "txt边缘证号";
            this.txt边缘证号.Size = new System.Drawing.Size(100, 21);
            this.txt边缘证号.TabIndex = 31;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 30;
            this.label5.Text = "边缘证号：";
            // 
            // 低保边缘户
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.txt边缘证号);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt身份证);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cmb性别);
            this.Controls.Add(this.txt备注);
            this.Controls.Add(this.txt家庭成员);
            this.Controls.Add(this.txt姓名);
            this.Controls.Add(this.txt所属街道);
            this.Controls.Add(this.dat有效期);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt联系电话);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "低保边缘户";
            this.Size = new System.Drawing.Size(404, 330);
            this.Load += new System.EventHandler(this.低保边缘户_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt联系电话;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private FrontFlag.Control.PickerDate.XDatePicker dat有效期;
        private System.Windows.Forms.TextBox txt所属街道;
        private System.Windows.Forms.TextBox txt姓名;
        private System.Windows.Forms.TextBox txt家庭成员;
        private System.Windows.Forms.TextBox txt备注;
        private Ctrl.Cmb.性别 cmb性别;
        private System.Windows.Forms.TextBox txt身份证;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt边缘证号;
        private System.Windows.Forms.Label label5;
    }
}
