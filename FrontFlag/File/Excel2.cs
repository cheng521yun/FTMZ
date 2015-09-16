#region 使用方法

/* 
        可以指定Excel 文档和数据库表之间的映射关系。
        即：Excel的字段名称不必可数据库一致。 
  
         void ExcelIn()
        {
            DataTable dt = new DataTable();
            ORM.ReceiveList.GetBlankDt( ref dt );

            FrontFlag.EXCEL Excel = new EXCEL();

            Excel.strSqlConn = GLOBAL.Param.strSqlConnect;      //初始化设置，不要遗忘
            Excel.dtDB = dt;                                    //初始化设置，不要遗忘
            bool bRet = Excel.Convert();

            if ( ! bRet )
            {
                FF.Ctrl.MsgBox.Show( "Convet ERR !" );
                return;
            }

            //Save in DB
            dt = Excel.dtDB;

            //补充字段
            foreach ( DataRow dr in dt.Rows )
            {
                dr["CreateDate"] = DateTime.Now.ToString("yyyy-MM-dd");
                dr["Creator"] = GLOBAL.User.strName;
                dr["Status"] = "Active" ;
            }
            ORM.ReceiveList.Save( ref dt );

            FF.Ctrl.MsgBox.Show("Convet OK .");
        }

 */

#endregion

using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;
//using NLog;

namespace FrontFlag
{
    public class EXCEL2
    {
        //private static Logger logger = LogManager.GetCurrentClassLogger();

        List<EXCEL2FLD> _lstExcel2Fld = new List<EXCEL2FLD>();

        private string _strSqlConn = "";
        private string _strExcelConn = "";

        private string _strExcelFile = "";
        ArrayList _aryExcelFldName = new ArrayList();        //Excel文档里的字段名称。（实际上也是SQL Table里的字段名称）

        DataTable _dtExcel = new DataTable();       //Excel文档会当做数据库读入。    
        DataTable _dtDB = new DataTable();      //sql数据库的表，Excel的数据要读进到这个表，再由程序后续处理


        public EXCEL2()
        {
        }
        
        public EXCEL2( List<EXCEL2FLD> lst )
        {
            _lstExcel2Fld = lst;
        }

