using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FrontFlag.Control;

namespace 福田民政.Forms.Work.数据管理.民管局.登记备案_社团.Tab
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
            //成员信息 f成员信息 = new 成员信息();
            //f成员信息.SetParent( pag成员信息 );

            变更记录 f变更记录 = new 变更记录();
            f变更记录.SetParent( pag变更记录 );

            年检记录 f年检记录 = new 年检记录();
            f年检记录.SetParent( pag年检记录 );

            换证记录 f换证记录 = new 换证记录();
            f换证记录.SetParent( pag换证记录 );

            行政执法记录 f行政执法记录 = new 行政执法记录();
            f行政执法记录.SetParent( pag行政执法记录 );

            备案 f备案 = new 备案();
            f备案.SetParent( pag备案 );

            评估 f评估 = new 评估();
            f评估.SetParent( pag评估 );
        }
    }
}
