using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using System.Data;

namespace FrontFlag.Control
{
    public partial class XDataGridView : System.Windows.Forms.DataGridView  
    {
        public delegate void delgRun ();
        public delegate void DELG_NoParam ();
        public delegate void DELG_SendRowParam ( int nRow );
        public delegate void DELG_SendCellParam ( int nRow , int nCol );

        public DELG_SendCellParam delgDBClickCell = null;       //双击cell产生的事件。
        public DELG_SendCellParam delgClickCellContent = null;  //点击格子中内容上才起作用。比如:对于一个TextBox的Cell,点在文字上也产生事件，点在文字后面的空白处，就没有ClickCellContent事件（同理，点击空白格子就没此事件）， 但有ClickCell事件。
        public DELG_SendCellParam delgClickCell = null;
        public DELG_SendRowParam delgSelectionChanged = null;

        public delegate void DELG_CellFormating(DataGridViewCellFormattingEventArgs e);
        public DELG_CellFormating delgCellFormatting = null;    //显示ListView的时候即时更改一个Cell的内容。（代替AfterFill的作用） 

        //完成填充Grd之后，立即要做的工作。比如：按条件更改Row底色之类...
        public delgRun OnAfterFill = null;

        //最左侧是否有CheckBox列，来用于选择行。
        bool _HaveSelectedCheckBox = false;

        string _strXmlFile = "";                        //保存列宽度的文件名称。
        string _strListName = "";                       //每个列表需要在XML文件中有自己的唯一的名称。
        private bool _bAllowSaveFldWidth = false ;              //true=可以自动保存用户调整过的列宽。

        private string _strColID = "";                  //指明把哪一列作为ID列
        private int _nCurRow = -1;                      //当先双击或则选中的列。

        public XDataGridView ()
        {
            InitializeComponent ();
            Init ();
        }

        public XDataGridView ( IContainer container )
        {
            container.Add ( this );

            InitializeComponent ();
            Init ();
        }

        void Init ()
        {
            AutoGenerateColumns = false;

            MouseDown += new System.Windows.Forms.MouseEventHandler ( this.OnMouseDown );
            CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler ( this.OnCellDBClick );
            CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler ( this.OnCellContentClick );
            CellClick += new System.Windows.Forms.DataGridViewCellEventHandler ( this.OnCellClick );
            ColumnHeaderMouseClick += new DataGridViewCellMouseEventHandler ( OnClickColumnHeader );  //作废。列表排序不在这里实现。而是在 FindList 类中，通过 fl.SortBindingList() 来实现。DataGridView类自身自带了排序功能，只需要传入有排序属性的数据就可以了。
            CellFormatting += new DataGridViewCellFormattingEventHandler(OnCellFormatting); //在显示数据的同时，对Cell里的数据/颜色/字体等进行处理。不必再使用AfterFill()之类的函数了。
            
            ClearContextMenu () ;

            //ListViewColumnSorter sortHelper = new ListViewColumnSorter();
            //Sort( sortHelper );
        }

        #region 属性

        public int LineHight
        {
            set { RowTemplate.Height = value; }
            get { return RowTemplate.Height; }
        }

        public int LineTextSize
        {
            set
            {
                DefaultCellStyle.Font = new Font ( DefaultCellStyle.Font.Name, value, GraphicsUnit.Pixel );
            }
        }

        public bool AllowAddRows
        {
            set { AllowUserToAddRows = value; }
            get { return AllowUserToAddRows; }
        }

        public bool AllowDeleteRows
        {
            set { AllowUserToDeleteRows = value; }
            get { return AllowUserToDeleteRows; }
        }

        public bool AllowMultiSelect
        {
            set { MultiSelect = value; }
            get { return MultiSelect; }
        }

        public bool ShowRowHeader
        {
            set { RowHeadersVisible = value; }
            get { return RowHeadersVisible; }
        }

        public bool AllowCheckBoxCol
        {
            set
            {
                AddSelectCheckBox ( value );
            }
            get
            {
                return _HaveSelectedCheckBox ;
            }
        }

        //void SetSortMode ()
        //{
        //    foreach ( DataGridViewColumn Column in Columns )
        //        Column.SortMode = DataGridViewColumnSortMode.Automatic; 
        //}

        /// <summary>
        /// 指明把哪一列作为ID列,同时这一列会隐藏
        /// </summary>
        public string strIDCol
        {
            set
            {
                _strColID = value;
                ShowColumn_ByHeadText ( value, false );
            }

            get
            {
                return _strColID;
            }
        }

        public int nCurRow
        {
            get { return _nCurRow; }
        }

