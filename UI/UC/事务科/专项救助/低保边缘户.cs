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
    public partial class 低保边缘户 : UserControl
    {
        DB.Stru.事务科.专项救助_低保边缘户 _stru = new DB.Stru.事务科.专项救助_低保边缘户();

        public 低保边缘户()
        {
            InitializeComponent();
        }

        #region 属性

        public DB.Stru.事务科.专项救助_低保边缘户 stru
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


        private void 低保边缘户_Load(object sender, EventArgs e)
        {
            //DB2Dlg();
        }

        private void DB2Dlg()
        {
            txt所属街道.Text = _stru.所属街道;
            txt身份证.Text = _stru.身份证;
            txt姓名.Text = _stru.姓名;
            cmb性别.Value = _stru.性别;
            txt联系电话.Text = _stru.联系电话;
            txt家庭成员.Text = _stru.家庭成员;
            txt边缘证号.Text = _stru.边缘证号;
            dat有效期.strDate = _stru.有效期Str;
            txt备注.Text = _stru.备注;
        }

        private void Dlg2DB()
        {
             _stru.所属街道 = txt所属街道.Text ;
            _stru.身份证 = txt身份证.Text ;
            _stru.姓名=txt姓名.Text ;
            _stru.性别 = cmb性别.Value ;
            _stru.联系电话 = txt联系电话.Text ;
            _stru.家庭成员 = txt家庭成员.Text ;
            _stru.边缘证号 = txt边缘证号.Text ;
            _stru.有效期 = dat有效期.strDate ;
            _stru.备注 = txt备注.Text;
        }


    }
}
