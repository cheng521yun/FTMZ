/*
 * 引用OLEDB，需要注意的问题：
 * 
 * 1）假设access中所有的自动编号字段 都叫“编号”。 临时解决办法。很有问题。
 * 
 * 
 */



using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;
using System.Windows.Forms;

using System.Data;
using System.Data.OleDb;


namespace FrontFlag
{
    public class OLEDB
    {
        private OleDbConnection _conn = null;

        string strReplaceChar = "＇";       //用于替换字段中危险的'字符。


        #region 构造函数

        public OLEDB ()
        {
            _conn = null;
        }

        public OLEDB ( string strMdbFileName )
        {
            string strConn = String.Format ( "Provider=Microsoft.Jet.OleDb.4.0; Data Source={0}" , strMdbFileName );
            try
            {
                _conn = new OleDbConnection ( strConn );
            }
            catch ( Exception e )
            {
                FF.Ctrl.MsgBox.ShowWarn ( String.Format ( "connect OleDB is ERR !\n{0}" , e.Message ) );
            }
        }

        public OLEDB(string strMdbFileName , string strPassword)
        {
            string strConn = String.Format("Provider=Microsoft.Jet.OleDb.4.0; Data Source={0}; Jet OLEDB:Database Password={1}", strMdbFileName, strPassword);
            try
            {
                _conn = new OleDbConnection(strConn);
            }
            catch (Exception e)
            {
                FF.Ctrl.MsgBox.ShowWarn(String.Format("connect OleDB is ERR !\n{0}", e.Message));
            }
        }

        #endregion

        #region 析构函数

        public void Close ()
        {
            if ( _conn != null )
            {
                _conn.Close ();
                _conn = null;
            }
        }    

        #endregion

        //
        public DataSet ExecDataSet ( string strSqlString )
        {
            DataSet ds = new DataSet ();

            try
            {
                _conn.Open ();

                strSqlString = GetSafeStr ( strSqlString );
                OleDbCommand cmd = new OleDbCommand ( strSqlString , _conn );
                OleDbDataReader dr = cmd.ExecuteReader ();
                ds = DataReader2DataSet ( dr );
                dr.Close ();
            }
            catch ( Exception e )
            {
                string strErr = String.Format ( "CSqlAdo Error ! " + e.Message + "\nSql语句是: " + strSqlString );
                MessageBox.Show ( strErr );
            }

            _conn.Close ();

            //set Tablename to dataset.
            strSqlString = strSqlString.ToLower ();
            int n = strSqlString.IndexOf ( "from" );
            if ( n >= 0 && ds != null && ds.Tables.Count > 0 )
            {
                string str = strSqlString.Substring ( n ).Trim ();  //str= from tablename where xxxx
                n = str.IndexOf ( ' ' );
                str = str.Substring ( n ).Trim ();  //str= tablename xxxxx
                n = str.IndexOf ( ' ' );
                if ( n >= 0 )                        //if have not Where , n =-1 .
                    str = str.Substring ( 0 , n ).Trim (); //str = tablename

                ds.Tables [ 0 ].TableName = str;
            }

            return ds;
        }

        public DataSet DataReader2DataSet ( OleDbDataReader reader )
        {
            DataSet dataSet = new DataSet ();
            do
            {
                // Create new data table

                DataTable schemaTable = reader.GetSchemaTable ();
                DataTable dataTable = new DataTable ();

                if ( schemaTable != null )
                {
                    // A query returning records was executed

                    for ( int i = 0 ; i < schemaTable.Rows.Count ; i++ )
                    {
                        DataRow dataRow = schemaTable.Rows [ i ];
                        // Create a column name that is unique in the data table
                        string columnName = ( string ) dataRow [ "ColumnName" ];
                        // Add the column definition to the data table
                        DataColumn column = new DataColumn ( columnName , ( Type ) dataRow [ "DataType" ] );
                        dataTable.Columns.Add ( column );
                    }

                    dataSet.Tables.Add ( dataTable );

                    // Fill the data table we just created

                    while ( reader.Read () )
                    {
                        DataRow dataRow = dataTable.NewRow ();

                        for ( int i = 0 ; i < reader.FieldCount ; i++ )
                            dataRow [ i ] = reader.GetValue ( i );

                        dataTable.Rows.Add ( dataRow );
                    }
                }
                else
                {
                    // No records were returned

                    DataColumn column = new DataColumn ( "RowsAffected" );
                    dataTable.Columns.Add ( column );
                    dataSet.Tables.Add ( dataTable );
                    DataRow dataRow = dataTable.NewRow ();
                    dataRow [ 0 ] = reader.RecordsAffected;
                    dataTable.Rows.Add ( dataRow );
                }
            }
            while ( reader.NextResult () );
            return dataSet;
        }

