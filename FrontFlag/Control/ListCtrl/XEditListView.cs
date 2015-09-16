using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FrontFlag.Control
{
    public partial class XEditListView : XListView
    {
        public Color _clrBKNotEdit = Color.LightGray;

        private System.Windows.Forms.TextBox editBox = new System.Windows.Forms.TextBox ();
        private System.Windows.Forms.ComboBox cmbBox = new System.Windows.Forms.ComboBox ();
        private DatePickInListItem datPicker = new DatePickInListItem();

        public delegate void entSendMsg ( int nItemIndex , string strCmbSelectText );     //nItemIndex=第几行， strCmbSelectText=cmb选择后的文本
        public event entSendMsg SendMsg = null;

        private ListViewItem _li;
        private int _X = 0;
        private int _Y = 0;
        private string _subItemText="";
        private int _subItemSelected = 0;

        int _ColItem = 0;
        int _ColValue = 1;

        //第一列的前景和背景色。
        public Color clrTagBK = Color.FromArgb ( 190 , 206 , 183 );  //暗绿色
        public Color clrTagFor = Color.FromArgb ( 0 , 0 , 0 );

        ArrayList _aryNoEditCols = new ArrayList () ;
        ArrayList _aryNoEditLines = new ArrayList ();   //保存不可以编辑的行号。

        struct COMBOUNIT
        {
            public string strFlag;                 //第一列的名称。表明是哪一行会显示combo
            public string [] strsItemString;       //combo 中用来显示的所有选项. 
        } ;

        ArrayList _aryComboUnit = new ArrayList () ;
        ArrayList _aryDatPickerUnit = new ArrayList ();
        ArrayList _aryColorTag = new ArrayList();           //特殊颜色的Tag序列。（这些行的Tag列，额可以指定颜色）

        public XEditListView ()
        {
            InitializeComponent ();
            Init ();

            this.MouseDown += new System.Windows.Forms.MouseEventHandler ( this.OnMouseDown );
            this.DoubleClick += new System.EventHandler ( this.OnDoubleClick );

            editBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler ( this.EditOver );
            editBox.LostFocus += new System.EventHandler ( this.FocusOver );

            cmbBox.LostFocus += new System.EventHandler ( this.CmbFocusOver );
            cmbBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler ( this.CmbKeyPress );

            //datPicker.dat.LostFocus += new System.EventHandler ( this.datPickerFocusOver );
            //datPicker.dat.KeyPress += new System.Windows.Forms.KeyPressEventHandler ( this.datPickerKeyPress );
            //datPicker.dat.ValueChanged += new System.EventHandler ( this.datPickerValueChanged );
            //datPicker.btnClear.Click += new System.EventHandler ( this.datPickerClear );
            datPicker.DoFinish += FinishDatPicker ; 
        }

        #region Public

        public void SetColorTag ( int nLine , Color clr )
        {
            COLORTAG tag = new COLORTAG();
            tag.nLine = nLine;
            tag.clrBK = clr;
            _aryColorTag.Add ( tag ) ;
        }

        public void ClearComboItem ( string strItemName )
        {
            foreach ( COMBOUNIT Unit in _aryComboUnit )
            {
                if ( Unit.strFlag.ToLower () == strItemName.ToLower () )
                {
                    _aryComboUnit.Remove ( Unit );
                    return;
                }
            }
        }

        public void AddComboItem ( string strItemName , string [ ] strComboItems )
        {
            ClearComboItem ( strItemName );

            COMBOUNIT Unit = new COMBOUNIT () ;
            Unit.strFlag = strItemName;
            Unit.strsItemString = strComboItems ;

            _aryComboUnit.Add ( Unit );
        }

        public void AddPiackerItem ( string strItemName )
        {
            _aryDatPickerUnit.Add ( strItemName );
        }

        public void AddNotEditCol ( int nCol )
        {
            if ( nCol < 0 || nCol >= this.Columns.Count )            
                return ;

            _aryNoEditCols.Add ( nCol );
        }

        public void AddReadOnlyLine ( int nLine )
        {
            if ( nLine < 0 )
                return;

            if ( _aryNoEditLines.Contains ( nLine ) )
                return;

            _aryNoEditLines.Add ( nLine );

            //
            ListViewItem li = Items [ nLine ];
            li.UseItemStyleForSubItems = false;
            li.SubItems [ _ColValue ].BackColor = _clrBKNotEdit;
        }

        public void AddReadOnlyLine ( string strItemName )
        {
            int nLine = GetLineNo ( strItemName );
            AddReadOnlyLine ( nLine );
        }

        public void RemoveReadOnlyLine ( int nLine )
        {
            if ( nLine < 0 )
                return;

            _aryNoEditLines.Remove ( nLine );

            //
            ListViewItem li = Items [ nLine ];
            li.UseItemStyleForSubItems = false;
            li.SubItems [ _ColValue ].BackColor = this.BackColor;
        }

        public void RemoveReadOnlyLine ( string strItemName )
        {
            int nLine = GetLineNo ( strItemName );
            RemoveReadOnlyLine ( nLine );
        }


        #region 只读，不变底色

        public void AddReadOnlyLine_NoColor(int nLine)
        {
            if (nLine < 0)
                return;

            if (_aryNoEditLines.Contains(nLine))
                return;

            _aryNoEditLines.Add(nLine);
        }

        public void AddReadOnlyLine_NoColor(string strItemName)
        {
            int nLine = GetLineNo(strItemName);
            AddReadOnlyLine_NoColor(nLine);
        }

        public void RemoveReadOnlyLine_NoColor (int nLine)
        {
            if (nLine < 0)
                return;

            _aryNoEditLines.Remove(nLine);
        }

        public void RemoveReadOnlyLine_NoColor (string strItemName)
        {
            int nLine = GetLineNo(strItemName);
            RemoveReadOnlyLine_NoColor (nLine);
        }

        #endregion


        public void HideText ( int nLine , int nCol )
        {
            if ( nLine < 0 || nLine >= Items.Count || nCol < 0 || nCol >= Columns.Count )
                return ;

            Items [ nLine ].UseItemStyleForSubItems = false; 
            Items [ nLine ].SubItems [ nCol ].ForeColor = Items [ nLine ].SubItems [ nCol ].BackColor;
        }

        public void ShowText ( int nLine , int nCol , Color clr )
        {
            if ( nLine < 0 || nLine >= Items.Count || nCol < 0 || nCol >= Columns.Count )
                return;

            Items [ nLine ].UseItemStyleForSubItems = false;
            Items [ nLine ].SubItems [ nCol ].ForeColor = clr;
        }

        public void ShowText ( int nLine , int nCol )
        {
            ShowText ( nLine , nCol , Color.Black );
        }

        public void OnMouseDown ( object sender , System.Windows.Forms.MouseEventArgs e )
        {
            _li = this.GetItemAt ( e.X , e.Y );
            _X = e.X;
            _Y = e.Y;
        }

        public void OnDoubleClick ( object sender , System.EventArgs e )
        {
            if ( this.SelectedIndices.Count <= 0 )
                return;

            int nStart = _X;
            int spos = 0;
            int epos = this.Columns [ 0 ].Width;

            _subItemSelected = -1;
            for ( int i = 0 ; i < this.Columns.Count ; i++ )
            {
                if ( nStart > spos && nStart < epos )
                {
                    _subItemSelected = i;
                    break;
                }

                spos = epos;
                epos += this.Columns [ i ].Width;
            }

            if ( _subItemSelected < 0 )
                return;

            if (this.SendMsg != null)
                //this.SendMsg(SelectedIndices[0], "");
                this.SendMsg(SelectedIndices[0], _subItemSelected.ToString() );  //2009-09-22,用于双击Customer和Vendor 显示具体内容窗口。 传递参数，标明是点击的第一列还是第二列。点击第一列弹出内容窗口。

            //if daouble click on Not allow edit column that do nothing.
            foreach ( int n in _aryNoEditCols )
            {
                if ( n == _subItemSelected )
                    return;
            }

            int index;
            if ( this.SelectedIndices.Count <= 0 )
                return ;

            string strFlag = this.Items [ this.SelectedIndices [ 0 ] ].SubItems [ 0 ].Text;

            //if daouble click on Not allow edit Line that do nothing.
            index = this.SelectedIndices [ 0 ];
            foreach ( int n in _aryNoEditLines )
            {
                if ( n == index )
                    return;
            }

            //
            foreach ( string strItemName in _aryDatPickerUnit )
            {
                if ( strItemName == strFlag )
                {
                    datPicker.Size = new System.Drawing.Size ( epos - spos , _li.Bounds.Bottom - _li.Bounds.Top );
                    datPicker.Location = new System.Drawing.Point ( spos , _li.Bounds.Y );
                    datPicker.Show ();
                    datPicker.Focus ();

                    datPicker.dat.Value = FF.Fun.MyConvert.Str2Date ( _li.SubItems [_subItemSelected].Text ) ;

                    return;
                }
            }

            //
            foreach ( COMBOUNIT unit in _aryComboUnit )
            {
                if ( unit.strFlag == strFlag )
                {
                    cmbBox.Items.Clear ();

                    try
                    {
                        cmbBox.Items.AddRange ( unit.strsItemString );
                    }
                    catch
                    {
                        return;
                    }

                    cmbBox.Size = new System.Drawing.Size ( epos - spos , _li.Bounds.Bottom - _li.Bounds.Top );
                    cmbBox.Location = new System.Drawing.Point ( spos , _li.Bounds.Y );
                    cmbBox.Show ();
                    cmbBox.Text = _subItemText;
                    cmbBox.SelectAll ();
                    cmbBox.Focus ();

                    cmbBox.SelectedIndex = GetIndexOfSts ( _li.SubItems [ _subItemSelected ].Text , unit.strsItemString );

                    return;
                }
            }

            //
            _subItemText = _li.SubItems [ _subItemSelected ].Text;

            editBox.Size = new System.Drawing.Size ( epos - spos , _li.Bounds.Bottom - _li.Bounds.Top );
            editBox.Location = new System.Drawing.Point ( 6 + spos , _li.Bounds.Y );
            editBox.Show ();
            editBox.Text = _subItemText;
            editBox.SelectAll ();
            editBox.Focus ();
        }

        public void FinishEdit ()
        {
            if (_subItemSelected < 0 || _li == null || editBox == null || editBox.Visible == false )
                return;

            _li.SubItems [ _subItemSelected ].Text = editBox.Text;
            editBox.Hide ();
        }

        public void FinishDatPicker ()
        {
            if ( _subItemSelected < 0 || _li == null || datPicker == null )
                return;

            //_li.SubItems [_subItemSelected].Text = datPicker.dat.Value.ToString ( "yyyy-MM-dd" );
            //datPicker.Hide ();

            _li.SubItems [_subItemSelected].Text = datPicker.strDate;
        }

        /// <summary>
        /// 设置指定列的颜色。
        /// </summary>
        /// <param name="nCol"></param>
        /// <param name="clrFor"></param>
        /// <param name="clrBK"></param>
        public void SetColColor ( int nCol , Color clrFor , Color clrBK )
        {
            //foreach ( ListViewItem li in Items )
            //{
            //    li.UseItemStyleForSubItems = false;
            //    li.SubItems [nCol].BackColor = clrBK;
            //    li.SubItems [nCol].ForeColor = clrFor;
            //}

            clrTagFor = clrFor;
            clrTagBK = clrBK;

            SetTagColor ();
        }

        //public void SetCellColor( int nLine , int nCol , Color clrFor, Color clrBK)
        //{
        //    if (nLine < 0 || nLine >= Items.Count)
        //        return;

        //    if (nCol < 0 || nCol >= Items[0].SubItems.Count)
        //        return;

        //    Items[nLine].UseItemStyleForSubItems = false;
        //    Items[nLine].SubItems[nCol].BackColor = clrBK;
        //    Items[nLine].SubItems[nCol].ForeColor = clrFor;

        //}

        /// <summary>
        /// 给 List 赋值。
        /// </summary>
        /// <param name="nLine"></param>
        /// <param name="nCol"></param>
        /// <param name="strText"></param>
        public void SetText ( int nLine , int nCol, string strText )
        {
            if ( nLine < 0 || nLine >= Items.Count)
                return;

            ListViewItem li = Items[nLine];

            if (nCol < 0 || nCol >= li.SubItems.Count)
                return;
            
            li.SubItems [ nCol ].Text = strText ;
        }

        #endregion

        #region Private

        public void SetTagColor ()
        {

            foreach ( ListViewItem li in Items )
            {
                li.UseItemStyleForSubItems = false;
                li.SubItems[0].BackColor = clrTagBK;
                li.SubItems[0].ForeColor = clrTagFor;

                if (_aryDatPickerUnit.Contains(li.SubItems[0].Text))
                    li.SubItems[0].BackColor = Color.LightBlue;

            }

            //设定特别行的Tag列的颜色。
            foreach ( COLORTAG tag in _aryColorTag )
            {
                Items [ tag.nLine ].UseItemStyleForSubItems = false;
                Items [ tag.nLine ].SubItems[0].BackColor = tag.clrBK;
                Items [ tag.nLine ].SubItems[0].ForeColor = clrTagFor;
            }
        }

        int GetLineNo ( string strItemName )
        {
            for ( int i = 0 ; i < Items.Count ; i++ )
            {
                if ( Items [ i ].SubItems [ _ColItem ].Text.ToUpper () == strItemName.ToUpper () )
                    return i;
            }
            return -1;
        }

        protected override void OnPaint ( PaintEventArgs pe )
        {
            // TODO: 在此处添加自定义绘制代码

            // 调用基类 OnPaint
            base.OnPaint ( pe );
        }

        void Init ()
        {
            editBox.Parent = this;
            editBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            editBox.BackColor = Color.Gold;

            datPicker.Parent = this;
            datPicker.dat.CustomFormat = "yyyy-MM-dd";
            datPicker.dat.CustomFormat = "yyyy-MM-dd";
            datPicker.dat.Format = System.Windows.Forms.DateTimePickerFormat.Custom;

            cmbBox.Parent = this;
            cmbBox.SelectedIndexChanged += new System.EventHandler ( this.CmbSelected );
            //cmbBox.Font = new System.Drawing.Font ( "Microsoft Sans Serif" , 9F , System.Drawing.FontStyle.Regular , System.Drawing.GraphicsUnit.Point , ( ( System.Byte ) ( 0 ) ) );
            editBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            //cmbBox.BackColor = Color.Gold;
            cmbBox.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbBox.Sorted = true;

            //
            editBox.Hide ();
            cmbBox.Hide ();
            datPicker.Hide ();

            //List不能排序。
            AllowOrder ( false );

            //
            SetTagColor ();
        }

        int GetIndexOfSts ( string strText , string [ ] strs )
        {
            int i = 0;
            foreach ( string s in strs )
            {
                if ( s.ToLower () == strText.ToLower () )
                    break;
                i++;
            }

            if ( i >= strs.Length )
                i = 0;

            return i;
        }

        private void CmbFocusOver ( object sender , System.EventArgs e )
        {
            cmbBox.Hide ();
        }

        private void datPickerFocusOver ( object sender , System.EventArgs e )
        {
            datPicker.Hide ();
            FinishDatPicker ();
        }

        private void EditOver ( object sender , System.Windows.Forms.KeyPressEventArgs e )
        {
            if ( e.KeyChar == 13 )
            {
                FinishEdit () ;
            }

            if ( e.KeyChar == 27 )
                editBox.Hide ();
        }

        private void FocusOver ( object sender , System.EventArgs e )
        {
            FinishEdit () ;
        }

        private const int WM_HSCROLL = 0x114;
        private const int WM_VSCROLL = 0x115;

        protected override void WndProc(ref Message msg)
        {
            // Look for the WM_VSCROLL or the WM_HSCROLL messages.
            if ((msg.Msg == WM_VSCROLL) || (msg.Msg == WM_HSCROLL))
            {
                // Move focus to the ListView to cause ComboBox to lose focus.
                this.Focus();  
            }

            // Pass message to default handler.
            base.WndProc(ref msg);
        } 

        //combo
        private void CmbKeyPress ( object sender , System.Windows.Forms.KeyPressEventArgs e )
        {
            if ( e.KeyChar == 13 || e.KeyChar == 27 )
            {
                cmbBox.Hide ();
            }
        }

        //DatPicker
        private void datPickerKeyPress ( object sender , System.Windows.Forms.KeyPressEventArgs e )
        {
            if ( e.KeyChar == 13 || e.KeyChar == 27 )
            {
                datPicker.Hide ();
                FinishDatPicker ();
            }
        }

        private void datPickerValueChanged ( object sender , EventArgs e )
        {
            datPicker.Hide ();
            FinishDatPicker ();

            SetTagColor ();
            Update ();
            Refresh ();
        }

        void datPickerClear ( object sender , EventArgs e )
        {
            datPicker.dat.Value = FF.Fun.MyConvert.Str2Date ( "1900-1-1" );
        }

        private void CmbSelected ( object sender , System.EventArgs e )
        {
            int nSel = cmbBox.SelectedIndex;
            if ( nSel < 0 )
                return;

            string strItemSel = cmbBox.Items [ nSel ].ToString ();
            _li.SubItems [ _subItemSelected ].Text = strItemSel;

            //通知父窗口, combo当前内容已经改变。
            int nItemIndex = Items.IndexOf ( _li );
            if ( nItemIndex < 0 )
                return;

            if ( this.SendMsg != null )
                this.SendMsg ( nItemIndex , strItemSel );
        }

        #endregion


    }

    public class COLORTAG
    {
        public int nLine = -1;
        public Color clrBK = Color.FromArgb( 255,255,255);
    }
}
