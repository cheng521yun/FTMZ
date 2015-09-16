//////////////////////////////////////////////////////////////////////////
//
//  使用说明: 需要调用 ListView.Init () ， 以便激活消息响应函数。
//
//////////////////////////////////////////////////////////////////////////


using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using System.Drawing;
using System.Data;
using System.Runtime.InteropServices;
using System.ComponentModel;



using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Design;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;

using Excel = Microsoft.Office.Interop.Excel;  

namespace FrontFlag.Control
{
    public class XListView : System.Windows.Forms.ListView
    {
        DEBUG Debug = new DEBUG (); 

        #region 委托

        public struct SENDMSGDATA
        {
            public enum FunNo { HoverCell } ;
            public int nFunNO;
            public string strMsg;
            public ListViewItem Item;
            public int nParam1;
            public int nParam2;
        } ;
        public delegate void entSendMsg ( SENDMSGDATA SendMsgData );
        public event entSendMsg SendMsg = null;   

        #endregion

        #region Windows Param

        [StructLayoutAttribute ( LayoutKind.Sequential )]
        public struct LV_ITEM
        {
            public UInt32 mask;
            public Int32 iItem;
            public Int32 iSubItem;
            public UInt32 state;
            public UInt32 stateMask;
            public String pszText;
            public Int32 cchTextMax;
            public Int32 iImage;
            public IntPtr lParam;
        }

        public const Int32 LVM_FIRST = 0x1000;
        public const Int32 LVM_GETITEM = LVM_FIRST + 5;
        public const Int32 LVM_SETITEM = LVM_FIRST + 6;
        public const Int32 LVIF_TEXT = 0x0001;
        public const Int32 LVIF_IMAGE = 0x0002;

        public const int LVW_FIRST = 0x1000;
        public const int LVM_GETEXTENDEDLISTVIEWSTYLE = LVW_FIRST + 54;

        public const int LVS_EX_GRIDLINES = 0x00000001;
        public const int LVS_EX_SUBITEMIMAGES = 0x00000002;
        public const int LVS_EX_CHECKBOXES = 0x00000004;
        public const int LVS_EX_TRACKSELECT = 0x00000008;
        public const int LVS_EX_HEADERDRAGDROP = 0x00000010;
        public const int LVS_EX_FULLROWSELECT = 0x00000020; // applies to report mode only
        public const int LVS_EX_ONECLICKACTIVATE = 0x00000040;

        #endregion

        bool _bCanSort = false;
        ListViewColumnSorter _sorter = new ListViewColumnSorter ();

        bool _bFilterColumnClick = false;

        //ArrayList _aryColHide = new ArrayList () ;      //记录需要隐藏的列。
        List<int> _lstColHide = new List<int>();          //记录需要隐藏的列。
        List<int> _listColNotW = new List<int>();         //记录Xml中所有宽度=0的列。

        public FLDCOL FldCol = new FLDCOL () ;          //处理直接由DataTable来赋值。

        string _strXmlFile = "";                        //保存列宽度的文件名称。
        string _strListName = "";                       //每个列表需要在XML文件中有自己的唯一的名称。
        bool   _bAllowSaveFldWidth = false;             //true=调节列宽度后，弯度数值会自动保存到xml文件中。

        string [] _strOrderValueType = null;
        int [] _nColWidths = null;                       //保存每列的宽度,以便HideCol/ShowCol之后，能正常恢复原来的列宽。

        public XListView()
        {
            Init ();
        }

        #region 属性

        public List<int> listColNotW
        {
            get { return _listColNotW; }
        }