        #endregion

        #region Event

        private void OnCellDBClick( object sender , DataGridViewCellEventArgs e )
        {
            _nCurRow = e.RowIndex;

            if ( delgDBClickCell != null )
                delgDBClickCell( e.RowIndex , e.ColumnIndex );
        }

        private void OnMouseDown( object sender , MouseEventArgs e )
        {
            HitTestInfo hti = HitTest( e.X , e.Y );
            if ( hti.Type == DataGridViewHitTestType.ColumnHeader )
            {
                //点击在checkBox列上面
                if ( _HaveSelectedCheckBox && hti.ColumnIndex == 0 )
                {
                    ContextMenuStrip = menuSelectCheck;
                    ContextMenuStrip.Show( PointToScreen( new Point( e.X , e.Y ) ) );
                }
            }
            else if ( hti.Type == DataGridViewHitTestType.None )
            {
                ClearSelect();
            }
        }

        private void OnCellContentClick( object sender , DataGridViewCellEventArgs e )
        {
            if ( delgClickCellContent != null )
                delgClickCellContent( e.RowIndex , e.ColumnIndex );
        }

        private void OnCellClick( object sender , DataGridViewCellEventArgs e )
        {
            if ( delgClickCell != null )
                delgClickCell( e.RowIndex , e.ColumnIndex );
        }

        void OnCellFormatting( object sender , DataGridViewCellFormattingEventArgs e )
        {
            if ( delgCellFormatting != null )
                delgCellFormatting( e );
        }

        private void OnClickmenuSelectAll( object sender , EventArgs e )
        {
            SelectAllCheckBox();
            ClearContextMenu();

            //通知父窗口，更新grd处理，-1 标示没有点击在任何行内。
            if ( delgClickCellContent != null )
                delgClickCellContent( -1 , 0 );
        }

        private void OnClickmenuUnSelectAll( object sender , EventArgs e )
        {
            UnSelectAllCheckBox();
            ClearContextMenu();

            //通知父窗口，更新grd处理，-1 标示没有点击在任何行内。
            if ( delgClickCellContent != null )
                delgClickCellContent( -1 , 0 );
        }

        private void OnClickmenuReverse( object sender , EventArgs e )
        {
            ReverseSelectCheckBox();
            ClearContextMenu();

            //通知父窗口，更新grd处理，-1 标示没有点击在任何行内。
            if ( delgClickCellContent != null )
                delgClickCellContent( -1 , 0 );
        }

        #endregion

        #region Status

        /// <summary>
        /// 整个GridView不可更改内容。
        /// </summary>
        public void SetLock ()
        {
            foreach ( DataGridViewRow row in Rows )
            {
                foreach ( DataGridViewCell cell in row.Cells )
                {
                    cell.ReadOnly = true;
                }
            }
        }

        #endregion

        #region 设置列表头

        public bool SetGrdFld ( ColumnType [] colsType , string [] strsHead , string [] strsData )
        {
            //if ( Columns == null || Columns.Count == 0 )  //20100506, 用这句会导致不显示Col栏。
            if (Columns == null)
                return false;

            if (Columns.Count > 0)
                Columns.Clear ();

            _HaveSelectedCheckBox = false;    //Columns 都Clear了, checkbox选择列当然也没有了

            if ( strsHead.Length <= 0 || colsType.Length != strsHead.Length || strsHead.Length != strsData.Length )
            {
                FF.Ctrl.MsgBox.ShowWarn ( "SetGrdFld() Have not same item count!" );
                return false;
            }

            int nCount = strsHead.Length;

            string strHead , strContent;
            DataGridViewColumn [] Column = new DataGridViewColumn [ nCount ];
            for ( int i = 0 ; i < nCount ; i++ )
            {
                Column [ i ] = CreateColumn ( colsType [ i ] );

                Column [ i ].HeaderText = strsHead [ i ];
                Column [ i ].Name = strsHead [ i ];
                Column [ i ].DataPropertyName = strsData [ i ];
                Column [ i ].ReadOnly = true;

                if ( colsType [ i ] == ColumnType.Button )
                    SetCellButton ( Column [ i ] , strsHead [ i ] );
                
                else if ( colsType [ i ] == ColumnType.CheckBox )
                    SetCellCheckBox ( Column [ i ] , strsHead [ i ] );

                else if ( colsType [i] == ColumnType.Combox )
                    SetCellCombox ( Column [i] , strsHead [i] );

                else if ( colsType [i] == ColumnType.Image )
                    SetCellImage ( Column [i] , strsHead [i] );

                else if ( colsType [i] == ColumnType.Link )
                    SetCellLink ( Column [i] , strsHead [i] );
            }

            Columns.AddRange ( Column );

            //
            //SetSortMode () ;

            return true;
        }

