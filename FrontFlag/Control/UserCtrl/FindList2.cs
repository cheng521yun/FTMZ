using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

using FrontFlag;
using FrontFlag.Control;

namespace FrontFlag.Control
{
    public partial class FindList2 : UserControl
    {
        public NaviPageDlgEx fNavi = new NaviPageDlgEx();

        public delegate void delgDo ( );
        public delegate void delgNoParam ();
        public delegate void delgSendParam ( int nPage );
        public delegate void delgSendParam2 ( int nRow , int nCol );

        public delegate EXCELPARAM delgGetTable ();
        public delegate ArrayList delgGetTableList();

        //只提供Grd的 双击格子, 单击格子里的内容(包括点击格子里的控件) 2种事件相应。
        private delgSendParam2 entDBClickCell = null;
        private delgSendParam2 entClickCellContent = null;
        private delgSendParam2 entClickCell = null;
        private delgSendParam entSelectionChanged = null;

        public delegate void DELG_CellFormating ( DataGridViewCellFormattingEventArgs e );
        private DELG_CellFormating entCellFormatting = null;    //显示ListView的时候即时更改一个Cell的内容。（代替AfterFill的作用）

        //取得全部导出Excel的Table数据。数据是EXCELPARAM param
        private delgGetTable entGetExcelTable = null;
        private delgDo entImportExecl = null ;
        private delgDo entLoadSampleExecl = null;

        //取得全部导出Excel的Table数据。数据是 ArrayList of EXCELPARAM , 用于现在一个Execl页面上显示多个不同结构的数据。
        private delgGetTableList entGetExcelTableList = null;
        
        //翻页后，显示数据。
        private NaviPageDlgEx.entSetNavi entShowPage = null;

        //打印列表
        private delgDo entPrint = null;

        public FindList2 ()
        {
            InitializeComponent ();
            InitNavi (); //Init ();                    //加在这里方式OnLoad()之前 NaviPage窗口被单独显示出来。
        }

        #region 属性

        public bool AllowAddRows
        {
            set { grd.AllowUserToAddRows = value; }
            get { return grd.AllowUserToAddRows; }
        }

        public bool AllowDeleteRows
        {
            set { grd.AllowUserToDeleteRows = value; }
            get { return grd.AllowUserToDeleteRows; }
        }

        public bool AllowMultiSelect
        {
            set { grd.MultiSelect = value; }
            get { return grd.MultiSelect; }
        }

        //public bool AllowSave2Excel
        //{
        //    set { btnSaveExcel.Visible = value; }
        //    get { return btnSaveExcel.Visible; }
        //}

        public bool AllowCheckBoxCol
        {
            set { grd.AllowCheckBoxCol = value; }
            get { return grd.AllowCheckBoxCol; }
        }

        public bool ShowRowHeader
        {
            set { grd.RowHeadersVisible = value; }
            get { return grd.RowHeadersVisible; }
        }

        /// <summary>
        /// 用这个属性赋值后， 点击colHead不会排序。
        /// 如果要实现点击ColHead排序，要用SortBindingList()函数替代此属性赋值。。
        /// </summary>
        public object DataSource
        {
            set { bindSrc.DataSource = value; }
            get { return bindSrc.DataSource; }
        }

        public string Title
        {
            set { labTitle.Text = value; }
            get { return labTitle.Text; }
        }

        /// <summary>
        /// 设置全部翻页的页码数量
        /// </summary>
        public int MaxPage
        {
            set { fNavi.SetMaxPage ( value ) ; }
        }

        /// <summary>
        /// 设置全部的记录个数（全部页面所包含的记录）
        /// </summary>
        public int RecCount
        {
            set { fNavi.SetRecCount(value); }
        }

        public int FindHeight
        {
            set { pnlFind.Height = value; }
            get { return pnlFind.Height; }
        }

        public int DownHeight
        {
            set { pnlDown.Height = value; }
            get { return pnlDown.Height; }
        }

        public int FootHeight
        {
            set { pnlButtom.Height = pnlFoot.Height = value; }
            get { return pnlFoot.Height; }
        }

        public int pnlExternWidth
        {
            set { pnlExtern.Width = value; }
            get { return pnlExtern.Width; }
        }

        /// <summary>
        /// 指明把哪一列作为ID列,同时这一列会隐藏
        /// </summary>
        public string strIDCol
        {
            set
            {
                grd.strIDCol = value;
            }
        }

