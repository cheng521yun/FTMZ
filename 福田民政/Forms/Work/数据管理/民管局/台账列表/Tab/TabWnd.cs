using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FrontFlag.Control;

namespace 福田民政.Forms.Work.数据管理.民管局.台账列表.Tab
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
            人员管理 f成员信息 = new 人员管理();
            f成员信息.SetParent( pag人员管理 );

            会员管理 f会员管理 = new 会员管理();
            f会员管理.SetParent( pag会员管理 );

            资产管理 f资产管理 = new 资产管理();
            f资产管理.SetParent( pag资产管理 );

            其他管理 f其他管理 = new 其他管理();
            f其他管理.SetParent( pag其他管理 );
            
        }
    }
}
