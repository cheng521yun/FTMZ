using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FrontFlag.Control;

namespace 福田民政.Forms.Work.数据管理.基层科.民主管理.Tab
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
            选举结果 f选举结果 = new 选举结果();
            f选举结果.SetParent( pag选举结果 );

        }
    }
}