        public string strSelectID
        {
            get
            {
                string strRet = "";
                //int nNo = grd.nCurRow;   //nCurRow 只有双击的时候才有效。
                int nNo = grd.GetSelectLineNo ();
                if ( nNo >= 0 && nNo < grd.Rows.Count )
                {
                    int nCol = grd.GetColumnIndex_ByHeadText( grd.strIDCol );
                    if ( nCol >= 0 && nCol < grd.Rows [ nNo ].Cells.Count )
                    {
                        if ( grd.Rows [ nNo ].Cells [ nCol ].Value != null )
                            strRet = grd.Rows[nNo].Cells[nCol].Value.ToString().Trim();
                    }
                }

                return strRet;
            }
        }

        /// <summary>
        /// 是否显示全部记录个数。
        /// </summary>
        public bool ShowCountNum
        {
            set { fNavi.ShowCountNum ( value ); }
        }


        #region Delegate

        public XDataGridView.delgRun OnAfterFill
        {
            set { grd.OnAfterFill = value; } 
        }

        public NaviPageDlgEx.entSetNavi OnShowPage
        {
            set
            {
                entShowPage = value;
                fNavi.SetNaviPage += entShowPage;
            }
        }

        public delgSendParam2 OnDBClickCell
        {
            set { entDBClickCell = value; }
        }

        public delgSendParam2 OnClickCellContent
        {
            set { entClickCellContent = value; }
        }

        public delgSendParam2 OnClickCell
        {
            set { entClickCell = value; }
        }

        public delgSendParam OnSelectionChanged
        {
            set { entSelectionChanged = value; }
        }

        //显示ListView的时候即时更改一个Cell的内容。（代替AfterFill的作用）
        public DELG_CellFormating OnCellFormatting
        {
            set { entCellFormatting = value; }
        }

        public delgDo OnPrint
        {
            set
            {
                pnlPrint.Show();
                entPrint = value;
            }
        }

        //设置导出Excel方式是：导出全部符合查询条件的数据（不仅仅是当前页。）
        public delgGetTable OnGetExcelTable
        {
            set
            {
                //ShowExcel = (value == null) ? false : true;

                //splitExcelOut.Visible = true;
                menuExcel_Export.Visible = true;
                entGetExcelTable = value;
            }
        }

        //导入Excel文件
        public delgDo OnImportExecl
        {
            set
            {
                menuExcel_Import.Visible = true;
                entImportExecl = value;
            }
        }

        //从服务器下载Excel文件样本
        public delgDo OnLoadSampleExecl
        {
            set 
            {
                menuExcel_Sample.Visible = true;
                entLoadSampleExecl = value; 
            }
        }

        //设置导出Excel方式是：导出全部符合查询条件的数据（不仅仅是当前页。）多个数据结构显示在一个excel页面中。
        public delgGetTableList OnGetExcelTableList
        {
            set { entGetExcelTableList = value; }
        }

        #endregion

        #region Panel

        public bool ShowSwitchFind 
        {
            set { pnlSwitchFind.Visible = value; }
            get { return pnlSwitchFind.Visible; } 
        }

        public bool ShowMenuBar
        {
            set { pnlMenu.Visible = value; }
            get { return pnlMenu.Visible; }
        }

        public bool ShowExcel 
        {
            set { pnlExcel.Visible = value; }
            get { return pnlExcel.Visible; }
        }

        public bool ShowPrint
        {
            set { pnlPrint.Visible = value; }
            get { return pnlPrint.Visible; }
        }

        public bool ShowNavi
        {
            set { fNavi.Visible = value; }
            get { return fNavi.Visible; }
        }

        public bool ShowButtonPnl
        {
            set { pnlButtom.Visible = value; }
            get { return pnlButtom.Visible; }
        }

        public bool ShowFind
        {
            set { pnlFind.Visible = value; }
            get { return pnlFind.Visible; }
        }

        public bool ShowTitle
        {
            set { pnlTitleBar.Visible = value; }
            get { return pnlTitleBar.Visible; }
        }

        public bool ShowOnlyList
        {
            set
            {
                if ( value )
                {
                    ShowTitle = false;
                    ShowFind = false;
                    ShowButtonPnl = false;
                }
                else
                {
                    ShowTitle = true;
                    ShowFind = true;
                    ShowButtonPnl = true;
                }
            }
        }

        public Color pnlBKColor
        {
            set { pnlTitleBar.BackColor = value; }
        }

