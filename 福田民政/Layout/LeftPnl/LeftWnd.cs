using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using FrontFlag.Control;

namespace 福田民政.Layout.LeftPnl
{
    public partial class FLeftWnd : XForm
    {
        public FLeftWnd()
        {
            InitializeComponent();
        }

        private void FWnd_Load( object sender, EventArgs e )
        {
            LoadForm();
        }

        private void LoadForm()
        {
            InitForm();

            Def.Act.Menu.Entry_首页 += Call;
        }

        void InitForm()
        {
            AddFormList( typeof( 福田民政.Layout.LeftPnl.数据管理.Wnd ), Def.FormId.数据管理_LeftMenu );

            AddFormList( typeof( 福田民政.Layout.LeftPnl.日志管理.Wnd ), Def.FormId.日志管理_LeftMenu );
            AddFormList( typeof( 福田民政.Layout.LeftPnl.系统配置.Wnd ), Def.FormId.系统配置_LeftMenu );
            AddFormList( typeof( 福田民政.Layout.LeftPnl.技术支持.Wnd ), Def.FormId.技术支持_LeftMenu );
        }

        private void Call(object obj)
        {
            HideLeftPnl();
        }

        void HideLeftPnl()
        {
            App.fMain.bShowLeftPnl = false;
        }
    }
}
