using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FrontFlag.Control;

namespace 福田民政.Layout.LeftPnl.数据管理
{
    public partial class Wnd : XForm
    {
        public Wnd()
        {
            InitializeComponent();
        }

        private void Wnd_Load( object sender, EventArgs e )
        {
            LoadForm();
        }

        private void LoadForm()
        {
            AddFormList( typeof( 福田民政.Layout.LeftPnl.数据管理.老龄办 ), Def.FormId.数据管理_老龄办_LeftMenu );
            AddFormList( typeof( 福田民政.Layout.LeftPnl.数据管理.民管局 ), Def.FormId.数据管理_民管局_LeftMenu );
            AddFormList( typeof( 福田民政.Layout.LeftPnl.数据管理.事务科 ), Def.FormId.数据管理_事务科_LeftMenu );
            AddFormList( typeof( 福田民政.Layout.LeftPnl.数据管理.基层科 ), Def.FormId.数据管理_基层科_LeftMenu );
            AddFormList( typeof( 福田民政.Layout.LeftPnl.数据管理.优抚科 ), Def.FormId.数据管理_优抚科_LeftMenu );
            AddFormList( typeof( 福田民政.Layout.LeftPnl.数据管理.福利中心 ), Def.FormId.数据管理_福利中心_LeftMenu );
        }
    }
}