        public DataTable ExecDataTable ( string strSqlString )
        {
            DataSet ds = new DataSet ();
            strSqlString = GetSafeStr ( strSqlString );
            ds = ExecDataSet ( strSqlString );
            if ( ds != null && ds.Tables.Count > 0 )
                return ds.Tables [ 0 ];
            else
                return null;
        }

        //

        public bool Exec ( string strSqlString )
        {
            try
            {
                _conn.Open ();

                strSqlString = GetSafeStr ( strSqlString );
                OleDbCommand cmd = new OleDbCommand ( strSqlString , _conn );
                cmd.ExecuteNonQuery ();
            }
            catch ( Exception e )
            {
                string str = String.Format ( "SQL Error ! " + e.Message );
                MessageBox.Show ( str );
                _conn.Close ();
                return false;
            }

            _conn.Close ();
            return true;
        }

        public void Exec ( string strSqlString , OleDbParameter [ ] Params )
        {
            try
            {
                _conn.Open ();

                strSqlString = GetSafeStr ( strSqlString );
                OleDbCommand cmd = new OleDbCommand ( strSqlString , _conn );
                cmd.Parameters.AddRange ( Params );

                cmd.ExecuteNonQuery ();
            }
            catch ( Exception e )
            {
                string str = String.Format ( "SQL Error ! " + e.Message );
                MessageBox.Show ( str );
            }

            _conn.Close ();
        }


        //下面代码是临时用的解决办法， 以后的改一个完善的。
        public string ExecInsertRet ( string strInsert )
        {
            strInsert = GetSafeStr ( strInsert );
            DataTable dt = new DataTable ();
            //string strSql = "SET NOCOUNT ON ; " + strInsert + " ; SELECT @@IDENTITY ";
            dt = ExecDataTable ( strInsert );
            //string strSql = strInsert + "SELECT @@IDENTITY";
            //dt = ExecDataTable ( "SELECT @@IDENTITY" );

            strInsert =strInsert.ToLower () ;
            int nIndex = strInsert.IndexOf ( "into" ) ;
            string strtmp = strInsert.Substring ( nIndex ).Trim () ;
            char [] chs = { ' ' } ;
            string [] strs = strtmp.Split ( chs ) ;
            if ( strs.Length <= 1 )
                return "" ;
            string strTablename = strs [ 1 ] ;
            string strSql = String.Format ( "SELECT Max ({0}) from {1}" , "编号" , strTablename );   //临时用的， 得保证表里的自增量字段 都叫“编号”。
            dt = ExecDataTable ( strSql );
            if ( dt == null || dt.Rows.Count <= 0 )
                return "";
            return dt.Rows [ 0 ] [ 0 ].ToString ();
        }

        public void ExecProcedure ( string strProcName , OleDbParameter [ ] Param )
        {
            try
            {
                _conn.Open ();

                strProcName = GetSafeStr ( strProcName );
                OleDbCommand cmd = new OleDbCommand ( strProcName , _conn );
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddRange ( Param );

                cmd.ExecuteNonQuery ();
            }
            catch ( Exception e )
            {
                string str = String.Format ( "SQL Error ! " + e.Message );
                MessageBox.Show ( str );
            }

            _conn.Close ();
        }

