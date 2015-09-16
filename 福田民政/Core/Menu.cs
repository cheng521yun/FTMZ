using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FrontFlag.Control.Menu;

namespace 福田民政.Core
{
    public class CMenu
    {
        public List<XToolStripMenuItem> lst数据管理 = new List<XToolStripMenuItem>();

        public CMenu()
        {
            Init();
        }

        public void Init()
        {
            lst数据管理 = new List<XToolStripMenuItem>()
                        {  
                            new XToolStripMenuItem( "老龄办", Def.Command.Menu.数据管理_老龄办 ),
                            new XToolStripMenuItem( "民管局", Def.Command.Menu.数据管理_民管局 ),
                            new XToolStripMenuItem( "事务科", Def.Command.Menu.数据管理_事务科 ),
                        };
        }


        #region public

        public void Set数据管理( System.Windows.Forms.Button btn )
        {
            SetBtnMenu( btn, lst数据管理 );
        }

        #endregion

        #region Function

        public void SetBtnMenu( System.Windows.Forms.Button btn, List<XToolStripMenuItem> lstItem )
        {
            System.Windows.Forms.ContextMenuStrip menu = new ContextMenuStrip();

            foreach ( XToolStripMenuItem Item in lstItem )
            {
                menu.Items.Add( Item );
                Item.dlgtAction = DealAction;
            }

            btn.Tag = menu;  //把菜单保存起来。
            btn.Click += new System.EventHandler(ShowMenu);                                     //左键点击显示菜单
            btn.MouseDown += new System.Windows.Forms.MouseEventHandler( this.DisbleMenu );     //右键点击无效
            btn.Cursor = Cursors.Hand;
        }

        void ShowMenu( object sender, EventArgs e )
        {
            Button btn = sender as Button;

            ContextMenuStrip menu = btn.Tag as ContextMenuStrip;
            if (menu != null)
            {
                btn.ContextMenuStrip = menu;
                btn.ContextMenuStrip.Show(btn, new Point(0, btn.Size.Height));
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

        private void DealAction(int nCommand)
        {
            //MessageBox.Show(nAction.ToString());
            //Command.Call( nAction );
            App.Commander.Exec( nCommand );
        }

        #endregion

    }
}
