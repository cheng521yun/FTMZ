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

namespace UI.UC.福利中心.老人费用登记管理
{
    public partial class 老人费用登记管理 : UserControl
    {
        DB.Stru.福利中心.老人费用登记管理 _stru = new DB.Stru.福利中心.老人费用登记管理();

        public 老人费用登记管理()
        {
            InitializeComponent();
        }

        #region 属性
        public DB.Stru.福利中心.老人费用登记管理 stru
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


        private void 老人费用登记管理_Load(object sender, EventArgs e)
        {
            DB2Dlg();
        }

        private void DB2Dlg()
        {
            txt老人电费.Text = _stru.老人电费;
            txt老人伙食费.Text = _stru.老人伙食费;
            txt老人名称.Text = _stru.老人名称;
            txt老人药费.Text = _stru.老人药费;
            txt养老服务费.Text = _stru.养老服务费;
            txt银行账号.Text = _stru.银行账号;
            txt应收金额.Text = _stru.应收金额;
            txt用户代码.Text = _stru.用户代码;
            dat时间.strDate = _stru.时间Str;
            
        }

        private void Dlg2DB()
        {
            _stru.老人电费 = txt老人电费.Text;
            _stru.老人伙食费 = txt老人伙食费.Text;
            _stru.老人名称 = txt老人名称.Text;
            _stru.老人药费 = txt老人药费.Text;
            _stru.养老服务费 = txt养老服务费.Text;
            _stru.银行账号 = txt银行账号.Text;
            _stru.应收金额 = txt应收金额.Text;
            _stru.用户代码 = txt用户代码.Text;
            _stru.时间 = dat时间.strDate;
        }


    }
}
