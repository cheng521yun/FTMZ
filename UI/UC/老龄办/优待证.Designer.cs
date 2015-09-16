using UI.Ctrl.Cmb;
using UI.DefCtrl.Cmb;
using UI.DefCtrl.Cmb.老龄办;

namespace UI.UC.老龄办
{
    partial class 优待证
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
            this.cmb性别 = new Cmb性别();
            this.cmb优待证类别 = new UI.DefCtrl.Cmb.老龄办.Cmb优待证类别();
            this.dat出生日期 = new FrontFlag.Control.PickerDate.XDatePicker();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.txt姓名 = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt身份证号码 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt单位或住址 = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.txt联系电话 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt证件编号 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt照片回执号 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.uc街道办 = new 街道办();
            this.SuspendLayout();
            // 
            // cmb性别
            // 
            this.cmb性别.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb性别.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmb性别.FormattingEnabled = true;
            this.cmb性别.Location = new System.Drawing.Point(354, 10);
            this.cmb性别.Name = "cmb性别";
            this.cmb性别.Size = new System.Drawing.Size(100, 20);
            this.cmb性别.TabIndex = 153;
            // 
            // cmb优待证类别
            // 
            this.cmb优待证类别.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb优待证类别.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmb优待证类别.FormattingEnabled = true;
            this.cmb优待证类别.Location = new System.Drawing.Point(94, 165);
            this.cmb优待证类别.Name = "cmb优待证类别";
            this.cmb优待证类别.Size = new System.Drawing.Size(120, 20);
            this.cmb优待证类别.TabIndex = 152;
            // 
            // dat出生日期
            // 
            this.dat出生日期.bShowTime = false;
            this.dat出生日期.Location = new System.Drawing.Point(354, 39);
            this.dat出生日期.Name = "dat出生日期";
            popedombyte1.CanAll = false;
            popedombyte1.CanCreate = false;
            popedombyte1.CanDelete = false;
            popedombyte1.CanModify = false;
            popedombyte1.CanRead = false;
            popedombyte1.p = ((byte)(0));
            this.dat出生日期.PopedomByte = popedombyte1;
            this.dat出生日期.Size = new System.Drawing.Size(100, 20);
            this.dat出生日期.strDate = "";
            this.dat出生日期.TabIndex = 151;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(310, 14);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(41, 12);
            this.label18.TabIndex = 150;
            this.label18.Text = "性别：";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(14, 169);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(77, 12);
            this.label19.TabIndex = 149;
            this.label19.Text = "优待证类别：";
            // 
            // txt姓名
            // 
            this.txt姓名.Location = new System.Drawing.Point(94, 10);
            this.txt姓名.Name = "txt姓名";
            this.txt姓名.Size = new System.Drawing.Size(120, 21);
            this.txt姓名.TabIndex = 148;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(50, 14);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(41, 12);
            this.label20.TabIndex = 147;
            this.label20.Text = "姓名：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(285, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 146;
            this.label4.Text = "出生日期：";
            // 
            // txt身份证号码
            // 
            this.txt身份证号码.Location = new System.Drawing.Point(94, 39);
            this.txt身份证号码.Name = "txt身份证号码";
            this.txt身份证号码.Size = new System.Drawing.Size(120, 21);
            this.txt身份证号码.TabIndex = 145;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 12);
            this.label2.TabIndex = 144;
            this.label2.Text = "身份证号码：";
            // 
            // txt单位或住址
            // 
            this.txt单位或住址.Location = new System.Drawing.Point(94, 126);
            this.txt单位或住址.Name = "txt单位或住址";
            this.txt单位或住址.Size = new System.Drawing.Size(360, 21);
            this.txt单位或住址.TabIndex = 160;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(14, 130);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(77, 12);
            this.label21.TabIndex = 159;
            this.label21.Text = "单位或住址：";
            // 
            // txt联系电话
            // 
            this.txt联系电话.Location = new System.Drawing.Point(94, 68);
            this.txt联系电话.Name = "txt联系电话";
            this.txt联系电话.Size = new System.Drawing.Size(120, 21);
            this.txt联系电话.TabIndex = 158;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(26, 72);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 12);
            this.label12.TabIndex = 157;
            this.label12.Text = "联系电话：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 155;
            this.label5.Text = "所属街道：";
            // 
            // txt证件编号
            // 
            this.txt证件编号.Location = new System.Drawing.Point(94, 195);
            this.txt证件编号.Name = "txt证件编号";
            this.txt证件编号.Size = new System.Drawing.Size(120, 21);
            this.txt证件编号.TabIndex = 162;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 161;
            this.label3.Text = "证件编号：";
            // 
            // txt照片回执号
            // 
            this.txt照片回执号.Location = new System.Drawing.Point(94, 224);
            this.txt照片回执号.Name = "txt照片回执号";
            this.txt照片回执号.Size = new System.Drawing.Size(120, 21);
            this.txt照片回执号.TabIndex = 164;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 228);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 12);
            this.label6.TabIndex = 163;
            this.label6.Text = "照片回执号：";
            // 
            // uc街道办
            // 
            this.uc街道办.Location = new System.Drawing.Point(94, 96);
            this.uc街道办.Name = "uc街道办";
            this.uc街道办.Size = new System.Drawing.Size(264, 22);
            this.uc街道办.str工作站 = "园东";
            this.uc街道办.str街道办 = "园岭街道办";
            this.uc街道办.TabIndex = 165;
            // 
            // 优待证
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.uc街道办);
            this.Controls.Add(this.txt照片回执号);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt证件编号);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt单位或住址);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.txt联系电话);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmb性别);
            this.Controls.Add(this.cmb优待证类别);
            this.Controls.Add(this.dat出生日期);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.txt姓名);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt身份证号码);
            this.Controls.Add(this.label2);
            this.Name = "优待证";
            this.Size = new System.Drawing.Size(469, 257);
            this.Load += new System.EventHandler(this.优待证_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Cmb性别 cmb性别;
        private Cmb优待证类别 cmb优待证类别;
        private FrontFlag.Control.PickerDate.XDatePicker dat出生日期;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txt姓名;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt身份证号码;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt单位或住址;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox txt联系电话;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt证件编号;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt照片回执号;
        private System.Windows.Forms.Label label6;
        private 街道办 uc街道办;
        //private DefCtrl.Cmb.Comm.Cmb所属街道 cmb所属街道;
    }
}
