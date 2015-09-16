using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FrontFlag;

namespace UI.Dlg.人员
{
    public partial class 人员 : UserControl
    {
        DB.Stru.人员 _stru = new DB.Stru.人员();

        public 人员()
        {
            InitializeComponent();
        }

        #region 属性

        public DB.Stru.人员 stru
        {
            set
            {
                _stru = value;
                DB2Dlg();
            }
            get
            {
                Dlg2DB();
                return _stru;
            }
        }

        #endregion

        #region Event

        private void 人员_Load( object sender, EventArgs e )
        {
            InitForm();
        }

        #endregion

        private void InitForm()
        {
            txt姓名.BackColor = Def.Style.SysColor.Input_MustNotBlank;

            cmb性别.SelectedIndex = 0;
        }

        public bool CheckBeforeSave()
        {
            if (String.IsNullOrEmpty(txt姓名.Text.Trim()))
            {
                FF.Ctrl.MsgBox.ShowWarn("必须填写姓名！");
                return false;
            }

            return true;
        }

        void DB2Dlg()
        {
            txt编号.Text = _stru.人员编号;
            txt姓名.Text = _stru.姓名;
            FF.Ctrl.Combo.SetSelectText( cmb性别, _stru.性别Str );
            txt身份证.Text = _stru.身份证;
            txt电话.Text = _stru.电话;
            txt手机.Text = _stru.联系手机;
            txt地址.Text = _stru.地址;
            txt街道.Text = _stru.所属街道;
        }

        void Dlg2DB()
        {
            _stru.人员编号 = txt编号.Text.Trim() ;
            _stru.姓名 = txt姓名.Text.Trim();
            _stru.性别Str = cmb性别.Text.Trim();
            _stru.身份证 = txt身份证.Text.Trim();
            _stru.电话 = txt电话.Text.Trim();
            _stru.联系手机 = txt手机.Text.Trim();
            _stru.地址 = txt地址.Text.Trim();
            _stru.所属街道 = txt街道.Text.Trim();
        }



    }
}
