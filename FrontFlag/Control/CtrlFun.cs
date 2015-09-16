using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using System.Drawing;
using System.IO;

using FrontFlag.Control;

namespace FrontFlag
{
    public class CONTROL
    {
        public FORM Form = new FORM ( );
        public TEXTBOX TxtBox = new TEXTBOX ();
        public COMBO Combo = new COMBO ( );
        public BUTTON Button = new BUTTON ( );
        public MESSAGEBOX MsgBox = new MESSAGEBOX ( );
        public GRID Grid = new GRID ( );
        public LISTVIEW ListView = new LISTVIEW ( );
        public BIND Bind = new BIND ( );
        public TOOLBAR ToolBar = new TOOLBAR ( );
        public LAYOUT Layout = new LAYOUT ( );
        public PICTUREBOX PicBox = new PICTUREBOX ( );

        public GROUPBOX GronpBox = new GROUPBOX();
        
    }

    public class UICOMMAND   
    {
        public int CommandID = 0;
        public string strParam = String.Empty;
        public object Tag = null;

        public UICOMMAND( int CommandID )
        {
            this.CommandID = CommandID;
        }

        public UICOMMAND( int CommandID, string strParam )
        {
            this.CommandID = CommandID;
            this.strParam = strParam;
        }
    }


    public class FORM
    {
        //Form
        public void SetDialog ( ref Form form )
        {
            form.AutoScaleDimensions = new System.Drawing.SizeF ( 6F , 12F );
            form.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            form.BackColor = Color.FromArgb ( 244 , 243 , 238 );
            form.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            form.MaximizeBox = false;
            form.MinimizeBox = false;
            form.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        }

        /*
        public Form GetParentByName( Form f, string strFindName)
        {
            Object obj = (Object)f;
            Type type ;

            try
            {
                while (true)
                {
                    f = (Object)obj.Parent;
                    type = obj.GetType();
                    if (type.Name == strFindName)
                        return obj;
                }
            }
            catch
            {
                return null;
            }
        }
         */

        /*
        public FORM FindParent ( Form fOrg , string strFormName )
        { 
            Form f = fOrg ;
            while ( f.Parent != null )
            {
                if ( f.Name == strFormName )
                    return ( FORM ) f;
            }

            return null;
        }
          */
    }

    public class TOOLBAR
    {
        /*            public void SetToolBarStyle ( ref DevExpress.XtraBars.BarDockControl barDockControlTop , ref DevExpress.XtraBars.Bar bar )
                    {
                        barDockControlTop.Appearance.BackColor = DEF.Appearance.Color.ToolBarBK;    //工具条背景色
                        bar.Appearance.BackColor = System.Drawing.Color.Transparent;                //工具条上butn的背景为透明.
                    }
         */
    }

    public class TEXTBOX
    {
        public void SetPassword ( ref TextBox txtbox )
        {
            txtbox.PasswordChar = '*';
        }

        public void SetUnPassword ( ref TextBox txtbox )
        {
            txtbox.PasswordChar = Convert.ToChar ( 0 );
        }

        public void SetReadOnly ( ref TextBox txtbox )
        {
            txtbox.ReadOnly = true;
            txtbox.BackColor = Color.WhiteSmoke;
        }

        public void SetReadOnly_WhiteBK(ref TextBox txtbox)
        {
            txtbox.ReadOnly = true;
            txtbox.BackColor = Color.White;
        }

        public void SetReadOnly_WhiteBK( ref XTextBox txtbox )
        {
            txtbox.ReadOnly = true;
            txtbox.BackColor = Color.White;
        }

        public void SetUnReadOnly ( ref TextBox txtbox )
        {
            txtbox.ReadOnly = false;
            txtbox.BackColor = Color.White;
        }

        public void ToUpper ( ref TextBox txtbox )
        {
            int n = txtbox.Text.Length;
            txtbox.Text = txtbox.Text.ToUpper ();
            txtbox.SelectionStart = n;
        }

    };

