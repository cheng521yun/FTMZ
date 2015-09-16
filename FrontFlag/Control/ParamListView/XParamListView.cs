using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using FrontFlag.Control.DataGridView;

namespace FrontFlag.Control.ParamListView
{
    public partial class XParamListView : System.Windows.Forms.ListView
    {
        private System.Windows.Forms.TextBox editBox = new System.Windows.Forms.TextBox();
        private System.Windows.Forms.ComboBox cmbBox = new System.Windows.Forms.ComboBox();
        private DatePickInListItem datPicker = new DatePickInListItem();

        //public delegate void entSendMsg( int nItemIndex, string strCmbSelectText );     //nItemIndex=第几行， strCmbSelectText=cmb选择后的文本
        //public event entSendMsg SendMsg = null;
        public delegate void entSendMsg( EVENTTYPE enmEventType, int nRow, int nCol, string strCaption, string strMsg );
        public event entSendMsg SendMsg = null;

        ListViewItem _SelItem = null;
        private ListViewItem.ListViewSubItem _SelSubItem = null;

        //MS Bug: 第一列时，返回的宽度不是Cell的宽度，而是一整行的宽度。
        //使用变量标示是否是第一列
        private bool _bFirstCol = false;

        private int _nColCaption = 0 ;    //第1列是数值列
        private int _nColVal = 1;         //第2列是数值列

        private int _nLineH = 18;

        protected  Color clrCaptionFore = Color.FromArgb( 0, 0, 0 );
        protected Color clrCaptionBK = Color.FromArgb( 190, 206, 183 );
        protected Color clrReadOnly = Color.FromArgb( 190, 206, 183 );


        public XParamListView()
        {
            InitializeComponent();
        }

        #region 属性

        private EDITITEMDEF curItemDef
        {
            get
            {
                return GetItemDef( _SelItem );
            }
        }

        private CONTROLTYPE curItemCtrlType
        {
            get
            {
                return curItemDef.CtrlType;
            }
        }

        public void SetLineHeight( int H )
        {
            ImageList imgList = new ImageList();
            imgList.ImageSize = new System.Drawing.Size( 1, H );
            SmallImageList = imgList;
        }

        #endregion

        #region Event

        protected override void OnPaint( PaintEventArgs pe )
        {
            base.OnPaint( pe );
        }

        private const int WM_HSCROLL = 0x114;
        private const int WM_VSCROLL = 0x115;

        protected override void WndProc( ref Message msg )
        {
            // Look for the WM_VSCROLL or the WM_HSCROLL messages.
            if ( ( msg.Msg == WM_VSCROLL ) || ( msg.Msg == WM_HSCROLL ) )
            {
                // Move focus to the ListView to cause ComboBox to lose focus.
                this.Focus();
            }

            // Pass message to default handler.
            base.WndProc( ref msg );
        }

        //combo
        private void CmbKeyPress( object sender, System.Windows.Forms.KeyPressEventArgs e )
        {
            if ( e.KeyChar == 13 || e.KeyChar == 27 )
            {
                cmbBox.Hide();
            }
        }

        private void CmbSelected( object sender, System.EventArgs e )
        {
            HideCtrl();

            int nSel = cmbBox.SelectedIndex;
            if ( nSel < 0 )
                return;

            string strCmbTextSel = cmbBox.Items[ nSel ].ToString();
            string strOrgItemText = GetSelItemText();

            bool bChange = (strCmbTextSel != strOrgItemText);

            SetSelItemText( strCmbTextSel );

            //选择完combox，通知父窗口combox已经选择新选项。 
            int nItemIndex = this.Items.IndexOf( _SelItem );
            if ( SendMsg != null && nItemIndex >= 0 && bChange )
            {
                //HideCtrl();

                string strCaption = GetItemCaption( _SelItem );
                SendMsg( EVENTTYPE.ComboxChanged, nItemIndex, _nColVal, strCaption, strCmbTextSel );
            }
        }

        private void OnMouseUp( object obj, MouseEventArgs e )
        {
            bool bRet = isSelectedItem( e.X, e.Y );
            CallCellWork( bRet );
        }

        public void OnDoubleClick( object sender, System.EventArgs e )
        {
            bool bRet = isSelectedItem();
            CallCellWork( bRet );
        }

        #endregion

        #region Init

        public void Init()
        {
            Init_ListView();
            Init_Ctrl();
        }

