using UI.DefCtrl.Cmb.老龄办;

namespace UI.UC.老龄办
{
    partial class 停发老龄津贴
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
            this.txt身份证号码 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dat领取时间 = new FrontFlag.Control.PickerDate.XDatePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt原因 = new System.Windows.Forms.TextBox();
            this.btnFind = new UI.Ctrl.Btn.btnFind();
            this.uc街道办 = new UI.Ctrl.Cmb.街道办();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
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
            this.txt身份证号码.Location = new System.Drawing.Point(94, 65);
            this.txt身份证号码.Name = "txt身份证号码";
            this.txt身份证号码.Size = new System.Drawing.Size(120, 21);
            this.txt身份证号码.TabIndex = 145;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 12);
            this.label2.TabIndex = 144;
            this.label2.Text = "身份证号码：";
            // 
            // dat领取时间
            // 
            this.dat领取时间.bShowTime = false;
            this.dat领取时间.Location = new System.Drawing.Point(94, 94);
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
            this.label4.Location = new System.Drawing.Point(25, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 165;
            this.label4.Text = "停发时间：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 167;
            this.label1.Text = "停发原因：";
            // 
            // txt原因
            // 
            this.txt原因.Location = new System.Drawing.Point(94, 122);
            this.txt原因.Name = "txt原因";
            this.txt原因.Size = new System.Drawing.Size(300, 21);
            this.txt原因.TabIndex = 168;
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(228, 11);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(20, 20);
            this.btnFind.TabIndex = 169;
            // 
            // uc街道办
            // 
            this.uc街道办.Location = new System.Drawing.Point(94, 37);
            this.uc街道办.Name = "uc街道办";
            this.uc街道办.Size = new System.Drawing.Size(264, 22);
            this.uc街道办.str工作站 = "园东";
            this.uc街道办.str街道办 = "园岭街道办";
            this.uc街道办.TabIndex = 171;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 170;
            this.label5.Text = "所属街道：";
            // 
            // 停发老龄津贴
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.uc街道办);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.txt原因);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dat领取时间);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt姓名);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.txt身份证号码);
            this.Controls.Add(this.label2);
            this.Name = "停发老龄津贴";
            this.Size = new System.Drawing.Size(401, 153);
            this.Load += new System.EventHandler(this.优待证_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt姓名;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txt身份证号码;
        private System.Windows.Forms.Label label2;
        private FrontFlag.Control.PickerDate.XDatePicker dat领取时间;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt原因;
        private Ctrl.Btn.btnFind btnFind;
        private Ctrl.Cmb.街道办 uc街道办;
        private System.Windows.Forms.Label label5;
    }
}
