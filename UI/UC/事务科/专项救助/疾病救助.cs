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


        private void 低收入居民_Load( object sender, EventArgs e )
        {
            //DB2Dlg();
        }

        private void DB2Dlg()
        {
            //dat审批时间.strDate = _stru.审批时间;
            //dat待遇截止日期.Text = _stru.待遇截止日期;
            //txt接收人.Text = _stru.接收人;
            //txt低保证号.Text = _stru.低保证号 ;
            //txt低保证号.Text = _stru.低保证号;
            //txt发放类型.Text = _stru.发放类型;
        }

        private void Dlg2DB()
        {
            //_stru.审批时间 = dat审批时间.strDate  ;
            //_stru.待遇截止日期 = dat待遇截止日期.Text ;
            //_stru.接收人 = txt接收人.Text.Trim();
            //_stru.低保证号 = txt低保证号.Text.Trim();
            //_stru.发放年月 = dat发放年月.strDate  ;
            //_stru.发放类型 = txt发放类型.Text.Trim();

        }


    }
}
