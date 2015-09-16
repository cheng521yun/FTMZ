using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Buss;
using DB.Stru;
using FrontFlag;
using FrontFlag.Control;
using FrontFlag.Test;

namespace 福田民政.Forms.Work.系统配置.用户管理
{
    public partial class Edit : XForm
    {
        DB.Stru.USER _stru职员 = new USER();

        public Def.dlgt.Act dlgtFlush = null;

        public Edit()
        {
            InitializeComponent();
        }

        #region Event

        private void Edit_Load( object sender, EventArgs e )
        {
            LoadForm();
        }

        private void btnAdd_Click( object sender, EventArgs e )
        {
            AddUser();
        }

        private void btnDelete_Click( object sender, EventArgs e )
        {
            Delete();
        }

        #endregion

        private void LoadForm()
        {
            btnDelete.clrBK = Def.Style.SysColor.Btn_Delete_BK;
        }

        private void AddUser()
        {
            if (!Check())
                return;

            Dlg2DB();

            bool bRet = BL.User.Save( _stru职员 );

            if (!bRet)
            {
                FF.Ctrl.MsgBox.ShowWarn( "用户保存失败！" );
                return;
            }

            FF.Ctrl.MsgBox.Show( "用户保存成功。" );

            Clear();

            if ( dlgtFlush != null )
                dlgtFlush();
        }

        private bool Check()
        {
            if ( String.IsNullOrEmpty( txtName.Text.Trim() ) )
            {
                FF.Ctrl.MsgBox.ShowWarn( "姓名不可为空！" );
                return false;
            }

            if ( String.IsNullOrEmpty( cmbRole.Text.Trim() ) )
            {
                FF.Ctrl.MsgBox.ShowWarn( "角色不可为空！" );
                return false;
            }

            if ( String.IsNullOrEmpty( cmb科室.Text.Trim() ) )
            {
                FF.Ctrl.MsgBox.ShowWarn( "科室不可为空！" );
                return false;
            }

            if ( String.IsNullOrEmpty( txtPwd.Text.Trim() ) )
            {
                FF.Ctrl.MsgBox.ShowWarn("密码不可为空！");
                return false;
            }

            if ( txtPwd.Text.Trim() != txtPwd2.Text.Trim() )
            {
                FF.Ctrl.MsgBox.ShowWarn( "两次输入的密码不一致！" );
                return false;
            }

            if (BL.User.isExsit(txtName.Text.Trim()))
            {
                FF.Ctrl.MsgBox.ShowWarn( "已经存在同名职员！" );
                return false;
            }

            return true;
        }

        private void Dlg2DB()
        {
            _stru职员.Name = txtName.Text.Trim();
            _stru职员.Grander = cmb性别.Text.Trim();
            _stru职员.Password = txtPwd.Text.Trim();
            _stru职员.Role = cmbRole.Text.Trim();
            _stru职员.Department = cmb科室.Text.Trim();

            _stru职员.Creator = "系统";
            _stru职员.Status = "启用";
        }

        private void DB2Dlg()
        {
            txtName.Text = _stru职员.Name ;
            FF.Ctrl.Combo.SetSelectText( cmb性别, _stru职员.GranderStr );
            txtPwd.Text = txtPwd2.Text = _stru职员.Password;
            FF.Ctrl.Combo.SetSelectText( cmbRole, _stru职员.Role );
            FF.Ctrl.Combo.SetSelectText( cmb科室, _stru职员.Department );
        }

        public void Modify( DB.Stru.USER stru )
        {
            _stru职员 = stru;

            DB2Dlg();
        }

        private void Clear()
        {
            _stru职员.Clear();
            DB2Dlg();
        }

        private void Delete()
        {
            if (! FF.Ctrl.MsgBox.ShowYesNo_RetBool(Def.Str.Msg.Delete_Ask))
                return;

            if (!Check())
                return;

            DB2Dlg();

            BL.User.Delete( _stru职员 );

            Clear();

            if ( dlgtFlush != null )
                dlgtFlush();
        }
    }
}
