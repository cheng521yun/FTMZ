using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FrontFlag.Control;

namespace 福田民政.Forms.Work.数据交换.Excel
{
    public partial class Wnd : WorkForm
    {
        public Wnd()
        {
            InitializeComponent();
        }


        protected override void Init()
        {
            strCaption = "数据交换 Excel方式";
            Def.Act.Menu.Entry_数据交换_Excel方式 += Call;

        }

        public override void ShowWnd()
        {
            Show();
            LoadWeb();
        }

        private void LoadWeb()
        {
            //string strUrl = String.Format(@"http://{0}/{1}", GL.Param.WebUrl, @"ftmz/Version.html");
            //System.Uri url = new Uri( strUrl );
            //web.Navigate( url );
        }
    }
}