        /// <summary>
        /// 面板上Title文字的颜色。
        /// </summary>
        public Color pnlTitleColor
        {
            set { labTitle.ForeColor = value; }
        }

        #endregion

        #endregion

        #region Event

        private void OnLoad( object sender , EventArgs e )
        {
            Init();            //加在这里，是翻页功能才能真正起作用。
        }

        private void DBClickCell( int RowIndex , int ColumnIndex )
        {
            if ( entDBClickCell != null )
                entDBClickCell( RowIndex , ColumnIndex );
        }

        private void ClickCellContent( int RowIndex , int ColumnIndex )
        {
            if ( entClickCellContent != null )
                entClickCellContent( RowIndex , ColumnIndex );
        }

        private void ClickCell( int RowIndex , int ColumnIndex )
        {
            if ( entClickCell != null )
                entClickCell( RowIndex , ColumnIndex );
        }

        private void SelectionChanged( object sender , EventArgs e )
        {
            if ( entSelectionChanged != null )
            {
                int nRow = grd.GetSelectLineNo();
                if ( nRow < 0 )
                    return;

                entSelectionChanged( nRow );
            }
        }

        private void OnClickColumnHeader( object sender , DataGridViewCellMouseEventArgs e )
        {
            int nRow = grd.GetSelectLineNo();
            if ( nRow < 0 )
                return;

            if ( entSelectionChanged != null )
                entSelectionChanged( nRow );
        }

        private void CellFormatting( DataGridViewCellFormattingEventArgs e )
        {
            if ( entCellFormatting != null )
                entCellFormatting( e );
        }

        private void btnShowFindClick( object sender , EventArgs e )
        {
            pnlFind.Visible = !pnlFind.Visible;
        }

        private void OnSizeChange( object sender , EventArgs e )
        {
            SizeChange();
        }

        private void OnbtnSaveExcelClick( object sender , EventArgs e )
        {

        }

        private void btnPrint_Click( object sender , EventArgs e )
        {
            if ( entPrint != null )
                entPrint();
        }

        #region Excel Event

        private void menuExcel_ImportClick( object sender , EventArgs e )
        {
            ImportExcel();
        }

        private void menuExcel_ExportClick( object sender , EventArgs e )
        {
            ExportExcel();
        }

        private void menuExcel_SampleClick( object sender , EventArgs e )
        {
            LoadSample();
        }

        private void btnExcelClick( object sender , EventArgs e )
        {
            btnExcel.ContextMenuStrip.Show( btnExcel , new Point( 0 , btnExcel.Size.Height ) );
        }

        #endregion

        #endregion

        #region Public

        public void Refresh ()
        {
            grd.Bind ( bindSrc );

            //grd.DataSource = bindSrc;
            //grd.Refresh ();

            //if ( OnAfterFill != null )
            //    OnAfterFill ();
        }

        public bool Save2Excel ()
        {
            //if (entGetExcelTable == null )
            //{
            //    return grd.Save2Excel ();   //只导出当前页。
            //}

            if (entGetExcelTable != null)
            {
                //导出全部DataTable数据
                EXCELPARAM param = entGetExcelTable();
                if (param == null)
                    return false;

                return GRID2EXCEL.SaveDtToExcel( param.dt, param.strOutFile, param.strsHeadName, param.strsFldName, param.strDecimalFormat );
            }
            else if (entGetExcelTableList != null)
            {
                //导出全部DataTable数据
                ArrayList aryParam = entGetExcelTableList();
                return GRID2EXCEL.SaveDtToExcel( aryParam );  //多个不同的数据结构显示在一个Excel页面中。
            }
            else
            {
                return grd.Save2Excel();   //只导出当前页。
            }
        }

        public void AddExternPnl ( ref Form fExtern )
        {
            fExtern.TopLevel = false;
            fExtern.Parent = pnlExtern;
            fExtern.Dock = DockStyle.Fill;
            fExtern.Show ();
            pnlExtern.Width = fExtern.Width;
            pnlExtern.Show();
        }

        public void AddExternPnl ( ref Form fExtern , int W )
        {
            AddExternPnl(ref fExtern);
            pnlExternWidth = W;
        }

        public void AddMenuPnl(ref Form fMenu)
        {
            fMenu.TopLevel = false;
            fMenu.Parent = pnlMenu;
            fMenu.Dock = DockStyle.Fill;
            fMenu.Show();
        }

