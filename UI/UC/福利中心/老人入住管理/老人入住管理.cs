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
    public partial class 老人入住管理 : UserControl
    {
        DB.Stru.福利中心.老人入住管理 _stru = new DB.Stru.福利中心.老人入住管理();

        public 老人入住管理()
        {
            InitializeComponent();
        }

        #region 属性
        public DB.Stru.福利中心.老人入住管理 stru
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


        private void 老人入住管理_Load( object sender, EventArgs e )
        {
            DB2Dlg();
        }

        private void DB2Dlg()
        {
            txt姓名.Text = _stru.姓名;
            cmb性别.Value = _stru.性别;
            txt本人成分.Text = _stru.本人成份;
            txt身份证.Text = _stru.身份证;
            txt户籍所在地.Text = _stru.户籍所在地;
            txt籍贯.Text = _stru.籍贯;
            txt家庭住址.Text = _stru.家庭住址;
            txt申请事由.Text = _stru.申请事由;
            txt押金费用.Text = _stru.押金费用;
            txt身体状况.Text = _stru.身体状况;

        }

        private void Dlg2DB()
        {
            _stru.姓名 = txt姓名.Text;
            _stru.性别 = cmb性别.Value;
            _stru.本人成份 = txt本人成分.Text;
            _stru.身份证 = txt身份证.Text;
            _stru.户籍所在地 = txt户籍所在地.Text;
            _stru.籍贯 = txt籍贯.Text;
            _stru.家庭住址 = txt家庭住址.Text;
            _stru.申请事由 = txt申请事由.Text;
            _stru.押金费用 = txt押金费用.Text;
            _stru.身体状况 = txt身体状况.Text;
        }
    }
}