    public class COMBO
    {
        public class COMBOITEM
        {
            private string _text = null;
            private object _value = null;
            public string Text { get { return this._text; } set { this._text = value; } }
            public object Value { get { return this._value; } set { this._value = value; } }
            public override string ToString ()
            {
                return this._text;
            }
        }

        public bool isExsit(ComboBox cmb, string strText)
        {
            foreach ( string str in cmb.Items )
            {
                if (str.Trim() == strText.Trim())
                    return true;
            }

            return false;
        }
        public bool isExsit_Insensitive( ComboBox cmb, string strText )
        {
            foreach ( string str in cmb.Items )
            {
                if ( str.Trim().ToLower() == strText.Trim().ToLower() )
                    return true;
            }

            return false;
        }

        public void AddItem( ComboBox cmb, string strText )
        {
            cmb.Items.Add( strText );
        }

        public void AddItem ( ComboBox cmb , string strText , int nVal )
        {
            COMBOITEM cbi = new COMBOITEM ();
            cbi.Text = strText;
            cbi.Value = nVal;
            cmb.Items.Add ( cbi );
        }

        public void SetSelectText ( ComboBox cmb , string strText )
        {
            if ( cmb.Items.Count <= 0 )
                return;

            if ( strText == null )
                return;

            int index = cmb.Items.IndexOf ( strText );
            cmb.SelectedIndex = ( index < 0 ) ? 0 : index;
        }
        /// <summary>
        /// 大小写不敏感的匹配
        /// </summary>
        /// <param name="cmb"></param>
        /// <param name="strText"></param>
        public void SetSelectText_NoCaseSens( ComboBox cmb, string strText )
        {
            if ( cmb.Items.Count <= 0 )
                return;

            int index = -1, n = -1;
            foreach ( string str in cmb.Items )
            {
                n ++;
                if ( str.ToLower().Trim() == strText.ToLower().Trim() )
                {
                    index = n;
                    break;
                }
            }
            cmb.SelectedIndex = ( index < 0 ) ? 0 : index;
        }

        /// <summary>
        /// 如果cmb中没有，就添加进cmb中，并选中它。
        /// </summary>
        /// <param name="cmb"></param>
        /// <param name="strText"></param>
        public void SetSelectText_Append ( ComboBox cmb, string strText )
        {
            int index = cmb.Items.IndexOf ( strText );
            if ( index < 0 )
            {
                cmb.Items.Add(strText);
                cmb.SelectedIndex = cmb.Items.Count - 1 ;
            }
            else
            {
                cmb.SelectedIndex = index;
            }

        }

        public void SetNum ( ComboBox cmb , int Num )
        {
            if ( Num <= 0 )
                return;

            cmb.Items.Clear ( );
            for ( int i = 1 ; i <= Num ; i++ )
                cmb.Items.Add ( i.ToString ( ) );

            cmb.SelectedIndex = 0;
        }

        public bool SetSelectIndex ( ComboBox cmb , int Index )
        {
            if ( Index < 0 || Index >= cmb.Items.Count )
            {
                cmb.SelectedIndex = ( cmb.Items.Count > 0 ) ? 0 : -1;
                return false;
            }
            else
            {
                cmb.SelectedIndex = Index;
                return true;
            }
        }

        public bool SetZeroIndex ( ComboBox cmb )
        {
            return SetSelectIndex ( cmb , 0 );
        }

        public void Ary2Combo ( ComboBox cmb , ArrayList ary )
        {
            cmb.Items.Clear ( );

            if ( ary == null )
                return ;

            for ( int i = 0 ; i < ary.Count ; i++ )
                cmb.Items.Add ( ary [ i ] );

            if ( cmb.Items.Count > 0 )
                cmb.SelectedIndex = 0;
        }

        public void AppendAry2Combo ( ComboBox cmb , ArrayList ary )
        {
            if (ary == null)
                return;

            for ( int i = 0 ; i < ary.Count ; i++ )
                cmb.Items.Add ( ary [ i ] );

            if ( cmb.Items.Count > 0 )
                cmb.SelectedIndex = 0;
        }