        public bool SetGrdFld ( string [] strsHead , string [] strsData )
        {
            if ( strsHead.Length <= 0 || strsHead.Length != strsData.Length )
            {
                FF.Ctrl.MsgBox.ShowWarn ( "SetGrdFld() Have not same item count!" );
                return false;
            }

            //默认col都是Text类型的。
            int nCount = strsHead.Length;
            ColumnType [] colsType = new ColumnType [ nCount ];
            for ( int i = 0 ; i < nCount ; i++ )
            {
                colsType [ i ] = ColumnType.Text;
            }

            //
            return SetGrdFld ( colsType , strsHead , strsData );
        }

        public bool SetGrdFld ( COLHEAD [] ColHeads )
        {
            if ( ColHeads == null || ColHeads.Length <= 0 )
                return false;

            if ( Columns.Count > 0 )
                Columns.Clear ();

            _HaveSelectedCheckBox = false;    //Columns 都Clear了, checkbox选择列当然也没有了

            int nCount = ColHeads.Length;

            string strHead, strContent;
            DataGridViewColumn [] Column = new DataGridViewColumn [ nCount ];

            ColumnType type;
            string strHeadText, strFldName;
            object objTag;

            int nSumW = 0;
            List<int> lstFillCol = new List<int>(); 
            int nWidth;

            for ( int i = 0 ; i < nCount ; i++ )
            {
                type = ColHeads [ i ].Type;
                strHeadText = ColHeads[i].HeadText;
                strFldName = ColHeads[i].FldName;
                nWidth = ColHeads[i].HeadWidth;
                objTag = ColHeads[i].Tag ;

                //nWidth =-1 表示此列是自适应宽度
                if (nWidth >= 0)
                {
                    nSumW += nWidth;
                }
                else
                {
                    lstFillCol.Add(i);
                }

                Column [ i ] = CreateColumn ( type );

                Column [ i ].HeaderText = strHeadText;
                Column [ i ].Name = ColHeads [ i ].HeadText;
                Column [ i ].DataPropertyName = strFldName;
                Column [ i ].ReadOnly = true;
                Column [ i ].Width = nWidth;
                Column[i].Tag = objTag;

                if ( type == ColumnType.Button )
                    SetCellButton ( Column [ i ], strHeadText );

                else if ( type == ColumnType.CheckBox )
                    SetCellCheckBox ( Column [ i ], strHeadText );

                else if ( type == ColumnType.Combox )
                    SetCellCombox ( Column [ i ], strHeadText );

                else if ( type == ColumnType.Image )
                    SetCellImage ( Column [ i ], strHeadText );

                else if ( type == ColumnType.Link )
                    SetCellLink ( Column [ i ], strHeadText );
            }

            Columns.AddRange ( Column );

            //
            int nNum = lstFillCol.Count;
            if ( nNum <= 0 )
                return true;

            int W = ( ( this.Width - nSumW ) / nNum)  - 1;  //-1消除整数除法的误差  
            foreach ( int nCol in lstFillCol )
            {
                Columns[nCol].Width = W;
            }

            return true;
        }

        #endregion

        #region Column

        public bool SetColW ( int [] nColW )
        {
            if ( Columns.Count <= 0 || Columns.Count != nColW.Length )
                return false;

            int i = 0;
            foreach ( DataGridViewColumn Column in Columns )
            {
                Column.Width = nColW [ i++ ];
            }

            return true;
        }

        public void SetColW( int nCol ,int nColW )
        {
            if ( nCol < 0 && nCol >= Columns.Count )
                return;
            
            DataGridViewColumn col = Columns[nCol];
            col.Width = nColW;
        }

        public void SetColW( string strHeadText, int nColW )
        {
            DataGridViewColumn col = GetColumn_ByHeadText( strHeadText );
            if ( col == null )
                return;

            col.Width = nColW;
        }

        public DataGridViewColumn GetColumn_ByHeadText ( string strHeaderText )
        {
            foreach ( DataGridViewColumn col in Columns )
            {
                if ( col.HeaderText == strHeaderText )
                    return col;
            }

            return null;
        }

        public DataGridViewColumn GetColumn_ByName ( string strColName )
        {
            foreach ( DataGridViewColumn col in Columns )
            {
                if ( col.Name == strColName )
                    return col;
            }

            return null;
        }

