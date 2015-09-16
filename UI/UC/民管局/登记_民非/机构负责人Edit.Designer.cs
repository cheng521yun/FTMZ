using UI.DefCtrl.Cmb;

namespace UI.UC.民管局.登记_民非
{
    partial class 机构负责人Edit
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
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.xDatePicker1 = new FrontFlag.Control.PickerDate.XDatePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.cmb性别1 = new Cmb性别();
            this.SuspendLayout();
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(82, 113);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(100, 21);
            this.textBox9.TabIndex = 49;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 119);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 12);
            this.label9.TabIndex = 48;
            this.label9.Text = "联系电话：";
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(261, 78);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(100, 21);
            this.textBox8.TabIndex = 47;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(216, 82);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 12);
            this.label8.TabIndex = 46;
            this.label8.Text = "职务：";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(82, 46);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 21);
            this.textBox6.TabIndex = 43;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(37, 45);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 42;
            this.label6.Text = "学历：";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(79, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 21);
            this.textBox1.TabIndex = 39;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 38;
            this.label1.Text = "姓名：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(213, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 50;
            this.label2.Text = "性别：";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(215, 48);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(72, 16);
            this.checkBox1.TabIndex = 51;
            this.checkBox1.Text = "是否留学";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // xDatePicker1
            // 
            this.xDatePicker1.bShowTime = false;
            this.xDatePicker1.Location = new System.Drawing.Point(82, 80);
            this.xDatePicker1.Name = "xDatePicker1";
            popedombyte1.CanAll = false;
            popedombyte1.CanCreate = false;
            popedombyte1.CanDelete = false;
            popedombyte1.CanModify = false;
            popedombyte1.CanRead = false;
            popedombyte1.p = ((byte)(0));
            this.xDatePicker1.PopedomByte = popedombyte1;
            this.xDatePicker1.Size = new System.Drawing.Size(100, 20);
            this.xDatePicker1.strDate = "";
            this.xDatePicker1.TabIndex = 52;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 53;
            this.label3.Text = "出生日期：";
            // 
            // cmb性别1
            // 
            this.cmb性别1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb性别1.FormattingEnabled = true;
            this.cmb性别1.Items.AddRange(new object[] {
            " ",
            "男",
            "女"});
            this.cmb性别1.Location = new System.Drawing.Point(261, 12);
            this.cmb性别1.Name = "cmb性别1";
            this.cmb性别1.Size = new System.Drawing.Size(97, 20);
            this.cmb性别1.TabIndex = 54;
            // 
            // 机构负责人Edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cmb性别1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.xDatePicker1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "机构负责人Edit";
            this.Size = new System.Drawing.Size(396, 150);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBox1;
        private FrontFlag.Control.PickerDate.XDatePicker xDatePicker1;
        private System.Windows.Forms.Label label3;
        private Cmb性别 cmb性别1;
    }
}
