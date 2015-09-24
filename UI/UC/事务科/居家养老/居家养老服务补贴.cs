using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace UI.UC.事务科.居家养老服务补贴
{
    public partial class 居家养老服务补贴 : UserControl
    {
        DB.Stru.事务科.居家养老服务补贴 _stru = new DB.Stru.事务科.居家养老服务补贴();

        public 居家养老服务补贴()
        {
            InitializeComponent();
        }

        #region 属性

        public DB.Stru.事务科.居家养老服务补贴 stru
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


        private void 居家养老服务补贴_Load(object sender, EventArgs e)
        {
            //DB2Dlg();
        }

        private void DB2Dlg()
        {
            txt所属街道.Text = _stru.所属街道;
            txt社区.Text = _stru.社区;
            txt身份证.Text = _stru.身份证;
            txt姓名.Text = _stru.姓名;
            cmb性别.Value = _stru.性别;
            txt享受类别.Text = _stru.享受类别;
            txt享受金额.Text = _stru.享受金额;
            txt服务机构.Text = _stru.服务机构;
            txt批准时间.strDate = _stru.批准时间Str;
            txt居住地址.Text = _stru.居住地址;
            txt居住状况.Text = _stru.居住状况;
            txt联系电话.Text = _stru.联系电话;
            txt紧急联系人.Text = _stru.紧急联系人;
            txt紧急联系人电话.Text = _stru.紧急联系人电话;
            txt备注.Text = _stru.备注;
            txt填表人.Text = _stru.填表人;
            txt填表人联系电话.Text = _stru.填表人联系电话;
            dat填表日期.strDate = _stru.填表日期Str;
        }

        private void Dlg2DB()
        {
            _stru.所属街道 = txt所属街道.Text;
            _stru.社区 = txt社区.Text;
            _stru.身份证 = txt身份证.Text;
            _stru.姓名 = txt姓名.Text;
            _stru.性别 = cmb性别.Value;
            _stru.享受类别 = txt享受类别.Text;
            _stru.享受金额 = txt享受金额.Text;
            _stru.服务机构 = txt服务机构.Text;
            _stru.批准时间 = txt批准时间.strDate;
            _stru.居住地址 = txt居住地址.Text;
            _stru.居住状况 = txt居住状况.Text;
            _stru.联系电话 = txt联系电话.Text;
            _stru.紧急联系人 = txt紧急联系人.Text;
            _stru.紧急联系人电话 = txt紧急联系人电话.Text;
            _stru.备注 = txt备注.Text;
            _stru.填表人 = txt填表人.Text;
            _stru.填表人联系电话 = txt填表人联系电话.Text;
            _stru.填表日期 = dat填表日期.strDate;
        }
    }
}
