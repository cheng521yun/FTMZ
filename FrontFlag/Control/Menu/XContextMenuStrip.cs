/* 
 * 名称：自定义菜单。
 *       针对整个菜单，要和XToolStripMenuItem配合使用。.
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
    /// 右键弹出菜单类。里面会包含若干MenuItem。
    /// </summary>
    public partial class XContextMenuStrip : ContextMenuStrip
    {
        public delegate FUN.POPEDOMBYTE DELE_Param1 ( string strParam );
        public DELE_Param1 delgGetPopedom = null;

        //菜单编号
        private string _strID = "";

        public XContextMenuStrip ()
            : base ()
        {
            InitializeComponent ();

            Visible = false;   //初始的时候不可见。
        }

        public XContextMenuStrip ( System.ComponentModel.IContainer Container )
            : base ()
        {

        }

        #region 属性

        public string ID
        {
            set { _strID = value; }
            get { return _strID; }
        }

        #endregion

        public void Show(System.Windows.Forms.Control control, System.Drawing.Point position)
        {
            //SetPopedom();
            base.Show(control, position);
        }


        protected override void OnPaint ( PaintEventArgs pe )
        {
            base.OnPaint ( pe );
        }

        #region public

        //public void SetPopedom ()
        //{
        //    if ( _strID == "" || delgGetPopedom == null )
        //        return;

        //    //权限标志，指明菜单是否可见，使能
        //    FUN.POPEDOMBYTE PopedomByte = delgGetPopedom ( _strID );

        //    //Visible = PopedomByte.CanRead;             //不可见           //弹出菜单不要处理Visible属性，因为会有动作执行弹出窗口。
        //    Enabled = PopedomByte.CanModify;           //可见，状态无效

        //    //遍历子菜单
        //    foreach ( ToolStripItem c in Items ) 
        //    {
        //        if ( c is XToolStripMenuItem )
        //        {
        //            XToolStripMenuItem Item = c as XToolStripMenuItem;

        //            if ( Item.ID == "" )
        //                continue;

        //            //遍历子菜单。
        //            Item.delgGetPopedom += GetItemPopedom;
        //            Item.SetPopedom();              
        //        }
        //    }

        //    //去掉不合规则的菜单分隔条。
        //    RemoveSeparator();
        //}

        #endregion

        FUN.POPEDOMBYTE GetItemPopedom ( string strID )
        {
            return delgGetPopedom ( strID );
        }

        /// <summary>
        /// 去掉不合规则的菜单分隔条。（连续多个的分隔条；上部是空的分隔条；下部是空的分隔条）
        /// </summary>
        void RemoveSeparator ()
        {
            ArrayList aryDel = new ArrayList();

            int n = 0 ;
            int jg = 0;  //分割线后面的间隔

            ToolStripItem lastSeparator = null;

            foreach ( ToolStripItem c in Items )
            {
                if ( c is ToolStripSeparator )
                {
                    lastSeparator = c;
                    c.Visible = true;

                    if ( jg == 0 )
                    {
                        aryDel.Add(c);
                    }

                    jg = 0;
                }
                else
                {
                    if ( c.Visible )  //不计算不可见的菜单项。
                        jg ++;

                }

                n++;
            }

            //分割线是最后一个可见元素的时候，也要删除。
            if ( jg == 0 && lastSeparator != null )
            {
                aryDel.Add ( lastSeparator );
            }

            if ( aryDel.Count <= 0 )
                return;

            foreach ( ToolStripItem c in aryDel )
            {
                c.Visible = false;
            }
        }
    }
}