        public string [ ] ExecStrAry ( string strSqlString )
        {
            ArrayList ary = new ArrayList ();

            try
            {
                _conn.Open ();

                strSqlString = GetSafeStr ( strSqlString );
                OleDbCommand cmd = new OleDbCommand ( strSqlString , _conn );
                OleDbDataReader dr = cmd.ExecuteReader ();

                string str;
                while ( dr.Read () )
                {
                    str = ( ( string ) dr.GetValue ( 0 ) ).Trim ();
                    ary.Add ( str );
                }

                dr.Close ();

            }
            catch ( Exception e )
            {
                string strErr = String.Format ( "CSqlAdo Error ! " + e.Message + "\nSql语句是: " + strSqlString );
                MessageBox.Show ( strErr );
            }

            _conn.Close ();

            //
            string [ ] strary = new string [ ary.Count ];
            for ( int i = 0 ; i < ary.Count ; i++ )
                strary [ i ] = ( string ) ary [ i ];

            return strary;
        }

        #region DataTable

        public string InsertTable2DB ( ref DataTable dt , string [ ] strsNotSaveFld )
        {
            if ( dt.Rows.Count < 0 )
                return "";

            string strRetID = "";

            string [ ] strsAutoAddFld = GetFlagFld ( dt.TableName );
            string strTable = dt.TableName;

            int n = 0;
            string strSql , str1 = "" , str2 = "" , strFld = "" , strValue = "" , strText;
            Type t;
            bool bEndFlag = false , bRet = true;

            foreach ( DataRow dr in dt.Rows )
            {
                n = 0;
                str1 = "";
                str2 = "";

                foreach ( DataColumn dc in dt.Columns )
                {
                    bEndFlag = false;

                    if ( strsAutoAddFld != null )
                    {
                        foreach ( string s in strsAutoAddFld )   //检查是否是自增量列， 要是，就不保存此列了。
                        {
                            if ( s == dc.ColumnName )
                                bEndFlag = true;
                        }
                    }

                    if ( strsNotSaveFld != null )
                    {
                        foreach ( string s2 in strsNotSaveFld ) //检查是否指定的不保存的列， 要是，就不保存此列了。
                        {
                            if ( s2 == dc.ColumnName )
                                bEndFlag = true;
                        }
                    }

                    if ( bEndFlag )
                        continue;

                    strFld = dc.ColumnName;
                    t = dc.DataType;

                    strText = dr [ dc ].ToString ().Trim ();
                    strText = strText.Replace ( "'" , strReplaceChar );

                    if ( t == typeof ( System.String ) )
                        strValue = String.Format ( " '{0}' " , strText );
                    else if ( t == typeof ( System.Int32 ) )
                        strValue = String.Format ( " {0} " , Convert.IsDBNull ( dr [ dc ] ) ? 0 : dr [ dc ] );
                    else if ( t == typeof ( System.Boolean ) )
                        strValue = String.Format ( " {0} " , strText );
                    else if ( t == typeof ( System.Byte ) )
                        strValue = String.Format ( " {0} " , dr [ dc ] );
                    else if ( t == typeof ( System.DateTime ) )
                        strValue = String.Format ( " '{0}' " , strText );
                    else if ( t == typeof ( System.Decimal ) )
                        strValue = String.Format ( " {0} " , strText );
                    else
                        //continue;
                        strValue = String.Format ( " '{0}' " , strText );

                    if ( n > 0 )
                    {
                        str1 += ", ";
                        str2 += ", ";
                    }

                    str1 += strFld;
                    str2 += strValue;

                    n++;
                }

                strSql = String.Format ( "INSERT INTO {0} ( {1} ) VALUES ( {2} ) " , strTable , str1 , str2 );
                strRetID = ExecInsertRet ( strSql );
            }

            return strRetID;
        }
        public string InsertTable2DB ( ref DataTable dt )
        {
            string [ ] strsNotSaveFld = null;
            return InsertTable2DB ( ref dt , strsNotSaveFld );
        }

