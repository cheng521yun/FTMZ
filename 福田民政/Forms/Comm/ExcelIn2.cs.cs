/* 
 * 用于导入Excel表之前，让用户手动匹配Excel表字段和数据库表字段的对应关系。
 
            //使用说明
  
  
            _lstBomItem = new List<BOM_ITEM>();

            List<FrontFlag.EXCEL2FLD> lst = new List<EXCEL2FLD>();
            
            lst.Add(new FrontFlag.EXCEL2FLD("", "PN"));
            lst.Add(new FrontFlag.EXCEL2FLD("", "CustomerPN"));
            lst.Add(new FrontFlag.EXCEL2FLD("", "Brand"));
            lst.Add(new FrontFlag.EXCEL2FLD("", "Qty"));
            lst.Add(new FrontFlag.EXCEL2FLD("", "Cost"));
            lst.Add(new FrontFlag.EXCEL2FLD("", "MoneyType"));
            lst.Add(new FrontFlag.EXCEL2FLD("", "DC"));
            lst.Add(new FrontFlag.EXCEL2FLD("", "LT"));
            lst.Add(new FrontFlag.EXCEL2FLD("", "Comment"));

            MogulCRM.CRM.CommDlg.FExcelIn2 fm = new FExcelIn2 ( txtExeclFile.Text );
            fm.lstE2F = lst;
            if (fm.ShowDialog() != DialogResult.OK)
                return;

            lst = fm.lstE2F; 
  
 
 */


using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using FrontFlag;
using System.Data.OleDb;
//using Program.Comm;
//using Program.Define;
//using MogulCRM.CRM.CommDlg;


namespace 福田民政.Forms.Comm
{
    public partial class FExcelIn2 : Form
    {
        List<FrontFlag.EXCEL2FLD> _lstE2F = new List<EXCEL2FLD>();

        //FF ff = new FF ( );

        //public bool _bBatchType = false;
        //public string _strType = "Customer";                     //Customer | Vendor
        //public string _strConvertMode = "Company";               //Company | Contact

        private string _strExcelName = "";
        private string _strConn = "";

        DataSet _dsExcel = new DataSet();
        ArrayList arySheetName = new ArrayList();
        ArrayList aryExcelFld = new ArrayList();
        
        //struct FIXUNIT
        //{
        //    public string strField;
        //    public string strExcel;
        //} ;

        //struct NEWITEM
        //{
        //    public string strName;
        //    public string strID;
        //} ;

        /// <summary>
        /// 
        /// </summary>
        public FExcelIn2(string strExcelFile)
        {
            _strExcelName = strExcelFile;

            InitializeComponent ();
        }

        #region 属性

        public List<FrontFlag.EXCEL2FLD> lstE2F
        {
            set { _lstE2F = value; }
            get { return _lstE2F; }
        }
        
        public string InfoText
        {
            set { txtInfo.Text = value; }
        }


        #endregion

        private void OnLoad ( object sender , EventArgs e )
        {
            Init ( );
        }

        private ArrayList GetSheetName ( )
        {
            string str = "";
            ArrayList ary = new ArrayList ( );
            try
            {
                OleDbConnection conn = new OleDbConnection ( _strConn );
                conn.Open ( );
                DataTable schemaTable = conn.GetOleDbSchemaTable ( OleDbSchemaGuid.Tables , new object [ ] { null , null , null , "TABLE" } );
                conn.Close ( );

                foreach ( DataRow dr in schemaTable.Rows )
                {
                    str = dr [ "TABLE_NAME" ].ToString ( );
                    str = str.Substring ( 0 , str.Length - 1 );
                    ary.Add ( str );
                }
            }
            catch ( Exception ex )
            {
                MessageBox.Show ( ex.ToString ( ) );
                return null;
            }

            //
            cmbSheetName.Items.Clear ( );
            for ( int i = 0 ; i < ary.Count ; i++ )
                cmbSheetName.Items.Add ( ary [ i ] );
            FF.Ctrl.Combo.SetZeroIndex ( cmbSheetName ) ;

            return ary;
        }

