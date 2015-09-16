using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FrontFlag.Control;

namespace 福田民政.Forms.Work.数据管理.事务科.社会救助.Tab
{
    public partial class TabWnd : XForm
    {
        public TabWnd()
        {
            InitializeComponent();
        }

        private void TabWnd_Load( object sender, EventArgs e )
        {
            LoadForm();
        }

        private void LoadForm()
        {
            家庭成员 f家庭成员 = new 家庭成员();
            f家庭成员.SetParent( pag成员信息 );

            发放记录 f发放记录 = new 发放记录();
            f发放记录.SetParent( pag发放记录 );

        }
    }
}