        private void Init_ListView()
        {
            this.MultiSelect = false;
            this.FullRowSelect = true;
            this.HideSelection = false;
            this.View = System.Windows.Forms.View.Details;
            SetLineHeight( _nLineH );

            this.MouseUp += OnMouseUp;
            this.DoubleClick += new System.EventHandler( this.OnDoubleClick );

            //
            Init_ListViewColumn();
        }

        private void Init_ListViewColumn()
        {
            AddColumns( "Caption", 120 );
            AddColumns( "Value", 120 );
        }

        private void Init_Ctrl()
        {
            Init_Ctrl_EditBox();
            Init_Ctrl_CmbBox();
            Init_Ctrl_datPicker();
        }

        private void Init_Ctrl_EditBox()
        {
            editBox.Parent = this;
            editBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            editBox.Hide();

            editBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler( this.EditOver );
            editBox.LostFocus += new System.EventHandler( this.FocusOver );
        }

        private void Init_Ctrl_CmbBox()
        {
            cmbBox.Parent = this;
            //cmbBox.Font = new System.Drawing.Font ( "Microsoft Sans Serif" , 9F , System.Drawing.FontStyle.Regular , System.Drawing.GraphicsUnit.Point , ( ( System.Byte ) ( 0 ) ) );
            editBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            cmbBox.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbBox.Sorted = true;
            cmbBox.Hide();

            cmbBox.LostFocus += new System.EventHandler( this.CmbFocusOver );
            cmbBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler( this.CmbKeyPress );
            cmbBox.SelectedIndexChanged += new System.EventHandler( this.CmbSelected );
            //cmbBox.SelectedIndexChanged += new System.EventHandler( this.CmbSelectedChange );
        }

        private void Init_Ctrl_datPicker()
        {
            datPicker.Parent = this;
            datPicker.dat.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            datPicker.dat.CustomFormat = "yyyy-MM-dd";
            datPicker.Hide();

            datPicker.DoFinish += FinishDatPicker; 
        }

        #endregion

        #region Function

        [DllImport( "user32" )]
        public static extern int GetScrollPos( int hwnd, int nBar );

        int GetCellNo( int x, int y )
        {
            //System.Windows.Forms.ListViewItem.ListViewSubItem Cell = new System.Windows.Forms.ListViewItem.ListViewSubItem();
            System.Windows.Forms.ListViewItem Item = new ListViewItem();

            // 获得单元格所在的行。
            Item = GetItemAt( x, y );
            if ( Item == null )
                return -1;

            //cell.ItemIndex = cell.Item.Index; // 现在 Item.Index 还能用

            // 根据各列宽度，获得单元格所在的列，以及 Bounds。
            int curX = Item.GetBounds( ItemBoundsPortion.Entire ).Left; // 依次循环各列，表示各列的起点值
            int scrollLeft = GetScrollPos( Handle.ToInt32(), 0 ); // 可能出现了横向滚动条，左边隐藏起来的宽度
            
            for ( int i = 0 ; i < Columns.Count ; i++ )
            {
                if ( scrollLeft + x >= curX && scrollLeft + x < curX + Columns[ i ].Width )
                {
                    //ListViewColumn = Columns[ i ]; // 列找到了
                    //Rectangle itemBounds = cell.Item.GetBounds( ItemBoundsPortion.Entire );
                    //cell.Bounds = new Rectangle( curX,
                    //    itemBounds.Y,
                    //    Columns[ i ].Width,
                    //    itemBounds.Height );
                    //break;
                    return i;
                }
                curX += Columns[ i ].Width;
            }

            return -1;
        }

        private bool isSelectedItem( int X, int Y )
        {
            _SelItem = this.GetItemAt( X, Y );

            if ( _SelItem == null )
                return false;

            int nCellNo = GetCellNo( X, Y );
            if ( nCellNo < 0 || nCellNo >= _SelItem.SubItems.Count )
                return false ;

            _SelSubItem = _SelItem.SubItems[ nCellNo ]; 

            //MS Bug: 第一列时，返回的宽度不是Cell的宽度，而是一整行的宽度。
            //使用变量标示是否是第一列
            _bFirstCol = ( nCellNo == 0 ) && ( _SelItem.SubItems.Count > 1 );

            ////
            //_ItemDef = GetItemDef( _SelItem );

            return true;
        }

        private bool isSelectedItem()
        {
            Point pt = MousePosition;
            pt = this.PointToClient( pt );

            return isSelectedItem( pt.X, pt.Y );
        }

        protected EDITITEMDEF GetItemDef( DATA data )
        {
            EDITITEMDEF ItemDef = new EDITITEMDEF();
            
            ItemDef.Set_ByCombin( data.Def );

            return ItemDef;
        }