        public bool UpdateTable2DB ( ref DataTable dt , string [ ] strKeys , string [ ] strNotSaveFld )
        {
            //            DataRow[] currentRows = dt.Select ( null , null , DataViewRowState.ModifiedCurrent );
            DataRow [ ] currentRows = dt.Select ( null , null , DataViewRowState.CurrentRows );

            if ( currentRows.Length < 1 )
                return false;

            int n = 0;
            string strTable = dt.TableName;
            string str = "" , strFld , strSet , strSql , strWhere , strText;
            Type t;
            bool bEndFlag;
            bool bRet = true;

            string [ ] strsAutoAddFld = GetFlagFld ( dt.TableName );

            //foreach ( DataRow dr in dt.Rows )  
            foreach ( DataRow dr in currentRows )
            {
                //create Where string
                n = 0;
                strWhere = "";
                foreach ( string strKey in strKeys )
                {
                    if ( n > 0 )
                        strWhere += " AND ";

                    strText = dr [ strKey ].ToString ().Trim ();
                    strText = strText.Replace ( "'" , strReplaceChar );

                    str = String.Format ( "{0}='{1}'" , strKey , strText );
                    strWhere += str;
                    n++;
                }

                //create set( x=y ,) string
                n = 0;
                strSet = "";
                foreach ( DataColumn dc in dt.Columns )
                {
                    bEndFlag = false;
                    strFld = dc.ColumnName;

                    foreach ( string s in strsAutoAddFld )   //检查是否是自增量列， 要是，就不保存此列了。
                    {
                        if ( s == strFld )
                            bEndFlag = true;
                    }

                    if ( bEndFlag )
                        continue;

                    t = dr [ dc ].GetType ();

                    foreach ( string strNot in strNotSaveFld )
                    {
                        if ( strNot == strFld )
                            bEndFlag = true;
                    }

                    if ( bEndFlag )
                        continue;

                    strText = dr [ dc ].ToString ().Trim ();
                    strText = strText.Replace ( "'" , strReplaceChar );

                    if ( t == typeof ( System.String ) )
                        str = String.Format ( " {0}='{1}' " , strFld , strText );
                    else if ( t == typeof ( System.Int32 ) )
                        str = String.Format ( " {0}={1} " , strFld , dr [ dc ] );
                    else if ( t == typeof ( System.DateTime ) )
                        str = String.Format ( " {0}='{1}' " , strFld , strText );
                    else if ( t == typeof ( System.Decimal ) )
                        str = String.Format ( " {0}={1} " , strFld , dr [ dc ] );
                    else
                        continue;

                    if ( n > 0 )
                        strSet += ", ";
                    strSet += str;

                    n++;
                }

                strSql = String.Format ( "UPDATE {0} SET {1} WHERE {2}" , strTable , strSet , strWhere );
                bRet &= Exec ( strSql );
            }

            return bRet;
        }
        public bool UpdateTable2DB ( ref DataTable dt , string [ ] strKeys )
        {
            string [ ] strNotFld = new string [ 1 ] { "" };
            return UpdateTable2DB ( ref dt , strKeys , strNotFld );
        }

        public string Save(ref DataTable dt, string[] strsNotSaveFld)
        {
            string[] strsAutoAddFld = GetFlagFld(dt.TableName);

            //没有自增加列。
            if (strsAutoAddFld.Length <= 0)
                return "";

            //一般默认第一个自增加列，比如是id
            string strID = strsAutoAddFld[0];
            string strRetID = "";  //要返回的自增量ID.

            foreach (DataRow dr in dt.Rows)
            {
                DataRow drtmp = dr;

                if (dr[strID].ToString().Trim() == "")       //没有id,表示是新增加的行。
                {
                    strRetID = InsertRow2DB(ref drtmp, strsNotSaveFld);
                }
                else
                {
                    UpdateRow2DB(ref drtmp, strsAutoAddFld, strsNotSaveFld);     //修改原来已有的行。
                    strRetID = dr[strID].ToString().Trim();
                }
            }

            return strRetID;
        }
        public string Save(ref DataTable dt)
        {
            string[] strsNotSaveFld = new string[1] { "" };
            return Save(ref dt, strsNotSaveFld);
        }