        public void Ary2Combo_WithBlank ( ComboBox cmb , ArrayList ary )
        {
            if (ary == null)
                return;

            cmb.Items.Clear ( );
            cmb.Items.Add ( " " );
            for ( int i = 0 ; i < ary.Count ; i++ )
                cmb.Items.Add ( ary [ i ] );

            if ( cmb.Items.Count > 0 )
                cmb.SelectedIndex = 0;
        }

        public void Strs2Combo ( ComboBox cmb , string [ ] strs )
        {
            cmb.Items.Clear ( );

            if ( strs == null )
                return;

            for ( int i = 0 ; i < strs.Length ; i++ )
                cmb.Items.Add ( strs [ i ] );

            if ( cmb.Items.Count > 0 )
                cmb.SelectedIndex = 0;
        }

        public void Strs2Combo_WithBlank ( ComboBox cmb , string [ ] strs )
        {
            cmb.Items.Clear ( );
            cmb.Items.Add ( " " );

            if ( strs == null )
                return;

            for ( int i = 0 ; i < strs.Length ; i++ )
                cmb.Items.Add ( strs [ i ] );

            if ( cmb.Items.Count > 0 )
                cmb.SelectedIndex = 0;
        }

        public void List2Combo( ComboBox cmb, List<string> lst)
        {
            cmb.Items.Clear();

            if (lst == null || lst.Count<= 0 )
                return;

            foreach (string str in lst)
                cmb.Items.Add(str);

            if (cmb.Items.Count > 0)
                cmb.SelectedIndex = 0;
        }

        public void List2Combo_WithBlank( ComboBox cmb, List<string> lst)
        {
            cmb.Items.Clear();

            if (lst == null || lst.Count <= 0)
                return;

            cmb.Items.Add(" ");
            foreach (string str in lst)
                cmb.Items.Add(str);

            if (cmb.Items.Count > 0)
                cmb.SelectedIndex = 0;
        }

        /// <summary>
        /// 可以选择的年份数量。
        /// 建议使用奇数，这样可以使当前年份，排在所有选项的最中间。
        /// </summary>
        /// <param name="nSelNum"></param>
        public void SetYear( ComboBox cmb, int nSelNum )
        {
            int nHalf = ( nSelNum-1 ) / 2;            
            int Year1 = DateTime.Now.Year - nHalf;
            int Year2 = Year1 + nHalf * 2 + 1;

            cmb.Items.Clear();
            for ( int i = Year1 ; i < Year2 ; i++ )
            {
                cmb.Items.Add( i.ToString() );
            }

            if ( cmb.Items.Count > 0 )
                cmb.SelectedIndex = 0;
        }

        public void SetMonth( ComboBox cmb )
        {
            cmb.Items.Clear();

            string str;
            for ( int i = 1 ; i <= 12 ; i++ )
            {
                str = String.Format( "{0:00}", i );
                cmb.Items.Add( str );
            }

            if ( cmb.Items.Count > 0 )
                cmb.SelectedIndex = 0;
        }

        public void SetMothDay ( ComboBox cmb )
        {
            cmb.Items.Clear ( );

            string str;
            for ( int i = 1 ; i <= 31 ; i++ )
            {
                str = String.Format ( "{0}" , i );
                cmb.Items.Add ( str );
            }

            if ( cmb.Items.Count > 0 )
                cmb.SelectedIndex = 0;
        }

        public void SetMothDay28 ( ComboBox cmb )
        {
            cmb.Items.Clear ( );

            string str;
            for ( int i = 1 ; i <= 28 ; i++ )
            {
                str = String.Format ( "{0}" , i );
                cmb.Items.Add ( str );
            }

            if ( cmb.Items.Count > 0 )
                cmb.SelectedIndex = 0;
        }

        public void SetHour( ComboBox cmb )
        {
            cmb.Items.Clear();
            for ( int i = 0 ; i <= 23 ; i++ )
                cmb.Items.Add( String.Format( "{0,2:00}", i ) );
            cmb.SelectedIndex = 9;
        }

        public void SetMin( ComboBox cmb )
        {
            cmb.Items.Clear();
            for ( int i = 0 ; i <= 59 ; i++ )
                cmb.Items.Add( String.Format( "{0,2:00}", i ) );

            if ( cmb.Items.Count > 0 )
                cmb.SelectedIndex = 0;
        }