        private EDITITEMDEF GetItemDef( ListViewItem Item )
        {
            EDITITEMDEF ItemDef = new EDITITEMDEF();

            if (Item != null)
                ItemDef = GetItemDef( Item.Tag as DATA );

            return ItemDef;
        }

        #region ItemDef

        private bool AllowShow(EDITITEMDEF Def)
        {
            return Def.bCanShow && Def.bShow;
        }

        private bool AllowEdit( EDITITEMDEF Def )
        {
            return (! Def.bCanReadOnly) && (! Def.bReadOnly);
        }

        #endregion

        #endregion

        #region ListViewItem

        /// <summary>
        /// 启用cell里的控件
        /// </summary>
        /// <param name="bFlag">鼠标是否点击在Cell里</param>
        private void CallCellWork( bool bClickInCell )
        {
            HideCtrl();

            if ( !bClickInCell )
                return;
            
            //cell是否可以编辑
            if ( !CanEditRow() )
                return;

            EditCell();
        }

        private bool hasSeletedItem()
        {
            return _SelSubItem != null;
        }

        protected void AddColumns( string strCaption, int nWidth )
        {
            ColumnHeader hd = new ColumnHeader();
            hd.Text = strCaption;
            hd.Width = nWidth;
            this.Columns.Add( hd );
        }

        public void AddItems( DATA data ) 
        {
            EDITITEMDEF Def = GetItemDef( data );

            //隐藏字段不添加到列表上
            //if( ! Def.bCanShow )
            if ( ! AllowShow( Def ) )
                return;

            ListViewItem li = new ListViewItem( data.Caption );
            li.SubItems.Add( data.Value );
            li.Tag = data;

            //
            SetValCellColor( li, Def );

            Items.Add(li);
        }

        void SetValCellColor( ListViewItem li, EDITITEMDEF Def )
        {
            li.UseItemStyleForSubItems = false;

            ListViewItem.ListViewSubItem subItem = li.SubItems[_nColVal];

            SetCellColor( subItem, Def.clrFore, Def.clrBK );

            //只读Item使用特殊颜色标示底色
            //if ( Def.bCanReadOnly )
            if ( ! AllowEdit(Def) )
                SetCellColor( subItem, Def.clrFore, clrReadOnly );
        }

        private void SetSelItemText( string strText )
        {
            if ( !hasSeletedItem() )
                return;

            _SelSubItem.Text = strText;
        }

        ListViewItem GetItemByCaption( string strCaption )
        {
            foreach ( ListViewItem li in this.Items  )
            {
                if ( li.SubItems[ _nColCaption ].Text.Trim().ToUpper() == strCaption.Trim().ToUpper() )
                    return li;
            }

            return null;
        }

        protected string GetItemText( string strCaption )
        {
            ListViewItem li = GetItemByCaption( strCaption );
            if ( li == null )
                return String.Empty;

            return li.SubItems[ _nColVal ].Text ;
        }

        protected void SetItemText( string strCaption, string strText )
        {
            ListViewItem li = GetItemByCaption( strCaption );
            if (li == null)
                return;

            li.SubItems[ _nColVal ].Text = strText;
        }

        private string GetSelItemText()
        {
            if ( !hasSeletedItem() )
                return String.Empty;

            return _SelSubItem.Text.Trim();
        }

        protected string GetItemCaption( ListViewItem li )
        {
            if ( li == null )
                return String.Empty;

            if (_nColCaption < 0 || _nColCaption >= li.SubItems.Count)
                return String.Empty;

            return li.SubItems[ _nColCaption ].Text.Trim();
        }

        protected string GetItemVal(ListViewItem li)
        {
            if (li == null)
                return String.Empty;

            if ( _nColVal < 0 || _nColVal >= li.SubItems.Count )
                return String.Empty;

            return li.SubItems[ _nColVal ].Text.Trim();
        }

        private bool CanEditRow()
        {
            //第一列（Caption）不可编辑。
            if (_bFirstCol)
                return false;

            //设为只读的Cell不可编辑
            EDITITEMDEF Def = GetItemDef(_SelItem);
            //if (Def.bCanReadOnly)
            if ( !AllowEdit( Def ) )
                return false;

            //不可见，当然就不可编辑
            //if ( ! Def.bCanShow )
            if ( !AllowShow( Def ) )
                return false;

            return true ;
        }