        public int GetColumnIndex_ByHeadText ( string strHeaderText )
        {
            DataGridViewColumn col = GetColumn_ByHeadText ( strHeaderText );
            if ( col == null )
                return -1;
            return GetColumn_ByHeadText ( strHeaderText ).Index;
        }

        public int GetColumnIndex_ByName ( string strName )
        {
            DataGridViewColumn col = GetColumn_ByName ( strName );
            if ( col == null )
                return -1;
            return GetColumn_ByName ( strName ).Index;
        }

        public void ShowColumn_ByHeadText ( string strHeadText , bool bFlag )
        {
            DataGridViewColumn col = GetColumn_ByHeadText ( strHeadText );
            if ( col != null )
                col.Visible = bFlag;
        }

        public void ShowColumn_ByName ( string strName , bool bFlag )
        {
            DataGridViewColumn col = GetColumn_ByName ( strName );
            if ( col != null )
                col.Visible = bFlag;
        }

        public void ShowColumn_ByColNo(int nCol, bool bFlag)
        {
            if (nCol < 0 || nCol >= Columns.Count)
                return;

            DataGridViewColumn col = Columns[nCol];
            if (col != null)
                col.Visible = bFlag;
        }

        public void ShowColumnSwitch_ByHeadText ( string strHeadText )
        {
            DataGridViewColumn col = GetColumn_ByHeadText ( strHeadText );
            if ( col != null )
                col.Visible = !col.Visible;
        }

        public void ShowColumnSwitch_ByName ( string strName )
        {
            DataGridViewColumn col = GetColumn_ByName ( strName );
            if ( col != null )
                col.Visible = !col.Visible;
        }