        public void AddFindPnl ( ref Form fFind )
        {
            fFind.TopLevel = false;
            fFind.Parent = pnlFind;
            fFind.Dock = DockStyle.Fill;
            fFind.Show ();
        }

        public void AddDownPnl ( ref Form fDown )
        {
            fDown.TopLevel = false;
            fDown.Parent = pnlDown;
            fDown.Dock = DockStyle.Fill;
            fDown.Show ();

            splt.Show ();
            pnlDown.Height = fDown.Height;
            pnlDown.Show ();
        }

        public void AddFootPnl ( ref Form fFoot )
        {
            fFoot.TopLevel = false;
            fFoot.Parent = pnlFoot;
            fFoot.Dock = DockStyle.Fill;
            fFoot.Show ();
        }

        /// <summary>
        /// 让 ListView 显示 List 数据。不排序。
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="list"></param>
        public void BindingList<T> ( System.Collections.Generic.IList<T> list )
        {
            bindSrc.DataSource = new BindingList<T> ( list );
        }

        //声明一个委托
        delegate void delgtSortBindingList<T> ( System.Collections.Generic.IList<T> list );
        /// <summary>
        /// 用这个函数 替代 fl.DataSource = new BindingList<T> ( _lst ) 可以实现点击ColHead排序。
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="list"></param>
        public void SortBindingList<T> ( System.Collections.Generic.IList<T> list )
        {
            if (list == null)
            {
                grd.Rows.Clear();
                return;
            }

            bindSrc.DataSource = new SortBindingList2<T> ( list );
        }

        #region 选择

        public object GetSelected(int nRow)
        {
            if ( nRow < 0 || nRow >= grd.Rows.Count )
                return null;

            return grd.Rows[nRow].DataBoundItem;
        }

        #endregion

        #endregion

        #region Line

        ///// <summary>
        ///// 返回选择的行的序号。
        ///// 如果幼多个选择，返回最小号（最上）的行序号。
        ///// 如果允许打钩选择，返回最上的打钩行序号。
        ///// </summary>
        ///// <returns>-1=没有选中的行</returns>
        //public int GetSelectLineNo ()
        //{
        //    DEBUG d = new DEBUG ();

        //    int nSel = -1;

        //    if ( AllowMultiSelect )
        //    {
        //        int [] nSels = grd.GetSelectCheckBoxLine() ;

        //        //如果有多个打钩，选第一个打钩的行。
        //        if ( nSels.Length > 0 )
        //        {
        //            nSel = nSels [0];
        //        }
        //        else  //没有选择任何打钩， 则查看有无光标选择行。
        //        {
        //            //光标有选择行
        //            if ( grd.SelectedRows.Count > 0 )
        //            {
        //                nSel = grd.SelectedRows [0].Index;
        //            }
        //        }
        //    }
        //    else  //不允许打钩
        //    {
        //        //光标有选择行
        //        if ( grd.SelectedRows.Count > 0 )
        //        {
        //            nSel = grd.SelectedRows [0].Index;
        //        }
        //    }

        //    return nSel;
        //}

        #endregion

        #region Cell

        public bool ExistCell ( int nRow , int nCol )
        {
            if ( nRow < 0 || nRow >= grd.Rows.Count || nCol < 0 || nCol >= grd.Columns.Count )
                return false;

            return true;
        }

        public string GetCellText ( int nRow , int nCol )
        {
            if ( nRow < 0 || nRow >= grd.Rows.Count || nCol < 0 || nCol >= grd.Columns.Count )
                return "";

            return grd.Rows [ nRow ].Cells [ nCol ].Value.ToString ();
        }

        #endregion

        #region DataGridView 设置

        #region new set col head
        
        public bool SetGrdFld ( FrontFlag.Control.ColumnType [] colType , string [] strHead , string [] strData )
        {
            return grd.SetGrdFld ( colType , strHead , strData );
        }

        public bool SetGrdFld ( string [] strsHead , string [] strsData )
        {
            return grd.SetGrdFld ( strsHead , strsData );
        }

        public void SetGrdFld(COLHEAD[] ColHeads)
        {
            grd.SetGrdFld(ColHeads);
        }

        public bool SetColW ( int [] nColsW )
        {
            return grd.SetColW ( nColsW );
        }

        #endregion

        #region Column

        public DataGridViewColumn GetColumn ( string strColName )
        {
            return grd.Columns [ strColName ];
        }