        private Rectangle GetSelectedBounds()
        {
            if ( !hasSeletedItem() )
                return new Rectangle(0,0,0,0);

            Rectangle rc = _SelSubItem.Bounds;

            //MS Bug: 第一列时，返回的宽度不是Cell的宽度，而是一整行的宽度。
            //使用变量标示是否是第一列
            if ( _bFirstCol )
                rc.Width = this.Columns[ 0 ].Width;

            return rc;
        }

        protected void SetColColor( int nCol, Color clrFore, Color clrBK )
        {
            if ( this.Items.Count <= 0 )
                return;

            if ( nCol < 0 || nCol >= this.Items.Count )
                return;

            foreach ( ListViewItem li in this.Items )
            {
                ListViewItem.ListViewSubItem SubItem = li.SubItems[ nCol ];
                SetCellColor( SubItem, clrFore, clrBK );
            }
        }

        #region Cell

        ListViewItem.ListViewSubItem GetCell(int nRow, int nCol)
        {
            if (nRow < 0 || nRow >= this.Items.Count)
                return null;

            if ( nCol < 0 || nCol >= this.Items[ nRow ].SubItems.Count )
                return null;

            return this.Items[nRow].SubItems[nCol] ;
        }

        private void SetCellColor( ListViewItem.ListViewSubItem SubItem, Color clrFore, Color clrBK )
        {
            if (SubItem == null)
                return;

            SubItem.ForeColor = clrFore;
            SubItem.BackColor = clrBK;
        }

        protected void SetCellColor( int nRow, int nCol, Color clrFore, Color clrBK )
        {
            ListViewItem.ListViewSubItem Item = GetCell( nRow, nCol);
            SetCellColor(Item, clrFore, clrBK);
        }

        #endregion

        #endregion

        #region Ctrl

        private List<string> GetCombItems()
        {
            List<string> lst = new List<string>();

            foreach ( string str in curItemDef.aryCombox )
            {
                lst.Add( str );
            }

            return lst;
        }

        private void ShowCtrl()
        {
            HideCtrl();

            switch ( curItemCtrlType )
            {
                case CONTROLTYPE.TextBox:
                    ShowCtrl_EditBox();
                break;
                case CONTROLTYPE.Combox:
                    ShowCtrl_CombBox();
                break;
                case CONTROLTYPE.DatePicker:
                    ShowCtrl_DatePick();
                break;
            }
        }

        void ShowCtrl_EditBox()
        {
            editBox.Text = GetSelItemText();
            editBox.Bounds = GetSelectedBounds();
            editBox.Show();
            editBox.BringToFront();
            editBox.Focus();
        }

        private void SetCombBoxItem()
        {
            cmbBox.Items.Clear();

            List<string> lst = GetCombItems();
            FF.Ctrl.Combo.List2Combo( cmbBox, lst );

            FF.Ctrl.Combo.SetSelectText( cmbBox, GetSelItemText() );
        }

        private void ShowCtrl_CombBox()
        {
            SetCombBoxItem();

            cmbBox.Bounds = GetSelectedBounds();
            cmbBox.Show();
            cmbBox.BringToFront();
            cmbBox.Focus();
        }

        void ShowCtrl_DatePick()
        {
            datPicker.Bounds = GetSelectedBounds();
            datPicker.Show();
            datPicker.Focus();

            datPicker.dat.Value = FF.Fun.MyConvert.Str2Date( GetSelItemText() );
        }

        private void HideCtrl()
        {
            editBox.Hide();
            cmbBox.Hide();
            datPicker.Hide();
        }

        public void FinishEdit()
        {
            if ( _SelSubItem == null || editBox == null || editBox.Visible == false )
                return;

            SetSelItemText( editBox.Text );
            editBox.Hide();
        }

        private void EditOver( object sender, System.Windows.Forms.KeyPressEventArgs e )
        {
            if ( e.KeyChar == 13 )
            {
                FinishEdit();
            }

            if ( e.KeyChar == 27 )
                editBox.Hide();
        }

        private void FocusOver( object sender, System.EventArgs e )
        {
            FinishEdit();
        }

        private void CmbFocusOver( object sender, System.EventArgs e )
        {
            cmbBox.Hide();
        }

        //private void CmbSelectedChange( object sender, EventArgs e )
        //{
        //    cmbBox.Hide();
        //    //this.Focus();

        //    ////test
        //    //FF.Debug.TimeLog( "相应 CmbSelectedChange" );
        //}

        public void FinishDatPicker()
        {
            if ( _SelSubItem == null || datPicker == null )
                return;

            SetSelItemText( datPicker.strDate );
        }

        private void EditCell()
        {
            ShowCtrl();
        }

        #endregion

    }
}