        #endregion

        #region DataRow

        public string InsertRow2DB ( ref DataRow dr , string [ ] strsNotSaveFld )
        {
            if ( dr == null )
                return "";

            string strRetID = "";

            string [ ] strsAutoAddFld = GetFlagFld ( dr.Table.TableName );
            string strTable = dr.Table.TableName;

            int n = 0;
            string strSql , str1 = "" , str2 = "" , strFld = "" , strValue = "" , strText;
            Type t;
            bool bEndFlag = false , bRet = true;

            n = 0;
            str1 = "";
            str2 = "";

            foreach ( DataColumn dc in dr.Table.Columns )
            {
                bEndFlag = false;

                if ( strsAutoAddFld != null )
                {
                    foreach ( string s in strsAutoAddFld )   //检查是否是自增量列， 要是，就不保存此列了。
                    {
                        if ( s == dc.ColumnName )
                            bEndFlag = true;
                    }
                }

                if ( strsNotSaveFld != null )
                {
                    foreach ( string s2 in strsNotSaveFld ) //检查是否指定的不保存的列， 要是，就不保存此列了。
                    {
                        if ( s2 == dc.ColumnName )
                            bEndFlag = true;
                    }
                }

                if ( bEndFlag )
                    continue;

                //strFld = dc.ColumnName;
                strFld = '[' + dc.ColumnName + ']';
                t = dc.DataType;

                strText = dr [ dc ].ToString ().Trim ();
                strText = strText.Replace ( "'" , strReplaceChar );

                if ( t == typeof ( System.String ) )
                    strValue = String.Format ( " '{0}' " , strText );
                else if ( t == typeof ( System.Int32 ) )
                    strValue = String.Format ( " {0} " , Convert.IsDBNull ( dr [ dc ] ) ? 0 : dr [ dc ] );
                else if ( t == typeof ( System.Boolean ) )
                    strValue = String.Format ( " {0} " , strText );
                else if ( t == typeof ( System.Byte ) )
                    strValue = String.Format ( " {0} " , dr [ dc ] );
                else if ( t == typeof ( System.DateTime ) )
                    strValue = String.Format ( " #{0}# " , strText );
                else if ( t == typeof ( System.Decimal ) )
                    strValue = String.Format ( " {0} " , strText );
                else
                    continue;

                if ( n > 0 )
                {
                    str1 += ", ";
                    str2 += ", ";
                }

                str1 += strFld;
                str2 += strValue;

                n++;
            }

            strSql = String.Format ( "INSERT INTO {0} ( {1} ) VALUES ( {2} ) " , strTable , str1 , str2 );
            strRetID = ExecInsertRet ( strSql );

            return strRetID;
        }
        public string InsertRow2DB ( ref DataRow dr )
        {
            string [ ] strsNotSaveFld = null;
            return InsertRow2DB ( ref dr , strsNotSaveFld );
        }

