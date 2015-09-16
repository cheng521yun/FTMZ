using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Def;
using FrontFlag.Control.Menu;
using Global;

namespace UI.Pnl.TopMenu
{
    public partial class TopMenu : UserControl
    {
        public TopMenu()
        {
            InitializeComponent();
        }

        private void TopMenu_Load( object sender, EventArgs e )
        {
            if ( !this.DesignMode )   //在设计模式下 GL.Path.StartUp 没有赋值，读取不到图片。
            {
                Init();
            }
        }

        private Bitmap LoadPic( string strPicName )
        {
            string strPath = String.Format( @"{0}\{1}", GL.Path.StartUp, Def.Const.Path.Skin_TopBar );
            string strFile = String.Format( @"{0}\{1}", strPath, strPicName );
            return new Bitmap( strFile );
        }

        private void SetBtn( Ctrl.Btn.TopMenuBtn bnt, string strName, int nCommandId )
        {
            string strPicName = String.Format( "{0}.png", strName );
            Image imgComm = LoadPic( strPicName );
            Image imgHove = imgComm;
            bnt.Init( imgComm, imgHove, strName, nCommandId );
        }

        private void SetBtn( Ctrl.Btn.TopMenuBtn bnt, string strName, List<XToolStripMenuItem> lstItem )
        {
            string strPicName = String.Format( "{0}.png", strName );
            Image imgComm = LoadPic( strPicName );
            Image imgHove = imgComm;
            bnt.Init( imgComm, imgHove, strName, lstItem );
        }

        private void Init()
        {
            SetBtn();
        }
        void SetBtn()
        {
            SetBtn( btn01, "首页", Def.CommandId.首页 );
            SetBtn( btn02, "数据管理", Def.Menu.TopMenu.数据管理 );
            SetBtn( btn03, "数据分析", Def.Menu.TopMenu.数据分析 );
            SetBtn( btn04, "日志管理", Def.Menu.TopMenu.日志管理 );
            SetBtn( btn05, "系统配置", Def.Menu.TopMenu.系统配置 );
            SetBtn( btn06, "技术支持", Def.Menu.TopMenu.技术支持 );

            SetBtn( btn10, "回收站", Def.Menu.TopMenu.回收站 );

        }

        #region Function

        public void SetBtnMenu( UI.Ctrl.Btn.TopMenuBtn btn, List<XToolStripMenuItem> lstItem )
        {
            System.Windows.Forms.ContextMenuStrip menu = new ContextMenuStrip();

            foreach ( XToolStripMenuItem Item in lstItem )
            {
                menu.Items.Add( Item );
                Item.dlgtAction = DealAction;
            }

            btn.Tag = menu;  //把菜单保存起来。
            btn.Click += new System.EventHandler( ShowMenu );                                     //左键点击显示菜单
            btn.MouseDown += new System.Windows.Forms.MouseEventHandler( this.DisbleMenu );     //右键点击无效
            btn.Cursor = Cursors.Hand;
        }

        void ShowMenu( object sender, EventArgs e )
        {
            Button btn = sender as Button;

            ContextMenuStrip menu = btn.Tag as ContextMenuStrip;
            if ( menu != null )
            {
                btn.ContextMenuStrip = menu;
                btn.ContextMenuStrip.Show( btn, new Point( 0, btn.Size.Height ) );
            }
        }

        private void DisbleMenu( object sender, MouseEventArgs e )
        {
            Button btn = sender as Button;

            if ( e.Button == MouseButtons.Right )
            {
                btn.ContextMenuStrip = null;    //禁止右键弹出菜单
            }
        }

        private void DealAction( int nCommand )
        {
            MessageBox.Show( nCommand.ToString() );
            //Command.Call( nAction );
            
            //App.Commander.Exec( nCommand );
        }

        #endregion

    }
}