        /*
        public void XtraGrid_SetCanSale ( DevExpress.XtraEditors.Repository.RepositoryItemComboBox cmb )
        {
            PROGRAM.ROLE Role = new PROGRAM.ROLE ();
            ArrayList ary = new ArrayList ();

            cmb.Items.Clear ();
            ary = Role.GetAryCanSale ();

            for ( int i = 0 ; i < ary.Count ; i++ )
                cmb.Items.Add ( ary[i] );
        }*/

        public void AddRange ( ComboBox cmb , string [ ] strs )
        {
            cmb.Items.Clear ( );

            if ( strs.Length <= 0 )
                return;

            cmb.Items.AddRange ( strs );

            if ( cmb.Items.Count > 0 )
                cmb.SelectedIndex = 0;
        }

        public void AppendRange( ComboBox cmb, string[] strs )
        {
            if( strs.Length <= 0 )
                return;

            cmb.Items.AddRange( strs );

            if( cmb.Items.Count > 0 )
                cmb.SelectedIndex = 0;
        }

        public void SetCallMode ( ref ComboBox cmb )
        {
            cmb.Items.Clear ( );
            string [ ] strs = new string [ ] { "Tel" , "Email" , "Fax" , "MSN" , "QQ" };
            cmb.Sorted = false;
            AddRange ( cmb , strs );
        }

        public void SetCallWell ( ref ComboBox cmb )
        {
            cmb.Items.Clear ( );
            string [ ] strs = new string [ ] { "1" , "2" , "3" , "4" , "5" , "0"  };
            cmb.Sorted = false;
            AddRange ( cmb , strs );
        }

    }

    public class BUTTON
    {
        public void SetStyle_HotLink ( ref System.Windows.Forms.Button btn , string strCaption )
        {
            btn.Text = strCaption;
            btn.BackColor = System.Drawing.Color.Transparent;
            btn.Cursor = System.Windows.Forms.Cursors.Hand;
            btn.FlatAppearance.BorderSize = 0;
            btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn.Font = new System.Drawing.Font ( "Tahoma" , 9 , System.Drawing.FontStyle.Underline , System.Drawing.GraphicsUnit.Point , ( ( byte ) ( 0 ) ) );
            btn.Margin = new System.Windows.Forms.Padding ( 1 , 3 , 1 , 3 );
            btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btn.UseVisualStyleBackColor = true;
            btn.Cursor = System.Windows.Forms.Cursors.Hand;
        }

        public void SetStyle_Icon ( ref System.Windows.Forms.Button btn )
        {
            btn.BackColor = System.Drawing.Color.Transparent;
            btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            btn.Cursor = System.Windows.Forms.Cursors.Hand;
            btn.FlatAppearance.BorderSize = 0;
            btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            btn.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            btn.Font = new System.Drawing.Font ( "宋体" , 9F );
            btn.ForeColor = System.Drawing.Color.FromArgb ( ( ( int ) ( ( ( byte ) ( 0 ) ) ) ) , ( ( int ) ( ( ( byte ) ( 192 ) ) ) ) , ( ( int ) ( ( ( byte ) ( 0 ) ) ) ) );
            btn.Margin = new System.Windows.Forms.Padding ( 2 , 3 , 2 , 3 );
            btn.Size = new System.Drawing.Size ( 20 , 20 );
            btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btn.UseVisualStyleBackColor = false;
            btn.Cursor = System.Windows.Forms.Cursors.Hand;
        }

        public void SetToolButn ( ref Button btn , Color clrBK )
        {
            btn.BackColor = clrBK;
            btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            btn.Cursor = System.Windows.Forms.Cursors.Hand;
            btn.FlatAppearance.BorderSize = 0;
            btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn.Size = new System.Drawing.Size ( 24 , 24 );
            btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            btn.UseMnemonic = false;
            btn.UseVisualStyleBackColor = false;
        }