        private void Init ( )
        {
            if ( _strExcelName == String.Empty )
                return;

            Init_MatchLis();

            //_strConn = String.Format ( "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + _strExcelName + ";Extended Properties=Excel 8.0; " );
            _strConn = String.Format("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + _strExcelName + ";Extended Properties='Excel 8.0; IMEX=1; '");  //IMEX=1 使得 Excel 表格中混合列(即该列中的包含有多种类型的数据)被 ADO.NET 认为其数据类型是 String 。

            //
            arySheetName = GetSheetName ( );
            if (arySheetName == null || arySheetName.Count <= 0)
            {
                FF.Ctrl.MsgBox.ShowWarn ( "the Excel file: " + _strExcelName + " have not any sheet !" );
                butConvert.Enabled = false;
                return;
            }

            GetExcelSheet ( 0 );
        }

        void Init_MatchLis()
        {
            lstMatch.Items.Clear();
            foreach ( FrontFlag.EXCEL2FLD e2f in _lstE2F )
            {
                ListViewItem listItem = new ListViewItem(e2f.FldName);
                listItem.SubItems.Add("");
                listItem.UseItemStyleForSubItems = false; 
                listItem.SubItems[1].BackColor = Color.LightYellow;
                lstMatch.Items.Add(listItem);
            }
        }

        private void GetExcelSheet ( int SheetNo )
        {
            Clear ( );

            if ( SheetNo >= arySheetName.Count )
            {
                butConvert.Enabled = false;
                return;
            }

            try
            {
                string strSelect = String.Format ( "SELECT * FROM [{0}$]" , arySheetName [ SheetNo ] );
                OleDbDataAdapter ada = new OleDbDataAdapter ( strSelect , _strConn );

                ada.Fill ( _dsExcel );
            }
            catch ( Exception ex )
            {
                MessageBox.Show ( ex.ToString ( ) );
                butConvert.Enabled = false;
                return;
            }

            datgrdExcel.DataSource = _dsExcel.Tables [ 0 ];

            SetListExcel ( );

            butConvert.Enabled = true;
        }

        #region Set List

        private void SetListExcel ( )
        {
            if ( _dsExcel.Tables.Count <= 0 )
                return;

            lstExcel.Items.Clear ( );
            aryExcelFld.Clear ( );

            foreach ( DataColumn col in _dsExcel.Tables [ 0 ].Columns )
            {
                aryExcelFld.Add ( col.ColumnName );

                ListViewItem listItem = new ListViewItem ( col.ColumnName );
                lstExcel.Items.Add ( listItem );
            }
        }

        #endregion

        ////从excel表中得到company 中英文 名称列表（Distingcy方式）
        //void GetAllExcelCompany ( string strCompanyFldCName , string strCompanyFldEName )
        //{
        //    if ( _dsExcel.Tables.Count <= 0 || _dsExcel.Tables [ 0 ].Rows.Count <= 0 )
        //        return;

        //    aryCompanyCName.Clear ( );
        //    string strCName , strEName ;

        //    try
        //    {
        //        foreach ( DataRow dr in _dsExcel.Tables [ 0 ].Rows )
        //        {
        //            strCName = dr [ strCompanyFldCName ].ToString ( ).Trim ( );
        //            strEName = dr [ strCompanyFldEName ].ToString ( ).Trim ( );
        //            if ( !FF.Ary.IsStrInAry ( ref aryCompanyCName , strCName ) )
        //            {
        //                aryCompanyCName.Add ( strCName );

        //                aryCompanyEName.Add ( strEName );
        //            }
        //        }
        //    }
        //    catch (System.Exception e)
        //    {
        //        MessageBox.Show("读取Xls表发生错误，表中必须使用 Customer EName 和 Customer CName 名称！ ");
        //        return;
        //    }
        //}

        private void Add2Left ( )
        {
            if ( lstMatch.SelectedItems.Count <= 0 )
                return;

            if ( lstExcel.SelectedItems.Count <= 0 )
                return;

            string strItemExcel = lstExcel.SelectedItems [ 0 ].SubItems [ 0 ].Text;
            string strItemDB = lstMatch.SelectedItems [ 0 ].SubItems [ 1 ].Text;

            //delete from right
            lstExcel.Items.RemoveAt ( lstExcel.SelectedItems [ 0 ].Index );
            lstExcel.SelectedItems.Clear ( );

            //add to left
            lstMatch.SelectedItems [ 0 ].SubItems [ 1 ].Text = strItemExcel;

            //交换
            if ( strItemDB.Trim ( ) != String.Empty )
            {
                ListViewItem listItem = new ListViewItem ( strItemDB );
                lstExcel.Items.Add ( listItem );
            }
        }

        private void Sub2Right ( )
        {
            if ( lstMatch.SelectedItems.Count <= 0 )
                return;

            string strItemDB = lstMatch.SelectedItems [ 0 ].SubItems [ 1 ].Text;
            if ( strItemDB.Trim ( ) == String.Empty )
                return;

            lstMatch.SelectedItems [ 0 ].SubItems [ 1 ].Text = "";

            ListViewItem listItem = new ListViewItem ( strItemDB );
            lstExcel.Items.Add ( listItem );
        }

        void Add2Left_Contact ( )
        {
            //if ( lstContactFix.SelectedItems.Count <= 0 )
            //    return;

            //if ( lstContactExcel.SelectedItems.Count <= 0 )
            //    return;

            //string strItemExcel = lstContactExcel.SelectedItems [ 0 ].SubItems [ 0 ].Text;
            //string strItemDB = lstContactFix.SelectedItems [ 0 ].SubItems [ 1 ].Text;

            ////delete from right
            //lstContactExcel.Items.RemoveAt ( lstContactExcel.SelectedItems [ 0 ].Index );
            //lstContactExcel.SelectedItems.Clear ( );

            ////add to left
            //lstContactFix.SelectedItems [ 0 ].SubItems [ 1 ].Text = strItemExcel;

            ////交换
            //if ( strItemDB.Trim ( ) != String.Empty )
            //{
            //    ListViewItem listItem = new ListViewItem ( strItemDB );
            //    lstContactExcel.Items.Add ( listItem );
            //}
        }

        void Sub2Right_Contact ( )
        {
            //if ( lstContactFix.SelectedItems.Count <= 0 )
            //    return;

            //string strItemDB = lstContactFix.SelectedItems [ 0 ].SubItems [ 1 ].Text;
            //if ( strItemDB.Trim ( ) == String.Empty )
            //    return;

            //lstContactFix.SelectedItems [ 0 ].SubItems [ 1 ].Text = "";

            //ListViewItem listItem = new ListViewItem ( strItemDB );
            //lstContactExcel.Items.Add ( listItem );

        }

        private bool Check ( )
        {
            bool bRet = true;
            int n = 0;
            foreach (ListViewItem Item in lstMatch.Items)
            {
                if (Item.SubItems[1].Text.Trim() == String.Empty)
                    bRet = false;
            }

            if ( ! bRet )
            {
                FF.Ctrl.MsgBox.ShowWarn("'Excel Colums'需要全部完成匹配!");
                return false;
            }

            return true;
        }

        //private ArrayList GetFixUnit_Company ( )
        //{
        //    ArrayList ary = new ArrayList ( );

        //    foreach ( ListViewItem lvi in lstMatch.Items )
        //    {
        //        if ( lvi.SubItems [ 1 ].Text == "" )
        //            continue;

        //        FIXUNIT unit = new FIXUNIT ( );
        //        unit.strField = lvi.SubItems [ 0 ].Text;
        //        unit.strExcel = lvi.SubItems [ 1 ].Text;

        //        ary.Add ( unit );
        //    }

        //    return ary;
        //}

        //private ArrayList GetFixUnit_Contact ( )
        //{
        //    ArrayList ary = new ArrayList ( );

        //    //foreach ( ListViewItem lvi in lstContactFix.Items )
        //    //{
        //    //    if ( lvi.SubItems [ 1 ].Text == "" )
        //    //        continue;

        //    //    FIXUNIT unit = new FIXUNIT ( );
        //    //    unit.strField = lvi.SubItems [ 0 ].Text;
        //    //    unit.strExcel = lvi.SubItems [ 1 ].Text;

        //    //    ary.Add ( unit );
        //    //}

        //    return ary;
        //}

        //private bool Convert ( )
        //{
        //    if ( _strConvertMode == "Company" && _strTable == DEF.Tab.Customer.TAB )
        //        return Convert_Customer ( );

        //    if ( _strConvertMode == "Contact" && _strTable2 == DEF.Tab.CustomerContact.TAB )
        //    {
        //        if ( _bBatchType )
        //            return Convert_CustomerContact_Batch ( );
        //        else
        //            return Convert_CustomerContact ( );
        //    }

        //    if ( _strConvertMode == "Company" && _strTable == DEF.Tab.Vendor.TAB )
        //        return Convert_Vendor ( );

        //    else if ( _strConvertMode == "Contact" && _strTable2 == DEF.Tab.VendorContact.TAB )
        //    {
        //        if ( _bBatchType )
        //            return Convert_VendorContact_Batch ( );
        //        else
        //            return Convert_VendorContact ( );
        //    }

        //    if ( _strConvertMode == "Stock" && _strTable == DEF.Tab.Stock.TAB )
        //        return Convert_Stock ();

        //    if ( _strConvertMode == "Supply" && _strTable == DEF.Tab.Supply.TAB )
        //        return Convert_Supply ();

        //    return true;
        //}

        //检查 Company List中 是否有匹配的行。
        bool CheckCompanyMap ( )
        {
            return true;
        }

        //bool Convert_Customer ( )
        //{
        //    SQL Sql = new SQL ( GLOBAL.Param.strSqlConnect );

        //    ArrayList ary = new ArrayList ( );
        //    ary = GetFixUnit_Company ( );

        //    FIXUNIT unit;
        //    int n = ary.Count;

        //    if ( n <= 0 )
        //    {
        //        FF.Ctrl.MsgBox.ShowWarn ( "Have not any convert mapping !" );
        //        Sql.Close ();
        //        return false;
        //    }

        //    foreach ( DataRow drExcel in _dsExcel.Tables [ 0 ].Rows )
        //    {
        //        //add new recorder 
        //        string strCustomerID = COMMTHIS.Program.Misc.CreateID ( DEF.Tab.Customer.TAB , DEF.Tab.Customer.CustomerID );
        //        ORM.Customer.Insert_ByID ( strCustomerID );

        //        Sql.DataSetClear ( ref _dsDBCompany );
        //        _dsDBCompany.Tables [ 0 ].Rows [ 0 ] [ DEF.Tab.Customer.CustomerID ] = strCustomerID;

        //        //set ds
        //        for ( int i = 0 ; i < n ; i++ )
        //        {
        //            unit = ( FIXUNIT ) ary [ i ];
        //            _dsDBCompany.Tables [ 0 ].Rows [ 0 ] [ unit.strField ] = drExcel [ unit.strExcel ];
        //        }

        //        _dsDBCompany.Tables [ 0 ].Rows [ 0 ] [ DEF.Tab.Customer.Sales ] = GLOBAL.User.strName;

        //        //save ds
        //        string [ ] strkeys = new string [ ] { DEF.Tab.Customer.CustomerID };
        //        Sql.UpdateDataSet2DB ( ref _dsDBCompany , strkeys );
        //    }

        //    Sql.Close ();
        //    return true;
        //}

        //bool Convert_CustomerContact ( )
        //{
        //    if ( _strCompanyID == "" )
        //    {
        //        FF.Ctrl.MsgBox.ShowWarn ( "Have not CustomerID !" );
        //        return false;
        //    }

        //    SQL Sql = new SQL ( GLOBAL.Param.strSqlConnect );

        //    ArrayList ary = new ArrayList ( );
        //    ary = GetFixUnit_Contact ( );

        //    FIXUNIT unit;
        //    int n = ary.Count;

        //    if ( n <= 0 )
        //    {
        //        FF.Ctrl.MsgBox.ShowWarn ( "Have not any convert mapping !" );
        //        Sql.Close () ;
        //        return false;
        //    }

        //    foreach ( DataRow drExcel in _dsExcel.Tables [ 0 ].Rows )
        //    {
        //        Sql.DataSetClear ( ref _dsDBContact );
        //        _dsDBContact.Tables [ 0 ].Rows [ 0 ] [ DEF.Tab.CustomerContact.CustomerID ] = _strCompanyID;

        //        //set ds
        //        for ( int i = 0 ; i < n ; i++ )
        //        {
        //            unit = ( FIXUNIT ) ary [ i ];
        //            _dsDBContact.Tables [ 0 ].Rows [ 0 ] [ unit.strField ] = drExcel [ unit.strExcel ];
        //        }

        //        _dsDBContact.Tables [ 0 ].Rows [ 0 ] [ DEF.Tab.CustomerContact.Sales ] = GLOBAL.User.strName;

        //        //save ds
        //        DataTable dt = new DataTable ( );
        //        dt = _dsDBContact.Tables [ 0 ];
        //        Sql.InsertTable2DB ( ref dt );
        //    }

        //    Sql.Close ();
        //    return true;
        //}

        //bool Convert_CustomerContact_Batch ( )
        //{
        //    //MatchCompany ( );

        //    aryCreateNew.Clear ( );
        //    aryUpdateName.Clear ( );

        //    //
        //    ArrayList aryContact = new ArrayList ( );
        //    aryContact = GetFixUnit_Contact ( );

        //    if ( aryContact.Count <= 0 )
        //    {
        //        FF.Ctrl.MsgBox.ShowWarn ( "Have not any Contact mapping !" );
        //        return false;
        //    }

        //    if ( !CheckCompanyMap ( ) )
        //    {
        //        FF.Ctrl.MsgBox.ShowWarn ( "Have not any Customer mapping !" );
        //        return false;
        //    }

        //    int indexE = 0 , indexC = 0 , index ;
        //    string strXlsCompanyEName , strXlsCompanyCName , strXlsCompanyName , strDBCustomerID;

        //    foreach ( DataRow drExcel in _dsExcel.Tables [ 0 ].Rows )
        //    {
        //        indexE = -1 ;
        //        indexC = -1;

        //        strXlsCompanyEName = drExcel [ Def_XlsColName_EName ].ToString ( ).Trim ( );
        //        if (strXlsCompanyEName !="")
        //            indexE = FF.Ary.IndexOfAry ( ref aryCompanyEName , strXlsCompanyEName );
                
        //        strXlsCompanyCName = drExcel [ Def_XlsColName_CName ].ToString ( ).Trim ( );
        //        if (strXlsCompanyCName != "") 
        //            indexC = FF.Ary.IndexOfAry(ref aryCompanyCName, strXlsCompanyCName);

        //        if ( indexE == -1 && indexC == -1 )
        //            continue;

        //        //2合1，下面只用一个 id,或 名称 比较。
        //        index = indexE;
        //        if ( index == -1 )
        //            index = indexC;

        //        strXlsCompanyName = strXlsCompanyEName;
        //        if ( strXlsCompanyName.Trim ( ) == String.Empty )
        //            strXlsCompanyName = strXlsCompanyCName;

        //        //
        //        strDBCustomerID = aryCompanyID [ index ].ToString ( );    //得到 xls company 对应的customweID 或 vendoerID

        //        if ( strDBCustomerID == "" )      //没有对xls中的Company名称做匹配关联,不处理。
        //        {
        //            continue;
        //        }
        //        else if ( strDBCustomerID == _strNewFlag )   //没有对xls中的Company名称在SQL中没有，需要新建一个Customer.
        //        {
        //            string strID = IsExistInNewAry ( strXlsCompanyName );
        //            if ( strID != "" )  //同样的名称， 之前已经建立过了。
        //            {
        //                strDBCustomerID = strID;
        //            }
        //            else //之前没有建立
        //            {
        //                strDBCustomerID = COMMTHIS.Program.Misc.CreateID ( DEF.Tab.Customer.TAB , DEF.Tab.Customer.CustomerID );

        //                NEWITEM NewItem = new NEWITEM ( );
        //                NewItem.strID = strDBCustomerID;
        //                NewItem.strName = strXlsCompanyName;
        //                aryCreateNew.Add ( NewItem );

        //                //给Customer添加字段
        //                CreateCompanyFromXlsLine ( strDBCustomerID , drExcel );
        //            }
        //        }
        //        else
        //        {
        //            //对于更新Company的名字都保存起来，只依Xls表中最开始的一行的信息为准,更新数据库的Customer信息。
        //            index = FF.Ary.IndexOfAry ( ref aryUpdateName , strXlsCompanyName );
        //            if ( index == -1 )
        //            {
        //                aryUpdateName.Add ( strXlsCompanyName );

        //                //更新Customer字段
        //                UpdateCompanyFromXlsLine ( strDBCustomerID , drExcel );
        //            }
        //        }

        //        SaveContactFromXlsLine ( strDBCustomerID , drExcel );
        //    }

        //    return true;
        //}

        //bool Convert_Vendor ( )
        //{
        //    SQL Sql = new SQL () ;

        //    ArrayList ary = new ArrayList ( );
        //    ary = GetFixUnit_Company ( );

        //    FIXUNIT unit;
        //    int n = ary.Count;

        //    if ( n <= 0 )
        //    {
        //        FF.Ctrl.MsgBox.ShowWarn ( "Have not any convert mapping !" );
        //        Sql.Close ();
        //        return false;
        //    }

        //    foreach ( DataRow drExcel in _dsExcel.Tables [ 0 ].Rows )
        //    {
        //        //add new recorder 
        //        string strVendorID = COMMTHIS.Program.Misc.CreateID ( DEF.Tab.Vendor.TAB , DEF.Tab.Vendor.VendorID );
        //        ORM.Vendor.Insert_ByID ( strVendorID );

        //        Sql.DataSetClear ( ref _dsDBCompany );
        //        _dsDBCompany.Tables [ 0 ].Rows [ 0 ] [ DEF.Tab.Vendor.VendorID ] = strVendorID;

        //        //set ds
        //        for ( int i = 0 ; i < n ; i++ )
        //        {
        //            unit = ( FIXUNIT ) ary [ i ];
        //            _dsDBCompany.Tables [ 0 ].Rows [ 0 ] [ unit.strField ] = drExcel [ unit.strExcel ];
        //        }

        //        //save ds
        //        string [ ] strkeys = new string [ ] { DEF.Tab.Vendor.VendorID };
        //        Sql.UpdateDataSet2DB ( ref _dsDBCompany , strkeys );
        //    }

        //    Sql.Close () ;
        //    return true;
        //}

        //bool Convert_VendorContact ( )
        //{
        //    if ( _strCompanyID == "" )
        //    {
        //        FF.Ctrl.MsgBox.ShowWarn ( "Have not VendorID !" );
        //        return false;
        //    }

        //    SQL Sql = new SQL ( GLOBAL.Param.strSqlConnect );

        //    ArrayList ary = new ArrayList ( );
        //    ary = GetFixUnit_Contact ( );

        //    FIXUNIT unit;
        //    int n = ary.Count;

        //    if ( n <= 0 )
        //    {
        //        FF.Ctrl.MsgBox.ShowWarn ( "Have not any convert mapping !" );
        //        return false;
        //    }

        //    foreach ( DataRow drExcel in _dsExcel.Tables [ 0 ].Rows )
        //    {
        //        Sql.DataSetClear ( ref _dsDBContact );
        //        _dsDBContact.Tables [ 0 ].Rows [ 0 ] [ DEF.Tab.VendorContact.VendorID ] = _strCompanyID;

        //        //set ds
        //        for ( int i = 0 ; i < n ; i++ )
        //        {
        //            unit = ( FIXUNIT ) ary [ i ];
        //            _dsDBContact.Tables [ 0 ].Rows [ 0 ] [ unit.strField ] = drExcel [ unit.strExcel ];
        //        }

        //        _dsDBContact.Tables [ 0 ].Rows [ 0 ] [ DEF.Tab.VendorContact.Sales ] = GLOBAL.User.strName;

        //        //save ds
        //        DataTable dt = new DataTable ( );
        //        dt = _dsDBContact.Tables [ 0 ];
        //        Sql.InsertTable2DB ( ref dt );
        //    }

        //    Sql.Close () ;
        //    return true;
        //}

        //bool Convert_VendorContact_Batch ( )
        //{
        //    //MatchCompany ( );

        //    aryCreateNew.Clear ( );
        //    aryUpdateName.Clear ( );

        //    //
        //    ArrayList aryContact = new ArrayList ( );
        //    aryContact = GetFixUnit_Contact ( );

        //    if ( aryContact.Count <= 0 )
        //    {
        //        FF.Ctrl.MsgBox.ShowWarn ( "Have not any Contact mapping !" );
        //        return false;
        //    }

        //    if ( !CheckCompanyMap ( ) )
        //    {
        //        FF.Ctrl.MsgBox.ShowWarn ( "Have not any Vendor mapping !" );
        //        return false;
        //    }

        //    int index = 0 , indexE , indexC ;
        //    string strXlsVendorName , strXlsVendorEName , strXlsVendorCName , strDBVendorID;

        //    foreach ( DataRow drExcel in _dsExcel.Tables [ 0 ].Rows )
        //    {
        //        strXlsVendorEName = drExcel [ Def_XlsColName_EName ].ToString ( ).Trim ( );
        //        indexE = FF.Ary.IndexOfAry ( ref aryCompanyEName , strXlsVendorEName );

        //        strXlsVendorCName = drExcel [ Def_XlsColName_CName ].ToString ( ).Trim ( );
        //        indexC = FF.Ary.IndexOfAry ( ref aryCompanyCName , strXlsVendorCName );

        //        if ( indexE == -1 && indexC == -1 )
        //            continue;

        //        //2合1，下面只用一个 id,或 名称 比较。
        //        index = indexE;
        //        if ( index == -1 )
        //            index = indexC;

        //        strXlsVendorName = strXlsVendorEName;
        //        if ( strXlsVendorName.Trim ( ) == String.Empty )
        //            strXlsVendorName = strXlsVendorCName;

        //        strDBVendorID = aryCompanyID [ index ].ToString ( );     //得到 xls company 对应的customweID 或 vendoerID

        //        if ( strDBVendorID == "" )      //没有对xls中的Company名称做匹配关联,不处理。
        //        {
        //            continue;
        //        }
        //        else if ( strDBVendorID == _strNewFlag )   //没有对xls中的Company名称在SQL中没有，需要新建一个Vendor.
        //        {
        //            /*
        //            string strVendorID = COMMTHIS.Program.Misc.CreateID(DEF.Tab.Vendor.TAB, DEF.Tab.Vendor.VendorID);
        //            ORM.Vendor.AddNew(strVendorID, strXlsVendorName, strXlsVendorName);
        //            strDBVendorID = strVendorID;
        //             */

        //            string strID = IsExistInNewAry ( strXlsVendorName );
        //            if ( strID != "" )  //同样的名称， 之前已经建立过了。
        //            {
        //                strDBVendorID = strID;
        //            }
        //            else //之前没有建立
        //            {
        //                strDBVendorID = COMMTHIS.Program.Misc.CreateID ( DEF.Tab.Vendor.TAB , DEF.Tab.Vendor.VendorID );

        //                NEWITEM NewItem = new NEWITEM ( );
        //                NewItem.strID = strDBVendorID;
        //                NewItem.strName = strXlsVendorName;
        //                aryCreateNew.Add ( NewItem );

        //                //给Vendor添加字段
        //                CreateCompanyFromXlsLine ( strDBVendorID , drExcel );
        //            }

        //        }
        //        else
        //        {
        //            //对于更新Company的名字都保存起来，只依Xls表中最开始的一行的信息为准,更新数据库的Customer信息。
        //            index = FF.Ary.IndexOfAry ( ref aryUpdateName , strXlsVendorName );
        //            if ( index == -1 )
        //            {
        //                aryUpdateName.Add ( strXlsVendorName );

        //                //更新Customer字段
        //                UpdateCompanyFromXlsLine ( strDBVendorID , drExcel );
        //            }
        //        }

        //        /*
        //        GLOBAL.Sql.DataSetClear(ref _dsDBContact);
        //        _dsDBContact.Tables[0].Rows[0][DEF.Tab.VendorContact.VendorID] = strDBVendorID;

        //        //set ds
        //        for (int i = 0; i < n; i++)
        //        {
        //            unit = (FIXUNIT)ary[i];
        //            _dsDBContact.Tables[0].Rows[0][unit.strField] = drExcel[unit.strExcel];
        //        }

        //        _dsDBContact.Tables[0].Rows[0][DEF.Tab.VendorContact.Sales] = GLOBAL.User.strName;

        //        //save ds
        //        DataTable dt = new DataTable();
        //        dt = _dsDBContact.Tables[0];
        //        GLOBAL.Sql.InsertTable2DB(ref dt);
        //         */

        //        SaveContactFromXlsLine ( strDBVendorID , drExcel );
        //    }

        //    return true;
        //}

        //bool Convert_Stock ()
        //{
        //    SQL Sql = new SQL ( GLOBAL.Param.strSqlConnect );

        //   ArrayList ary = new ArrayList ();
        //   ary = GetFixUnit_Company ();

        //   FIXUNIT unit;
        //   int n = ary.Count;

        //   if ( n <= 0 )
        //   {
        //       FF.Ctrl.MsgBox.ShowWarn ( "Have not any convert mapping !" );
               
        //       //因为 如果原来表是全空的话，会插入一条临时记录， 最后要清除它。
        //       ORM.Stock.Delete_ById ( "000000000" );

        //       Sql.Close ();
        //       return false;
        //   }

        //   foreach ( DataRow drExcel in _dsExcel.Tables [ 0 ].Rows )
        //   {
        //       //add new recorder 
        //       string strStockID = COMMTHIS.Program.Misc.CreateID ( DEF.Tab.Stock.TAB , DEF.Tab.Stock.ID );
        //       ORM.Stock.Insert_ByID ( strStockID );

        //       _dsDBCompany.Tables [ 0 ].Rows [ 0 ] [ DEF.Tab.Stock.ID ] = strStockID;
        //       _dsDBCompany.Tables [ 0 ].Rows [ 0 ] [ DEF.Tab.Stock.Sales ] = GLOBAL.User.strName;
        //       _dsDBCompany.Tables [ 0 ].Rows [ 0 ] [ DEF.Tab.Stock.TheTime ] = FF.Str.Date.GetNow_yyyyMMddHHmm (); ;

        //       //set ds
        //       for ( int i = 0 ; i < n ; i++ )
        //       {
        //           unit = ( FIXUNIT ) ary [ i ];
        //           _dsDBCompany.Tables [ 0 ].Rows [ 0 ] [ unit.strField ] = drExcel [ unit.strExcel ];
        //       }

        //       //save ds
        //       string [] strkeys = new string [] { DEF.Tab.Stock.ID };
        //       Sql.UpdateDataSet2DB ( ref _dsDBCompany , strkeys );
        //   }

        //   //因为 如果原来表是全空的话，会插入一条临时记录， 最后要清除它。
        //   ORM.Stock.Delete_ById ( "000000000" );

        //   Sql.Close ();
        //   return true;
        //}

        //bool Convert_Supply ()
        //{
        //    SQL Sql = new SQL ( GLOBAL.Param.strSqlConnect );

        //    ArrayList ary = new ArrayList ();
        //    ary = GetFixUnit_Company ();

        //    FIXUNIT unit;
        //    int n = ary.Count;

        //    if ( n <= 0 )
        //    {
        //        FF.Ctrl.MsgBox.ShowWarn ( "Have not any convert mapping !" );

        //        //因为 如果原来表是全空的话，会插入一条临时记录， 最后要清除它。
        //        ORM.Supply.Delete_ById ( "000000000" );

        //        Sql.Close ();
        //        return false;
        //    }

        //    foreach ( DataRow drExcel in _dsExcel.Tables [ 0 ].Rows )
        //    {
        //        //add new recorder 
        //        string strSupplyID = COMMTHIS.Program.Misc.CreateID ( DEF.Tab.Supply.TAB , DEF.Tab.Supply.ID );
        //        ORM.Supply.Insert_ByID ( strSupplyID );

        //        _dsDBCompany.Tables [ 0 ].Rows [ 0 ] [ DEF.Tab.Supply.ID ] = strSupplyID;
        //        _dsDBCompany.Tables [ 0 ].Rows [ 0 ] [ DEF.Tab.Supply.Sales ] = GLOBAL.User.strName;

        //        //set ds
        //        for ( int i = 0 ; i < n ; i++ )
        //        {
        //            unit = ( FIXUNIT ) ary [ i ];
        //            _dsDBCompany.Tables [ 0 ].Rows [ 0 ] [ unit.strField ] = drExcel [ unit.strExcel ];
        //        }

        //        //save ds
        //        string [] strkeys = new string [] { DEF.Tab.Supply.ID };
        //        Sql.UpdateDataSet2DB ( ref _dsDBCompany , strkeys );
        //    }

        //    //因为 如果原来表是全空的话，会插入一条临时记录， 最后要清除它。
        //    ORM.Supply.Delete_ById ( "000000000" );

        //    Sql.Close ();
        //    return true;
        
        //}

        //
        //void SaveContactFromXlsLine ( string strDBCustomerID , DataRow drExcel )
        //{
        //    SQL Sql = new SQL ( GLOBAL.Param.strSqlConnect ); 

        //    ArrayList aryLstMatch = new ArrayList ( );
        //    aryLstMatch = GetFixUnit_Contact ( );

        //    FIXUNIT unit;

        //    Sql.DataSetClear ( ref _dsDBContact );

        //    if (_dsDBContact.Tables[0].Rows.Count <= 0)
        //    {
        //        Sql.Close ();
        //        return;
        //    }    

        //    DataRow dr = _dsDBContact.Tables [ 0 ].Rows [ 0 ];

        //    if ( _strTable == DEF.Tab.Customer.TAB )
        //    {
        //        dr [ DEF.Tab.CustomerContact.CustomerID ] = strDBCustomerID;
        //        dr [ DEF.Tab.CustomerContact.Sales ] = GLOBAL.User.strName;
        //    }
        //    else if ( _strTable == DEF.Tab.Vendor.TAB )
        //    {
        //        dr [ DEF.Tab.VendorContact.VendorID ] = strDBCustomerID;
        //        dr [ DEF.Tab.VendorContact.Sales ] = GLOBAL.User.strName;
        //    }

        //    //set ds
        //    for ( int i = 0 ; i < aryLstMatch.Count ; i++ )
        //    {
        //        unit = ( FIXUNIT ) aryLstMatch [ i ];
        //        dr [ unit.strField ] = drExcel [ unit.strExcel ];
        //    }

        //    //                dr[DEF.Tab.CustomerContact.Sales] = GLOBAL.User.strName;

        //    //save ds
        //    DataTable dt = new DataTable ( );
        //    dt = _dsDBContact.Tables [ 0 ];
        //    Sql.InsertTable2DB ( ref dt );

        //    Close () ;
        //}

        //void CreateCompanyFromXlsLine ( string strCustomerID , DataRow drExcel )
        //{
        //    SQL Sql = new SQL ( GLOBAL.Param.strSqlConnect ) ;

        //    ArrayList aryCompanyItem = new ArrayList ( );
        //    aryCompanyItem = GetFixUnit_Company ( );

        //    Sql.DataSetClear ( ref _dsDBCompany );
        //    DataRow dr = _dsDBCompany.Tables [ 0 ].Rows [ 0 ];

        //    string strXlsCompanyEName = drExcel [ Def_XlsColName_EName ].ToString ( ).Trim ( );
        //    string strXlsCompanyCName = drExcel [ Def_XlsColName_CName ].ToString ( ).Trim ( );

        //    if ( _strTable == DEF.Tab.Customer.TAB )
        //    {
        //        dr [ DEF.Tab.Customer.CustomerID ] = strCustomerID;
        //        dr [ DEF.Tab.Customer.EnglishName ] = strXlsCompanyEName;
        //        dr [ DEF.Tab.Customer.CompanyName ] = strXlsCompanyCName;

        //        dr [ DEF.Tab.CustomerContact.Sales ] = GLOBAL.User.strName;
        //    }
        //    else if ( _strTable == DEF.Tab.Vendor.TAB )
        //    {
        //        dr [ DEF.Tab.Vendor.VendorID ] = strCustomerID;
        //        dr [ DEF.Tab.Vendor.VendorName ] = strXlsCompanyCName;
        //        dr [ DEF.Tab.Vendor.EnglishName ] = strXlsCompanyEName;
        //    }

        //    //set ds
        //    FIXUNIT unit;
        //    for ( int i = 0 ; i < aryCompanyItem.Count ; i++ )
        //    {
        //        unit = ( FIXUNIT ) aryCompanyItem [ i ];
        //        dr [ unit.strField ] = drExcel [ unit.strExcel ];
        //    }

        //    //save ds
        //    DataTable dt = new DataTable ( );
        //    dt = _dsDBCompany.Tables [ 0 ];
        //    Sql.InsertTable2DB ( ref dt );

        //    Sql.Close () ;

        //}

        //void UpdateCompanyFromXlsLine ( string strCompanyID , DataRow drExcel )
        //{
        //    SQL Sql = new SQL ( GLOBAL.Param.strSqlConnect ) ;

        //    string [ ] strKeys = new string [ 1 ] { "" };

        //    ArrayList aryCompanyItem = new ArrayList ( );
        //    aryCompanyItem = GetFixUnit_Company ( );

        //    //Sql.DataSetClear ( ref _dsDBCompany );

        //    string strSql ;
        //    if ( _strTable == DEF.Tab.Customer.TAB )
        //    {
        //        strSql = String.Format ( "select * from {0} where {1}='{2}' " , _strTable , DEF.Tab.Customer.CustomerID , strCompanyID );
        //        _dsDBCompany = Sql.ExecDataSet ( strSql );
        //    }
        //    else
        //    {
        //        strSql = String.Format ( "select * from {0} where {1}='{2}' " , _strTable , DEF.Tab.Vendor.VendorID , strCompanyID );
        //        _dsDBCompany = Sql.ExecDataSet ( strSql );

        //    }

        //    DataRow dr = _dsDBCompany.Tables [ 0 ].Rows [ 0 ];

        //    string strXlsCompanyCName = drExcel [ Def_XlsColName_CName ].ToString ( ).Trim ( );
        //    string strXlsCompanyEName = drExcel [ Def_XlsColName_EName ].ToString ( ).Trim ( );

        //    if ( _strTable == DEF.Tab.Customer.TAB )
        //    {
        //        dr [ DEF.Tab.Customer.CustomerID ] = strCompanyID;
        //        //dr [ DEF.Tab.Customer.EnglishName ] = strXlsCompanyEName;
        //        //dr [ DEF.Tab.Customer.CompanyName ] = strXlsCompanyCName;

        //        dr [ DEF.Tab.CustomerContact.Sales ] = GLOBAL.User.strName;

        //        strKeys [ 0 ] = DEF.Tab.Customer.CustomerID;
        //    }
        //    else if ( _strTable == DEF.Tab.Vendor.TAB )
        //    {
        //        dr [ DEF.Tab.Vendor.VendorID ] = strCompanyID;
        //        //dr [ DEF.Tab.Vendor.VendorName ] = strXlsCompanyCName;
        //        //dr [ DEF.Tab.Vendor.EnglishName ] = strXlsCompanyEName;

        //        strKeys [ 0 ] = DEF.Tab.Vendor.VendorID;
        //    }

        //    //set ds
        //    FIXUNIT unit;
        //    for ( int i = 0 ; i < aryCompanyItem.Count ; i++ )
        //    {
        //        unit = ( FIXUNIT ) aryCompanyItem [ i ];
        //        dr [ unit.strField ] = drExcel [ unit.strExcel ];
        //    }

        //    //save ds
        //    DataTable dt = new DataTable ( );
        //    dt = _dsDBCompany.Tables [ 0 ];
        //    //string[] strKeys = new string[1] { DEF.Tab.Customer.CustomerID };
        //    //strKeys[0] = DEF.Tab.Customer.CustomerID;
        //    Sql.UpdateTable2DB ( ref dt , strKeys );

        //    Sql.Close () ;
        //}

        private void Clear ( )
        {
            for ( int i = 0 ; i < lstMatch.Items.Count ; i++ )
                lstMatch.Items [ i ].SubItems [ 1 ].Text = "";

            lstExcel.Items.Clear ( );

            if ( _dsExcel.Tables.Count > 0 )
            {
                _dsExcel.Tables [ 0 ].Rows.Clear ( );
                _dsExcel.Tables.Clear ( );
            }
        }

        //private void InitCaption ( )
        //{
        //    /*
        //    captonTitle.Text = "Set Mapping and Convert";
        //    captonTitle.Lable.Font = DEF.Appearance.Font.Title;
        //    captonTitle.Lable.ForeColor = DEF.Appearance.Color.TextTitle;
        //    captonTitle.SetBKColor ( DEF.Appearance.Color.CaptionBK , DEF.Appearance.Color.CaptionBK2 );

        //    captonNote.Text = "Note: the Execl FIRST line must be a description of column.";
        //    captonNote.Lable.Font = DEF.Appearance.Font.Note;
        //    captonNote.Lable.ForeColor = DEF.Appearance.Color.TextNote;
        //    captonNote.Icon = global::MogulCRM.Properties.Resources.Light_16x16;
        //    captonNote.SetBKColor ( DEF.Appearance.Color.CaptionBK , Color.Transparent );
        //     */
        //}

        #region Event

        //company <=
        private void btnCompany2Left_Click ( object sender , EventArgs e )
        {
            Add2Left ( );
        }

        //company =>
        private void btnCompany2Right_Click ( object sender , EventArgs e )
        {
            Sub2Right ( );
        }

        private void btnContact2Left_Click ( object sender , EventArgs e )
        {
            Add2Left_Contact ( );
        }

        private void btnContact2Right_Click ( object sender , EventArgs e )
        {
            Sub2Right_Contact ( );
        }

        void GetMatchList()
        {
            if (_lstE2F.Count != lstMatch.Items.Count)
            {
                FF.Ctrl.MsgBox.ShowWarn( "Match Error !" );
                return;
            }

            int n = 0;
            foreach (ListViewItem Item in lstMatch.Items)
            {
                _lstE2F[ n ++ ].ExcelName = Item.SubItems [ 1 ].Text.Trim();
            }
        }

        private void butConvert_Click_1 ( object sender , EventArgs e )
        {
            if (!Check())
                return;

            GetMatchList();
            
            //FF.Ctrl.MsgBox.Show ( DEF.String.MsgBox.ConvertOK );
            DialogResult = DialogResult.OK;
            Close ( );
            
        }

        private void cmbSheetName_Change ( object sender , EventArgs e )
        {
            int Index = cmbSheetName.SelectedIndex;
            GetExcelSheet ( Index );
        }

        ////private void cmbXlsCompany_SelectChange ( object sender , EventArgs e )
        //private void LoadXlsCompany ( )
        //{
        //    string str;
         
        //    /*string strCompanyCol = cmbXlsCompanyCol.Text;
        //    if ( strCompanyCol.Trim ( ) == "" )
        //        return;
        //    */

        //    //_nXlsCNameCol = cmbXlsCompanyCol.SelectedIndex;

        //    //得到Xls的所有公司名称（Distingct性质）
        //    GetAllExcelCompany ( Def_XlsColName_CName , Def_XlsColName_EName );

        //    //Fill List
        //    int n = 0 ;
        //    //lstMatchCompany.Items.Clear ( );
        //    foreach ( string strCompany in aryCompanyCName )
        //    {
        //        ListViewItem li = new ListViewItem ( strCompany );

        //        str = aryCompanyEName [ n++ ].ToString ( ); 
        //        li.SubItems.Add ( str );

        //        li.SubItems.Add ( "" );
        //        li.SubItems.Add ( "" );
        //        li.SubItems.Add ( "" );
        //        li.SubItems.Add ( "" );

        //        //this.lstMatchCompany.Items.Add ( li );
        //    }
        //}

        //private void btnMathCompany_Click ( object sender , EventArgs e )
        //{
        //    if ( _strType == "Customer" )
        //        SetCustomer ( );
        //    else if ( _strType == "Vendor" )
        //        SetVendor ( );
        //}

        #endregion

        //void SetCustomer ( )
        //{
        //    if ( lstMatchCompany.SelectedIndices.Count <= 0 )
        //    {
        //        MessageBox.Show ( "Please Select a List Item in first." );
        //        return;
        //    }

        //    int nlstCompanyCurSel = lstMatchCompany.SelectedIndices [ 0 ];

        //    FindVendorDlg Dlg = new FindVendorDlg ( );
        //    Dlg.txtName.Text = lstMatchCompany.Items [ nlstCompanyCurSel ].SubItems [ 0 ].Text;
        //    Dlg.ShowDialog ( );

        //    lstMatchCompany.Items [ nlstCompanyCurSel ].SubItems [ 3 ].Text = Dlg._strSelVendorID;
        //    lstMatchCompany.Items [ nlstCompanyCurSel ].SubItems [ 4 ].Text = Dlg._strSelVendorCName;
        //    lstMatchCompany.Items [ nlstCompanyCurSel ].SubItems [ 5 ].Text = Dlg._strSelVendorEName;

        //}

        //void SetVendor ( )
        //{
        //    if ( lstMatchCompany.SelectedIndices.Count <= 0 )
        //    {
        //        MessageBox.Show ( "Please Select a List Item in first." );
        //        return;
        //    }

        //    int nlstCompanyCurSel = lstMatchCompany.SelectedIndices [ 0 ];

        //    FindVendorDlg Dlg = new FindVendorDlg ( );
        //    Dlg.txtName.Text = lstMatchCompany.Items [ nlstCompanyCurSel ].SubItems [ 0 ].Text;
        //    Dlg.ShowDialog ( );

        //    lstMatchCompany.Items [ nlstCompanyCurSel ].SubItems [ 3 ].Text = Dlg._strSelVendorID;
        //    lstMatchCompany.Items [ nlstCompanyCurSel ].SubItems [ 4 ].Text = Dlg._strSelVendorCName;
        //    lstMatchCompany.Items [ nlstCompanyCurSel ].SubItems [ 5 ].Text = Dlg._strSelVendorEName;
        //}

        //void MatchCompany ( )
        //{
        //    aryCompanyID.Clear ( );
        //    foreach ( string str in aryCompanyCName )
        //        aryCompanyID.Add ( "" );

        //    //
        //    int n;
        //    string strName;
        //    foreach ( ListViewItem li in lstMatchCompany.Items )
        //    {
        //        strName = li.SubItems [ 0 ].Text.Trim ( );
        //        n = FF.Ary.IndexOfAry ( ref aryCompanyCName , strName );
        //        if ( n != -1 )
        //            aryCompanyID [ n ] = li.SubItems [ 3 ].Text.Trim ( );           //CustomerID
        //    }
        //}

        //private void lstmatch_DBClick ( object sender , MouseEventArgs e )
        //{
        //    SetFindParam ( );
        //}

        //private void lstFind_DBClick ( object sender , MouseEventArgs e )
        //{
        //    GetFindResult ( );
        //}

        //void SetFindParam ( )
        //{
        //    if ( lstMatchCompany.SelectedIndices.Count <= 0 )
        //        return;

        //    _nSelMatch = lstMatchCompany.SelectedIndices [ 0 ];
        //    string strXlsCName = lstMatchCompany.Items [ _nSelMatch ].SubItems [ 0 ].Text.Trim ( );
        //    string strXlsEName = lstMatchCompany.Items [ _nSelMatch ].SubItems [ 1 ].Text.Trim ( );

        //    txtCName.Text = strXlsCName;
        //    txtEName.Text = strXlsEName;

        //    DoFind ( );
        //}

        //void GetFindResult ( )
        //{
        //    if ( lstFind.SelectedIndices.Count <= 0 )
        //        return;

        //    int nSel = lstFind.SelectedIndices [ 0 ];

        //    string strID = lstFind.Items [ nSel ].SubItems [ 0 ].Text.Trim ( );
        //    string strCName = lstFind.Items [ nSel ].SubItems [ 1 ].Text.Trim ( );
        //    string strEName = lstFind.Items [ nSel ].SubItems [ 2 ].Text.Trim ( );

        //    lstMatchCompany.Items [ _nSelMatch ].SubItems [ 3 ].Text = strID;
        //    lstMatchCompany.Items [ _nSelMatch ].SubItems [ 4 ].Text = strCName;
        //    lstMatchCompany.Items [ _nSelMatch ].SubItems [ 5 ].Text = strEName;

        //    ShowNewCompanyItem ( );
        //}

        //private void btnFind_Click ( object sender , EventArgs e )
        //{
        //    DoFind ( );
        //}

        //void DoFind ( )
        //{
        //    if ( _strType == "Customer" )
        //        FindCustomer ( );
        //    else if ( _strType == "Vendor" )
        //        FindVendor ( );
        //}

        //void FindCustomer ( )
        //{
        //    string strWhere = "" , strCNameCause = "" , strENameCause = "" , strSalescause = "";

        //    if ( txtCName.Text.Trim ( ) != "" )
        //    {
        //        strCNameCause = String.Format ( "{0} like '%{1}%'" , DEF.Tab.Customer.CompanyName , txtCName.Text.Trim ( ) );
        //        FF.Str.Where.AndWhereCause ( ref strWhere , strCNameCause );
        //    }

        //    if ( txtEName.Text.Trim ( ) != "" )
        //    {
        //        strENameCause = String.Format ( "{0} like '%{1}%'" , DEF.Tab.Customer.EnglishName , txtEName.Text.Trim ( ) );
        //        FF.Str.Where.AndWhereCause ( ref strWhere , strENameCause );
        //    }

        //    strSalescause = COMMTHIS.Program.Where.GetSalseCause ( );
        //    FF.Str.Where.AndWhereCause ( ref strWhere , strSalescause );

        //    //
        //    DataTable dt = new DataTable ( );
        //    dt = ORM.Customer.Get_ByWhere ( strWhere );
        //    FillCustomerData ( ref dt );
        //}

        //void FindVendor ( )
        //{
        //    string strWhere = "" , strCNameCause = "" , strENameCause = "" , strSalescause = "";

        //    if ( txtCName.Text.Trim ( ) != "" )
        //    {
        //        strCNameCause = String.Format ( "{0} like '%{1}%'" , DEF.Tab.Vendor.VendorName , txtCName.Text.Trim ( ) );
        //        FF.Str.Where.AndWhereCause ( ref strWhere , strCNameCause );
        //    }

        //    if ( txtEName.Text.Trim ( ) != "" )
        //    {
        //        strENameCause = String.Format ( "{0} like '%{1}%'" , DEF.Tab.Vendor.EnglishName , txtEName.Text.Trim ( ) );
        //        FF.Str.Where.AndWhereCause ( ref strWhere , strENameCause );
        //    }

        //    //strSalescause = COMMTHIS.Program.Where.GetSalseCause();
        //    //FF.Str.Where.AndWhereCause(ref strWhere, strSalescause);

        //    //
        //    DataTable dt = new DataTable ( );
        //    dt = ORM.Vendor.Get_ByWhere ( strWhere );
        //    FillVendorData ( ref dt );
        //}

        //void FillCustomerData ( ref DataTable dt )
        //{
        //    lstFind.Items.Clear ( );

        //    foreach ( DataRow dr in dt.Rows )
        //    {
        //        ListViewItem li = new ListViewItem ( dr [ DEF.Tab.Customer.CustomerID ].ToString ( ).Trim ( ) );
        //        li.SubItems.Add ( dr [ DEF.Tab.Customer.CompanyName ].ToString ( ).Trim ( ) );
        //        li.SubItems.Add ( dr [ DEF.Tab.Customer.EnglishName ].ToString ( ).Trim ( ) );
        //        li.SubItems.Add ( dr [ DEF.Tab.Customer.Level ].ToString ( ).Trim ( ) );
        //        li.SubItems.Add( dr[DEF.Tab.Customer.Phone1].ToString().Trim());
        //        li.SubItems.Add ( dr [ DEF.Tab.Customer.Application ].ToString ( ).Trim ( ) );
        //        li.SubItems.Add ( dr [ DEF.Tab.Customer.Location ].ToString ( ).Trim ( ) );
        //        li.SubItems.Add(dr[DEF.Tab.Customer.Web].ToString().Trim());
        //        li.SubItems.Add ( dr [ DEF.Tab.Customer.Sales ].ToString ( ).Trim ( ) );

        //        lstFind.Items.Add ( li );
        //    }
        //}

        //void FillVendorData ( ref DataTable dt )
        //{
        //    lstFind.Items.Clear ( );

        //    foreach ( DataRow dr in dt.Rows )
        //    {
        //        ListViewItem li = new ListViewItem ( dr [ DEF.Tab.Vendor.VendorID ].ToString ( ).Trim ( ) );
        //        li.SubItems.Add ( dr [ DEF.Tab.Vendor.VendorName ].ToString ( ).Trim ( ) );
        //        li.SubItems.Add ( dr [ DEF.Tab.Vendor.EnglishName ].ToString ( ).Trim ( ) );
        //        li.SubItems.Add(dr[DEF.Tab.Vendor.Credit].ToString().Trim());   //as customer level
        //        li.SubItems.Add(dr[DEF.Tab.Vendor.Phone1].ToString().Trim());
        //        li.SubItems.Add("");    //as customer Application
        //        li.SubItems.Add ( dr [ DEF.Tab.Vendor.Location ].ToString ( ).Trim ( ) );
        //        li.SubItems.Add(dr[DEF.Tab.Vendor.Web].ToString().Trim());
        //        li.SubItems.Add(""); //as customer Sales

        //        lstFind.Items.Add ( li );
        //    }
        //}

        //private void btnOK_Click ( object sender , EventArgs e )
        //{
        //    GetFindResult ( );
        //}

        //private void btnSetNewCus_Click ( object sender , EventArgs e )
        //{
        //    SetNewCompany ( );
        //}

        //private void button3_Click ( object sender , EventArgs e )
        //{
        //    ClearNewCompany ( );
        //}

        //void SetNewCompany ( )
        //{
        //    if ( lstMatchCompany.SelectedIndices.Count <= 0 )
        //        return;

        //    int nSel = lstMatchCompany.SelectedIndices [ 0 ];
        //    aryNewCompanyIndex.Add ( nSel );

        //    ShowNewCompanyItem ( );
        //}

        //void ClearNewCompany ( )
        //{
        //    if ( lstMatchCompany.SelectedIndices.Count <= 0 )
        //        return;

        //    int nSel = lstMatchCompany.SelectedIndices [ 0 ];

        //    int index = aryNewCompanyIndex.IndexOf ( nSel );

        //    if ( index >= 0 )
        //    {
        //        lstMatchCompany.Items [ nSel ].SubItems [ 2 ].Text = "";
        //        aryNewCompanyIndex.RemoveAt ( index );
        //    }

        //    ShowNewCompanyItem ( );
        //}

        //void ShowNewCompanyItem ( )
        //{
        //    string str = "";
        //    int index , count = lstMatchCompany.Items.Count;
        //    for ( int i = 0 ; i < count ; i++ )
        //    {
        //        index = aryNewCompanyIndex.IndexOf ( i );

        //        if ( index >= 0 )    //是要新建立company的行
        //        {
        //            lstMatchCompany.Items [ i ].SubItems [ 3 ].Text = _strNewFlag;
        //            lstMatchCompany.Items [ i ].SubItems [ 4 ].Text = "";
        //            lstMatchCompany.Items [ i ].SubItems [ 5 ].Text = "";

        //            lstMatchCompany.Items [ i ].BackColor = Color.DeepPink;
        //        }
        //        else
        //        {
        //            str = lstMatchCompany.Items [ i ].SubItems [ 3 ].Text.Trim ( );
        //            if ( str != "" )
        //                lstMatchCompany.Items [ i ].BackColor = Color.LightGreen;
        //            else
        //                lstMatchCompany.Items [ i ].BackColor = Color.White;
        //        }
        //    }
        //}

        //string IsExistInNewAry ( string strXlsCompanyName )
        //{
        //    foreach ( NEWITEM NewItem in aryCreateNew )
        //    {
        //        if ( strXlsCompanyName == NewItem.strName )
        //        {
        //            return NewItem.strID;
        //        }
        //    }

        //    return "";
        //}

        //private void btnRemove_Click(object sender, EventArgs e)
        //{
        //    RemoveMatch();
        //    ClearNewCompany();
        //}

        //void RemoveMatch()
        //{
        //    if (lstMatchCompany.SelectedIndices.Count <= 0)
        //        return;

        //    int nSel = lstMatchCompany.SelectedIndices[0];

        //    //remove match
        //    lstMatchCompany.Items[nSel].SubItems[3].Text = "";
        //    lstMatchCompany.Items[nSel].SubItems[4].Text = "";
        //    lstMatchCompany.Items[nSel].SubItems[5].Text = "";

            
        //    ShowNewCompanyItem();
        //}

        //private void btnExit_Click ( object sender , EventArgs e )
        //{
        //    //因为 如果原来表是全空的话，会插入一条临时记录， 最后要清除它。
        //    ORM.Stock.Delete_ById ( "000000000" );
        //    ORM.Supply.Delete_ById ( "000000000" );
        //}



    }
}