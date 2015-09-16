using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FrontFlag.Control;

namespace 福田民政.Forms.数据管理.福利中心.费用统计.Tab
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
            养老服务费 f养老服务费 = new 养老服务费();
            f养老服务费.SetParent( pag养老服务费 );

            老人伙食费 f老人伙食费 = new 老人伙食费();
            f老人伙食费.SetParent( pag老人伙食费 );

            老人药费 f老人药费 = new 老人药费();
            f老人药费.SetParent( pag老人药费 );

            老人电费 f老人电费 = new 老人电费();
            f老人电费.SetParent( pag老人电费 );

            应收金额 f应收金额 = new 应收金额();
            f应收金额.SetParent( pag应收金额 );


        }
    }
}
