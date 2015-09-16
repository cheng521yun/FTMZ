using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FrontFlag.Control;

namespace 福田民政.Forms.Work.数据管理.基层科.数据统计.Tab
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
            民主管理信息管理 f选举结果 = new 民主管理信息管理();
            f选举结果.SetParent( pag民主管理信息管理 );

            社区基础服务设施情况 f社区基础服务设施情况 = new 社区基础服务设施情况();
            f社区基础服务设施情况.SetParent( pag社区基础服务设施情况 );

            福田区社工岗位社会工作 f福田区社工岗位社会工作 = new 福田区社工岗位社会工作();
            f福田区社工岗位社会工作.SetParent( pag福田区社工岗位社会工作 );

        }
    }
}
