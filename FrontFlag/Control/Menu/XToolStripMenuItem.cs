/* 
 * 名称：自定义菜单。
 *       针对菜单的具体的一个Item.
 *
 * 日期：2010-08-30
 *
 * 作者：徐力
 *
 * 描述：可以根据权限表，自动显示，隐藏，变灰菜单项。
 * 
 * 
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FrontFlag.Control.Menu
{
    /// <summary>
    /// 右键弹出菜单中的单个的menuItem. 
    /// </summary>
    public partial class XToolStripMenuItem : ToolStripMenuItem
    {
        public delegate void DLGTint( int n );
        public DLGTint dlgtAction = null;           //点击菜单后要调用的函数功能编号

        MENU_ITEM_UNIT MenuItemUnit = new MENU_ITEM_UNIT();

        public PERMISSION Permission = new PERMISSION();   //设置此菜单项的权限。控制是否可见或有效。

        #region 构造函数

        public XToolStripMenuItem ()
            : base ()
        {
            Init();
        }

        public XToolStripMenuItem( MENU_ITEM_UNIT Item )
        {
            MenuItemUnit = Item;
            Init();
        }

        public XToolStripMenuItem( string MenuId, string Text, int nCommandId )
        {
            MenuItemUnit = new MENU_ITEM_UNIT( MenuId, Text, nCommandId );
            Init();
        }

        public XToolStripMenuItem( string Text, int nCommandId )
        {
            MenuItemUnit = new MENU_ITEM_UNIT( String.Empty, Text, nCommandId );
            Init();
        }

        public XToolStripMenuItem( string Text, int nCommandId, bool bEnable )
        {
            MenuItemUnit = new MENU_ITEM_UNIT( String.Empty, Text, nCommandId );
            Init();
            Permission.CanEnable = bEnable;
        }

        #endregion

        private void Init()
        {
            this.Text = MenuItemUnit.strText;
            Click += new System.EventHandler( OnClickMenuItem );
        }

        private void OnClickMenuItem( object sender, EventArgs e )
        {
            if (dlgtAction != null)
                dlgtAction( MenuItemUnit.nCommandId );
        }

        #region 属性

        public int CommandId
        {
            get { return MenuItemUnit.nCommandId; }
        }

        #endregion

        //protected override void OnPaint ( PaintEventArgs pe )
        //{
        //    base.OnPaint ( pe );
        //}

        public void SetPermission( PERMISSION Perm )
        {
            Permission = Perm;

            //if ( MenuItemUnit.strId == String.Empty  || delgGetPopedom == null )
            //    return;

            ////权限标志，指明菜单是否可见，使能
            //FUN.POPEDOMBYTE PopedomByte = delgGetPopedom ( _strID );

            Visible = Permission.CanShow;           //不可见
            Enabled = Permission.CanEnable;         //可见，状态无效

            ////遍历子菜单
            //foreach ( ToolStripItem c in DropDownItems )
            //{
            //    //string strTmp = c.Text;

            //    if ( c is XToolStripMenuItem )
            //    {
            //        XToolStripMenuItem Item = c as XToolStripMenuItem;

            //        if ( Item.ID == "" )
            //            continue;

            //        PopedomByte = delgGetPopedom ( Item.ID );

            //        Item.Visible = PopedomByte.CanRead;             //不可见
            //        Item.Enabled = PopedomByte.CanModify;           //可见，状态无效

            //        //遍历子菜单
            //        Item.SetPopedom();    
            //    }
            //}

            //去掉不合规则的菜单分隔条。
            //RemoveSeparator();
        }

        ///// <summary>
        ///// 去掉不合规则的菜单分隔条。（连续多个的分隔条；上部是空的分隔条；下部是空的分隔条）
        ///// </summary>
        //void RemoveSeparator ()
        //{
        //    ArrayList aryDel = new ArrayList ();

        //    int n = 0;
        //    int jg = 0;  //分割线后面的间隔

        //    ToolStripItem lastSeparator = null;

        //    foreach ( ToolStripItem c in DropDownItems )
        //    {
        //        if ( c is ToolStripSeparator )
        //        {
        //            lastSeparator = c;
        //            c.Visible = true;

        //            if ( jg == 0 )
        //            {
        //                aryDel.Add ( c );
        //            }

        //            jg = 0;
        //        }
        //        else
        //        {
        //            if ( c.Visible )  //不计算不可见的菜单项。
        //                jg++;

        //        }

        //        n++;
        //    }

        //    //分割线是最后一个可见元素的时候，也要删除。
        //    if ( jg == 0 && lastSeparator != null )
        //    {
        //        aryDel.Add ( lastSeparator );
        //    }

        //    if ( aryDel.Count <= 0 )
        //        return;

        //    foreach ( ToolStripItem c in aryDel )
        //    {
        //        c.Visible = false;
        //    }
        //}
    }
}
