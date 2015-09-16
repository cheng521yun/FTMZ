using UI.DefCtrl.Cmb.老龄办;

namespace UI.UC.老龄办
{
    partial class 发放老龄津贴
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
            this.label19 = new System.Windows.Forms.Label();
            this.txt姓名 = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.txt身份证号码 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt银行账号 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dat领取时间 = new FrontFlag.Control.PickerDate.XDatePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.cmb类别 = new UI.DefCtrl.Cmb.老龄办.Cmb发放津贴类别();
            this.uc街道办 = new UI.Ctrl.Cmb.街道办();
            this.SuspendLayout();
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(49, 101);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(41, 12);
            this.label19.TabIndex = 149;
            this.label19.Text = "类别：";
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
            this.label20.Location = new System.Drawing.Point(37, 14);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(53, 12);
            this.label20.TabIndex = 147;
            this.label20.Text = "接收人：";
            // 
            // txt身份证号码
            // 
            this.txt身份证号码.Location = new System.Drawing.Point(94, 70);
            this.txt身份证号码.Name = "txt身份证号码";
            this.txt身份证号码.Size = new System.Drawing.Size(120, 21);
            this.txt身份证号码.TabIndex = 145;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 12);
            this.label2.TabIndex = 144;
            this.label2.Text = "身份证号码：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 155;
            this.label5.Text = "所属街道：";
            // 
            // txt银行账号
            // 
            this.txt银行账号.Location = new System.Drawing.Point(94, 158);
            this.txt银行账号.Name = "txt银行账号";
            this.txt银行账号.Size = new System.Drawing.Size(120, 21);
            this.txt银行账号.TabIndex = 162;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 161;
            this.label3.Text = "银行账号：";
            // 
            // dat领取时间
            // 
            this.dat领取时间.bShowTime = false;
            this.dat领取时间.Location = new System.Drawing.Point(94, 129);
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
            this.label4.Location = new System.Drawing.Point(25, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 165;
            this.label4.Text = "领取时间：";
            // 
            // cmb类别
            // 
            this.cmb类别.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb类别.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmb类别.FormattingEnabled = true;
            this.cmb类别.Items.AddRange(new object[] {
            " ",
            "类别01",
            "类别02"});
            this.cmb类别.Location = new System.Drawing.Point(94, 100);
            this.cmb类别.Name = "cmb类别";
            this.cmb类别.Size = new System.Drawing.Size(120, 20);
            this.cmb类别.TabIndex = 152;
            // 
            // uc街道办
            // 
            this.uc街道办.Location = new System.Drawing.Point(94, 39);
            this.uc街道办.Name = "uc街道办";
            this.uc街道办.Size = new System.Drawing.Size(264, 22);
            this.uc街道办.str工作站 = "园东";
            this.uc街道办.str街道办 = "园岭街道办";
            this.uc街道办.TabIndex = 167;
            // 
            // 发放老龄津贴
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.uc街道办);
            this.Controls.Add(this.dat领取时间);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt银行账号);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmb类别);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.txt姓名);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.txt身份证号码);
            this.Controls.Add(this.label2);
            this.Name = "发放老龄津贴";
            this.Size = new System.Drawing.Size(463, 193);
            this.Load += new System.EventHandler(this.优待证_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Cmb发放津贴类别 cmb类别;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txt姓名;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txt身份证号码;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt银行账号;
        private System.Windows.Forms.Label label3;
        private FrontFlag.Control.PickerDate.XDatePicker dat领取时间;
        private System.Windows.Forms.Label label4;
        private Ctrl.Cmb.街道办 uc街道办;
        //private DefCtrl.Cmb.Comm.Cmb所属街道 cmb所属街道;
    }
}