        public void SetToolButn ( ref Button btn )
        {
            SetToolButn ( ref btn , Color.Transparent );
        }

    }

    public class MESSAGEBOX
    {
        public void Show ( string strMsg )
        {
            MessageBox.Show ( strMsg , "Information" , MessageBoxButtons.OK , MessageBoxIcon.Information );
            return;
        }
        public bool ShowWarn ( string strMsg )
        {
            MessageBox.Show ( strMsg , "Warning" , MessageBoxButtons.OK , MessageBoxIcon.Warning );
            return false;
        }

        //use eg: if ( DialogResult.No == Comm.Ctrl.MsgBox.ShowYesNo ( "do you really want to DELETE the Employee ? " ) ) {...}
        public DialogResult ShowYesNo ( string strMsg )
        {
            return MessageBox.Show ( strMsg , "Warning" , MessageBoxButtons.YesNo , MessageBoxIcon.Question );
        }

        public bool ShowYesNo_RetBool (string strMsg)
        {
            DialogResult ret = MessageBox.Show(strMsg, "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            return ret == DialogResult.Yes;
        }
    }

    public class LISTVIEW
    {
        public void SetStyle_Comm ( ref System.Windows.Forms.ListView lv )
        {
            lv.FullRowSelect = true;
            lv.GridLines = true;
            lv.View = System.Windows.Forms.View.Details;
            lv.MultiSelect = false;
            lv.HideSelection = false;
        }

        public int GetAllColWidth ( ref System.Windows.Forms.ListView lv )
        {
            int nAllW = 0;
            int count = lv.Columns.Count;
            for ( int i = 0 ; i < count ; i++ )
            {
                nAllW += lv.Columns [ i ].Width;
            }

            return nAllW;
        }

        public int GetAllColWidth ( ref XListView lv )
        {
            int nAllW = 0;
            int count = lv.Columns.Count;
            for ( int i = 0 ; i < count ; i++ )
            {
                nAllW += lv.Columns [ i ].Width;
            }

            return nAllW;
        }

        public void SetLineHeight ( ref ListView lst , int nHeight )
        {
            ImageList imgList = new ImageList ( );
            imgList.ImageSize = new Size ( 1 , nHeight );//分别是宽和高
            lst.SmallImageList = imgList;   //这里设置listView的SmallImageList ,用imgList将其撑大
        }

        public void SetLineHeight ( ref XListView lst , int nHeight )
        {
            ImageList imgList = new ImageList ();
            imgList.ImageSize = new Size ( 1 , nHeight );//分别是宽和高
            lst.SmallImageList = imgList;   //这里设置listView的SmallImageList ,用imgList将其撑大
        }
        public void SetLineHeight( ref XListView2 lst, int nHeight )
        {
            ImageList imgList = new ImageList();
            imgList.ImageSize = new Size( 1, nHeight );//分别是宽和高
            lst.SmallImageList = imgList;   //这里设置listView的SmallImageList ,用imgList将其撑大
        }

        public void SetLineHeight ( ref XEditListView lst , int nHeight )
        {
            ImageList imgList = new ImageList ();
            imgList.ImageSize = new Size ( 1 , nHeight );//分别是宽和高
            lst.SmallImageList = imgList;   //这里设置listView的SmallImageList ,用imgList将其撑大
        }

        public void SetFontSize ( ref ListView lst , int nFontSize )
        {
            lst.Font = new System.Drawing.Font ( "宋体" , nFontSize , System.Drawing.FontStyle.Regular , System.Drawing.GraphicsUnit.Pixel );
        }

        public void SetFontSize ( ref XListView lst , int nFontSize )
        {
            lst.Font = new System.Drawing.Font ( "宋体" , nFontSize , System.Drawing.FontStyle.Regular , System.Drawing.GraphicsUnit.Pixel );
        }
        public void SetFontSize( ref XListView2 lst, int nFontSize )
        {
            lst.Font = new System.Drawing.Font( "宋体", nFontSize, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel );
        }

        public void SetFontSize ( ref XEditListView lst , int nFontSize )
        {
            lst.Font = new System.Drawing.Font ( "宋体" , nFontSize , System.Drawing.FontStyle.Regular , System.Drawing.GraphicsUnit.Pixel );
        }

