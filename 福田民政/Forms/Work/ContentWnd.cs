using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FrontFlag.Control;

namespace 福田民政.Forms
{
    public partial class FContentWnd : XForm
    {
        public FContentWnd()
        {
            InitializeComponent();
        }

        private void FContentWnd_Load( object sender, EventArgs e )
        {
            LoadForm();
        }

        private void LoadForm()
        {
            AddFormList( typeof( 福田民政.Forms.首页.Wnd ), Def.FormId.首页 );
            AddFormList( typeof( 福田民政.Forms.数据管理.Wnd ), Def.FormId.数据管理 );
            //AddFormList( typeof( 福田民政.Forms.数据分析.Wnd ), Def.FormId.数据分析 );
            AddFormList( typeof( 福田民政.Forms.Work.数据交换.Wnd ), Def.FormId.数据交换 );
            AddFormList( typeof( 福田民政.Forms.日志管理.Wnd ), Def.FormId.日志管理 );
            AddFormList( typeof( 福田民政.Forms.系统配置.Wnd ), Def.FormId.系统配置 );
            AddFormList( typeof( 福田民政.Forms.技术支持.Wnd ), Def.FormId.技术支持 );
        }
    }
}