        public int GetColumnIndex_ByHeadText ( string strHeadText )
        {
            DataGridViewColumn col = grd.GetColumn_ByHeadText ( strHeadText ) ;
            if ( col == null )
                return -1 ;
            return col.Index;
        }

        public int GetColumnIndex_ByName ( string strColName )
        {
            DataGridViewColumn col = grd.GetColumn_ByName ( strColName ) ;
            if ( col == null )
                return -1 ;
            return col.Index;
        }

        public void ShowColumn_ByHeadText ( string strHeadText , bool bFlag )
        {
            grd.ShowColumn_ByHeadText ( strHeadText , bFlag );
        }
        
        public void ShowColumn_ByName ( string strColName , bool bFlag )
        {
            grd.ShowColumn_ByName ( strColName , bFlag );
        }

        public void ShowColumnSwitch_ByHeadText ( string strHeadText )
        {
            grd.ShowColumnSwitch_ByHeadText ( strHeadText );
        }

        public void ShowColumnSwitch_ByName ( string strColName )
        {
            grd.ShowColumnSwitch_ByName ( strColName );
        }

        #endregion 

        public void ClearSelect ()
        {
            grd.ClearSelection ();
        }

        public void SetRowColor ( DataGridViewRow Row , Color clrFore , Color clrBack )
        {
            if ( Row == null )
                return;

            Row.DefaultCellStyle.ForeColor = clrFore;
            Row.DefaultCellStyle.BackColor = clrBack;
        }

        public void SetRowColor ( int nLine , Color clrFore , Color clrBack )
        {
            if ( nLine < 0 || nLine >= grd.RowCount )
                return;

            grd.Rows [ nLine ].DefaultCellStyle.ForeColor = clrFore;
            grd.Rows [ nLine ].DefaultCellStyle.BackColor = clrBack;
        }

        public void SetRowBKColor ( DataGridViewRow Row , Color clrBack )
        {
            if ( Row == null )
                return;

            Row.DefaultCellStyle.BackColor = clrBack;
        }

        public void SetRowBKColor ( int nLine , Color clrBack )
        {
            if ( nLine < 0 || nLine >= grd.RowCount )
                return;

            grd.Rows [ nLine ].DefaultCellStyle.BackColor = clrBack;
        }

        public void SetColColor ( int nCol , Color clrFore , Color clrBack )
        {
            if ( nCol < 0 || nCol >= grd.ColumnCount )
                return;

            grd.Columns [ nCol ].DefaultCellStyle.ForeColor = clrFore;
            grd.Columns [ nCol ].DefaultCellStyle.BackColor = clrBack;
        }

        public void SetColBKColor ( int nCol , Color clrBack )
        {
            if ( nCol < 0 || nCol >= grd.ColumnCount )
                return;

            grd.Columns [ nCol ].DefaultCellStyle.BackColor = clrBack;
        }

        public void SetColReadOnly ( int nCol , bool bFlag )
        {
            if ( nCol < 0 || nCol >= grd.ColumnCount )
                return;

            grd.Columns [ nCol ].ReadOnly = bFlag;
        }


        #endregion

        #region Private

        void InitNavi ()
        {
            fNavi.TopLevel = false;
            fNavi.Parent = this.pnlButtom;
            fNavi.Show ();
            fNavi.SetBKColor ( pnlButtom.BackColor );
        }

        void Init ()
        {
            //fNavi.TopLevel = false;
            //fNavi.Parent = this.pnlButtom;
            //fNavi.Show ();
            //fNavi.SetNaviPage += entShowPage;
            //fNavi.SetBKColor ( pnlButtom.BackColor );

            splt.Hide();
            pnlDown.Hide ();

            grd.delgDBClickCell += DBClickCell ;
            grd.delgClickCellContent += ClickCellContent ;
            grd.delgClickCell += ClickCell;
            grd.SelectionChanged += SelectionChanged;
            grd.delgCellFormatting = CellFormatting;
            grd.ColumnHeaderMouseClick += OnClickColumnHeader ;
        }

        DataGridViewColumn CreateColumn ( FrontFlag.Control.ColumnType colType )
        {
            DataGridViewColumn col = null;

            if ( colType == ColumnType.Text )
                col = new DataGridViewTextBoxColumn ();

            else if ( colType == ColumnType.Button )
                col = new DataGridViewButtonColumn ();

            else if ( colType == ColumnType.CheckBox )
                col = new DataGridViewCheckBoxColumn ();

            else if ( colType == ColumnType.Combox )
                col = new DataGridViewComboBoxColumn ();

            else if ( colType == ColumnType.Image )
                col = new DataGridViewImageColumn ();

            else if ( colType == ColumnType.Link )
                col = new DataGridViewLinkColumn ();

            return col;
        }