        public bool UpdateRow2DB ( ref DataRow dr , string [ ] strKeys , string [ ] strNotSaveFld )
        {
            if ( dr == null || strKeys == null || strKeys.Length <= 0 )
                return false;

            int n = 0;
            string strTable = dr.Table.TableName;
            string str = "" , strFld , strSet , strSql , strWhere , strText;
            Type t;
            bool bEndFlag;
            bool bRet = true;

            string [ ] strsAutoAddFld = GetFlagFld ( dr.Table.TableName );

            n = 0;
            strWhere = "";
            foreach ( string strKey in strKeys )
            {
                if ( n > 0 )
                    strWhere += " AND ";

                strText = dr [ strKey ].ToString ().Trim ();
                strText = strText.Replace ( "'" , strReplaceChar );

                str = String.Format("[{0}]={1}", strKey, strText);  //Access的子增量字段是数值性的，不要加引号。这与SQL不同。
                strWhere += str;
                n++;
            }

            //create set( x=y ,) string
            n = 0;
            strSet = "";
            foreach ( DataColumn dc in dr.Table.Columns )
            {
                bEndFlag = false;
                strFld = dc.ColumnName;

                foreach ( string s in strsAutoAddFld )   //检查是否是自增量列， 要是，就不保存此列了。
                {
                    if ( s == strFld )
                        bEndFlag = true;
                }

                if ( bEndFlag )
                    continue;

                t = dr [ dc ].GetType ();

                foreach ( string strNot in strNotSaveFld )
                {
                    if ( strNot == strFld )
                        bEndFlag = true;
                }

                if ( bEndFlag )
                    continue;

                strText = dr [ dc ].ToString ().Trim ();
                strText = strText.Replace ( "'" , strReplaceChar );

                if ( t == typeof ( System.String ) )
                    str = String.Format ( " [{0}]='{1}' " , strFld , strText );
                else if ( t == typeof ( System.Int32 ) )
                    str = String.Format ( " [{0}]={1} " , strFld , dr [ dc ] );
                else if ( t == typeof ( System.DateTime ) )
                    str = String.Format ( " [{0}]='{1}' " , strFld , strText );
                else if ( t == typeof ( System.Decimal ) )
                    str = String.Format ( " [{0}]={1} " , strFld , strText );
                else
                    continue;

                if ( n > 0 )
                    strSet += ", ";
                strSet += str;

                n++;
            }

            strSql = String.Format ( "UPDATE {0} SET {1} WHERE {2}" , strTable , strSet , strWhere );
            bRet &= Exec ( strSql );

            return bRet;
        }
        //以 strKeys 为索引字段， 来更新dr. 即以 strKeys中指定的一个或多个字段 来构造 Update中的 Where 字串。
        public bool UpdateRow2DB ( ref DataRow dr , string [ ] strKeys )
        {
            string [ ] strNotFld = { "" };
            return UpdateRow2DB ( ref dr , strKeys , strNotFld );
        }
        //默认 dr 中已经有一个自增量字段。以那个自增量字段作为 strKeys. 保存dr中所有的值。
        public bool UpdateRow2DB ( ref DataRow dr )
        {
            if ( dr == null )
                return false;

            int n = 0;
            string strTable = dr.Table.TableName;
            string str = "" , strFld , strSet , strSql , strWhere , strText;
            Type t;
            bool bEndFlag;
            bool bRet = true;

            string [ ] strsAutoAddFld = GetFlagFld ( dr.Table.TableName );

            n = 0;
            strWhere = "";
            foreach ( string strKey in strsAutoAddFld )
            {
                if ( n > 0 )
                    strWhere += " AND ";

                strText = dr [ strKey ].ToString ().Trim ();
                strText = strText.Replace ( "'" , strReplaceChar );

                t = dr [ strKey ].GetType ();

                if ( t == typeof ( System.Int32 ) )
                    str = String.Format ( "{0}={1}" , strKey , strText );
                else
                    str = String.Format ( "{0}='{1}'" , strKey , strText );

                strWhere += str;
                n++;
            }

            //create set( x=y ,) string
            n = 0;
            strSet = "";
            foreach ( DataColumn dc in dr.Table.Columns )
            {
                bEndFlag = false;
                strFld = dc.ColumnName;

                foreach ( string s in strsAutoAddFld )   //检查是否是自增量列， 要是，就不保存此列了。
                {
                    if ( s == strFld )
                        bEndFlag = true;
                }

                if ( bEndFlag )
                    continue;

                t = dr [ dc ].GetType ();

                if ( bEndFlag )
                    continue;

                strText = dr [ dc ].ToString ().Trim ();
                strText = strText.Replace ( "'" , strReplaceChar );

                if ( t == typeof ( System.String ) )
                    str = String.Format ( " {0}='{1}' " , strFld , strText );
                else if ( t == typeof ( System.Int32 ) )
                    str = String.Format ( " {0}={1} " , strFld , dr [ dc ] );
                else if ( t == typeof ( System.DateTime ) )
                    str = String.Format ( " {0}='{1}' " , strFld , strText );
                else if ( t == typeof ( System.Decimal ) )
                    str = String.Format ( " {0}={1} " , strFld , dr [ dc ] );
                else
                    continue;

                if ( n > 0 )
                    strSet += ", ";
                strSet += str;

                n++;
            }

            strSql = String.Format ( "UPDATE {0} SET {1} WHERE {2}" , strTable , strSet , strWhere );
            bRet &= Exec ( strSql );

            return bRet;
        }