        public EXCEL2( string strExcelFile )
        {
            _strExcelFile = strExcelFile;

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="strExcelFile">要导入的Excel文件名称</param>
        /// <param name="lst">Excel字段和Datatable字段的映射列表</param>
        public EXCEL2( string strExcelFile, List<EXCEL2FLD> lst )
        {

            _strExcelFile = strExcelFile;
            _lstExcel2Fld = lst;
        }

        #region 属性

        //public List<EXCEL2FLD> lstExcel2Fld
        //{
        //    set { _lstExcel2Fld = value; }
        //}

        public string strSqlConn
        {
            set { _strSqlConn = value; }
        }

        public string ExcelFile
        {
            set { _strExcelFile = value; }
            get { return _strExcelFile; }
        }

        public DataTable dtDB
        {
            set { _dtDB = value; }
            get { return _dtDB; }
        }

        #endregion

        bool GetExcelFile()
        {
            if ( _strExcelFile == "" )
            {
                string strCurPath = Environment.CurrentDirectory;

                OpenFileDialog Dlg = new System.Windows.Forms.OpenFileDialog();

                Dlg.DefaultExt = ".xls";
                Dlg.Filter = "exe files (*.xls)|*.xls";
                Dlg.InitialDirectory = Application.StartupPath;

                DialogResult ret = Dlg.ShowDialog();

                Environment.CurrentDirectory = strCurPath;

                if ( ret != DialogResult.OK )
                    return false;

                _strExcelFile = Dlg.FileName;
            }

            return true;
        }

        private string GetSheetName()
        {
            string SheetName = "";

            try
            {
                OleDbConnection conn = new OleDbConnection( _strExcelConn );
                conn.Open();
                DataTable schemaTable = conn.GetOleDbSchemaTable( OleDbSchemaGuid.Tables, new object[] { null, null, null, "TABLE" } );
                conn.Close();

                DataRow dr = schemaTable.Rows[ 0 ];
                SheetName = dr[ "TABLE_NAME" ].ToString();
                SheetName = SheetName.Substring( 0, SheetName.Length - 1 );  //去掉最后的$符号

            }
            catch ( Exception ex )
            {
                MessageBox.Show( "请使用 Excel 97-2003 格式工作薄 !" );
                //MessageBox.Show(ex.ToString());
                return "";
            }

            return SheetName;
        }

        bool CheckMatchFld()
        {
            string strColName;
            foreach ( DataColumn dc in _dtExcel.Columns )
            {
                strColName = dc.ColumnName.ToString();
                _aryExcelFldName.Add( strColName );
            }

            bool bFlag;
            foreach ( string strExcelFldName in _aryExcelFldName )
            {
                bFlag = false;
                foreach ( DataColumn dc in _dtExcel.Columns )
                {
                    strColName = dc.ColumnName.ToString();
                    if ( strExcelFldName.ToLower() == strColName.ToLower() )
                        bFlag = true;
                }

                if ( bFlag == false )
                {
                    string strMsg = String.Format( "Excel文档中的 {0} 字段,在数据库中不存在！", strExcelFldName );
                    FF.Ctrl.MsgBox.ShowWarn( strMsg );
                    return false;
                }
            }

            return true;
        }

        public DataTable GetExcelData()
        {
            return GetExcelData( String.Empty );
        }

        public DataTable GetExcelData( string strExcelFile )
        {
            if (String.IsNullOrEmpty(strExcelFile.Trim()))
            {
                GetExcelFile();
                strExcelFile = _strExcelFile;
            }

            DataTable dt = new DataTable();

            //_strExcelConn = String.Format( "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + strExcelFile + ";Extended Properties='Excel 8.0; IMEX=1; '" );  //IMEX=1 使得 Excel 表格中混合列(即该列中的包含有多种类型的数据)被 ADO.NET 认为其数据类型是 String 。
            //IMEX=1 使得 Excel 表格中混合列(即该列中的包含有多种类型的数据)被 ADO.NET 认为其数据类型是 String 。
            _strExcelConn = String.Format( "Provider=Microsoft.Jet.OLEDB.4.0;Data Source='{0}';Extended Properties='Excel 8.0; IMEX=1;'", strExcelFile );

            string SheetName = GetSheetName();
            if ( String.IsNullOrEmpty( SheetName ) )
                return dt;

            try
            {
                //读取Excel表。
                string strSelect = String.Format( "SELECT * FROM [{0}$]", SheetName );
                OleDbDataAdapter ada = new OleDbDataAdapter( strSelect, _strExcelConn );
                ada.Fill( dt );

                if ( dt == null || dt.Rows.Count <= 0 )
                {
                    FF.Ctrl.MsgBox.ShowWarn( "没有需要转换的Excel数据！" );
                    return dt;
                }

                ////检查Excel要转换的字段是否有不存在的情况
                //if ( !CheckMatchFld() )
                //    return dt;

                //SQL Sql = new SQL( _strSqlConn );

                //if ( _dtDB == null || _dtDB.Rows == null )
                //{
                //    FF.Ctrl.MsgBox.ShowWarn( "无效的数据库表！（数据库表可能不存在）" );
                //    return false;
                //}

                //_dtDB.Rows.Clear();

                ////Excel表 => SQL表
                //foreach ( DataRow drExcel in _dtExcel.Rows )
                //{
                //    DataRow drDB = SQL.AddNewRow( ref _dtDB );
                //    foreach ( EXCEL2FLD obj in _lstExcel2Fld )
                //    {
                //        drDB[ obj.FldName ] = drExcel[ obj.ExcelName ];
                //    }
                //}

                //Sql.Close();
            }
            catch ( Exception ex )
            {
                MessageBox.Show( ex.ToString() );
                return dt;
            }

            return dt;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public bool Convert()
        {
            if ( _strSqlConn == "" )
            {
                FF.Ctrl.MsgBox.ShowWarn( "没有设置SQL连接字符串！" );
                return false;
            }

            //如果没有事先指定EXcel，就弹出文件对话框选择。
            if ( _strExcelFile == String.Empty )
            {
                if ( !GetExcelFile() )
                    return false;
            }

            _strExcelConn = String.Format( "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + _strExcelFile + ";Extended Properties='Excel 8.0; IMEX=1; '" );  //IMEX=1 使得 Excel 表格中混合列(即该列中的包含有多种类型的数据)被 ADO.NET 认为其数据类型是 String 。

            string SheetName = GetSheetName();

            if ( SheetName == "" )
                return false;

            try
            {
                //读取Excel表。
                string strSelect = String.Format( "SELECT * FROM [{0}$]", SheetName );
                OleDbDataAdapter ada = new OleDbDataAdapter( strSelect, _strExcelConn );
                ada.Fill( _dtExcel );

                if ( _dtExcel == null || _dtExcel.Rows.Count <= 0 )
                {
                    FF.Ctrl.MsgBox.ShowWarn( "没有需要转换的Excel数据！" );
                    return false;
                }

                //检查Excel要转换的字段是否有不存在的情况
                if ( !CheckMatchFld() )
                    return false;

                SQL Sql = new SQL( _strSqlConn );

                if ( _dtDB == null || _dtDB.Rows == null )
                {
                    FF.Ctrl.MsgBox.ShowWarn( "无效的数据库表！（数据库表可能不存在）" );
                    return false;
                }

                _dtDB.Rows.Clear();

                //Excel表 => SQL表
                foreach ( DataRow drExcel in _dtExcel.Rows )
                {
                    DataRow drDB = SQL.AddNewRow( ref _dtDB );
                    foreach ( EXCEL2FLD obj in _lstExcel2Fld )
                    {
                        drDB[ obj.FldName ] = drExcel[ obj.ExcelName ];
                    }
                }

                Sql.Close();
            }
            catch ( Exception ex )
            {
                MessageBox.Show( ex.ToString() );
                return false;
            }

            return true;
        }
    }

    /// <summary>
    /// 用于指定Excel表字段和数据库表字段之间的对应关系。
    /// </summary>
    public class EXCEL2FLD
    {
        public EXCEL2FLD( string e, string f )
        {
            ExcelName = e;      //Excel表列头名称
            FldName = f;        //数据库字段
        }

        public string ExcelName = "";
        public string FldName = "";
    }
}
