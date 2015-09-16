using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using FrontFlag.Control;
using Global;

namespace 福田民政.Forms.技术支持
{
    public partial class 版本更新 : WorkForm
    {
        public 版本更新()
        {
            InitializeComponent();
        }

        protected override void Init()
        {
            strCaption = "技术支持 版本更新";
            Def.Act.Menu.Entry_技术支持_版本更新 += Call;
           
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