        //Delete
        public bool DeleteRow ( ref DataRow dr , string [ ] strKeys )
        {
            if ( dr == null || strKeys == null || strKeys.Length <= 0 )
                return false;

            int n = 0;
            string strTable = dr.Table.TableName;
            string str = "" , strFld , strSet , strSql , strWhere , strText;
            Type t;
            bool bEndFlag;
            bool bRet = true;

            string [ ] strsAutoAddFld = GetFlagFld ( dr.Table.TableName );

            n = 0;
            strWhere = "";
            foreach ( string strKey in strKeys )
            {
                if ( n > 0 )
                    strWhere += " AND ";

                strText = dr [ strKey ].ToString ().Trim ();
                strText = strText.Replace ( "'" , strReplaceChar );

                str = String.Format ( "{0}='{1}'" , strKey , strText );
                strWhere += str;
                n++;
            }

            strSql = String.Format ( "delete from {0} WHERE {1}" , strTable , strWhere );
            bRet &= Exec ( strSql );

            return bRet;

        }

        //默认 dr 中已经有一个自增量字段。
        public bool DeleteRow ( ref DataRow dr )
        {
            if ( dr == null )
                return false;

            int n = 0;
            string strTable = dr.Table.TableName;
            string str = "" , strFld , strSet , strSql , strWhere , strText;
            Type t;
            bool bEndFlag;
            bool bRet = true;

            string [ ] strsAutoAddFld = GetFlagFld ( dr.Table.TableName );

            n = 0;
            strWhere = "";
            foreach ( string strKey in strsAutoAddFld )
            {
                if ( n > 0 )
                    strWhere += " AND ";

                strText = dr [ strKey ].ToString ().Trim ();
                strText = strText.Replace ( "'" , strReplaceChar );

                str = String.Format ( "{0}='{1}'" , strKey , strText );
                strWhere += str;
                n++;
            }

            strSql = String.Format ( "Delete from {0} WHERE {1}" , strTable , strWhere );
            bRet &= Exec ( strSql );

            return bRet;
        }

        #endregion

        #region Static

        static public bool IsValid ( ref DataSet ds )
        {
            if ( ds == null || ds.Tables.Count <= 0 )
                return false;

            if ( ds.Tables [ 0 ] == null || ds.Tables [ 0 ].Rows.Count <= 0 )
                return false;

            return true;
        }
        static public bool IsValid ( ref DataTable dt )
        {
            if ( dt == null || dt.Rows.Count <= 0 )
                return false;
            return true;
        }
        static public bool IsNotValid ( ref DataTable dt )
        {
            return !IsValid ( ref dt );
        }

        static public bool HaveVisibleRow ( DataTable dt )
        {
            DataRow [ ] drs = dt.Select ( "" , "" , DataViewRowState.CurrentRows );
            if ( drs == null || drs.Length <= 0 )
                return false;
            else
                return true;
        }
        static public int GetVisibleRowNum ( ref DataTable dt )
        {
            DataRow [ ] drs = dt.Select ( "" , "" , DataViewRowState.CurrentRows );
            if ( drs == null || drs.Length <= 0 )
                return 0;
            else
                return drs.Length;
        }

        static public string GetFld ( ref DataRow dr , string strFld )
        {
            if ( dr == null )
                return "";

            string strRet = "";
            try
            {
                strRet = dr [ strFld ].ToString ().Trim ();
            }
            catch ( Exception e )
            {
                FF.Ctrl.MsgBox.ShowWarn ( String.Format ( "Err in SQL.GetFld() !\n{0}" , e.Message ) );
            }

            return strRet;
        }