        /*
        public void SetFontSize ( ref XControl.ListViewEx lst , int nFontSize )
        {
            lst.Font = new System.Drawing.Font ( "宋体" , nFontSize , System.Drawing.FontStyle.Regular , System.Drawing.GraphicsUnit.Pixel );
        }
        */

        public string GetSelectCell ( ref XListView lst , int ColNo )
        {
            string strCell = "";
            
            int nMaxCol = lst.Columns.Count;
            if ( ColNo >= nMaxCol )
                return String.Empty ;

            if ( lst.SelectedIndices.Count <= 0 )       //没有选中任何行.
                return String.Empty;

            int index = lst.SelectedIndices [ 0 ];
            strCell = lst.Items [ index ].SubItems [ ColNo ].Text;
            return strCell;
        }

        public bool SetSelectCell ( ref XListView lst , int ColNo , string strCell )
        {
            int nMaxCol = lst.Columns.Count;
            if ( ColNo >= nMaxCol )
                return false;

            if ( lst.SelectedIndices.Count <= 0 )       //没有选中任何行.
                return false;

            int index = lst.SelectedIndices [ 0 ];
            lst.Items [ index ].SubItems [ ColNo ].Text = strCell ;
            return true ;
        }

        public string GetSelectCell ( ref XListView lst , int LineNo , int ColNo )
        {
            string strCell = "";

            int nMaxCol = lst.Columns.Count;
            if ( ColNo >= nMaxCol )
                return String.Empty;

            int nMaxLine = lst.Items.Count;
            if ( LineNo >= nMaxLine )
                return String.Empty;

            strCell = lst.Items [ LineNo ].SubItems [ ColNo ].Text;
            return strCell;
        }

        public bool SetSelectCell ( ref XListView lst , int LineNo , int ColNo , string strCell )
        {
            int nMaxCol = lst.Columns.Count;
            if ( ColNo >= nMaxCol )
                return false ;

            int nMaxLine = lst.Items.Count;
            if ( LineNo >= nMaxLine )
                return false ;

            lst.Items [ LineNo ].SubItems [ ColNo ].Text = strCell ;
            return true ;
        }
    }

    public class GRID
    {
        /*
        //Grid
        public void SetXtraGrid ( ref DevExpress.XtraGrid.Views.Grid.GridView gridView , ref DevExpress.XtraGrid.GridControl grid )
        {
            gridView.Appearance.Empty.BackColor = System.Drawing.Color.WhiteSmoke;
            gridView.Appearance.Empty.Options.UseBackColor = true;
            gridView.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb ( ( (int)( ( (byte)( 255 ) ) ) ) , ( (int)( ( (byte)( 128 ) ) ) ) , ( (int)( ( (byte)( 0 ) ) ) ) );
            gridView.Appearance.FocusedCell.Options.UseBackColor = true;
            gridView.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb ( ( (int)( ( (byte)( 255 ) ) ) ) , ( (int)( ( (byte)( 128 ) ) ) ) , ( (int)( ( (byte)( 0 ) ) ) ) );
            gridView.Appearance.FocusedRow.Options.UseBackColor = true;
            gridView.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb ( ( (int)( ( (byte)( 236 ) ) ) ) , ( (int)( ( (byte)( 233 ) ) ) ) , ( (int)( ( (byte)( 216 ) ) ) ) );
            gridView.Appearance.HorzLine.Options.UseBackColor = true;
            gridView.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb ( ( (int)( ( (byte)( 236 ) ) ) ) , ( (int)( ( (byte)( 233 ) ) ) ) , ( (int)( ( (byte)( 216 ) ) ) ) );
            gridView.Appearance.VertLine.Options.UseBackColor = true;
            gridView.Appearance.Row.BackColor = System.Drawing.Color.WhiteSmoke;
            gridView.Appearance.Row.BackColor2 = System.Drawing.Color.White;
            gridView.Appearance.Row.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            gridView.Appearance.Row.Options.UseBackColor = true;
            gridView.Appearance.Row.Options.UseTextOptions = true;
            gridView.Appearance.Row.TextOptions.Trimming = DevExpress.Utils.Trimming.Character;
            gridView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.None;
            gridView.GridControl = grid;
            gridView.Name = "gridView1";
            gridView.OptionsCustomization.AllowColumnMoving = false;
            gridView.OptionsCustomization.AllowGroup = false;
            gridView.OptionsMenu.EnableColumnMenu = false;
            gridView.OptionsMenu.EnableFooterMenu = false;
            gridView.OptionsMenu.EnableGroupPanelMenu = false;
            gridView.OptionsNavigation.AutoFocusNewRow = true;
            gridView.OptionsView.ColumnAutoWidth = false;
            gridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.None;
            gridView.OptionsView.ShowFooter = false;
            gridView.OptionsView.ShowGroupPanel = false;
            gridView.OptionsView.ShowHorzLines = false;
            gridView.ViewCaption = "GridView";

            gridView.IndicatorWidth = 16;

            gridView.OptionsSelection.EnableAppearanceFocusedCell = false;
            gridView.OptionsCustomization.AllowFilter = false;
            gridView.OptionsBehavior.Editable = false;

        }*/

