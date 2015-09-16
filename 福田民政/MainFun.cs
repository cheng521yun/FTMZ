using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FrontFlag.Control;
using Global;
using 福田民政.Forms;
using 福田民政.Layout.LeftPnl;


namespace 福田民政
{
    public partial class MainForm : XForm
    {
        #region 属性

        public bool bShowLeftPnl
        {
            set { pnlLeft.Visible = value; }
            get { return pnlLeft.Visible; }
        }

        #endregion

        private void InitForm()
        {
            FLeftWnd fLeftMenu = new FLeftWnd();
            FContentWnd fContent = new FContentWnd();

            fLeftMenu.SetParent(pnlLeft);
            fContent.SetParent(pnlContent);

            if ( Def.Act.Sys.ChangeLoginUser != null )
                Def.Act.Sys.ChangeLoginUser( GL.User.Name );
        }

        public void ShowCaption( string strCaptionText )
        {
            ucCaptionBar.ShowCaption( strCaptionText );
        }

        /// <summary>
        /// 起始显示的一个窗口页面。
        /// </summary>
        void StartForm()
        {
            ShowHome();
        }

        void ShowHome()
        {
            Command.Exec( Def.Command.Menu.首页 );
        }

        private void CommandReady()
        {
            //App.Commander.InitParam();
        }

    }
}
