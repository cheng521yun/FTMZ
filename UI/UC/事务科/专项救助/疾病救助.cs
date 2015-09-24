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

namespace UI.UC.事务科.专项救助
{
    public partial class 疾病救助: UserControl
    {
        DB.Stru.事务科.专项救助_疾病救助 _stru = new DB.Stru.事务科.专项救助_疾病救助();

        public 疾病救助()
        {
            InitializeComponent();
        }
        #region 属性

        public DB.Stru.事务科.专项救助_疾病救助 stru
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


        private void 疾病救助_Load(object sender, EventArgs e)
        {
            //DB2Dlg();
        }

        private void DB2Dlg()
        {
            txt所属街道.Text = _stru.所属街道;
            txt姓名.Text = _stru.姓名;
            cmb性别.Value = _stru.性别;
            txt联系电话.Text = _stru.联系电话;
            txt救助原因.Text = _stru.救助原因;
            txt金额.Text = _stru.金额;
            dat救助时间.strDate = _stru.救助时间Str;
            txt类别.Text = _stru.类别;
            txt备注.Text = _stru.备注;
        }

        private void Dlg2DB()
        {
            _stru.所属街道 = txt所属街道.Text.Trim();
            _stru.姓名 = txt姓名.Text.Trim();
            _stru.性别 = cmb性别.Value.Trim();
            _stru.联系电话 = txt联系电话.Text.Trim();
            _stru.救助原因 = txt救助原因.Text.Trim();
            _stru.金额 = txt金额.Text.Trim();
            _stru.救助时间 = dat救助时间.strDate;
            _stru.类别 = txt类别.Text.Trim();
            _stru.备注 = txt备注.Text.Trim();
        }


    }
}
