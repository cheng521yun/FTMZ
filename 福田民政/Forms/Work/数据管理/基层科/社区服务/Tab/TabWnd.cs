using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FrontFlag.Control;

namespace 福田民政.Forms.Work.数据管理.基层科.社区服务.Tab
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
            社工岗位 f选举结果 = new 社工岗位();
            f选举结果.SetParent( pag社工岗位 );

            社区公益服务 f社区公益服务 = new 社区公益服务();
            f社区公益服务.SetParent( pag社区公益服务 );

        }
    }
}
