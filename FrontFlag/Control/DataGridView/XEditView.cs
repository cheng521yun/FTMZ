using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace FrontFlag.Control.DataGridView
{
    public partial class XEditView : System.Windows.Forms.DataGridView
    {
        List<DATA> _lst = new List<DATA> ();

        System.Windows.Forms.TextBox txtBox = new TextBox ();
        System.Windows.Forms.ComboBox cmb = new ComboBox();
        FrontFlag.Control.PickerDate.XDatePicker datPicker = new FrontFlag.Control.PickerDate.XDatePicker ();

        public delegate void entSendMsg( EVENTTYPE enmEventType , int nRow, int nCol, string strCaption , string strMsg );
        public event entSendMsg SendMsg = null;

        private bool _bBrief = false;  //true=简略显示方式。

        private int nColCaption = 0;   //Caption 的列序号
        private int nColValue = 1;   //Value 的列序号
        private int nColDef = 2;   //Def 的列序号

        //记录上次控件出现的位置。
        private int nOldCtrlRow = -1;
        private int nOldCtrlCol = -1;

        private Color clrCaptionFore = Color.FromArgb(0, 0, 0);
        private Color clrCaptionBK = Color.FromArgb ( 190, 206, 183 );
        private Color clrReadOnly = Color.FromArgb(190, 206, 183);

        private int _nLineH = 18;

        //定义哪些字段（Caption）需要输入数值类型
        List<string> _lstCaptionWithDecimal = new List<string>();


        public XEditView ()
        {
            InitializeComponent();

            InitCtrol();
        }

        void InitCtrol ()
        {
            ReadOnly = true;
            //this.AllowAddRows = false;
            AllowUserToAddRows = false;
            AllowUserToDeleteRows = false;
            AllowUserToResizeRows = false;
            ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            MultiSelect = false;
            RowHeadersVisible = false;
            SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            ScrollBars = System.Windows.Forms.ScrollBars.Both;
            BackgroundColor = System.Drawing.Color.White;
            BorderStyle = System.Windows.Forms.BorderStyle.None;
            Scroll += new System.Windows.Forms.ScrollEventHandler(OnScroll);
            CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.OnCellDoubleClick);
            txtBox.KeyDown += new KeyEventHandler ( OnKeyDown );

            RowTemplate.Height = _nLineH;

            SetStyle(ControlStyles.DoubleBuffer | ControlStyles.OptimizedDoubleBuffer | ControlStyles.AllPaintingInWmPaint, true);
            UpdateStyles();

            //
            Columns.Clear();

            DataGridViewColumn col1 = new DataGridViewTextBoxColumn ();
            col1.HeaderText = "Caption";
            col1.Name = "Caption";
            col1.DataPropertyName = "Caption";
            col1.ReadOnly = true;
            Columns.Add ( col1 );

            DataGridViewColumn col2 = new DataGridViewTextBoxColumn ();
            col2.HeaderText = "Value";
            col2.Name = "Value";
            col2.DataPropertyName = "Value";
            col2.ReadOnly = false;
            Columns.Add ( col2 );

            DataGridViewColumn col3 = new DataGridViewTextBoxColumn ();
            col3.HeaderText = "Def";
            col3.Name = "Def";
            col3.DataPropertyName = "Def";
            col3.ReadOnly = true;
            col3.Visible = false;
            Columns.Add ( col3 );

            Columns[0].DefaultCellStyle.ForeColor = clrCaptionFore;
            Columns[0].DefaultCellStyle.BackColor = clrCaptionBK;

            //
            txtBox.Parent = this;
            txtBox.AcceptsReturn = true;
            txtBox.WordWrap = false;
            txtBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler ( textBoxKeyPress );
            txtBox.Hide();

            cmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cmb.SelectedIndexChanged += new System.EventHandler ( cmb_SelectedIndexChanged );
            cmb.Parent = this;
            cmb.Hide();

            datPicker.Parent = this;
            datPicker.bShowTime = true;
            datPicker.Finish += dateTimePicker_ValueChanged ;
            datPicker.Hide();
        }

        #region 属性

        public List<DATA> lstData
        {
            set 
            {
                HideAllCtrl();

                _lst = value;
                _lst.Sort ( DATA.Compare );

                DataSource = new BindingList<DATA> ( _lst );

                SetList ();
                Refresh ();
            }
            get { return _lst; }
        }

        public bool bBrief
        {
            set
            {
                _bBrief = value;

                SetList ();
            }
            get { return _bBrief; }
        }

        #endregion

        #region Event

        protected override void OnPaint ( PaintEventArgs pe )
        {
            base.OnPaint ( pe );
        }

        /// <summary>
        /// 进入自己的textbox之后，按键事件不会传入到这个函数。所以不能用这个函数处理小数点问题。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnKeyDown ( object sender, KeyEventArgs e )
        {
            //if ( ( e.KeyCode == Keys.OemPeriod ) )
            //{
            //    //SendKeys.Send("{Tab}");
            //    txtBox.SelectedText = ".";
            //    e.Handled = true;
            //}
        }

        //Grd 会先于TextBox拦截回车键。 所以textBoxKeyPress()对回车键无效，需要对grd的按键事件重载。
        protected override bool ProcessCmdKey ( ref Message msg, Keys keyData )
        {
            if ( keyData == Keys.Enter ) //监听回车事件 
            {
                HideAllCtrl ();
            }

            if ( txtBox.Visible )
            {

                if (keyData.ToString() == "OemPeriod") //监听小数点事件 
                {
                    txtBox.SelectedText = ".";
                    //txtBox.Text = txtBox.Text.Replace("..", ".");
                    return true;
                }

                if (keyData.ToString() == "Left") //左箭头
                {
                    txtBox.SelectionLength = 0;
                    if (txtBox.SelectionStart > 0)
                        txtBox.SelectionStart--;
                    return true;
                }

                if (keyData.ToString() == "Right") //右箭头
                {
                    txtBox.SelectionLength = 0;
                    if (txtBox.SelectionStart < txtBox.Text.Length )
                        txtBox.SelectionStart ++;
                    return true;
                }

                if ( keyData.ToString () == "Up" ) //上箭头
                {
                    return true;
                }

                if ( keyData.ToString () == "Down" ) //下箭头
                {
                    return true;
                }

                if ( keyData.ToString () == "C, Control" ) //Copy组合键
                {
                    try
                    {
                        string strSelect = txtBox.Text;    //如果不选择Textbox内的任何字符，就拷贝全部内容。
                        if ( txtBox.SelectionLength > 0 )
                            strSelect = txtBox.Text.Substring( txtBox.SelectionStart, txtBox.SelectionLength );

                        Clipboard.SetDataObject( strSelect, true );
                    }
                    catch (Exception ex )
                    {
                    }
                    return true;
                }
            }

            //继续原来base.ProcessCmdKey中的处理 
            return base.ProcessCmdKey ( ref msg, keyData );
        }

        private void textBoxKeyPress ( object sender, KeyPressEventArgs e )
        {
            //Grd 会先于TextBox拦截回车键。 所以textBoxKeyPress()对回车键无效
        }

        private void cmb_SelectedIndexChanged ( object sender, EventArgs e )
        {
            Finish_cmb ();

            //选择完combox，通知父窗口combox已经选择新选项。 
            if ( SendMsg != null )
            {
                string strCaption = Rows [ nOldCtrlRow ].Cells [ nColCaption ].Value.ToString ();
                SendMsg(EVENTTYPE.ComboxChanged, nOldCtrlRow, -1, strCaption , cmb.Text);
            }
        }

        private void dateTimePicker_ValueChanged ( string strValue )
        {
            CurrentCell.Value = strValue;
            datPicker.Visible = false;
        }

        protected override void OnCellClick(System.Windows.Forms.DataGridViewCellEventArgs e)
        {
            HideAllCtrl();
        }

        private void OnScroll(object sender, ScrollEventArgs e)
        {
            HideAllCtrl();
        }

        private void OnCellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //IntPtr hWnd = this.Handle;
            //SendMessage ( (int)hWnd, WM_KEYDOWN, Convert.ToInt32 ( Keys.Delete ), 0 );
            //SendMessage ( (int) hWnd, WM_KEYUP, Convert.ToInt32 ( Keys.Delete ), 0 );

            //test
            //FF.Ctrl.MsgBox.Show("OnCellDoubleClick");

            //
            SetValue();
        }

        //const int WM_KEYDOWN = 0x100;
        //const int WM_KEYUP = 0x101;
        //const int WM_CHAR = 0x105;

        //[DllImport ( "User32.dll", EntryPoint = "SendMessage" )]
        //private static extern int SendMessage (
        //       int hWnd,　　　// handle to destination window
        //       int Msg,　　　 // message
        //       int wParam,　// first message parameter
        //       int lParam // second message parameter
        // ); 

        #endregion

        public void SetDecimalCaption( List<string> lstCaption )
        {
            _lstCaptionWithDecimal = lstCaption;
        }


        void SetList ()
        {
            RowTemplate.Height = _nLineH;

            nColCaption = GetColNo_ByName ( "Caption" );
            nColValue = GetColNo_ByName ( "Value" );
            nColDef = GetColNo_ByName ( "Def" );

            if (DataSource == null)
                return;

            if (((System.Windows.Forms.Control) (this)).BindingContext == null)
                return;

            if ( DataSource != null )
                BindingContext [ DataSource ].SuspendBinding ();

            EDITITEMDEF struDef = new EDITITEMDEF();

            for (int i = Rows.Count -1 ; i >= 0 ; i -- )
            {
                struDef.Set_ByCombin ( Rows[i].Cells[nColDef].Value.ToString() );

                if (struDef.bReadOnly)
                {
                    Rows[i].Cells[nColValue].Style.ForeColor = struDef.clrFore;
                    Rows[i].Cells[nColValue].Style.BackColor = clrReadOnly;
                }
                else
                {
                    Rows[i].Cells[nColValue].Style.ForeColor = struDef.clrFore;
                    Rows[i].Cells[nColValue].Style.BackColor = struDef.clrBK;
                }

                if (struDef.bShow)
                {
                    if (_bBrief && struDef.bHideInBrief)
                        Rows[i].Visible = false;
                    else
                        Rows[i].Visible = true;
                }
                else
                    Rows[i].Visible = false;
            }

            if ( DataSource != null )
                BindingContext [ DataSource ].ResumeBinding ();
        }

        void SetValue ()
        {
            //FF.Ctrl.MsgBox.Show("000");

            if ( CurrentCell == null )
                return;

            string strValue = CurrentCell.Value.ToString();

            HideAllCtrl();

            int nRow = CurrentCell.RowIndex;
            int nCol = CurrentCell.ColumnIndex;

            EDITITEMDEF struDef = new EDITITEMDEF();

            //FF.Ctrl.MsgBox.Show("111");

            try
            {
                struDef.strComBin = Rows[nRow].Cells[nColDef].Value.ToString();
            }
            catch ( Exception ex )
            {
                return;
            }

            //FF.Ctrl.MsgBox.Show("222");

            if ( struDef.bReadOnly )
                return;

            //test 1234
            //FF.Ctrl.MsgBox.Show(struDef.bEvent.ToString());

            //点击触发父窗口事件。
            if ( struDef.bEvent )
            {
                if ( SendMsg != null )
                {
                    string strCaption = Rows [ nRow ].Cells [ nColCaption ].Value.ToString ();
                    SendMsg(EVENTTYPE.Click, nRow , nCol, strCaption, "");
                }

                EndEdit();
                return;
            }

            //只有点击在第二列（数值列）才有效。
            if ( nCol != nColValue )
                return;

            Rectangle R = GetCellDisplayRectangle ( CurrentCell.ColumnIndex, CurrentCell.RowIndex, false );  //获取单元格位置
            nOldCtrlRow = nRow;
            nOldCtrlCol = nCol;

            if ( struDef.CtrlType == CONTROLTYPE.TextBox )
            {
                if ( txtBox == null )
                    return;

                txtBox.Text = ( CurrentCell == null ) ? "" : strValue;  //对txtBox赋值
                txtBox.SetBounds ( R.X, R.Y, R.Width, R.Height ); //定位坐标位置
                txtBox.Visible = true;

                //test
                //CurrentCell = this[ 0, 0 ];  
                //BeginEdit ( false );
            }

            else if ( struDef.CtrlType == CONTROLTYPE.Combox )
            {
                if ( cmb == null )
                    return;

                FF.Ctrl.Combo.Ary2Combo ( cmb, struDef.aryCombox );

                cmb.Text = ( CurrentCell == null ) ? "" : strValue;  //对combobox赋值
                cmb.SetBounds ( R.X, R.Y, R.Width, R.Height ); //定位坐标位置
                cmb.Visible = true;
            }

            else if ( struDef.CtrlType == CONTROLTYPE.DatePicker ) 
            {
                if ( datPicker == null )
                    return;

                datPicker.strDate = ( CurrentCell == null || strValue == "" ) ? "" : strValue;  //对combobox赋值
                datPicker.SetBounds ( R.X, R.Y, R.Width, R.Height ); //定位坐标位置
                if ( datPicker.strDate.Trim() == "" )
                    datPicker.ShowTxt ();
                else
                    datPicker.ShowDatPacker ();
                datPicker.Visible = true;
            }

        }

        public void HideAllCtrl ()
        {
            if ( txtBox.Visible )
                Finish_TextBox ();

            txtBox.Visible = false;
            cmb.Visible = false;
            datPicker.Visible = false;
        }

        private bool IsDecimal( string strVal )
        {
            try
            {
                decimal d = Convert.ToDecimal(strVal);
                return true;
            }
            catch (Exception e )
            {
                return false;
            }
        }

        private bool IsDecimalOrBlank (string strVal)
        {
            if (String.IsNullOrEmpty(strVal.Trim()))
                return true;

            return IsDecimal( strVal );
        }

        void Finish_TextBox ()
        {
            if ( nOldCtrlRow == -1 || nOldCtrlCol == -1 )
                return;

            string strCaption = Rows[ nOldCtrlRow ].Cells[ nColCaption ].Value.ToString();
            string strVal = txtBox.Text.Trim ();

            //对数值类型要判断内容是否合法有效。
            if ( _lstCaptionWithDecimal.Contains( strCaption ) )
            {
                //if (!IsDecimal(strVal))
                if ( !IsDecimalOrBlank( strVal ) )
                {
                    string strMsg = String.Format( "{0} 必须输入数值！", strCaption );
                    FF.Ctrl.MsgBox.ShowWarn( strMsg );
                }

                decimal d = FF.Fun.MyConvert.Str2Decimal( strVal );
                strVal = d.ToString();
            }

            Rows [ nOldCtrlRow ].Cells [ nOldCtrlCol ].Value = strVal;

            //输入完TextBox，通知父窗口TextBox已经选择新选项。 
            if (SendMsg != null)
            {
                SendMsg(EVENTTYPE.TextBoxChanged, nOldCtrlRow, -1, strCaption, strVal);
            }

            //
            txtBox.Visible = false;
        }

        void Finish_cmb ()
        {
            if ( nOldCtrlRow == -1 || nOldCtrlCol == -1 )
                return;

            Rows [ nOldCtrlRow ].Cells [ nOldCtrlCol ].Value = cmb.Text;
            cmb.Visible = false;
        }

        void Finish_DatePicker ()
        {
            datPicker.Visible = false;
        }

        #region public

        public void Clear ()
        {
            lstData = new List<DATA>();
        }

        public int GetRow_ByCaption ( string strCaption )
        {
            for ( int i = 0 ; i < Rows.Count ; i ++ )
            {
                if (Rows[i].Cells[0].Value.ToString().ToUpper() == strCaption.ToUpper())
                    return i;
            }

            return -1;
        }

        public int GetRow_ByFld(string strFld)
        {
            EDITITEMDEF struDef = new EDITITEMDEF();
            nColDef = GetColNo_ByName ( "Def" );

            for (int i = 0; i < Rows.Count; i++)
            {
                struDef.strComBin = Rows[i].Cells[nColDef].Value.ToString();

                if (struDef.Fld == strFld)
                    return i;
            }

            return -1;
        }

        /// <summary>
        /// 防止Fld重名， 用 EDITITEMDEF.Table 再区分一下。
        /// </summary>
        /// <param name="strFld"></param>
        /// <param name="strTab"></param>
        /// <returns></returns>
        public int GetRow_ByFldTab ( string strFld , string strTab )
        {
            EDITITEMDEF struDef = new EDITITEMDEF ();
            nColDef = GetColNo_ByName ( "Def" );

            for ( int i = 0 ; i < Rows.Count ; i++ )
            {
                struDef.strComBin = Rows [ i ].Cells [ nColDef ].Value.ToString ();

                if ( struDef.Fld == strFld && struDef.Table == strTab )
                    return i;
            }

            return -1;
        }

        public int GetColNo_ByName ( string strColName )
        {
            for ( int i = 0 ; i < Columns.Count ; i ++ )
            {
                if ( Columns [ i ].Name == strColName )
                    return i;
            }

            return -1;
        }

        public void SetValueCol_BKColor_ByFldName ( string strFldName , Color clr )
        {
            int nRow = GetRow_ByFld ( strFldName );
            Rows [ nRow ].Cells [ nColValue ].Style.BackColor = clr;
        }

        public void SetValueCol_ForeColor_ByFldName ( string strFldName, Color clr )
        {
            int nRow = GetRow_ByFld ( strFldName );
            Rows [ nRow ].Cells [ nColValue ].Style.BackColor = clr;
        }

        public void ShowRow_ByFld ( string strFldName, bool bShow )
        {
            int nRow = GetRow_ByFld ( strFldName );
            if ( nRow == -1 )
                return;

            //如果定义了只能不可见， 则程序也不能设置为可见。
            if ( ! IfCanShow_ByFld(strFldName))
                bShow = false;

            if ( DataSource != null )
                BindingContext [ DataSource ].SuspendBinding ();

            Rows [ nRow ].Visible = bShow;


            if ( DataSource != null )
                BindingContext [ DataSource ].ResumeBinding ();
        }

        public bool IsRowShow_ByFld ( string strFldName )
        {
            int nRow = GetRow_ByFld ( strFldName );
            if ( nRow == -1 )
                return false;

            return Rows [ nRow ].Visible;
        }

        public bool IfCanShow_ByFld(string strFldName)
        {
            int nRow = GetRow_ByFld(strFldName);
            nColDef = GetColNo_ByName("Def");

            EDITITEMDEF struDef = new EDITITEMDEF();

            try
            {
                struDef.strComBin = Rows[nRow].Cells[nColDef].Value.ToString();
            }
            catch (Exception ex)
            {
                return false;
            }

            return struDef.bCanShow;
        }

        //ReadOnly
        public void SetReadOnly_ByFldName ( string strFldName, bool bReadOnly )
        {
            //如果定义了只能只读， 则程序也不能设置为可读。
            if (IfCanReadOnly_ByFld(strFldName))
                bReadOnly = true;

            int nRow = GetRow_ByFld ( strFldName );
            if ( nRow < 0 )
                return ;

            nColDef = GetColNo_ByName ( "Def" );

            EDITITEMDEF struDef = new EDITITEMDEF ();

            try
            {
                struDef.strComBin = Rows [ nRow ].Cells [ nColDef ].Value.ToString ();
            }
            catch ( Exception ex )
            {
                return;
            }

            struDef.bReadOnly = bReadOnly;

            Rows[nRow].Cells[nColDef].Value = struDef.strComBin;
        }

        public bool GetReadOnly_ByFldName ( string strFldName, bool bReadOnly )
        {
            int nRow = GetRow_ByFld ( strFldName );
            nColDef = GetColNo_ByName ( "Def" );

            EDITITEMDEF struDef = new EDITITEMDEF ();

            try
            {
                struDef.strComBin = Rows [ nRow ].Cells [ nColDef ].Value.ToString ();
            }
            catch ( Exception ex )
            {
                return false;
            }

            return struDef.bReadOnly;
        }

        public bool IfCanReadOnly_ByFld(string strFldName)
        {
            int nRow = GetRow_ByFld(strFldName);
            if ( nRow < 0 )
                return false;

            nColDef = GetColNo_ByName("Def");

            EDITITEMDEF struDef = new EDITITEMDEF();

            try
            {
                struDef.strComBin = Rows[nRow].Cells[nColDef].Value.ToString();
            }
            catch (Exception ex)
            {
                return false;
            }

            return struDef.bCanReadOnly;
        }

        #region Set,Get Value

        public string GetValue_ByCaption ( string strCaption )
        {
            int nRow = GetRow_ByCaption ( strCaption );
            int nColValue = GetColNo_ByName ( "Value" );
            if ( nRow < 0 || nColValue < 0 )
                return "";
            return Rows [ nRow ].Cells [ nColValue ].Value.ToString ();
        }

        public bool SetValue_ByCaption ( string strCaption, string strValue )
        {
            int nRow = GetRow_ByCaption ( strCaption );
            int nColValue = GetColNo_ByName ( "Value" );
            if ( nRow < 0 || nColValue < 0 )
                return false;
            Rows [ nRow ].Cells [ nColValue ].Value = strValue;
            return true;
        }

        public string GetValue_ByFld ( string strFld )
        {
            int nRow = GetRow_ByFld ( strFld );
            int nColValue = GetColNo_ByName ( "Value" );
            if ( nRow < 0 || nColValue < 0 )
                return "";
            return Rows [ nRow ].Cells [ nColValue ].Value.ToString ();
        }

        public bool SetValue_ByFld ( string strFld, string strValue )
        {
            int nRow = GetRow_ByFld ( strFld );
            int nColValue = GetColNo_ByName ( "Value" );
            if ( nRow < 0 || nColValue < 0 )
                return false;
            Rows [ nRow ].Cells [ nColValue ].Value = strValue;
            return true;
        }

        public string GetValue_ByFldTab ( string strFld, string strTab )
        {
            int nRow = GetRow_ByFldTab ( strFld, strTab );
            int nColValue = GetColNo_ByName ( "Value" );
            if ( nRow < 0 || nColValue < 0 )
                return "";
            return Rows [ nRow ].Cells [ nColValue ].Value.ToString ();
        }

        public bool SetValue_ByFldTab ( string strFld, string strTab, string strValue )
        {
            int nRow = GetRow_ByFldTab ( strFld, strTab );
            int nColValue = GetColNo_ByName ( "Value" );
            if ( nRow < 0 || nColValue < 0 )
                return false;
            Rows [ nRow ].Cells [ nColValue ].Value = strValue;
            return true;
        }

        #endregion

        #endregion
    }

    public enum CONTROLTYPE
    {
        TextBox,
        Combox,
        DatePicker 
    }

    public enum EVENTTYPE
    {
        Click,
        ComboxChanged,
        DatePickerChanged,
        TextBoxChanged
    }

    
    ///// <summary>
    ///// 定义第二列内容的数值类型
    ///// </summary>
    //public enum VALUETYPE
    //{
    //    Text,
    //    Decimal,
    //    Date
    //}


    //public class EDITITEMDEF_OLD
    //{
    //    public string Caption = "";
    //    public string Table = "";
    //    public string Fld = "";
    //    public string Value = "";

    //    public CONTROLTYPE CtrlType = CONTROLTYPE.TextBox;    //控件的类型 Text,Combox,DatePocker     
    //    public bool bShow = true;
    //    public bool bReadOnly = false;
    //    public int OrderNo = 0;
    //    public bool bHideInBrief = false;     //true=列表切换为简略状态时，不显示的项。
    //    public bool bEvent = false;     //Click 是否发送消息给父窗口。

    //    public Color clrFore = Color.Black;
    //    public Color clrBK = Color.White;

    //    public ArrayList aryCombox = new ArrayList();  //combox下拉框内要现实的内容。

    //    private int MaxUnitLen = 13;
    //    private string strSplit = "&|&";

    //    public string strComBin
    //    {
    //        set
    //        {
    //            string [] chs = new string [] { strSplit };
    //            string [] strs = value.Split (chs , StringSplitOptions.None);

    //            if ( strs == null || strs.Length != MaxUnitLen )
    //                return;

    //            int i = 0;

    //            try
    //            {

    //                Caption = strs [ i++ ]; 
    //                Table = strs [ i++ ];
    //                Fld = strs [ i++ ];
    //                Value = strs[i++];

    //                CtrlType = (CONTROLTYPE) int.Parse ( strs [ i++ ] );
    //                bShow = bool.Parse(strs[i++]);
    //                bReadOnly = bool.Parse ( strs [ i++ ] );
    //                OrderNo = int.Parse(strs[i++]);
    //                bHideInBrief = bool.Parse ( strs [ i++ ] );
    //                bEvent = bool.Parse(strs[i++]);

    //                clrFore = FF.Fun.MyConvert.CombinStr2Color ( strs [ i++ ] );
    //                clrBK = FF.Fun.MyConvert.CombinStr2Color ( strs [ i++ ] );

    //                aryCombox = FF.Fun.MyConvert.CombinStr2ary ( strs [ i++ ] );
    //            }
    //            catch ( Exception e )
    //            {
    //                FF.Ctrl.MsgBox.ShowWarn("XEdeitView.strComBin转换发生错误!" + " " + e.Message);
    //                return;
    //            }
    //        }

    //        get
    //        {
    //            string strRet = "";

    //            strRet += Caption + strSplit; 
    //            strRet += Table + strSplit;
    //            strRet += Fld + strSplit;
    //            strRet += Value + strSplit;

    //            strRet += ((int)CtrlType).ToString() + strSplit;
    //            strRet += bShow.ToString() + strSplit;
    //            strRet += bReadOnly.ToString () + strSplit;
    //            strRet += OrderNo.ToString() + strSplit;
    //            strRet += bHideInBrief.ToString () + strSplit;
    //            strRet += bEvent.ToString () + strSplit;

    //            strRet += FF.Fun.MyConvert.Color2CombinStr ( clrFore ) + strSplit;
    //            strRet += FF.Fun.MyConvert.Color2CombinStr ( clrBK ) + strSplit;

    //            strRet += FF.Fun.MyConvert.ary2CombinStr( aryCombox );
 
    //            return strRet;
    //        }
    //    }

    //    public void Set_ByCombin ( string strCombin )
    //    {
    //        string [] chs = new string [] { strSplit };
    //        string[] strs = strCombin.Split(chs, StringSplitOptions.None);

    //        if ( strs == null || strs.Length != MaxUnitLen )
    //        {
    //            return;
    //        }

    //        int i = 0;

    //        try
    //        {

    //            Caption = strs [ i++ ]; 
    //            Table = strs [ i++ ];
    //            Fld = strs [ i++ ];
    //            Value = strs[i++];

    //            CtrlType = (CONTROLTYPE) int.Parse ( strs [ i++ ] );
    //            bShow = bool.Parse(strs[i++]);
    //            bReadOnly = bool.Parse ( strs [ i++ ] );
    //            OrderNo = int.Parse(strs[i++]);
    //            bHideInBrief = bool.Parse ( strs [ i++ ] );
    //            bEvent = bool.Parse(strs[i++]);

    //            clrFore = FF.Fun.MyConvert.CombinStr2Color ( strs [ i++ ] );
    //            clrBK = FF.Fun.MyConvert.CombinStr2Color ( strs [ i++ ] );

    //            //FF.Debug.Log("strComBin:" + "Caption:" + Caption + " Color:" + clrBK.ToString());

    //            aryCombox = FF.Fun.MyConvert.CombinStr2ary ( strs [ i++ ] );
    //        }
    //        catch ( Exception e )
    //        {
    //            FF.Ctrl.MsgBox.ShowWarn("XEdeitView.strComBin转换发生错误!" + " " + e.Message);
    //            return;
    //        }
    //    }
    //}

    /// <summary>
    /// 定义一条行数据行的 数据 和 属性。
    /// </summary>
    public class EDITITEMDEF
    {
        public string Caption = "";
        public string Table = "";
        public string Fld = "";
        public string Value = "";

        public CONTROLTYPE CtrlType = CONTROLTYPE.TextBox;    //控件的类型 Text,Combox,DatePocker     
        public bool bCanShow = true;                          //是否允许显示,Setting设置
        public bool bCanReadOnly = false;                     //是否允许只读,Setting设置
        public int OrderNo = 0;
        public bool bHideInBrief = false;     //true=列表切换为简略状态时，不显示的项。
        public bool bEvent = false;     //Click 是否发送消息给父窗口。

        public Color clrFore = Color.Black;
        public Color clrBK = Color.White;

        public bool bShow = true;                               //true=当前是显示状态，程序临时改变，最终受bCanShow约束
        public bool bReadOnly = false;                          //true=当前是只读状态，程序临时改变，最终受bCanReadOnly约束

        public ArrayList aryCombox = new ArrayList();  //combox下拉框内要现实的内容。

        private int MaxUnitLen = 15;   //数据库中保存的变量个数。即需要读取和赋值的变量数目
        private string strSplit = "&|&";

        public string strComBin
        {
            set
            {
                string[] chs = new string[] { strSplit };
                string[] strs = value.Split(chs, StringSplitOptions.None);

                if (strs == null || strs.Length != MaxUnitLen)
                    return;

                int i = 0;

                try
                {

                    Caption = strs[i++];
                    Table = strs[i++];
                    Fld = strs[i++];
                    Value = strs[i++];

                    CtrlType = (CONTROLTYPE)int.Parse(strs[i++]);
                    bCanShow = bool.Parse(strs[i++]);
                    bCanReadOnly = bool.Parse(strs[i++]);
                    OrderNo = int.Parse(strs[i++]);
                    bHideInBrief = bool.Parse(strs[i++]);
                    bEvent = bool.Parse(strs[i++]);

                    clrFore = FF.Fun.MyConvert.CombinStr2Color(strs[i++]);
                    clrBK = FF.Fun.MyConvert.CombinStr2Color(strs[i++]);

                    bShow = bool.Parse(strs[i++]);
                    bReadOnly = bool.Parse(strs[i++]);

                    aryCombox = FF.Fun.MyConvert.CombinStr2ary(strs[i++]);
                }
                catch (Exception e)
                {
                    FF.Ctrl.MsgBox.ShowWarn("XEdeitView.strComBin转换发生错误!" + " " + e.Message);
                    return;
                }
            }

            get
            {
                string strRet = "";

                strRet += Caption + strSplit;
                strRet += Table + strSplit;
                strRet += Fld + strSplit;
                strRet += Value + strSplit;

                strRet += ((int)CtrlType).ToString() + strSplit;
                strRet += bCanShow.ToString() + strSplit;
                strRet += bCanReadOnly.ToString() + strSplit;
                strRet += OrderNo.ToString() + strSplit;
                strRet += bHideInBrief.ToString() + strSplit;
                strRet += bEvent.ToString() + strSplit;

                strRet += FF.Fun.MyConvert.Color2CombinStr(clrFore) + strSplit;
                strRet += FF.Fun.MyConvert.Color2CombinStr(clrBK) + strSplit;

                strRet += bShow.ToString() + strSplit;
                strRet += bReadOnly.ToString() + strSplit;

                strRet += FF.Fun.MyConvert.ary2CombinStr(aryCombox);

                return strRet;
            }
        }

        public void Set_ByCombin(string strCombin)
        {
            if (strCombin == null)
                return;

            string[] chs = new string[] { strSplit };
            string[] strs = strCombin.Split(chs, StringSplitOptions.None);

            if (strs == null || strs.Length != MaxUnitLen)
            {
                return;
            }

            int i = 0;

            try
            {

                Caption = strs[i++];
                Table = strs[i++];
                Fld = strs[i++];
                Value = strs[i++];

                CtrlType = (CONTROLTYPE)int.Parse(strs[i++]);
                bCanShow = bool.Parse(strs[i++]);
                bCanReadOnly = bool.Parse(strs[i++]);
                OrderNo = int.Parse(strs[i++]);
                bHideInBrief = bool.Parse(strs[i++]);
                bEvent = bool.Parse(strs[i++]);

                clrFore = FF.Fun.MyConvert.CombinStr2Color(strs[i++]);
                clrBK = FF.Fun.MyConvert.CombinStr2Color(strs[i++]);

                //FF.Debug.Log("strComBin:" + "Caption:" + Caption + " Color:" + clrBK.ToString());

                bShow = bool.Parse(strs[i++]);
                bReadOnly = bool.Parse(strs[i++]);

                aryCombox = FF.Fun.MyConvert.CombinStr2ary(strs[i++]);
            }
            catch (Exception e)
            {
                FF.Ctrl.MsgBox.ShowWarn("XEdeitView.strComBin转换发生错误!" + " " + e.Message);
                return;
            }
        }


        //public void FromOld ( EDITITEMDEF_OLD struOld )
        //{
        //    Caption = struOld.Caption;
        //    Table = struOld.Table;
        //    Fld = struOld.Fld;
        //    Value = struOld.Value;

        //    CtrlType = struOld.CtrlType;    //控件的类型 Text,Combox,DatePocker     
        //    bCanShow = struOld.bShow;                          //是否允许显示
        //    bCanReadOnly = struOld.bReadOnly;                     //是否允许只读
        //    OrderNo = struOld.OrderNo;
        //    bHideInBrief = struOld.bHideInBrief;     //true=列表切换为简略状态时，不显示的项。
        //    bEvent = struOld.bEvent;     //Click 是否发送消息给父窗口。

        //    clrFore = struOld.clrFore;
        //    clrBK = struOld.clrBK;

        //    bShow = struOld.bShow;
        //    bReadOnly = struOld.bReadOnly;  
        //}
    }

    [Serializable]
    public class DATA
    {
        private string _strCaption = "";
        private string _strValue = "";
        private string _strDef = "";

        public string Caption
        {
            set { _strCaption = value; }
            get { return _strCaption; }
        }

        public string Value
        {
            set { _strValue = value; }
            get { return _strValue; }
        }

        public string Def
        {
            set { _strDef = value; }
            get { return _strDef; }
        }

        public static int Compare ( DATA t1, DATA t2 )
        {
            EDITITEMDEF def1 = new EDITITEMDEF();
            EDITITEMDEF def2 = new EDITITEMDEF();
            
            def1.strComBin = t1.Def;
            def2.strComBin = t2.Def;


            if ( def1.OrderNo > def2.OrderNo )
                return 1;
            else if ( def1.OrderNo < def2.OrderNo )
                return -1;

            return 0;
        }

        public static List<DATA> FromDefList ( List<EDITITEMDEF> lstDef )
        {
            List<DATA> lstData = new List<DATA>();

            foreach ( EDITITEMDEF def in lstDef )
            {
                DATA data = new DATA();

                data.Caption = def.Caption.ToUpper();
                data.Def = def.strComBin;

                lstData.Add( data );
            }

            return lstData;
        }

    }
}
