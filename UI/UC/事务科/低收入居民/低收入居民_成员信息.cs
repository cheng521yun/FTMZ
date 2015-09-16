using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FrontFlag;
using UI.DefCtrl.Cmb;

namespace UI.UC.事务科.低收入居民
{
    public partial class 低收入居民_成员信息 : UserControl
    {
        DB.Stru.事务科.低收入居民_成员信息 _stru = new DB.Stru.事务科.低收入居民_成员信息();

        public 低收入居民_成员信息()
        {
            InitializeComponent();
        }

        #region 属性

        public DB.Stru.事务科.低收入居民_成员信息 stru
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


        private void 低收入居民_Load( object sender, EventArgs e )
        {
            //DB2Dlg();
        }

        private void DB2Dlg()
        {
            txt姓名.Text = _stru.姓名;
            cmb性别.Value = _stru.性别;
            txt身份证.Text = _stru.身份证;
            txt家庭人数.Text = _stru.家庭人数;
            txt保障人数.Text = _stru.保障人数;
            txt家庭月收入.Text = _stru.家庭月收入;
            txt成员类型.Text = _stru.成员类型;



        }

        private void Dlg2DB()
        {

            _stru.姓名 = txt姓名.Text.Trim();
            _stru.性别 = cmb性别.Value;
            _stru.身份证 = txt身份证.Text.Trim();
            _stru.家庭人数 = txt家庭人数.Text.Trim();
            _stru.保障人数 = txt保障人数.Text.Trim();
            _stru.家庭月收入 = txt家庭月收入.Text.Trim();
            _stru.成员类型 = txt成员类型.Text.Trim();
        }


    }
}
