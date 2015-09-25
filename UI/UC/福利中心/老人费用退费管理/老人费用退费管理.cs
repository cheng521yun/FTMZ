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

namespace UI.UC.福利中心.老人费用退费管理
{
    public partial class 老人费用退费管理 : UserControl
    {
        DB.Stru.福利中心.老人费用退费管理 _stru = new DB.Stru.福利中心.老人费用退费管理();

        public 老人费用退费管理()
        {
            InitializeComponent();
        }

        #region 属性
        public DB.Stru.福利中心.老人费用退费管理 stru
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


        private void 老人费用退费管理_Load(object sender, EventArgs e)
        {
            DB2Dlg();
        }

        private void DB2Dlg()
        {
            txt备注.Text = _stru.备注;
            txt电费.Text = _stru.电费;
            txt伙食费.Text = _stru.伙食费;
            txt老人服务费.Text = _stru.老人服务费;
            txt入住押金.Text = _stru.入住押金;
            txt姓名.Text = _stru.姓名;
            txt药费.Text = _stru.药费;
            txt医疗保证金.Text = _stru.医疗保证金;
            txt银行账号.Text = _stru.银行账号;
        }

        private void Dlg2DB()
        {
            _stru.备注 = txt备注.Text;
            _stru.电费 = txt电费.Text;
            _stru.伙食费 = txt伙食费.Text;
            _stru.老人服务费 = txt老人服务费.Text;
            _stru.入住押金 = txt入住押金.Text;
            _stru.姓名 = txt姓名.Text;
            _stru.药费 = txt药费.Text;
            _stru.医疗保证金 = txt医疗保证金.Text;
            _stru.银行账号 = txt银行账号.Text;
        }
    }
}