        void SizeChange ()
        {
            int X , Y , W , H;

            //fNavi
            W = pnlButtom.Width;
            X = W - 0 - fNavi.Width;
            Y = ( pnlButtom.Height - fNavi.Height ) / 2 ;
            fNavi.Location = new Point ( X, Y );

            //fFoot  //放在fNavi左面剩下的部分。
            pnlFoot.Width = W - fNavi.Width;
        }

        #endregion

        #region Export & Impoet Excel

        void ImportExcel ()
        {
            if ( entImportExecl != null )
                entImportExecl();
        }

        void LoadSample()
        {
            if (entLoadSampleExecl != null)
                entLoadSampleExecl();
        }

        public void ExportExcel ()
        {
            Save2Excel ();
        }

        #endregion

    }

    /// <summary>
    /// Provides a generic collection that supports data binding and additionally supports sorting.
    /// See http://msdn.microsoft.com/en-us/library/ms993236.aspx
    /// If the elements are IComparable it uses that; otherwise compares the ToString()
    /// </summary>
    /// <typeparam name="T">The type of elements in the list.</typeparam>
    public class SortBindingList2<T> : BindingList<T>
    {
        private bool _isSorted;
        private ListSortDirection _sortDirection = ListSortDirection.Ascending;
        private PropertyDescriptor _sortProperty;

        //public SortableBindingList ()
        //{

        //}

        public SortBindingList2 ( System.Collections.Generic.IList<T> list )
        {
            int n = 0;
            foreach ( T t in list )
            {
                InsertItem ( n++, t );
            }
        }

        /// <summary>
        /// Gets a value indicating whether the list supports sorting.
        /// </summary>
        protected override bool SupportsSortingCore
        {
            get { return true; }
        }

        /// <summary>
        /// Gets a value indicating whether the list is sorted.
        /// </summary>
        protected override bool IsSortedCore
        {
            get { return _isSorted; }
        }

        /// <summary>
        /// Gets the direction the list is sorted.
        /// </summary>
        protected override ListSortDirection SortDirectionCore
        {
            get { return _sortDirection; }
        }

        /// <summary>
        /// Gets the property descriptor that is used for sorting the list if sorting is implemented in a derived class; otherwise, returns null
        /// </summary>
        protected override PropertyDescriptor SortPropertyCore
        {
            get { return _sortProperty; }
        }

        /// <summary>
        /// Removes any sort applied with ApplySortCore if sorting is implemented
        /// </summary>
        protected override void RemoveSortCore ()
        {
            _sortDirection = ListSortDirection.Ascending;
            _sortProperty = null;
        }

        /// <summary>
        /// Sorts the items if overridden in a derived class
        /// </summary>
        /// <param name="prop"></param>
        /// <param name="direction"></param>
        protected override void ApplySortCore ( PropertyDescriptor prop, ListSortDirection direction )
        {
            _sortProperty = prop;
            _sortDirection = direction;

            if ( _sortProperty == null ) return; //nothing to sort on
            List<T> list = Items as List<T>;
            if ( list == null ) return;

            list.Sort ( delegate ( T lhs, T rhs )
            {
                object lhsValue = lhs == null ? null : _sortProperty.GetValue ( lhs );
                object rhsValue = rhs == null ? null : _sortProperty.GetValue ( rhs );
                int result = 0;
                if ( lhsValue == null )
                {
                    result = -1;
                }
                else if ( rhsValue == null )
                {
                    result = 1;
                }
                else
                {
                    if ( lhsValue is IComparable )
                    {
                        result = ( (IComparable) lhsValue ).CompareTo ( rhsValue );
                    }
                    else if ( !lhsValue.Equals ( rhsValue ) )//not comparable, compare ToString
                    {
                        result = lhsValue.ToString ().CompareTo ( rhsValue.ToString () );
                    }
                }
                if ( _sortDirection == ListSortDirection.Descending )
                    result = -result;
                return result;
            } );

            _isSorted = true;
            //fire an event that the list has been changed.
            OnListChanged ( new ListChangedEventArgs ( ListChangedType.Reset, -1 ) );
        }
    }

}