        /*
        public void XtraGridAllowEdit ( ref DevExpress.XtraGrid.Views.Grid.GridView gridView , bool bFlag )
        {
            gridView.OptionsBehavior.Editable = bFlag;
            for ( int i = 0 ; i < gridView.Columns.Count ; i++ )
                gridView.Columns[i].OptionsColumn.AllowEdit = bFlag;
        }*/

        /*
        public void XtraGridAllowAddNew ( ref DevExpress.XtraGrid.Views.Grid.GridView gridView , bool bFlag )
        {
            if ( bFlag )
                gridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            else 
                gridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.None;
        }*/

        /*
        public void XtraGridAutoWidth ( ref DevExpress.XtraGrid.Views.Grid.GridView gridView , bool bFlag )
        {
            gridView.OptionsView.ColumnAutoWidth = bFlag;
        }*/

        /*
        public string GetCurLineCell ( Form fm , ref DevExpress.XtraGrid.GridControl grid , string strKeyFld )
        {
            DataRowView rowview = (DataRowView)( (CurrencyManager)fm.BindingContext[grid.DataSource , grid.DataMember] ).Current;
            return rowview[strKeyFld].ToString ().Trim ();
        }*/

        /*
        public void SetFld ( ref DevExpress.XtraGrid.GridControl grid , string[] strFldName , string[] strGrdLst )
        {
            DevExpress.XtraGrid.Views.Base.ColumnView view = grid.MainView as DevExpress.XtraGrid.Views.Base.ColumnView;
            DevExpress.XtraGrid.Columns.GridColumn column;
            view.Columns.Clear ();

            for ( int i = 0 ; i < strFldName.Length ; i++ )
            {
                column = view.Columns.Add ( strGrdLst[i] );
                column.VisibleIndex = i;
                column.FieldName = strFldName[i];
                column.OptionsFilter.AllowFilter = false;
                column.Width = 100;
                column.OptionsColumn.AllowEdit = false;
            }
        }*/
    }

    public class BIND
    {
        public void BindLabel ( System.Windows.Forms.Label Label , object strField )
        {
            if ( Label.DataBindings [ "Text" ] != null )
                Label.DataBindings.Remove ( Label.DataBindings [ "Text" ] );

            Label.DataBindings.Add ( "Text" , strField , "" );
        }

        /*
        public void BindEditBox ( DevExpress.XtraEditors.TextEdit Edit , object strField )
        {
            if ( Edit.DataBindings["Text"] != null )
                Edit.DataBindings.Remove ( Edit.DataBindings["Text"] );

            Edit.DataBindings.Add ( "Text" , strField , "" );
        }
         * */

        public void BindEditBox ( System.Windows.Forms.TextBox Edit , object strField )
        {
            if ( Edit.DataBindings [ "Text" ] != null )
                Edit.DataBindings.Remove ( Edit.DataBindings [ "Text" ] );

            Edit.DataBindings.Add ( "Text" , strField , "" );
        }