        /// <summary>
        /// 指定某列的Cell文字对齐方式。
        /// </summary>
        /// <param name="strHeadText"></param>
        /// <param name="strAlign"></param>
        public void SetColumnAlign(string strHeadText, string strAlign )
        {
            DataGridViewColumn col = GetColumn_ByHeadText(strHeadText);
            if (col == null)
                return;

            if (strAlign == "Left")
                col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            else if (strAlign == "Right")
                col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            else if (strAlign == "Center")
                col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        /// <summary>
        /// 指定所有列的Cell文字对齐方式。
        /// </summary>
        /// <param name="strHeadText"></param>
        /// <param name="strAlign"></param>
        public void SetAllColumnAlign(string strAlign)
        {
            if (strAlign == "Left")
                DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            else if (strAlign == "Right")
                DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            else if (strAlign == "Center")
                DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        /// <summary>
        /// 全部的Header的文字对齐方式。
        /// </summary>
        /// <param name="strAlign"></param>
        public void SetHeadAlign(string strAlign)
        {
            if (strAlign == "Left")
                ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            else if (strAlign == "Right")
                ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            else if (strAlign == "Center")
                ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        public void SetColumnHeadText_ByColNo(int nCol, string strColHeadText)
        {
            if (nCol < 0 || nCol >= Columns.Count)
                return;

            DataGridViewColumn col = Columns[nCol];
                    col.HeaderText = strColHeadText;

            return ;
        }

        public void SetColumnHeadText_ByName(string strColName, string strColHeadText)
        {
            foreach (DataGridViewColumn col in Columns)
            {
                if (col.Name == strColName)
                {
                    col.HeaderText = strColHeadText;
                }
            }

            return;
        }

        public DataGridViewColumn FinColumnByTag( string strTag )
        {
            foreach ( DataGridViewColumn col in Columns )
            {
                if ( strTag == col.Tag as string )
                    return col;
            }

            return null;
        }

        #endregion

        #region Cell

        public string GetCellText( int nRow , int nCol )
        {
            if (nRow < 0 || nRow >= Rows.Count)
                return "";

            if (nCol < 0 || nCol >= Columns.Count)
                return "";

            return Rows[nRow].Cells[nCol].Value.ToString().Trim();
        }

        public string GetCellText(int nRow, string strColName)
        {
            int nCol = GetColumnIndex_ByName(strColName);
            return GetCellText(nRow, nCol);
        }

        #endregion

        #region Color

        public void SetRowColor ( int nLine , Color clrFore , Color clrBack )
        {
            if ( nLine < 0 || nLine >= RowCount )
                return;

            Rows [ nLine ].DefaultCellStyle.ForeColor = clrFore;
            Rows [ nLine ].DefaultCellStyle.BackColor = clrBack;
        }

        public void SetRowBKColor ( int nLine , Color clrBack )
        {
            if ( nLine < 0 || nLine >= RowCount )
                return;

            Rows [ nLine ].DefaultCellStyle.BackColor = clrBack;
        }

        public void SetColColor ( int nCol , Color clrFore , Color clrBack )
        {
            if ( nCol < 0 || nCol >= ColumnCount )
                return;

            Columns [ nCol ].DefaultCellStyle.ForeColor = clrFore;
            Columns [ nCol ].DefaultCellStyle.BackColor = clrBack;
        }

        public void SetColBKColor ( int nCol , Color clrBack )
        {
            if ( nCol < 0 || nCol >= ColumnCount )
                return;

            Columns [ nCol ].DefaultCellStyle.BackColor = clrBack;
        }

        public void SetColReadOnly ( int nCol , bool bFlag )
        {
            if ( nCol < 0 || nCol >= ColumnCount )
                return;

            Columns [ nCol ].ReadOnly = bFlag;
        }

        #endregion

        #region Bind

        public void Bind ( BindingSource bindSrc )
        {
            DataSource = bindSrc;
            Refresh ();

            if ( OnAfterFill != null )
                OnAfterFill ();
        }

        public void Bind ( ref DataTable dt )
        {
            DataSource = dt;
            Refresh ();

            if ( OnAfterFill != null )
                OnAfterFill ();
        }

        public void Bind ( ref List<object> list )
        {
            DataSource = list;
            Refresh ();

            if ( OnAfterFill != null )
                OnAfterFill ();
        }

        #endregion

        #region Excel

        public bool Save2Excel ()
        {
            //有checknox列的，只导出那些被选择的行
            if ( _HaveSelectedCheckBox )
            {
                GRID2EXCEL Excel = new GRID2EXCEL ();
                return Excel.SaveToExcel ( this , GetSelectCheckBoxLine () );
            }
            else
                return SaveAll2Excel ();
        }

        //public bool Save2Excel (  )
        //{
        //    //有checknox列的，只导出那些被选择的行
        //    if ( _HaveSelectedCheckBox )
        //    {
        //        return GRID2EXCEL.SaveToExcel ( this , GetSelectCheckBoxLine () );
        //    }
        //    else
        //        return SaveAll2Excel ();
        //}

        public bool SaveAll2Excel ()
        {
            GRID2EXCEL Excel = new GRID2EXCEL ();
            return Excel.SaveToExcel ( this );
        }

        #endregion

        #region  Public 获取选择了哪一行数据。

        public void ClearSelect ()
        {
            ClearSelection ();
        }

        /// <summary>
        /// 得到 最左侧checkbox列，选择的行号。
        /// </summary>
        /// <returns></returns>
        public int [] GetSelectCheckBoxLine ()
        {
            if ( !_HaveSelectedCheckBox )
                return null ;

            //即时更新选项。让真实数据与界面显示同步。
            UpdateEdit ();

            //
            ArrayList ary = new ArrayList () ;

            foreach ( DataGridViewRow row in Rows )
            {
                if ( row.Cells [ 0 ].Value != null && (bool) row.Cells [ 0 ].Value )  //当checkbox刚刚初始化，从没有被点击选择的时候，value=null.
                    ary.Add ( row.Index );
            }

            if ( ary == null || ary.Count <= 0 )
                return null ;

            int [] nsLine = new int [ ary.Count ] ;
            
            int i = 0 ;
            foreach ( int n in ary )
            {
                nsLine [ i ++ ] = n ;
            }

            return nsLine ;
        }

        /// <summary>
        /// 如果有打钩的，就返回所有打钩的记录行号；如果没有打钩的，就返回全部反色选择的，都没有就返回null。
        /// </summary>
        /// <returns></returns>
        public int [] GetMuchSelectLine ()
        {
            int [] nsSel = GetSelectCheckBoxLine ();
            
            //没有打钩的
            if ( nsSel == null )
            {
                //光标有选择行
                if ( SelectedRows.Count > 0 )
                {
                    nsSel = new int [ SelectedRows.Count ];
                    int n = 0;
                    foreach ( DataGridViewRow Row in SelectedRows )
                        nsSel [ n ++ ] = Row.Index;
                }
            }

            return nsSel;
        }

        /// <summary>
        /// 返回选择的行的序号。
        /// 如果有多个选择，返回最小号（最上）的行序号。
        /// 如果允许打钩选择，返回最上的打钩行序号。
        /// </summary>
        /// <returns>-1=没有选中的行</returns>
        public int GetSelectLineNo ()
        {
            DEBUG d = new DEBUG ();

            int nSel = -1;

            if ( AllowMultiSelect )
            {
                int [] nSels = GetSelectCheckBoxLine ();

                //如果有多个打钩，选第一个打钩的行。
                if ( nSels != null && nSels.Length > 0 )
                {
                    nSel = nSels [0];
                }
                else  //没有选择任何打钩， 则查看有无光标选择行。
                {
                    //光标有选择行
                    if ( SelectedRows.Count > 0 )
                    {
                        nSel = SelectedRows [0].Index;
                    }
                }
            }
            else  //不允许打钩
            {
                //光标有选择行
                if ( SelectedRows.Count > 0 )
                {
                    nSel = SelectedRows [0].Index;
                }
            }

            return nSel;
        }

        #endregion

        #region Private

        DataGridViewColumn CreateColumn ( ColumnType colType )
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

            //如果是控件，不要撑满格子，不好看。
            if ( colType != ColumnType.Text )
                col.DefaultCellStyle.Padding = new System.Windows.Forms.Padding ( 5 , 2 , 5 , 2 );

            return col;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Column"></param>
        /// <param name="strText">strText可以是txtButton,也可是txtHead|txtButton ,也可是txtHead|txtButton|Name 格式 </param>
        void SetCellButton ( DataGridViewColumn Column , string strText )
        {
            DataGridViewButtonColumn col = Column as DataGridViewButtonColumn;

            string strHead = "";
            string strContent = FF.Str.Combin.GetUnit ( strText , 1 );  //检查是 HeadText|ContentText 格式。
            if ( strContent == null )  //不是合并连接类型的字串，就直接显示在按钮上。
            {
                strContent = strText;
            }
            else  //是 HeadText|ContentText 格式。
            {
                strHead = FF.Str.Combin.GetUnit ( strText , 0 );
            }

            col.HeaderText = strHead;
            col.Text = strContent;
            col.UseColumnTextForButtonValue = true;

            //如果指定了Name,直接赋值，没有的话用 按钮名称 赋值 Column.Name
            col.Name = ( FF.Str.Combin.GetUnit ( strText , 2 ) == null ) ? strContent : FF.Str.Combin.GetUnit ( strText , 2 );
        }

        void SetCellCheckBox ( DataGridViewColumn Column , string strText )
        {
            DataGridViewCheckBoxColumn col = Column as DataGridViewCheckBoxColumn;

            string strHead = "";
            string strContent = FF.Str.Combin.GetUnit ( strText , 1 );  //检查是 HeadText|ContentText 格式。
            if ( strContent == null )  //不是合并连接类型的字串，就直接显示在按钮上。
            {
                strContent = strText;
            }
            else  //是 HeadText|ContentText 格式。
            {
                strHead = FF.Str.Combin.GetUnit ( strText , 0 );
            }

            //col.HeaderText = strHead;
            //col.Text = strContent;

            //
            DatagridViewCheckBoxHeaderCell cbHeader = new DatagridViewCheckBoxHeaderCell ();
            col.HeaderCell = cbHeader;
            cbHeader.OnCheckBoxClicked += new CheckBoxClickedHandler ( cbHeader_OnCheckBoxClicked );

        }

        //需要更改
        void SetCellCombox ( DataGridViewColumn Column , string strText )
        {
            DataGridViewComboBoxColumn col = Column as DataGridViewComboBoxColumn;

            string strHead = "";
            string strContent = FF.Str.Combin.GetUnit ( strText , 1 );  //检查是 HeadText|ContentText 格式。
            if ( strContent == null )  //不是合并连接类型的字串，就直接显示在按钮上。
            {
                strContent = strText;
            }
            else  //是 HeadText|ContentText 格式。
            {
                strHead = FF.Str.Combin.GetUnit ( strText , 0 );
            }

            //
            DatagridViewCheckBoxHeaderCell cbHeader = new DatagridViewCheckBoxHeaderCell ();
            col.HeaderCell = cbHeader;
            cbHeader.OnCheckBoxClicked += new CheckBoxClickedHandler ( cbHeader_OnCheckBoxClicked );

        }

        //需要更改
        void SetCellImage ( DataGridViewColumn Column , string strText )
        {
            DataGridViewImageColumn col = Column as DataGridViewImageColumn;

            string strHead = "";
            string strContent = FF.Str.Combin.GetUnit ( strText , 1 );  //检查是 HeadText|ContentText 格式。
            if ( strContent == null )  //不是合并连接类型的字串，就直接显示在按钮上。
            {
                strContent = strText;
            }
            else  //是 HeadText|ContentText 格式。
            {
                strHead = FF.Str.Combin.GetUnit ( strText , 0 );
            }

            //col.HeaderText = strHead;
            //col.Text = strContent;

            //
            DatagridViewCheckBoxHeaderCell cbHeader = new DatagridViewCheckBoxHeaderCell ();
            col.HeaderCell = cbHeader;
            cbHeader.OnCheckBoxClicked += new CheckBoxClickedHandler ( cbHeader_OnCheckBoxClicked );

        }

        void SetCellLink ( DataGridViewColumn Column , string strText )
        {
            DataGridViewLinkColumn col = Column as DataGridViewLinkColumn;

            string strHead = strText;
            string strName = FF.Str.Combin.GetUnit ( strText , 1 );  //检查是 HeadText|ContentText 格式。
            if ( strName == null )  //不是合并连接类型的字串，就直接显示在按钮上。
            {
                strName = strHead;
            }
            else  //是 HeadText|ContentText 格式。
            {
                strHead = FF.Str.Combin.GetUnit ( strText , 0 );
            }

            col.HeaderText = strHead;
            col.Name = strName;
            col.LinkBehavior = LinkBehavior.HoverUnderline;
        }

        void cbHeader_OnCheckBoxClicked ( bool bCheck )
        { 
        
        }

        void OnClickColumnHeader ( object sender, DataGridViewCellMouseEventArgs e )
        {

        }

        #region CheckBox

        /// <summary>
        /// 添加或则去除chexbox的选择列。
        /// </summary>
        /// <param name="bFlag">true=添加；false=去除</param>
        void AddSelectCheckBox ( bool bFlag )
        {
            if ( bFlag )
            {
                //已经有了不要重复加。
                if ( _HaveSelectedCheckBox == true )
                    return;

                DataGridViewCheckBoxColumn col = new DataGridViewCheckBoxColumn ();
                col.Width = 40;
                Columns.Insert ( 0 , col );

                //
                _HaveSelectedCheckBox = true;
            }
            else
            {
                //已经没有了， 就不用去除。
                if ( _HaveSelectedCheckBox == false )
                    return;

                Columns.RemoveAt ( 0 );

                //
                _HaveSelectedCheckBox = false;
            }
        }

        /// <summary>
        /// 设置指定行的CheckBox
        /// </summary>
        public void SelectCheckBox( int nLineNo , bool bFlag )
        {
            if ( _HaveSelectedCheckBox == false )
                return;

            if ( nLineNo < 0 || nLineNo >= Rows.Count )
                return;

            Rows[nLineNo].Cells[0].Value = bFlag;

            //
            UpdateEdit ();
        }

        /// <summary>
        /// 全部选中
        /// </summary>
        public void SelectAllCheckBox ()
        {
            if ( _HaveSelectedCheckBox == false )
                return;

            foreach ( DataGridViewRow row in Rows )
                row.Cells [ 0 ].Value = true;

            //
            UpdateEdit ();
        }

        /// <summary>
        /// 全部不选中
        /// </summary>
        public void UnSelectAllCheckBox ()
        {
            if ( _HaveSelectedCheckBox == false )
                return;

            foreach ( DataGridViewRow row in Rows )
                row.Cells [ 0 ].Value = false;

            //
            UpdateEdit ();
        }

        /// <summary>
        /// 反选
        /// </summary>
        public void ReverseSelectCheckBox ()
        {
            if ( _HaveSelectedCheckBox == false )
                return;

            //强制更新当前行的checkbox选择的状态。
            //另外更简单的方法是直接用 EditedFormattedValue取值，这样无论数据时候提交，取出的一定是编辑后的数据。 
            UpdateEdit ();            

            //
            foreach ( DataGridViewRow row in Rows )
            {
                if ( row.Cells [ 0 ].Value == null )
                    row.Cells [ 0 ].Value = true;
                else
                    row.Cells [ 0 ].Value = ! ( bool )row.Cells [ 0 ].Value;
            }

            //
            UpdateEdit ();       
        }

        void ClearContextMenu ()
        {
            ContextMenuStrip = null;
        }

        /// <summary>
        /// 在行编辑状态时，强制更新数据。
        /// 即时更新选项。让真实数据与界面显示同步。
        /// </summary>
        void UpdateEdit ()
        {
            CommitEdit ( DataGridViewDataErrorContexts.Commit );
            EndEdit ();
            //DataSource.EndEdit ();
        }

        #endregion

        #endregion

        #region 自动保存用户调整的列宽

        public void AllowSaveColWidth ( string strXmlFile, string strListName )
        {
            if ( strXmlFile.Trim () == "" || strListName.Trim () == "" )
            {
                _bAllowSaveFldWidth = false;
                return;
            }
            
            //加在这里是因为init()里面没起效果，隐藏列可以被拉开。ColumnWidthChanged加在这里可以被强制执行。
            ColumnWidthChanged += new DataGridViewColumnEventHandler ( OnColumnWidthChanged );

            _bAllowSaveFldWidth = true;
            _strXmlFile = strXmlFile;
            _strListName = strListName;
        }

        //更改列的宽度后， 要把这个宽度值记录到本地文件中， 以便下次显示List时，可以保持各列是最后调节的宽度。
        void OnColumnWidthChanged ( object sender, DataGridViewColumnEventArgs e )
        {
            if ( !_bAllowSaveFldWidth )
                return;

            string strColName = Columns [ e.Column.Index ].HeaderText;
            FF.Xml.FilterInvalidCh ( ref strColName );
            int nWidth = Columns [ e.Column.Index ].Width;

            string Param = String.Format ( @"{0}/{1}", _strListName, strColName );
            FF.Xml.WriteParam( _strXmlFile, Param, nWidth.ToString() );
        }

        public void RestoreColWidth ()
        {
            if ( !_bAllowSaveFldWidth )
                return;

            string strHeadName, strValue = "";
            int nDefaultW= 100 , nWidth = 0;

            //_nColWidths = new int [ Columns.Count ];
            //int i = 0;

            foreach ( DataGridViewColumn hd in Columns )
            {
                strHeadName = hd.HeaderText;
                FF.Xml.FilterInvalidCh ( ref strHeadName );

                string Param = String.Format ( @"{0}/{1}", _strListName, strHeadName );
                FF.Xml.ReadParam( _strXmlFile, Param, ref strValue );

                //第一次执行，Xml文件中还没有列宽度记录的时候，给宽度一个默认值。
                nWidth = ( strValue.Trim() == "" ) ? nDefaultW : FF.Fun.MyConvert.Str2Int( strValue );

                hd.Width = nWidth;
                //_nColWidths [ i++ ] = hd.Width;
            }
        }

        #endregion

    }

    public enum ColumnType
    {
        Text = 1 ,
        Button = 2 ,
        Combox = 3 ,
        CheckBox = 4 ,
        Image = 5 ,
        Link = 6
    }

    public class COLHEAD
    {
        public ColumnType Type = ColumnType.Text;
        public string HeadText;
        public string FldName;
        public int HeadWidth = 100;
        public object Tag = null;

        public COLHEAD( ColumnType type, string strHeadText, string strFldName, int nWidth, object tag )
        {
            Type = type;
            HeadText = strHeadText;
            FldName = strFldName;
            if ( nWidth > 0 )
                HeadWidth = nWidth;
            Tag = tag;
        }

        public COLHEAD ( ColumnType type, string strHeadText, string strFldName, int nWidth )
        {
            Type = type;
            HeadText = strHeadText;
            FldName = strFldName;
            HeadWidth = nWidth;
        }

        public COLHEAD ( ColumnType type, string strHeadText, string strFldName)
        {
            Type = type;
            HeadText = strHeadText;
            FldName = strFldName;
        }

        public COLHEAD ( string strHeadText , string strFldName, int Width  )
        {
            HeadText = strHeadText;
            FldName = strFldName;
            HeadWidth = Width;
        }

        public COLHEAD ( string strHeadText, string strFldName )
        {
            HeadText = strHeadText;
            FldName = strFldName;
        }
    }

    //public class RowComparer : System.Collections.IComparer
    //{
    //    private static int sortOrderModifier = 1;

    //    public RowComparer ( SortOrder sortOrder )
    //    {
    //        if ( sortOrder == SortOrder.Descending )
    //        {
    //            sortOrderModifier = -1;
    //        }
    //        else if ( sortOrder == SortOrder.Ascending )
    //        {
    //            sortOrderModifier = 1;
    //        }
    //    }

    //    public int Compare ( object x, object y )
    //    {
    //        DataGridViewRow DataGridViewRow1 = (DataGridViewRow) x;
    //        DataGridViewRow DataGridViewRow2 = (DataGridViewRow) y;

    //        // Try to sort based on the Last Name column.
    //        int CompareResult = System.String.Compare (
    //            DataGridViewRow1.Cells [ 1 ].Value.ToString (),
    //            DataGridViewRow2.Cells [ 1 ].Value.ToString () );

    //        // If the Last Names are equal, sort based on the First Name.
    //        if ( CompareResult == 0 )
    //        {
    //            CompareResult = System.String.Compare (
    //                DataGridViewRow1.Cells [ 0 ].Value.ToString (),
    //                DataGridViewRow2.Cells [ 0 ].Value.ToString () );
    //        }
    //        return CompareResult * sortOrderModifier;
    //    }
    //}
}
