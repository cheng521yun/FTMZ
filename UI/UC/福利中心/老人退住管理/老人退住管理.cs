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

namespace UI.UC.福利中心.老人退住管理
{
    public partial class 老人退住管理 : UserControl
    {
        DB.Stru.福利中心.老人退住管理 _stru = new DB.Stru.福利中心.老人退住管理();

        public 老人退住管理()
        {
            InitializeComponent();
        }

        #region 属性
        public DB.Stru.福利中心.老人退住管理 stru
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


        private void 老人退住管理_Load(object sender, EventArgs e)
        {
            DB2Dlg();
        }

        private void DB2Dlg()
        {
            txt姓名.Text = _stru.姓名;
            txt身份证.Text = _stru.身份证;
            txt入住级别.Text = _stru.入住级别;
            txt申请时间.Text = _stru.申请时间;
            txt入住时间.Text = _stru.入住时间;
            txt退住级别.Text = _stru.退住级别;
        }

        private void Dlg2DB()
        {
            _stru.姓名 = txt姓名.Text;
            _stru.身份证 = txt身份证.Text;
            _stru.入住级别 = txt入住级别.Text;
            _stru.申请时间 = txt申请时间.Text;
            _stru.入住时间 = txt入住时间.Text;
            _stru.退住级别 = txt退住级别.Text;
        }


    }
}