        static public bool SetFld ( ref DataRow dr , string strFld , string strText )
        {
            if ( dr == null )
                return false;

            try
            {
                dr [ strFld ] = strText.Trim ();
            }
            catch ( Exception e )
            {
                FF.Ctrl.MsgBox.ShowWarn ( String.Format ( "Err in SQL.SetFld() !\n{0}" , e.Message ) );
                return false;
            }

            return true;
        }

        #endregion

        //
        public DataTable GetNewTable ( ref DataTable table , string strSelect )
        {
            DataTable NewTable = table.Clone ();

            strSelect = GetSafeStr ( strSelect );
            DataRow [ ] drs = table.Select ( strSelect );

            foreach ( DataRow row in drs )
            {
                DataRow dr = NewTable.NewRow ();

                for ( int i = 0 ; i < NewTable.Columns.Count ; i++ )
                {
                    dr [ i ] = row [ i ];
                }
                NewTable.Rows.Add ( dr );
            }

            return NewTable;
        }

        public DataTable GetBlankDt ( string strTableName )
        {
            string strSql = String.Format ( "select * from {0} where 1<>1" , strTableName );

            DataTable dt = new DataTable ();
            dt = ExecDataTable ( strSql );

            if ( dt == null )
                return null;

            DataRow dr = dt.NewRow ();
            dt.Rows.Add ( dr );

            return dt;
        }

        public DataRow GetBlankDr ( string strTableName )
        {
            DataTable dt = GetBlankDt ( strTableName );

            if ( SQL.IsNotValid ( ref dt ) )
                return null;

            DataRow dr = dt.Rows [ 0 ];
            return dr;
        }

        static public DataRow AddNewRow ( ref DataTable dt )
        {
            DataRow dr = dt.NewRow ();
            dt.Rows.Add ( dr );
            return dr;
        }

        public void DataSetClear ( ref DataSet ds )
        {
            if ( ds.Tables.Count <= 0 )
                return;

            string [ ] strsFlagFld = GetFlagFld ( ds.Tables [ 0 ].TableName );

            DataTable dt = ds.Tables [ 0 ];

            foreach ( DataRow dr in dt.Rows )
            {
                foreach ( DataColumn dc in dt.Columns )
                {
                    bool bFlag = true;
                    foreach ( string s in strsFlagFld )
                    {
                        if ( s == dc.ColumnName )
                            bFlag = false;
                    }

                    if ( bFlag )
                        dr [ dc ] = "";
                }
            }
        }

        //这个函数是有问题的， 目前还没有判断 Acess中自增量字段的好办法。
        //get 所有自增量字段。
        public string [ ] GetFlagFld ( string strTabeName )
        {
            /*
            DataTable dt = new DataTable ();
            string strSql = String.Format ( "Select [name] From sysColumns Where id=object_id(N'{0}') and Status=128" , strTabeName );
            dt = ExecDataTable ( strSql );

            string [ ] strary = new string [ dt.Rows.Count ];
            int i = 0;
            foreach ( DataRow dr in dt.Rows )
            {
                strary [ i ] = dr [ 0 ].ToString ().Trim ();
                i++;
            }
             * */

            string strSql = String.Format ( "select * from {0}" , strTabeName );
            DataTable dt = new DataTable ();
            dt = ExecDataTable ( strSql );

            ArrayList ary = new ArrayList ();
            foreach ( DataColumn col in  dt.Columns )
            {
                if ( col.Caption == "编号" )                    //假设access中所有的自动编号字段 都叫“编号”。 临时解决办法。很有问题。
                {
                    ary.Add ( col.ColumnName );
                }
            }

            string [ ] strary = new string [ ary.Count ];
            int i = 0;
            foreach ( string str in ary )
                strary [ i++ ] = str;
            
            return strary;
        }

        //------------------------------------------------

        #region private

        static string GetSafeStr ( string str )
        {
            return str;

            /*
            string strRet = str.Replace ( "'" , "''" ) ;
            return strRet;
             */
        }

        #endregion
    }
}
