using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FrontFlag.Control;

namespace 福田民政.Forms.数据管理.福利中心.老人入住.Tab
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
            监护人 f监护人 = new 监护人();
            f监护人.SetParent( pag监护人 );

            担保人 f担保人 = new 担保人();
            f担保人.SetParent( pag担保人 );

            //社区基础服务设施情况 f社区基础服务设施情况 = new 社区基础服务设施情况();
            //f社区基础服务设施情况.SetParent( pag社区基础服务设施情况 );

            //福田区社工岗位社会工作 f福田区社工岗位社会工作 = new 福田区社工岗位社会工作();
            //f福田区社工岗位社会工作.SetParent( pag福田区社工岗位社会工作 );

        }
    }
}
