using UI.Ctrl.TextBox;

namespace UI.UC.事务科.低收入居民
{
    partial class 低收入居民_发放记录
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
            FrontFlag.FUN.POPEDOMBYTE popedombyte3 = new FrontFlag.FUN.POPEDOMBYTE();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt接收人 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt低保证号 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt发放类型 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dat审批时间 = new FrontFlag.Control.PickerDate.XDatePicker();
            this.dat待遇截止日期 = new FrontFlag.Control.PickerDate.XDatePicker();
            this.dat发放年月 = new FrontFlag.Control.PickerDate.XDatePicker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "审批时间：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "待遇截止日期：";
            // 
            // txt接收人
            // 
            this.txt接收人.Location = new System.Drawing.Point(144, 75);
            this.txt接收人.Name = "txt接收人";
            this.txt接收人.Size = new System.Drawing.Size(100, 21);
            this.txt接收人.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(86, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "接收人：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(74, 143);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 12;
            this.label6.Text = "发放年月：";
            // 
            // txt低保证号
            // 
            this.txt低保证号.Location = new System.Drawing.Point(144, 107);
            this.txt低保证号.Name = "txt低保证号";
            this.txt低保证号.Size = new System.Drawing.Size(100, 21);
            this.txt低保证号.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(74, 111);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 12);
            this.label7.TabIndex = 10;
            this.label7.Text = "低保证号：";
            // 
            // txt发放类型
            // 
            this.txt发放类型.Location = new System.Drawing.Point(144, 171);
            this.txt发放类型.Name = "txt发放类型";
            this.txt发放类型.Size = new System.Drawing.Size(100, 21);
            this.txt发放类型.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(74, 175);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 12);
            this.label9.TabIndex = 14;
            this.label9.Text = "发放类型：";
            // 
            // dat审批时间
            // 
            this.dat审批时间.bShowTime = false;
            this.dat审批时间.Location = new System.Drawing.Point(144, 13);
            this.dat审批时间.Name = "dat审批时间";
            popedombyte1.CanAll = false;
            popedombyte1.CanCreate = false;
            popedombyte1.CanDelete = false;
            popedombyte1.CanModify = false;
            popedombyte1.CanRead = false;
            popedombyte1.p = ((byte)(0));
            this.dat审批时间.PopedomByte = popedombyte1;
            this.dat审批时间.Size = new System.Drawing.Size(100, 20);
            this.dat审批时间.strDate = "";
            this.dat审批时间.TabIndex = 16;
            // 
            // dat待遇截止日期
            // 
            this.dat待遇截止日期.bShowTime = false;
            this.dat待遇截止日期.Location = new System.Drawing.Point(144, 45);
            this.dat待遇截止日期.Name = "dat待遇截止日期";
            popedombyte2.CanAll = false;
            popedombyte2.CanCreate = false;
            popedombyte2.CanDelete = false;
            popedombyte2.CanModify = false;
            popedombyte2.CanRead = false;
            popedombyte2.p = ((byte)(0));
            this.dat待遇截止日期.PopedomByte = popedombyte2;
            this.dat待遇截止日期.Size = new System.Drawing.Size(100, 20);
            this.dat待遇截止日期.strDate = "";
            this.dat待遇截止日期.TabIndex = 17;
            // 
            // dat发放年月
            // 
            this.dat发放年月.bShowTime = false;
            this.dat发放年月.Location = new System.Drawing.Point(144, 139);
            this.dat发放年月.Name = "dat发放年月";
            popedombyte3.CanAll = false;
            popedombyte3.CanCreate = false;
            popedombyte3.CanDelete = false;
            popedombyte3.CanModify = false;
            popedombyte3.CanRead = false;
            popedombyte3.p = ((byte)(0));
            this.dat发放年月.PopedomByte = popedombyte3;
            this.dat发放年月.Size = new System.Drawing.Size(100, 20);
            this.dat发放年月.strDate = "";
            this.dat发放年月.TabIndex = 18;
            // 
            // 低收入居民_发放记录
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.dat发放年月);
            this.Controls.Add(this.dat待遇截止日期);
            this.Controls.Add(this.dat审批时间);
            this.Controls.Add(this.txt发放类型);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt低保证号);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt接收人);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "低收入居民_发放记录";
            this.Size = new System.Drawing.Size(382, 214);
            this.Load += new System.EventHandler(this.低收入居民_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt接收人;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt低保证号;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt发放类型;
        private System.Windows.Forms.Label label9;
        private FrontFlag.Control.PickerDate.XDatePicker dat审批时间;
        private FrontFlag.Control.PickerDate.XDatePicker dat待遇截止日期;
        private FrontFlag.Control.PickerDate.XDatePicker dat发放年月;
    }
}