        /*
        public void BindEditBox ( DevExpress.XtraEditors.DateEdit Edit , object strField )
        {
            if ( Edit.DataBindings["Text"] != null )
                Edit.DataBindings.Remove ( Edit.DataBindings["Text"] );

            Edit.DataBindings.Add ( "Text" , strField , "" );
        }*/

        public void BindComboBox ( System.Windows.Forms.ComboBox Combox , object strField )
        {
            if ( Combox.DataBindings [ "Text" ] != null )
                Combox.DataBindings.Remove ( Combox.DataBindings [ "Text" ] );

            Combox.DataBindings.Add ( "Text" , strField , "" );
        }

        public void BindCheckBox ( System.Windows.Forms.CheckBox CheckBox , object strField )
        {
            if ( CheckBox.DataBindings ["Text"] != null )
                CheckBox.DataBindings.Remove ( CheckBox.DataBindings ["Text"] );

            CheckBox.DataBindings.Add ( "Text" , strField , "" );
        }

        public void BindPicBox ( System.Windows.Forms.PictureBox PicBox , object strField )
        {
            if ( PicBox.DataBindings [ "Text" ] != null )
                PicBox.DataBindings.Remove ( PicBox.DataBindings [ "Image" ] );

            PicBox.DataBindings.Add ( "Image" , strField , "" );
        }

    }

    public class LAYOUT
    {
        public int AddBack ( int XBefore , int btnY , int Xgap , ref System.Windows.Forms.Button btn )
        {
            if ( btn.Visible == false )
                return XBefore;

            btn.Location = new Point ( XBefore + Xgap , btnY );

            int XAfter = XBefore + Xgap + btn.Size.Width;
            return XAfter;
        }
    }

    public class PICTUREBOX
    {
        public void LoadFromDisk ( PictureBox picbox )
        {
            System.Windows.Forms.OpenFileDialog openFileDialog = new OpenFileDialog ( );
            if ( openFileDialog.ShowDialog ( ) != DialogResult.OK )
                return;

            string strImg = openFileDialog.FileName;
            picbox.Image = Image.FromFile ( strImg );
        }

        bool ThumbnailCallback ( )
        {
            return false;
        }

        // ImgW , ImgH 是 要缩放成的尺寸.
        public void LoadFromDisk ( ref PictureBox picbox )
        {
            int ImgW = picbox.Size.Width;
            int ImgH = picbox.Size.Height;

            System.Windows.Forms.OpenFileDialog openFileDialog = new OpenFileDialog ( );
            if ( openFileDialog.ShowDialog ( ) != DialogResult.OK )
                return;

            string strImg = openFileDialog.FileName;
            Image Img = Image.FromFile ( strImg );

            int W = Img.Width;
            int H = Img.Height;
            int w , h;

            if ( W > H )
            {
                w = ImgW;
                h = ( int ) ( ( float ) ( ImgW * H ) / ( float ) W );
            }
            else
            {
                h = ImgH;
                w = ( int ) ( ( float ) ( ImgH * W ) / ( float ) H );
            }

            Image.GetThumbnailImageAbort myCallback = new Image.GetThumbnailImageAbort ( ThumbnailCallback );
            picbox.Image = Img.GetThumbnailImage ( w , h , myCallback , IntPtr.Zero );
        }

        public bool LoadFromFld ( ref PictureBox picbox , Object Obj )
        {
            if ( FF.Fun.IsDBNull ( Obj ) )
                return false;

            byte [ ] buf = ( byte [ ] ) Obj;
            if ( buf.Length > 0 )
            {
                MemoryStream stream = new MemoryStream ( );
                stream.Write ( buf , 0 , buf.Length );
                picbox.Image = Image.FromStream ( stream );
            }
            return true;
        }
    }

    public class GROUPBOX
    {
        public void ShowContent( ref GroupBox grp , bool bFlag )
        {
            foreach (System.Windows.Forms.Control ctl in grp.Controls)
            {
                ctl.Visible = bFlag;
            }
        }

    }
}
