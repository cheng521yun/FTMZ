using FrontFlag.Control;

namespace 福田民政.Forms.Work.系统配置.用户管理
{
    partial class Edit
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose( bool disposing )
        {
            if ( disposing && ( components != null ) )
            {
                components.Dispose();
            }
            base.Dispose( disposing );
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            FrontFlag.FUN.POPEDOMBYTE popedombyte1 = new FrontFlag.FUN.POPEDOMBYTE();
            FrontFlag.FUN.POPEDOMBYTE popedombyte2 = new FrontFlag.FUN.POPEDOMBYTE();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAdd = new FrontFlag.Control.XButton();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnDelete = new FrontFlag.Control.XButton();
            this.txtPwd = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPwd2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmb性别 = new UI.Ctrl.Cmb.性别();
            this.cmb科室 = new UI.Ctrl.Cmb.科室();
            this.cmbRole = new UI.Ctrl.Cmb.角色();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "姓名：";
            // 
            // btnAdd
            // 
            this.btnAdd.FlatStyle = true;
            this.btnAdd.Location = new System.Drawing.Point(237, 10);
            this.btnAdd.Name = "btnAdd";
            popedombyte1.CanAll = false;
            popedombyte1.CanCreate = false;
            popedombyte1.CanDelete = false;
            popedombyte1.CanModify = false;
            popedombyte1.CanRead = false;
            popedombyte1.p = ((byte)(0));
            this.btnAdd.PopedomByte = popedombyte1;
            this.btnAdd.SelectTable = true;
            this.btnAdd.Size = new System.Drawing.Size(100, 23);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "添加用户";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(72, 12);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 21);
            this.txtName.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "性别：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "角色：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 8;
            this.label4.Text = "科室：";
            // 
            // btnDelete
            // 
            this.btnDelete.FlatStyle = true;
            this.btnDelete.Location = new System.Drawing.Point(237, 45);
            this.btnDelete.Name = "btnDelete";
            popedombyte2.CanAll = false;
            popedombyte2.CanCreate = false;
            popedombyte2.CanDelete = false;
            popedombyte2.CanModify = false;
            popedombyte2.CanRead = false;
            popedombyte2.p = ((byte)(0));
            this.btnDelete.PopedomByte = popedombyte2;
            this.btnDelete.SelectTable = true;
            this.btnDelete.Size = new System.Drawing.Size(100, 23);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "删除用户";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtPwd
            // 
            this.txtPwd.Location = new System.Drawing.Point(70, 151);
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.PasswordChar = '*';
            this.txtPwd.Size = new System.Drawing.Size(100, 21);
            this.txtPwd.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 11;
            this.label5.Text = "密码：";
            // 
            // txtPwd2
            // 
            this.txtPwd2.Location = new System.Drawing.Point(261, 151);
            this.txtPwd2.Name = "txtPwd2";
            this.txtPwd2.PasswordChar = '*';
            this.txtPwd2.Size = new System.Drawing.Size(100, 21);
            this.txtPwd2.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(194, 155);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 13;
            this.label6.Text = "重复密码：";
            // 
            // cmb性别
            // 
            this.cmb性别.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb性别.FormattingEnabled = true;
            this.cmb性别.Location = new System.Drawing.Point(72, 46);
            this.cmb性别.Name = "cmb性别";
            this.cmb性别.Size = new System.Drawing.Size(100, 20);
            this.cmb性别.TabIndex = 15;
            // 
            // cmb科室
            // 
            this.cmb科室.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb科室.FormattingEnabled = true;
            this.cmb科室.Location = new System.Drawing.Point(72, 78);
            this.cmb科室.Name = "cmb科室";
            this.cmb科室.Size = new System.Drawing.Size(100, 20);
            this.cmb科室.TabIndex = 9;
            // 
            // cmbRole
            // 
            this.cmbRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRole.FormattingEnabled = true;
            this.cmbRole.Location = new System.Drawing.Point(72, 114);
            this.cmbRole.Name = "cmbRole";
            this.cmbRole.Size = new System.Drawing.Size(100, 20);
            this.cmbRole.TabIndex = 7;
            // 
            // Edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 200);
            this.Controls.Add(this.cmb性别);
            this.Controls.Add(this.txtPwd2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtPwd);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.cmb科室);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbRole);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Edit";
            this.Text = "Edit";
            this.Load += new System.EventHandler(this.Edit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private XButton btnAdd;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private UI.Ctrl.Cmb.角色 cmbRole;
        private UI.Ctrl.Cmb.科室 cmb科室;
        private System.Windows.Forms.Label label4;
        private XButton btnDelete;
        private System.Windows.Forms.TextBox txtPwd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPwd2;
        private System.Windows.Forms.Label label6;
        private UI.Ctrl.Cmb.性别 cmb性别;
    }
}