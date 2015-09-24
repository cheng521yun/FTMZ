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

namespace UI.UC.福利中心.老人入住管理
{
    public partial class 老人入住管理_担保人 : UserControl
    {
        DB.Stru.事务科.低收入居民_发放记录 _stru = new DB.Stru.事务科.低收入居民_发放记录();
        public 老人入住管理_担保人()
        {
            InitializeComponent();
        }

        #region 属性
        public DB.Stru.事务科.低收入居民_发放记录 stru
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


        private void 老人入住管理_担保人_Load(object sender, EventArgs e)
        {
            //DB2Dlg();
        }

        private void DB2Dlg()
        {
            /*
            FF.Ctrl.Combo.SetSelectText( cmbType, _stru.类别 );
            txt姓名.Text = _stru.户主姓名;
            cmb性别.Value = _stru.性别;
            txt年龄.Text = _stru.年龄;
            txt身份证.Text = _stru.身份证;
            txt通讯住址.Text = _stru.通讯住址;
            txt所属社区.Text = _stru.所属社区;
            txt电话号码.Text = _stru.电话号码;
            txt银行帐号.Text = _stru.银行帐号;
            */


        }

        private void Dlg2DB()
        {
            /*
            _stru.类别 = cmbType.Text;
            _stru.户主姓名 = txt姓名.Text.Trim();
            _stru.性别 = cmb性别.Value;
            _stru.年龄 = txt年龄.Text.Trim();
            _stru.身份证 = txt身份证.Text.Trim();
            _stru.通讯住址 = txt通讯住址.Text.Trim();
            _stru.所属社区 = txt所属社区.Text.Trim();
            _stru.电话号码 = txt电话号码.Text.Trim();
            _stru.银行帐号 = txt银行帐号.Text.Trim();
             * */
        }


    }
}