        #endregion

        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case 0x4E: // WM_NOTIFY
                    //if (!this.HandleNotify(ref m))
                        base.WndProc(ref m);
                    break;
                default:
                    base.WndProc(ref m);
                    break;
            }
        }

        private bool HandleNotify(ref Message m)
        {
            bool isMsgHandled = false;

            const int HDN_FIRST = (0 - 300);
            const int HDN_ITEMCHANGINGA = (HDN_FIRST - 0);
            const int HDN_ITEMCHANGINGW = (HDN_FIRST - 20);

            API.NMHDR nmhdr = (API.NMHDR)m.GetLParam(typeof(API.NMHDR));

            if (nmhdr.code == HDN_ITEMCHANGINGA || nmhdr.code == HDN_ITEMCHANGINGW)
            {
                //Debug.Log("in nmhdr.code == HDN_ITEMCHANGINGW");

                API.NMHEADER nmheader = (API.NMHEADER)m.GetLParam(typeof(API.NMHEADER));
                if (nmheader.iItem >= 0 && nmheader.iItem < this.Columns.Count)
                {
                    API.HDITEM hditem = (API.HDITEM)Marshal.PtrToStructure(
                        nmheader.pHDITEM, typeof(API.HDITEM));
                    //OLVColumn column = this.GetColumn(nmheader.iItem);
                    //if ( IsOutsideOfBounds ( nmheader.iItem ) )

                    //Debug.Log(String.Format("--- HandleNotify. col={0}", (int)nmheader.iItem));

                    //if (_aryColHide.Contains((int)nmheader.iItem))
                    if (_lstColHide.Contains((int)nmheader.iItem))
                    {
                        Columns[(int)nmheader.iItem].Width = 0;

                        m.Result = (IntPtr)1; // prevent the change
                        isMsgHandled = true;

                        //Debug.Log("**** HandleNotify");
                    }
                }
            }

            return isMsgHandled;
        }

        //private bool IsOutsideOfBounds(int col)
        //{
        //    // Check the mask to see if the width field is valid,
        //    if ((hditem.mask & 1) != 1)
        //        return false;

        //    // Now check that the value is in range
        //    //return ( hditem.cxy < col.MinimumWidth ||
        //    //       ( col.MaximumWidth != -1 && hditem.cxy > col.MaximumWidth ) );

        //    foreach (int nCol in _aryColHide)
        //    {
        //        if (e.ColumnIndex == nCol && e.NewWidth > 0)
        //        {
        //            Debug.Log("**** Do Hide col");

        //            e.NewWidth = 0;
        //            e.Cancel = true;
        //        }
        //    }
        //}

        public void Init ()
        {
            this.View = System.Windows.Forms.View.Details;
            MultiSelect = false;

            //AllowOrder ( false );     //默不能排序。
            AllowOrder ( true );        //默可以排序。
 
            //设定排序器.
            ListViewItemSorter = _sorter;
            _sorter.Order = SortOrder.Ascending;

            //消息响应函数。
            ColumnClick += new System.Windows.Forms.ColumnClickEventHandler ( this.OnColumnClick );
            ColumnWidthChanging += new System.Windows.Forms.ColumnWidthChangingEventHandler ( this.OnColWidthChanging );
            ItemMouseHover += new System.Windows.Forms.ListViewItemMouseHoverEventHandler ( this.OnItemMouseHover );
            ColumnWidthChanged += new System.Windows.Forms.ColumnWidthChangedEventHandler ( this.OnColumnWidthChanged );

            //
            SetStyle ();

            RestoreColWidth ();   

            //
            SetDefaultAllOrderType ();
        }

        public void SetMultSetlst(bool bFlag)
        {
            MultiSelect = bFlag;
        }

        /// <summary>
        /// 设置每列的默认排序类型。 默认是字符串型。
        /// </summary>
        public void SetDefaultAllOrderType ( )
        {
            int nNum = Columns.Count ;
            _strOrderValueType = new string [ nNum ];

            for ( int i = 0 ; i < nNum ; i++ )
                _strOrderValueType [ i ] = ListViewColumnSorter.DefValueType_String;
        }

        public void SetColOrderType ( int nCol , string strValueType )
        {
            if ( nCol >= 0 && nCol < Columns.Count && nCol < _strOrderValueType.Length )
                _strOrderValueType [ nCol ] = strValueType;
        }

        //不知道为什末点击Colum的时候， 会发2次 ColumnClick 消息进来,所以只好用计数器过滤掉第2次的消息.
        public bool FilterColumnClick
        {
            set
            {
                _bFilterColumnClick = value;
            }

            get
            {
                return _bFilterColumnClick;
            }
        }

        public void AllowOrder ( bool bFlag )
        {
            _bCanSort = bFlag;

            if ( _bCanSort )
            {
                HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Clickable;
                _sorter.Order = SortOrder.Ascending;
            }
            else
            {
                HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
                _sorter.Order = SortOrder.None;
            }
        }

        public void AllowSaveColWidth ( bool bFlag , string strXmlFile , string strListName )
        {
            //加在这里是因为init()里面没起效果，隐藏列可以被拉开。ColumnWidthChanged加在这里可以被强制执行。
            ColumnWidthChanged += new System.Windows.Forms.ColumnWidthChangedEventHandler(this.OnColumnWidthChanged);
            ColumnWidthChanging += new System.Windows.Forms.ColumnWidthChangingEventHandler(this.OnColWidthChanging);


            _bAllowSaveFldWidth = bFlag;
            _strXmlFile = strXmlFile;
            _strListName = strListName;

            if ( _strXmlFile.Trim () == "" || strListName.Trim() == "" )
                _bAllowSaveFldWidth = false;
        }

        public void SetStyle ()      
        {
            System.Windows.Forms.Message m = new Message ();
            m.HWnd = this.Handle;
            m.Msg = LVM_GETEXTENDEDLISTVIEWSTYLE;
            m.LParam = ( IntPtr ) ( LVS_EX_GRIDLINES | LVS_EX_FULLROWSELECT | LVS_EX_SUBITEMIMAGES );
            m.WParam = IntPtr.Zero;
            this.WndProc ( ref m );
        }

        public void Order ( int colNum , SortOrder so )
        {
            _sorter.SortColumn = colNum;
            _sorter.Order = so ;
            Sort ();
        }

        public void Order ( int colNum , SortOrder so , string strValueType )
        {
            _sorter.SortColumn = colNum;
            _sorter.Order = so;
            _sorter.SortValueType = strValueType ; 
            Sort ();
        }

        //给单击表头事件添加代码
        long nColumnClick = 0;
        private void OnColumnClick ( object sender , System.Windows.Forms.ColumnClickEventArgs e )
        {
            if ( !_bCanSort )
                return;

            if ( _bFilterColumnClick )
            {
                if ( nColumnClick++ % 2 == 1 )          //不知道为什末点击Colum的时候， 会发2次 ColumnClick 消息进来,所以只好用计数器过滤掉第2次的消息.
                    return;

                if ( nColumnClick > 1000 )
                    nColumnClick = 0;
            }

            //设置排序的类型。
            if ( e.Column < _strOrderValueType.Length )
                 _sorter.SortValueType = _strOrderValueType [ e.Column ];
            else   //默认是字符串类型比较。
                _sorter.SortValueType = ListViewColumnSorter.DefValueType_String;

            //
            if ( e.Column == _sorter.SortColumn )
            {
                if ( _sorter.Order == SortOrder.Ascending )
                    _sorter.Order = SortOrder.Descending;
                else
                {
                    if ( _sorter.Order == SortOrder.Descending )
                        _sorter.Order = SortOrder.Ascending;
                    else
                        return;
                }
            }
            else
            {
                _sorter.SortColumn = e.Column;
            }

            Sort ();
        }

        #region 赋值

        public bool SetColFld ( string [ ] strsCol , string [ ] strsFld )
        {
            ArrayList ary = new ArrayList () ;  
            ary = GetColNameAry () ;

            foreach ( string str in strsCol )
            {
                if ( ! ary.Contains ( str ) )
                {
                    FF.Ctrl.MsgBox.ShowWarn ( String.Format ( "XListView.SetColFld(): 中不存在指定的列名: {0} !" , str ) );
                    return false;
                }
            }

            return FldCol.Set ( strsCol , strsFld );
        }

        public bool DataTable2List ( ref DataTable dt )
        {
            FUN Fun = new FUN () ;

            Items.Clear ();

            if ( !FldCol.IsValid () || SQL.IsNotValid ( ref dt ) )
                return false;

            bool bRet = true;
            int ColMax = Columns.Count;
            string [ ] strsSubItem = new string [ ColMax ];
            int LineNum = dt.Rows.Count;
            ListViewItem [ ] lis = new ListViewItem [ LineNum ];
            Type t;
            DateTime dat;

            BeginUpdate ();
            SuspendLayout ();

            string strFld , strText;
            int i = 0 , j = 0;

            try 
            {
                foreach ( DataRow dr in dt.Rows )
                {
                    j = 0;

                    foreach ( ColumnHeader hd in Columns )
                    {
                        strFld = FldCol.GetFldName ( hd.Text );

                        if ( strFld == String.Empty )
                        {
                            strsSubItem [ j++ ] = "";       //不需要从dt中读入的col, 设置为空
                        }
                        else
                        {
                            t = dr [ strFld ].GetType ();

                            if ( t == typeof ( System.DateTime ) )
                            {
                                dat = FF.Fun.MyConvert.Str2Date ( dr [ strFld ].ToString () );
                                if( dat.Year == 1900 )
                                    //strsSubItem[j++] = String.Empty;   //2013-10-09 怕引起其他错误，暂时不用
                                    strsSubItem[j++] = dat.ToString( "yyyy-MM-dd HH:mm" );   //使用yyyy代替yy, 可避免1900-01-01 被改变成 00-01-01（ 操作系统会当成 2000-01-01 ）
                                else
                                    strsSubItem [ j++ ] = dat.ToString ( "yy-MM-dd HH:mm" );
                            }
                            else if ( t == typeof ( System.Decimal ) )  //decimal 或者 Money类型
                            {
                                strText = dr [strFld].ToString ().Trim ();
                                strsSubItem [j++] = Fun.MyConvert.Decimal2StrDot4 ( strText ); //控制到2位小数点。
                            }
                            else   //其他类型的字段 都默认为文本方式。
                            {
                                strText = dr [strFld].ToString ().Trim ();
                                strsSubItem [j++] = strText;
                            }
                        }
                    }

                    lis [ i++ ] = new ListViewItem ( strsSubItem );
                }

                Items.AddRange ( lis );

            }
            catch ( Exception e )
            {
                bRet = false;
                string strMsg = String.Format ( "DataTable2List() Err!\nTable:{0}\n{1}" , dt.TableName , e.Message );
                FF.Ctrl.MsgBox.ShowWarn ( strMsg );
            }

            ResumeLayout ();
            EndUpdate ();

            return bRet;
        }
        public bool List2DataTable ( ref DataTable dt )
        {
            dt.Rows.Clear () ;

            bool bRet = true;
            string strFld , strText;
            int n = 0;

            try
            {
                foreach ( ListViewItem li in Items )
                {
                    SQL.AddNewRow ( ref dt );
                    DataRow dr = dt.Rows [ n ];

                    foreach ( ColumnHeader hd in Columns )
                    {
                        strFld = FldCol.GetFldName ( hd.Text );
                        if ( strFld == String.Empty )
                            continue;

                        strText = li.SubItems [ hd.Index ].Text;
                        dr [ strFld ] = strText;
                    }

                    n++;
                }
            }
            catch ( Exception e )
            {
                bRet = false;
                string strMsg = String.Format ( "List2DataTable() Err!\nTable:{0}\n{1}" , dt.TableName ,  e.Message );
                FF.Ctrl.MsgBox.ShowWarn ( strMsg );
            }

            return bRet;
        }
        /*public bool List2DataTable ( ref DataTable dt )
        {
            bool bRet = true;
            string strFld , strText;
            int n = 0;

            try
            {
                foreach ( ListViewItem li in Items )
                {
                    SQL.AddNewRow ( ref dt );
                    DataRow dr = dt.Rows [ n ];

                    foreach ( ColumnHeader hd in Columns )
                    {
                        strFld = FldCol.GetFldName ( hd.Text );
                        if ( strFld == String.Empty )
                            continue;

                        strText = li.SubItems [ hd.Index ].Text;
                        dr [ strFld ] = strText;
                    }

                    n++;
                }
            }
            catch ( Exception e )
            {
                bRet = false;
                string strMsg = String.Format ( "List2DataTable() Err!\nTable:{0}\n{1}" , dt.TableName , e.Message );
                FF.Ctrl.MsgBox.ShowWarn ( strMsg );
            }

            return bRet;
        }*/

        public bool DataRow2List ( int nLineNo , ref DataRow dr )
        {
            if ( nLineNo < 0 || nLineNo >= Items.Count )
                return false;

            if ( !FldCol.IsValid () || dr == null )
                return false;

            bool bRet = true;

            int ColMax = Columns.Count;
            string [ ] strsSubItem = new string [ ColMax ];

            BeginUpdate ();
            SuspendLayout ();

            string strFld , strText;
            int i = 0 , j = 0;

            try
            {
                foreach ( ColumnHeader hd in Columns )
                {
                    strFld = FldCol.GetFldName ( hd.Text );
                    if ( strFld == String.Empty )
                    {
                        strsSubItem [ j++ ] = "";       //不需要从dr中读入的col, 设置为空
                    }
                    else
                    {
                        strText = dr [ strFld ].ToString ().Trim ();
                        strsSubItem [ j++ ] = strText;
                    }
                }

                ListViewItem li = new ListViewItem ( strsSubItem );

                Items [ nLineNo ] = li;
            }
            catch ( Exception e )
            {
                bRet = false;
                string strMsg = String.Format ( "DataRow2List() Err!\nTable:{0}\n{1}" , dr.Table.TableName , e.Message ); 
                FF.Ctrl.MsgBox.ShowWarn ( strMsg ) ;
            }
            
            ResumeLayout ();
            EndUpdate ();

            return bRet;
        }
        public bool DataRow2List(int nLineNo, DataRow dr)
        {
            if (nLineNo < 0 || nLineNo >= Items.Count)
                return false;

            if (!FldCol.IsValid() || dr == null)
                return false;

            bool bRet = true;

            int ColMax = Columns.Count;
            string[] strsSubItem = new string[ColMax];

            BeginUpdate();
            SuspendLayout();

            string strFld, strText;
            int i = 0, j = 0;

            try
            {
                foreach (ColumnHeader hd in Columns)
                {
                    strFld = FldCol.GetFldName(hd.Text);
                    if (strFld == String.Empty)
                    {
                        strsSubItem[j++] = "";       //不需要从dr中读入的col, 设置为空
                    }
                    else
                    {
                        strText = dr[strFld].ToString().Trim();
                        strsSubItem[j++] = strText;
                    }
                }

                ListViewItem li = new ListViewItem(strsSubItem);

                Items[nLineNo] = li;
            }
            catch (Exception e)
            {
                bRet = false;
                string strMsg = String.Format("DataRow2List() Err!\nTable:{0}\n{1}", dr.Table.TableName, e.Message);
                FF.Ctrl.MsgBox.ShowWarn(strMsg);
            }

            ResumeLayout();
            EndUpdate();

            return bRet;
        }

        public bool List2DataRow ( int nLineNo , ref DataRow dr )
        {
            if ( nLineNo < 0 || nLineNo >= Items.Count )
                return false;

            if ( !FldCol.IsValid () )
                return false;

            bool bRet = true;
            string strFld , strText;
            int n = 0;

            try
            {
                foreach ( ColumnHeader hd in Columns )
                {
                    strFld = FldCol.GetFldName ( hd.Text );
                    if ( strFld == String.Empty )
                        continue;

                    strText = Items[ nLineNo ].SubItems [ hd.Index ].Text;
                    dr [ strFld ] = strText;
                }
            }
            catch ( Exception e )
            {
                bRet = false;
                string strMsg = String.Format ( "List2DataTable() Err!\nTable:{0}\n{1}" , dr.Table.TableName , e.Message );
                FF.Ctrl.MsgBox.ShowWarn ( strMsg );
            }

            return bRet;
        }

        #endregion

        #region 关于列

        public int GetColIndex ( string strColName )
        {
            foreach ( ColumnHeader hd in Columns )
            {
                if ( hd.Text.Trim () == strColName.Trim () )
                    return hd.Index;
            }
            return -1;
        }

        public void ClearHideCol ()
        {
            //_aryColHide.Clear ();
            _lstColHide.Clear();
        }

        public void HideCol ( string strColName )
        {
            int nCol = GetColIndex ( strColName );
            HideCol ( nCol );
        }
        public void ShowCol ( string strColName , int nColW )
        {
            int nCol = GetColIndex ( strColName );

            ShowCol(nCol);   

            if ( nColW <= 0 )
                nColW = 100;

            SetColWidth(nCol, nColW);   
        }
        public void ShowCol ( string strColName )
        {
            try
            {
                int nCol = GetColIndex ( strColName );

                ShowCol ( strColName , _nColWidths [ nCol ] );
            }
            catch ( Exception e )
            {
                ShowCol ( strColName , 100 );
            }
        }

        public void HideCol ( int nCol )
        {
            if ( nCol < 0 || nCol >= this.Columns.Count )
                return ;

            //_aryColHide.Add ( nCol ) ;
            _lstColHide.Add(nCol);
            SetColWidth ( nCol , 0 );
        }
        public void ShowCol ( int nCol , int nColW )
        {
            if ( nCol < 0 || nCol >= this.Columns.Count )
                return;

            try
            {
                //if ( _aryColHide.Contains ( nCol ) )
                //    _aryColHide.Remove ( nCol );
                if (_lstColHide.Contains(nCol))
                    _lstColHide.Remove(nCol);
            }
            catch ( Exception e )
            {
                MessageBox.Show ( e.Message );
            }

            SetColWidth ( nCol , nColW );
        }
        public void ShowCol ( int nCol )
        {
            try
            {
                ShowCol ( nCol , _nColWidths [ nCol ] );
            }
            catch ( Exception e )
            {
                ShowCol ( nCol , 100 ) ;
            }
        }

        public void SetColWidth ( string strColName , int Width )
        {
            int nCol = GetColIndex ( strColName );
            SetColWidth ( nCol , Width );
        }
        public void SetColWidth ( int nCol , int Width )
        { 
            if ( nCol < 0 || nCol >= this.Columns.Count || Width < 0 )
                return ;

            //FF.Debug.Log(String.Format("SetColWidth. Width={0}", Width));

            Columns [ nCol ].Width = Width;
        }

        //合并两个列到第三列
        public bool CombinColToDest ( string strColOrg1 , string strColOrg2 , string strColDest , string strSplit )
        {
            int nCol1 = GetColIndex ( strColOrg1 );
            int nCol2 = GetColIndex ( strColOrg2 );
            int nCol3 = GetColIndex ( strColDest );

            if ( nCol1 < 0 || nCol2 < 0 || nCol3 < 0 )
                return false ;
            
            string str1 , str2 ;
            foreach ( ListViewItem li in Items )
            {
                str1 = li.SubItems [ nCol1 ].Text;
                str2 = li.SubItems [ nCol2 ].Text;
                li.SubItems [ nCol3 ].Text = str1 + strSplit + str2;
            }

            return true;
        }
        public bool CombinColToDest ( string strColOrg1 , string strColOrg2 , string strColDest )
        {
            return CombinColToDest ( strColOrg1 , strColOrg2 , strColDest , " " );
        }

        //把第一列合并到第二列上
        public bool CombinCol ( string strCol1 , string strCol2 , string strSplit )
        {
            return CombinColToDest ( strCol1 , strCol2 , strCol2 , strSplit );
        }
        public bool CombinCol ( string strCol1 , string strCol2 )
        {
            return CombinCol ( strCol1 , strCol2 , "" ) ;
        }

        //拖动Head的时候，处理需要隐藏的列。
        void OnColWidthChanging ( object sender , ColumnWidthChangingEventArgs e )
        {
            //Debug.Log ( "===== in OnColWidthChanging()" );

            //foreach (int nCol in _aryColHide)
            foreach ( int nCol in _lstColHide )
            {
                //Debug.Log("foreach nCol in _aryColHide： ");
                //Debug.Log(String.Format ( "e.ColumnIndex == nCol; {0} , {1}", e.ColumnIndex , nCol ));
                //Debug.Log( String.Format ("e.NewWidth > 0: {0}", e.NewWidth ) );

                if (e.ColumnIndex == nCol && e.NewWidth > 0)
                {
                    //Debug.Log("**** Do Hide col");

                    e.NewWidth = 0;
                    e.Cancel = true;
                }
            }
        }

        //鼠标移动到哪个Item上。//在一行内移动，或者在List空白处移动，不会激发这个消息。
        void OnItemMouseHover ( object sender , ListViewItemMouseHoverEventArgs e )
        {
            if ( SendMsg == null )
                return;

            SENDMSGDATA data = new SENDMSGDATA ();
            data.nFunNO = ( int ) SENDMSGDATA.FunNo.HoverCell;
            data.Item = e.Item;

            SendMsg ( data );
        }

        //更改列的宽度后， 要把这个宽度值记录到本地文件中， 以便下次显示List时，可以保持各列是最后调节的宽度。
        void OnColumnWidthChanged ( object sender , ColumnWidthChangedEventArgs e )
        {
            #region 因为OnColumnWidthChanging没起作用，暂时放在这里，不让隐藏列给拉出来
            foreach (int nCol in _lstColHide)
            {
                if (e.ColumnIndex == nCol && Columns[e.ColumnIndex].Width > 0)
                {
                    Columns[e.ColumnIndex].Width = 0;
                }
            }
            #endregion 

            if ( ! _bAllowSaveFldWidth )
                return;

            //return;   //2014-02-28 以下cancel, 因为列宽动态显示不正确

            string strColName = Columns [ e.ColumnIndex ].Text;
            FF.Xml.FilterInvalidCh ( ref strColName ) ;
            int nWidth = Columns [ e.ColumnIndex ].Width;

            string Param = String.Format ( @"{0}/{1}" , _strListName , strColName );
            FF.Xml.WriteParam ( _strXmlFile , Param , nWidth.ToString () );
        }

        public void RestoreColWidth()
        {
            if ( !_bAllowSaveFldWidth )
                return;

            _listColNotW.Clear();

            string strCol, strValue = "";
            int nWidth = 0;

            _nColWidths = new int[ Columns.Count ];

            int i = 0;
            foreach ( ColumnHeader hd in Columns )
            {
                strCol = hd.Text;
                FF.Xml.FilterInvalidCh( ref strCol );

                string Param = String.Format( @"{0}/{1}", _strListName, strCol );
                FF.Xml.ReadParam( _strXmlFile, Param, ref strValue );

                if ( strValue == "" )
                {
                    _nColWidths[ i++ ] = hd.Width;
                    continue;
                }

                nWidth = FF.Fun.MyConvert.Str2Int( strValue );

                if ( nWidth == 0 )
                    _listColNotW.Add( hd.Index );   //记录下宽度=0的列。

                if ( nWidth >= 0 )
                {
                    hd.Width = nWidth;
                    _nColWidths[ i++ ] = hd.Width;
                }
            }

        }


        #endregion

        #region 关于行

        public void SetLineHeight ( int H )
        {
            ImageList imgList = new ImageList ();
            imgList.ImageSize = new System.Drawing.Size ( 1 , H );
            SmallImageList = imgList;
        }

        public void ItemSelectedUp ()
        {
            if ( SelectedIndices.Count <= 0 )
                return;

            int nSel = SelectedIndices [0];
            if ( nSel == 0 )
                return;

            nSel = ItemUp ( nSel );

            SelectedIndices.Clear ();
            if ( nSel >= 0 )
                SelectedIndices.Add ( nSel );

        }

        public void ItemSelectedDown ()
        {
            if ( SelectedIndices.Count <= 0 )
                return;

            int nSel = SelectedIndices [0];
            if ( nSel == Items.Count -  1 )
                return;

            nSel = ItemDown ( nSel );

            SelectedIndices.Clear ();
            if ( nSel >= 0 )
                SelectedIndices.Add ( nSel );
        }

        public int ItemUp ( int nSel )
        {
            if ( nSel < 0 && nSel >= Items.Count )
                return -1;

            if ( nSel == 0 )
                return 0;

            ListViewItem ItemTmp = new ListViewItem ( Items [nSel].SubItems [0].Text );
            int nCount = Items [nSel].SubItems.Count ;
            for ( int i = 1 ; i < nCount ; i ++ )
            {
                ItemTmp.SubItems.Add ( Items [nSel].SubItems [ i ].Text );
            }

            ListViewItem ItemTmp2 =  Items.Insert ( nSel - 1 , ItemTmp );
            Items.RemoveAt ( nSel + 1 );

            return nSel - 1;
        }

        public int ItemDown ( int nSel )
        {
            if ( nSel < 0 && nSel >= Items.Count )
                return -1;

            if ( nSel == Items.Count -1 )
                return Items.Count - 1;

            ListViewItem ItemTmp = new ListViewItem ( Items [nSel].SubItems [0].Text );
            int nCount = Items [nSel].SubItems.Count;
            for ( int i = 1 ; i < nCount ; i++ )
            {
                ItemTmp.SubItems.Add ( Items [nSel].SubItems [i].Text );
            }

            ListViewItem ItemTmp2 = Items.Insert ( nSel + 2 , ItemTmp );
            Items.RemoveAt ( nSel );

            return nSel + 1;
        }

        #endregion

        #region 关于Cell

        //
        public void SetCellImg ( int nLine , int nCol , int nImgIndex )
        {
            LV_ITEM lvi = new LV_ITEM ();

            lvi.mask = XListView.LVIF_IMAGE | XListView.LVIF_TEXT;
            lvi.iItem = nLine;
            lvi.iSubItem = nCol;
            lvi.iImage = nImgIndex;
            lvi.pszText = GetCellText ( nLine , nCol );
            SendMessage ( Handle , LVM_SETITEM , 0 , ref lvi );
        }
        public void SetCellImg ( ListViewItem li , int nCol , int nImgIndex )
        {
            int nLine = Items.IndexOf ( li );
            if ( nLine < 0 )
                return;
            SetCellImg ( nLine , nCol , nImgIndex ) ;
        }

        #region Get/Set Text

        public string GetCellText ( int nLine , int nCol )
        {
            if ( nLine < 0 || nLine >= Items.Count || nCol < 0 || nCol >= Columns.Count )
                return "";

            return Items [ nLine ].SubItems [ nCol ].Text;
        }
        public string GetCellText ( int nLine , string strColName )
        {
            int nCol = GetColIndex ( strColName );
            return GetCellText ( nLine , nCol );
        }

        public string GetSelectLineCellText ( int nCol )
        {
            int nLine = GetSelLine ();
            if ( nLine < 0 )
                return "";

            if ( nLine < 0 || nLine >= Items.Count || nCol < 0 || nCol >= Columns.Count )
                return "";

            return Items [ nLine ].SubItems [ nCol ].Text;
        }
        public string GetSelectLineCellText ( string strColName )
        {
            int nCol = GetColIndex ( strColName );
            return GetSelectLineCellText ( nCol );
        }

        public void SetCellText ( int nLine , int nCol , string strText )
        {
            if ( nLine < 0 || nLine >= Items.Count || nCol < 0 || nCol >= Columns.Count )
                return;

            Items [ nLine ].SubItems [ nCol ].Text = strText;
        }
        public void SetCellText ( int nLine , string strColName , string strText )
        {
            int nCol = GetColIndex ( strColName );
            SetCellText ( nLine , nCol , strText );
        }

        public bool SetSelectLineCellText ( int nCol , string strText )
        {
            int nLine = GetSelLine ();
            if ( nLine < 0 )
                return false;

            if ( nLine < 0 || nLine >= Items.Count || nCol < 0 || nCol >= Columns.Count )
                return false;

            Items [ nLine ].SubItems [ nCol ].Text = strText;
            return true;
        }
        public bool SetSelectLineCellText ( string strColName , string strText )
        {
            int nCol = GetColIndex ( strColName );
            return SetSelectLineCellText ( nCol , strText );
        }

        #endregion

        #endregion

        #region Select

        //选中哪一行.
        public int GetSelLine ()
        {
            if ( SelectedIndices.Count <= 0 )
                return -1;

            return SelectedIndices [ 0 ];
        }

        //鼠标放在哪一列上.
        public int GetSelCol ()
        {
            Point curPos = PointToClient ( Cursor.Position );
            ListViewItem lvwItem = GetItemAt ( curPos.X , curPos.Y );

            if ( lvwItem != null )
            {
                int W = 0;
                for ( int i = 0 ; i < Columns.Count ; i++ )
                {
                    W += Columns [ i ].Width;
                    if ( W > curPos.X )
                        return i;
                }
            }

            return -1;
        }

        public bool DeleteSelectLine ()
        {
            int nIndex = GetSelLine ();
            if ( nIndex < 0 )
                return false;

            Items.RemoveAt ( nIndex );
            return true;
        }

        public void SelectLastLine ()
        {
            int nLastLine = Items.Count - 1;
            SelectedIndices.Clear ();
            SelectedIndices.Add ( nLastLine );
        }

        //返回新增的行序号.
        public int AddNewLine ()
        {
            try
            {
                int MaxCol = Columns.Count;
                ListViewItem li = new ListViewItem("");

                for (int i = 1; i < MaxCol; i++)
                    li.SubItems.Add("");

                Items.Add(li);

                SelectedIndices.Clear();
                li.Selected = true;                     //2010-03-14,这句在mogulttech公司的makePO的Save()之后会出错，所以加上 Try{}处理，避免弹出出错对话框。

                if (SelectedIndices.Count <= 0)
                    return -1;

                return SelectedIndices[0];
            }
            catch ( Exception e )
            {
                string strErr = e.Message;
                return -1;
            }

        }

        #endregion

        #region Private

        ArrayList GetColNameAry ()
        { 
            ArrayList ary = new ArrayList () ;
            foreach ( ColumnHeader hd in Columns )
                ary.Add ( hd.Text );
            return ary;
        }

        #endregion

        #region Windows API

        [DllImport ( "user32.dll" )]
        public static extern int SendMessage (
            IntPtr hWnd ,	// handle to destination window 
            int Msg ,		// message 
            IntPtr wParam ,	// first message parameter 
            IntPtr lParam	// second message parameter 
            );

        [DllImport ( "user32.dll" )]
        public static extern bool SendMessage (
            IntPtr hWnd ,		// handle to destination window 
            Int32 msg ,			// message 
            Int32 wParam ,
            ref LV_ITEM lParam );// pointer to struct of LV_ITEM

        #endregion


        /// <summary>
        /// 方法，导出DataTable中的数据到Excel文件 , 多个不同的数据结构显示在一个Excel页面中。  
        /// </summary>
        /// <remarks>  
        /// add com "Microsoft Excel 11.0 Object Library"  
        /// using Excel=Microsoft.Office.Interop.Excel;  
        /// using System.Reflection;  
        /// </remarks>  
        /// <param name="dgv">DataTable</param>
        /// <param name="strOutFileName">设定导出的文件名称</param>
        /// <param name="strsHeadName">导出的列的的HeadName, 如果为null,则导出全部列</param>
        /// <returns></returns>
        public static bool SaveDtToExcel(ArrayList aryParam)
        {
            if (aryParam == null || aryParam.Count == 0)
                return false;

            Excel.Application objExcel = null;
            Excel.Workbook objWorkbook = null;
            Excel.Worksheet objsheet = null;

            string fileNameString = "";     //Excel的文件名称。

            int n = 0;          //标明当前是第几个数据结构。 
            int nLine = 1;      //每个数据结构的开始的行数
            int nJG = 5;        //每个数据结构之间 间隔的行数

            foreach (EXCELPARAM param in aryParam)
            {
                DataTable dt = param.dt;
                string strOutFileName = param.strOutFile;
                string[] strsHeadName = param.strsHeadName;
                string[] strsFldName = param.strsFldName;

                int[] nsLineNo = null;

                if (dt.Rows.Count <= 0)
                {
                    MessageBox.Show("没有可以导出的数据！", "提示 ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }

                //处理第一个数据结构。 选择文件名称。
                if (n == 0)
                {

                    #region   验证可操作性

                    //申明保存对话框   
                    SaveFileDialog dlg = new SaveFileDialog();
                    //默然文件后缀   
                    dlg.FileName = strOutFileName;
                    dlg.DefaultExt = "xls ";
                    //文件后缀列表   
                    dlg.Filter = "EXCEL文件(*.XLS)|*.xls ";
                    //默然路径是系统当前路径   
                    dlg.InitialDirectory = Directory.GetCurrentDirectory();
                    //打开保存对话框   
                    if (dlg.ShowDialog() == DialogResult.Cancel)
                        return false;

                    //返回文件路径   
                    fileNameString = dlg.FileName;
                    //验证strFileName是否为空或值无效   
                    if (fileNameString.Trim() == " ")
                        return false;

                    //验证以fileNameString命名的文件是否存在，如果存在删除它   
                    FileInfo file = new FileInfo(fileNameString);
                    if (file.Exists)
                    {
                        try
                        {
                            file.Delete();
                        }
                        catch (Exception error)
                        {
                            MessageBox.Show(error.Message, "删除失败 ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return false;
                        }
                    }

                    //申明对象   
                    objExcel = new Microsoft.Office.Interop.Excel.Application();
                    objWorkbook = objExcel.Workbooks.Add(Missing.Value);
                    objsheet = (Excel.Worksheet)objWorkbook.ActiveSheet;
                    //设置EXCEL不可见   
                    objExcel.Visible = false;

                }


                //定义表格内数据的行数和列数   
                int rowscount = dt.Rows.Count;
                int colscount = dt.Columns.Count;
                //行数必须大于0   
                if (rowscount <= 0)
                {
                    MessageBox.Show("没有数据可供保存 ", "提示 ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }

                //列数必须大于0   
                if (colscount <= 0)
                {
                    MessageBox.Show("没有数据可供保存 ", "提示 ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }

                //行数不可以大于65536   
                if (rowscount > 65536)
                {
                    MessageBox.Show("数据记录数太多(最多不能超过65536条)，不能保存 ", "提示 ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }

                //列数不可以大于255   
                if (colscount > 255)
                {
                    MessageBox.Show("数据记录行数太多，不能保存 ", "提示 ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }


                    #endregion

                #region

                //取得要导出的列的HeadName.
                //如果没有指定特定的列，则默认转换 可见的 并且 有HeadName 的列。（控件列不用导出，控件列一般没有HeadName）
                if (strsHeadName == null)
                {
                    MessageBox.Show("没有指定字段名称！", "提示 ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }

                //取得所有要执行的行，（可能用户并不是要导出所有行，而是通过checkbox选择要导出的行）
                //如果没有指定特定的行，则默认转出全部的行
                if (nsLineNo == null)
                {
                    nsLineNo = new int[dt.Rows.Count];
                    for (int row = 0; row <= dt.Rows.Count - 1; row++)
                    {
                        nsLineNo[row] = row;
                    }
                }

                #endregion


                try
                {
                    //向Excel中写入表格的表头   
                    Excel.Range rag = objsheet.get_Range(objsheet.Cells[nLine, 1], objsheet.Cells[nLine, strsHeadName.Length]);
                    rag.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;

                    int displayColumnsCount = 1;
                    foreach (string strHeadName in strsHeadName)
                    {
                        objExcel.Cells[nLine, displayColumnsCount] = strHeadName;
                        displayColumnsCount++;
                    }

                    //定义每列的数据格式。
                    int nRow1 = nLine + 1, nRow2 = nRow1 + nsLineNo.Length;
                    int nColSel = 1;
                    foreach (string strFldName in strsFldName)
                    {
                        rag = objsheet.get_Range(objsheet.Cells[nRow1, nColSel], objsheet.Cells[nRow2, nColSel]);

                        switch (dt.Columns[strFldName].DataType.ToString())
                        {
                            case "System.String":
                                rag.NumberFormatLocal = "@";
                                break;

                            case "System.DateTime":
                                rag.NumberFormatLocal = "yyyy-MM-dd HH:mm";
                                break;

                            //可以根据自己的需要扩展。

                            default:
                                //rag.NumberFormatLocal = "G/通用格式";
                                break;
                        }

                        nColSel++;
                    }

                    //向Excel中逐行逐列写入表格中的数据   
                    int nCol, row;
                    int nExcelCol, nExcelRow = nLine + 1; //Execl的行列都从1开始起算。第一行是列名，数据从第二行开始写入。

                    for (int i = 0; i <= nsLineNo.Length - 1; i++)
                    {
                        row = nsLineNo[i];
                        nExcelCol = 1;              //Execl的行列都从1开始起算。第一行是列名，数据从第二行开始写入。

                        foreach (string strFldName in strsFldName)
                        {
                            try
                            {
                                objExcel.Cells[nExcelRow, nExcelCol++] = dt.Rows[row][strFldName].ToString().Trim();
                            }
                            catch (Exception)
                            {
                            }
                        }

                        nExcelRow++;
                    }

                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message, "警告 ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                //
                n++;
                nLine += nsLineNo.Length + nJG;
            }


            //保存文件   
            objWorkbook.SaveAs(fileNameString, Missing.Value, Missing.Value, Missing.Value, Missing.Value,
                    Missing.Value, Excel.XlSaveAsAccessMode.xlShared, Missing.Value, Missing.Value, Missing.Value,
                    Missing.Value, Missing.Value);


            //关闭Excel应用   
            if (objWorkbook != null) objWorkbook.Close(Missing.Value, Missing.Value, Missing.Value);
            if (objExcel.Workbooks != null) objExcel.Workbooks.Close();
            if (objExcel != null) objExcel.Quit();

            objsheet = null;
            objWorkbook = null;
            objExcel = null;


            MessageBox.Show(fileNameString + "\n\n导出完毕! ", "提示 ", MessageBoxButtons.OK, MessageBoxIcon.Information);

            return true;
        }
 
    }


    /////////////////////////////////////////////////////////////////////////////////////////////////////////

    public class EXCELPARAM
    {
        public DataTable dt = new DataTable();
        public string strOutFile = "";
        public string[] strsHeadName = null;
        public string[] strsFldName = null;

        public string strDecimalFormat = String.Empty;   //小数点格式。传入String.Empty，默认处理成"0.00"

    }
     
    #region ListViewColumnSorter

    /// <summary>
    /// 继承自IComparer
    /// </summary>
    public class ListViewColumnSorter : IComparer
    {
        static public string DefValueType_String = "String";
        static public string DefValueType_Num = "Number";
        static public string DefValueType_Date = "Date";

        string _strValueType = "String";    //指明要排序的列是什末类型， 属性有 "String","Num".

        /// <summary>
        /// 指定按照哪个列排序
        /// </summary>
        private int ColumnToSort;
        /// <summary>
        /// 指定排序的方式
        /// </summary>
        private SortOrder OrderOfSort;
        /// <summary>
        /// 声明CaseInsensitiveComparer类对象，
        /// 参见ms-help://MS.VSCC.2003/MS.MSDNQTR.2003FEB.2052/cpref/html/frlrfSystemCollectionsCaseInsensitiveComparerClassTopic.htm
        /// </summary>
        private CaseInsensitiveComparer ObjectCompare;

        /// <summary>
        /// 构造函数
        /// </summary>
        public ListViewColumnSorter()
        {
            // 默认按第一列排序
            ColumnToSort = 0;

            // 排序方式为不排序
            OrderOfSort = SortOrder.None;

            // 初始化CaseInsensitiveComparer类对象
            ObjectCompare = new CaseInsensitiveComparer();
        }

        /// <summary>
        /// 重写IComparer接口.
        /// </summary>
        /// <param name="x">要比较的第一个对象</param>
        /// <param name="y">要比较的第二个对象</param>
        /// <returns>比较的结果.如果相等返回0，如果x大于y返回1，如果x小于y返回-1</returns>
        public int Compare( object x, object y )
        {
            int compareResult;
            ListViewItem listviewX, listviewY;

            // 将比较对象转换为ListViewItem对象
            listviewX = (ListViewItem)x;
            listviewY = (ListViewItem)y;

            if ( ColumnToSort < 0 || ColumnToSort >= listviewX.SubItems.Count || ColumnToSort >= listviewY.SubItems.Count )
                return 0;

            // 比较
            if ( _strValueType == DefValueType_Num )
            {
                //double f1 = FF.Fun.MyConvert.Str2Double ( listviewX.SubItems [ ColumnToSort ].Text );
                //double f2 = FF.Fun.MyConvert.Str2Double ( listviewY.SubItems [ ColumnToSort ].Text );

                //也可以用于比较 "1234 USD" 的这种字串
                string str1 = listviewX.SubItems[ ColumnToSort ].Text;
                string str2 = listviewY.SubItems[ ColumnToSort ].Text;

                string[] strs1 = str1.Split( new char[] { ' ' } );
                if ( strs1.Length > 1 )
                    str1 = strs1[ 0 ];

                string[] strs2 = str2.Split( new char[] { ' ' } );
                if ( strs2.Length > 1 )
                    str2 = strs2[ 0 ];

                double f1 = FF.Fun.MyConvert.Str2Double( str1 );
                double f2 = FF.Fun.MyConvert.Str2Double( str2 );

                if ( f1 > f2 )
                    compareResult = 1;
                else if ( f1 == f2 )
                    compareResult = 0;
                else
                    compareResult = -1;
            }
            else if ( _strValueType == DefValueType_Date )
            {
                DateTime d1 = FF.Fun.MyConvert.Str2Date( listviewX.SubItems[ ColumnToSort ].Text );
                DateTime d2 = FF.Fun.MyConvert.Str2Date( listviewY.SubItems[ ColumnToSort ].Text );

                if ( d1 > d2 )
                    compareResult = 1;
                else if ( d1 == d2 )
                    compareResult = 0;
                else
                    compareResult = -1;
            }
            else  //默认的都是用 "Char"文本类型 比较
                compareResult = ObjectCompare.Compare( listviewX.SubItems[ ColumnToSort ].Text, listviewY.SubItems[ ColumnToSort ].Text );

            // 根据上面的比较结果返回正确的比较结果
            if ( OrderOfSort == SortOrder.Ascending )
            {
                // 因为是正序排序，所以直接返回结果
                return compareResult;
            }
            else if ( OrderOfSort == SortOrder.Descending )
            {
                // 如果是反序排序，所以要取负值再返回
                return ( -compareResult );
            }
            else
            {
                // 如果相等返回0
                return 0;
            }
        }

        /// <summary>
        /// 获取或设置按照哪一列排序.
        /// </summary>
        public int SortColumn
        {
            set
            {
                ColumnToSort = value;
            }
            get
            {
                return ColumnToSort;
            }
        }

        /// <summary>
        /// 获取或设置排序方式.
        /// </summary>
        public SortOrder Order
        {
            set
            {
                OrderOfSort = value;
            }
            get
            {
                return OrderOfSort;
            }
        }

        /// <summary>
        /// 要排序的列是什末类型. 比如是 字符串， 数字，等
        /// </summary>
        public string SortValueType
        {
            set
            {
                _strValueType = value;
            }
            get
            {
                return _strValueType;
            }
        }

    }

    #endregion

    #region FLDCOL

    ////处理直接由DataTable来赋值。
    //public class FLDCOL
    //{
    //    //记录每列对应的Table的字段名称， 用于直接从DataTable给List赋值。（一次赋值多行多列）
    //    string [ ] _strColName = null;
    //    string [ ] _strFldName = null;

    //    public bool IsValid ()
    //    {
    //        if ( _strColName == null || _strFldName == null )
    //            return false;

    //        if ( _strColName.Length == 0 || _strFldName.Length == 0 || _strColName.Length != _strFldName.Length )
    //            return false;

    //        return true;
    //    }

    //    public bool Set ( string [] strsCol , string [] strsFld )
    //    {
    //        if ( strsCol.Length != strsFld.Length )
    //            return false;

    //        _strColName = strsCol;
    //        _strFldName = strsFld;

    //        return true;
    //    }

    //    public string GetFldName ( string strColName )  
    //    {
    //        if ( ! IsValid () )
    //            return String.Empty ;

    //        int i = 0;
    //        foreach ( string str in _strColName )
    //        {
    //            if ( str == strColName )
    //            {
    //                if ( i < _strFldName.Length )
    //                    return _strFldName [ i ];
    //            } 
    //            i++;
    //        }
    //        return "";
    //    }

    //    public int GetDefColNum ()
    //    {
    //        if ( !IsValid () )
    //            return 0 ;

    //        return _strColName.Length ;
    //    }

    //}

    #endregion
}
