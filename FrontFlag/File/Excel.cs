#region 使用方法

/* 
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


namespace FrontFlag
{
    public class EXCEL
    {
        private string _strSqlConn = "";
        private string _strExcelConn = "";

        private string _strExcelFile = "";
        ArrayList _aryExcelFldName = new ArrayList();        //Excel文档里的字段名称。（实际上也是SQL Table里的字段名称）

        DataTable _dtExcel = new DataTable();       //Excel文档会当做数据库读入。    
        DataTable _dtDB = new DataTable();      //sql数据库的表，Excel的数据要读进到这个表，再由程序后续处理

        public EXCEL()
        {
        }

        public EXCEL( string strExcelFile )
        {
            _strExcelFile = strExcelFile;
        }

        #region 属性

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

        bool GetExcelFile ()
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

                if (ret != DialogResult.OK)
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
                OleDbConnection conn = new OleDbConnection(_strExcelConn);
                conn.Open();
                DataTable schemaTable = conn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, new object[] { null, null, null, "TABLE" });
                conn.Close();

                DataRow dr = schemaTable.Rows[0];
                SheetName = dr["TABLE_NAME"].ToString();
                SheetName = SheetName.Substring(0, SheetName.Length - 1);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return "";
            }

            return SheetName;
        }

        bool CheckMatchFld ()
        {
            string strColName;
            foreach ( DataColumn dc in _dtExcel.Columns )
            {
                strColName = dc.ColumnName.ToString();
                _aryExcelFldName.Add(strColName);
            }

            bool bFlag;
            foreach (string strExcelFldName in _aryExcelFldName)
            {
                bFlag = false;
                foreach ( DataColumn dc in _dtExcel.Columns )
                {
                    strColName = dc.ColumnName.ToString();
                    if ( strExcelFldName.ToLower() == strColName.ToLower() )
                        bFlag = true;
                }

                if (bFlag == false)
                {
                    string strMsg = String.Format("Excel文档中的 {0} 字段,在数据库中不存在！", strExcelFldName);
                    FF.Ctrl.MsgBox.ShowWarn( strMsg );
                    return false;
                }
            }

            return true;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public bool Convert()
        {
            if (_strSqlConn == "")
            {
                FF.Ctrl.MsgBox.ShowWarn( "没有设置SQL连接字符串！" );
                return false;
            }

            //如果没有事先指定EXcel，就弹出文件对话框选择。
            if ( _strExcelFile == String.Empty )
            {
                if ( ! GetExcelFile() )
                    return false;
            }

            _strExcelConn = String.Format("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + _strExcelFile + ";Extended Properties='Excel 8.0; IMEX=1; '");  //IMEX=1 使得 Excel 表格中混合列(即该列中的包含有多种类型的数据)被 ADO.NET 认为其数据类型是 String 。

            string SheetName = GetSheetName();
            if (SheetName == "")
                return false;

            try
            {
                //读取Excel表。
                string strSelect = String.Format("SELECT * FROM [{0}$]", SheetName);
                OleDbDataAdapter ada = new OleDbDataAdapter(strSelect, _strExcelConn);
                ada.Fill(_dtExcel);

                //检查Excel要转换的字段是否有不存在的情况
                if (!CheckMatchFld())
                    return false;

                SQL Sql = new SQL(_strSqlConn);
                _dtDB.Rows.Clear();

                //Excel表 => SQL表
                foreach (DataRow drExcel in _dtExcel.Rows)
                {
                    DataRow drDB = SQL.AddNewRow(ref _dtDB);
                    foreach (string strFldName in _aryExcelFldName)
                    {
                        drDB[strFldName] = drExcel[strFldName];
                    }
                }

                Sql.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return false;
            }

            return true;
        }
    }
}
