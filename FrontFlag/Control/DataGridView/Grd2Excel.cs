using System;
using System.Collections.Generic;
using System.Collections;
using System.Data.OleDb;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using Excel=Microsoft.Office.Interop.Excel;  
using System.Reflection;
using System.Data;

namespace FrontFlag.Control
{
    public class GRID2EXCEL
    {
        Excel.Application objExcel = null;
        Excel.Workbook objWorkbook = null;
        Excel.Worksheet objSheet = null;

        void OpenExcel()
        {
            objExcel = new Microsoft.Office.Interop.Excel.Application();
            objWorkbook = objExcel.Workbooks.Add(Missing.Value);
            objSheet = (Excel.Worksheet)objWorkbook.ActiveSheet;

            //设置EXCEL不可见   
            objExcel.Visible = false;
        }

        void CloseExcel()
        {
            if (objWorkbook != null)
                objWorkbook.Close(Missing.Value, Missing.Value, Missing.Value);

            if (objExcel.Workbooks != null)
                objExcel.Workbooks.Close();

            if (objExcel != null)
                objExcel.Quit();

            objSheet = null;
            objWorkbook = null;
            objExcel = null;
        }

        public void Close()
        {
            CloseExcel();
        }

        #region 私有成员

        private string GetColumnName(int number)
        {
            int h, l;
            h = number / 26;
            l = number % 26;
            if (l == 0)
            {
                h -= 1;
                l = 26;
            }
            string s = GetLetter(h) + GetLetter(l);
            return s;
        }

        private string GetLetter(int number)
        {
            switch (number)
            {
                case 1:
                    return "A";
                case 2:
                    return "B";
                case 3:
                    return "C";
                case 4:
                    return "D";
                case 5:
                    return "E";
                case 6:
                    return "F";
                case 7:
                    return "G";
                case 8:
                    return "H";
                case 9:
                    return "I";
                case 10:
                    return "J";
                case 11:
                    return "K";
                case 12:
                    return "L";
                case 13:
                    return "M";
                case 14:
                    return "N";
                case 15:
                    return "O";
                case 16:
                    return "P";
                case 17:
                    return "Q";
                case 18:
                    return "R";
                case 19:
                    return "S";
                case 20:
                    return "T";
                case 21:
                    return "U";
                case 22:
                    return "V";
                case 23:
                    return "W";
                case 24:
                    return "X";
                case 25:
                    return "Y";
                case 26:
                    return "Z";
                default:
                    return "";
            }
        }

        #endregion

        #region 设置格式

        /// <summary>
        /// 自动调整列宽
        /// </summary>
        /// <param name="columnNum">列号</param>
        public void ColumnAutoFit( int columnNum )
        {
            string strcolumnNum = GetColumnName(columnNum);
            //获取当前正在使用的工作表
            Excel.Worksheet worksheet = (Excel.Worksheet)objExcel.ActiveSheet;
            Excel.Range range = (Excel.Range)worksheet.Columns[strcolumnNum + ":" + strcolumnNum, System.Type.Missing];
            range.EntireColumn.AutoFit();
        }

        public void AllColumnAutoFit(int nColumnCount)
        {
            for (int i = 0; i < nColumnCount; i++)
            {
                ColumnAutoFit(i);
            }
        }

        #endregion

        #region 导入Excel

        //public DataSet GetDtFromExcel( string fileName )
        //{
        //    string connStr = "";
        //    string fileType = System.IO.Path.GetExtension( fileName );
        //    if ( string.IsNullOrEmpty( fileType ) ) return null;

        //    if ( fileType == ".xls" )
        //        connStr = "Provider=Microsoft.Jet.OLEDB.4.0;" + "Data Source=" + fileName + ";" + ";Extended Properties=\"Excel 8.0;HDR=YES;IMEX=1\"";
        //    else
        //        connStr = "Provider=Microsoft.ACE.OLEDB.12.0;" + "Data Source=" + fileName + ";" + ";Extended Properties=\"Excel 12.0;HDR=YES;IMEX=1\"";
        //    string sql_F = "Select * FROM [{0}]";

        //    OleDbConnection conn = null;
        //    OleDbDataAdapter da = null;
        //    DataTable dtSheetName = null;

        //    DataSet ds = new DataSet();
        //    try
        //    {
        //        // 初始化连接，并打开  
        //        conn = new OleDbConnection( connStr );
        //        conn.Open();

        //        // 获取数据源的表定义元数据                         
        //        string SheetName = "";
        //        dtSheetName = conn.GetOleDbSchemaTable( OleDbSchemaGuid.Tables, new object[] { null, null, null, "TABLE" } );

        //        // 初始化适配器  
        //        da = new OleDbDataAdapter();
        //        for ( int i = 0 ; i < dtSheetName.Rows.Count ; i++ )
        //        {
        //            SheetName = (string)dtSheetName.Rows[ i ][ "TABLE_NAME" ];

        //            if ( SheetName.Contains( "$" ) && !SheetName.Replace( "'", "" ).EndsWith( "$" ) )
        //            {
        //                continue;
        //            }

        //            da.SelectCommand = new OleDbCommand( String.Format( sql_F, SheetName ), conn );
        //            DataSet dsItem = new DataSet();
        //            da.Fill( dsItem, "tblName" );  //todo

        //            ds.Tables.Add( dsItem.Tables[ 0 ].Copy() );
        //        }
        //    }
        //    catch ( Exception ex )
        //    {
        //        string strMsg = ex.Message;
        //        FF.Ctrl.MsgBox.ShowWarn(strMsg);
        //    }
        //    finally
        //    {
        //        // 关闭连接  
        //        if ( conn.State == ConnectionState.Open )
        //        {
        //            conn.Close();
        //            da.Dispose();
        //            conn.Dispose();
        //        }
        //    }
        //    return ds;  
        //}


        #endregion

        #region 导出Excel

        /// <summary>
        /// 方法，导出DataGridView中的数据到Excel文件   
        /// </summary>
        /// <remarks>  
        /// add com "Microsoft Excel 11.0 Object Library"  
        /// using Excel=Microsoft.Office.Interop.Excel;  
        /// using System.Reflection;  
        /// </remarks>  
        /// <param name="dgv">DataGridView</param>
        /// <param name="strOutFileName">设定导出的文件名称</param>
        /// <param name="strsHeadName">导出的列的的HeadName, 如果为null,则导出全部列</param>
        /// <returns></returns>
        public bool SaveToExcel ( System.Windows.Forms.DataGridView dgv, string strOutFileName, string [] strsHeadName, int [] nsLineNo )
        {
            #region   验证可操作性

            //申明保存对话框   
            SaveFileDialog dlg = new SaveFileDialog ();
            //默然文件后缀   
            dlg.FileName = strOutFileName;
            dlg.DefaultExt = "xls ";
            //文件后缀列表   
            dlg.Filter = "EXCEL文件(*.XLS)|*.xls ";
            //默然路径是系统当前路径   
            dlg.InitialDirectory = Directory.GetCurrentDirectory ();
            //打开保存对话框   
            if ( dlg.ShowDialog () == DialogResult.Cancel ) 
                return false ;

            //返回文件路径   
            string fileNameString = dlg.FileName;
            //验证strFileName是否为空或值无效   
            if ( fileNameString.Trim () == " " )
                return false; 

            //定义表格内数据的行数和列数   
            int rowscount = dgv.Rows.Count;
            int colscount = dgv.Columns.Count;
            //行数必须大于0   
            if ( rowscount <= 0 )
            {
                MessageBox.Show ( "没有数据可供保存 " , "提示 " , MessageBoxButtons.OK , MessageBoxIcon.Information );
                return false ;
            }

            //列数必须大于0   
            if ( colscount <= 0 )
            {
                MessageBox.Show ( "没有数据可供保存 " , "提示 " , MessageBoxButtons.OK , MessageBoxIcon.Information );
                return false;
            }

            //行数不可以大于65536   
            if ( rowscount > 65536 )
            {
                MessageBox.Show ( "数据记录数太多(最多不能超过65536条)，不能保存 " , "提示 " , MessageBoxButtons.OK , MessageBoxIcon.Information );
                return false;
            }

            //列数不可以大于255   
            if ( colscount > 255 )
            {
                MessageBox.Show ( "数据记录行数太多，不能保存 " , "提示 " , MessageBoxButtons.OK , MessageBoxIcon.Information );
                return false;
            }

            //验证以fileNameString命名的文件是否存在，如果存在删除它   
            FileInfo file = new FileInfo ( fileNameString );
            if ( file.Exists )
            {
                try
                {
                    file.Delete ();
                }
                catch ( Exception error )
                {
                    MessageBox.Show ( error.Message , "删除失败 " , MessageBoxButtons.OK , MessageBoxIcon.Warning );
                    return false;
                }
            }

            #endregion

            #region 
            
            //取得要导出的列的HeadName.
            //如果没有指定特定的列，则默认转换 可见的 并且 有HeadName 的列。（控件列不用导出，控件列一般没有HeadName）
            if ( strsHeadName == null )
            {
                int n = 0;
                for ( int i = 0 ; i <= dgv.ColumnCount - 1 ; i++ )
                {
                    if ( dgv.Columns [ i ].Visible == true && dgv.Columns [ i ].HeaderText.Trim () != "" )
                        n ++;
                }

                strsHeadName = new string [ n ] ;

                n = 0 ;
                for ( int i = 0 ; i <= dgv.ColumnCount - 1 ; i++ )
                {
                    if ( dgv.Columns [ i ].Visible == true && dgv.Columns [ i ].HeaderText.Trim () != "" )
                        strsHeadName [ n ++ ] = dgv.Columns [ i ].HeaderText.Trim () ;
                }
            }

            //取得所有要执行的行，（可能用户并不是要导出所有行，而是通过checkbox选择要导出的行）
            //如果没有指定特定的行，则默认转出全部的行
            if ( nsLineNo == null )
            {
                nsLineNo = new int [ dgv.RowCount ] ;
                for ( int row = 0 ; row <= dgv.RowCount - 1 ; row ++ )
                {
                    nsLineNo [ row ] = row;
                }
            }

            #endregion
           
            Excel.Application objExcel = null;
            Excel.Workbook objWorkbook = null;
            Excel.Worksheet objsheet = null;
            try
            {
                //申明对象   
                objExcel = new Microsoft.Office.Interop.Excel.Application ();
                objWorkbook = objExcel.Workbooks.Add ( Missing.Value );
                objsheet = (Excel.Worksheet) objWorkbook.ActiveSheet;
                //设置EXCEL不可见   
                objExcel.Visible = false;

                //向Excel中写入表格的表头   
                Excel.Range rag = objsheet.get_Range ( objsheet.Cells [1 , 1] , objsheet.Cells [1 , strsHeadName.Length] );
                rag.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;    

                int displayColumnsCount = 1;
                foreach ( string strHeadName in strsHeadName )
                {
                    objExcel.Cells [ 1 , displayColumnsCount ] = strHeadName  ;
                    displayColumnsCount++;
                }

                //设置Excel列格式
                //if ( aryColFormat.Count != 0 )
                {
                    int nRow1 = 2 , nRow2 = nRow1 + nsLineNo.Length;
                    int nColSel = 1;
                    //foreach ( string strFormat in aryColFormat )
                    foreach ( DataGridViewColumn column in dgv.Columns )
                    {

                        rag = objsheet.get_Range ( objsheet.Cells [nRow1 , nColSel] , objsheet.Cells [nRow1 , nColSel] );

                        switch ( column.HeaderCell.FormattedValueType.ToString() )
                        {
                            case "System.String": 
                                rag.NumberFormatLocal = "@";
                            break;

                            case "System.DateTime": 
                                rag.NumberFormatLocal = "yyyy-MM-dd HH:mm";
                            break;

                            default:
                                //rag.NumberFormatLocal = "G/通用格式";
                            break;
                        }

                        nColSel++;
                    }
                }
                //

                //向Excel中逐行逐列写入表格中的数据   
                int nCol , row ;
                int nExcelCol , nExcelRow = 2; //Execl的行列都从1开始起算。第一行是列名，数据从第二行开始写入。
                
                for ( int i = 0 ; i <= nsLineNo.Length - 1 ; i++ )
                {
                    //tempProgressBar.PerformStep();   

                    row = nsLineNo [ i ] ;
                    nExcelCol = 1;              //Execl的行列都从1开始起算。第一行是列名，数据从第二行开始写入。

                    foreach ( string strHeadName in strsHeadName )
                    {
                        try
                        {
                            //if ( aryTextCol.Contains ( strHeadName ) )
                            //    objExcel.Cells [ nExcelRow , nExcelCol ].NumberFormatLocal   =   "@" ;

                            nCol = dgv.Columns [ strHeadName ].Index;
                            objExcel.Cells [ nExcelRow , nExcelCol ++ ] = dgv.Rows [ row ].Cells [ nCol ].Value.ToString ().Trim ();
                        }
                        catch ( Exception )
                        {
                        }
                    }

                    nExcelRow++;
                }

                //隐藏进度条   
                //tempProgressBar.Visible   =   false;   
                //保存文件   
                objWorkbook.SaveAs ( fileNameString , Missing.Value , Missing.Value , Missing.Value , Missing.Value ,
                        Missing.Value , Excel.XlSaveAsAccessMode.xlShared , Missing.Value , Missing.Value , Missing.Value ,
                        Missing.Value , Missing.Value );
            }
            catch ( Exception error )
            {
                MessageBox.Show ( error.Message , "警告 " , MessageBoxButtons.OK , MessageBoxIcon.Warning );
                return false;
            }
            finally
            {
                //关闭Excel应用   
                if ( objWorkbook != null ) objWorkbook.Close ( Missing.Value , Missing.Value , Missing.Value );
                if ( objExcel.Workbooks != null ) objExcel.Workbooks.Close ();
                if ( objExcel != null ) objExcel.Quit ();

                objsheet = null;
                objWorkbook = null;
                objExcel = null;
            }
            MessageBox.Show ( fileNameString + "\n\n导出完毕! " , "提示 " , MessageBoxButtons.OK , MessageBoxIcon.Information );

            return true;
        }

        public bool SaveToExcel ( System.Windows.Forms.DataGridView dgv, string strOutFileName )
        {
            return SaveToExcel ( dgv , strOutFileName , null , null );
        }

        public bool SaveToExcel ( System.Windows.Forms.DataGridView dgv, string [] strsHeadName, int [] nsLine )
        {
            return SaveToExcel ( dgv , "" , strsHeadName , nsLine );
        }

        public bool SaveToExcel ( System.Windows.Forms.DataGridView dgv, string [] strsHeadName )
        {
            return SaveToExcel ( dgv , "" , strsHeadName , null );
        }

        public bool SaveToExcel ( System.Windows.Forms.DataGridView dgv, int [] nsLine )
        {
            return SaveToExcel ( dgv , "" , null , nsLine );
        }

        public bool SaveToExcel ( System.Windows.Forms.DataGridView dgv )
        {
            return SaveToExcel ( dgv , "" , null , null );
        }

        /// <summary>
        /// 方法，导出DataTable中的数据到Excel文件   
        /// </summary>
        /// <remarks>  
        /// add com "Microsoft Excel 11.0 Object Library"  
        /// using Excel=Microsoft.Office.Interop.Excel;  
        /// using System.Reflection;  
        /// </remarks>  
        /// <param name="dt">DataTable</param>
        /// <param name="strOutFileName">设定导出的文件名称</param>
        /// <param name="strsHeadName">导出的列的的HeadName, 如果为null,则导出全部列</param>
        /// <returns></returns>
        public static bool SaveDtToExcel ( DataTable dt , string strOutFileName , string [] strsHeadName , string [] strsFldName, string strDecimalFormat="" )
        {
            int [] nsLineNo = null;

            if ( dt.Rows.Count <= 0 )
            {
                MessageBox.Show ( "没有可以导出的数据！" , "提示 " , MessageBoxButtons.OK , MessageBoxIcon.Information );
                return false;
            }

            #region   验证可操作性

            //申明保存对话框   
            SaveFileDialog dlg = new SaveFileDialog ();
            //默然文件后缀   
            dlg.FileName = strOutFileName;
            dlg.DefaultExt = "xls ";
            //文件后缀列表   
            dlg.Filter = "EXCEL文件(*.XLS)|*.xls ";
            //默然路径是系统当前路径   
            dlg.InitialDirectory = Directory.GetCurrentDirectory ();
            //打开保存对话框   
            if ( dlg.ShowDialog () == DialogResult.Cancel )
                return false;

            //返回文件路径   
            string fileNameString = dlg.FileName;
            //验证strFileName是否为空或值无效   
            if ( fileNameString.Trim () == " " )
                return false;

            //定义表格内数据的行数和列数   
            int rowscount = dt.Rows.Count;
            int colscount = dt.Columns.Count;
            //行数必须大于0   
            if ( rowscount <= 0 )
            {
                MessageBox.Show ( "没有数据可供保存 " , "提示 " , MessageBoxButtons.OK , MessageBoxIcon.Information );
                return false;
            }

            //列数必须大于0   
            if ( colscount <= 0 )
            {
                MessageBox.Show ( "没有数据可供保存 " , "提示 " , MessageBoxButtons.OK , MessageBoxIcon.Information );
                return false;
            }

            //行数不可以大于65536   
            if ( rowscount > 65536 )
            {
                MessageBox.Show ( "数据记录数太多(最多不能超过65536条)，不能保存 " , "提示 " , MessageBoxButtons.OK , MessageBoxIcon.Information );
                return false;
            }

            //列数不可以大于255   
            if ( colscount > 255 )
            {
                MessageBox.Show ( "数据记录行数太多，不能保存 " , "提示 " , MessageBoxButtons.OK , MessageBoxIcon.Information );
                return false;
            }

            //验证以fileNameString命名的文件是否存在，如果存在删除它   
            FileInfo file = new FileInfo ( fileNameString );
            if ( file.Exists )
            {
                try
                {
                    file.Delete ();
                }
                catch ( Exception error )
                {
                    MessageBox.Show ( error.Message , "删除失败 " , MessageBoxButtons.OK , MessageBoxIcon.Warning );
                    return false;
                }
            }

            #endregion

            #region

            //取得要导出的列的HeadName.
            //如果没有指定特定的列，则默认转换 可见的 并且 有HeadName 的列。（控件列不用导出，控件列一般没有HeadName）
            if ( strsHeadName == null )
            {
                MessageBox.Show ( "没有指定字段名称！" , "提示 " , MessageBoxButtons.OK , MessageBoxIcon.Information );
                return false;
            }

            //取得所有要执行的行，（可能用户并不是要导出所有行，而是通过checkbox选择要导出的行）
            //如果没有指定特定的行，则默认转出全部的行
            if ( nsLineNo == null )
            {
                nsLineNo = new int [dt.Rows.Count];
                for ( int row = 0 ; row <= dt.Rows.Count - 1 ; row++ )
                {
                    nsLineNo [row] = row;
                }
            }

            #endregion

            Excel.Application objExcel = null;
            Excel.Workbook objWorkbook = null;
            Excel.Worksheet objsheet = null;
            try
            {
                //申明对象   
                objExcel = new Microsoft.Office.Interop.Excel.Application ();
                objWorkbook = objExcel.Workbooks.Add ( Missing.Value );
                objsheet = (Excel.Worksheet) objWorkbook.ActiveSheet;
                //设置EXCEL不可见   
                objExcel.Visible = false;

                //向Excel中写入表格的表头   
                Excel.Range rag = objsheet.get_Range ( objsheet.Cells [1 , 1] , objsheet.Cells [1 , strsHeadName.Length] );
                rag.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;    

                int displayColumnsCount = 1;
                foreach ( string strHeadName in strsHeadName )
                {
                    objExcel.Cells [1 , displayColumnsCount] = strHeadName;
                    displayColumnsCount++;
                }

                //设置进度条   
                //tempProgressBar.Refresh();   
                //tempProgressBar.Visible   =   true;   
                //tempProgressBar.Minimum=1;   
                //tempProgressBar.Maximum=dgv.RowCount;   
                //tempProgressBar.Step=1;   

                int nRow1 = 2 , nRow2 = nRow1 + nsLineNo.Length;
                int nColSel = 1;
                DataColumn col ;
                foreach ( string strFldName in strsFldName )
                {
                    rag = objsheet.get_Range ( objsheet.Cells [nRow1 , nColSel] , objsheet.Cells [nRow2 , nColSel] );

                    col = dt.Columns[strFldName];
                    if (col == null)
                    {
                        string strErr = String.Format("数据库表列名称'{0}'不存在!",strFldName);
                        FF.Ctrl.MsgBox.ShowWarn(strErr);
                        return false ;
                    }

                    switch ( col.DataType.ToString () )
                    {
                        case "System.String": 
                            rag.NumberFormatLocal = "@";
                        break;
                        
                        case "System.DateTime": 
                            rag.NumberFormatLocal = "yyyy-MM-dd HH:mm" ;
                        break;

                        case "System.Decimal":
                            rag.NumberFormatLocal = String.IsNullOrEmpty( strDecimalFormat ) ? "0.00" : strDecimalFormat ;   //默认是"0.00";
                            rag.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignRight;
                        break;
                        

                        //可以根据自己的需要扩展。
                        
                        default:
                            //rag.NumberFormatLocal = "G/通用格式";
                        break;
                    }

                    nColSel ++;
               }

                //向Excel中逐行逐列写入表格中的数据   
                int nCol , row;
                int nExcelCol , nExcelRow = 2; //Execl的行列都从1开始起算。第一行是列名，数据从第二行开始写入。

                for ( int i = 0 ; i <= nsLineNo.Length - 1 ; i++ )
                {
                    //tempProgressBar.PerformStep();   

                    row = nsLineNo [i];
                    nExcelCol = 1;              //Execl的行列都从1开始起算。第一行是列名，数据从第二行开始写入。

                    foreach ( string strFldName in strsFldName )
                    {
                        try
                        {
                            //nCol = dgv.Columns [strHeadName].Index;
                            //objExcel.Cells [nExcelRow , nExcelCol++] = dgv.Rows [row].Cells [nCol].Value.ToString ().Trim ();
                            objExcel.Cells [nExcelRow , nExcelCol++] = dt.Rows [row] [strFldName].ToString ().Trim ();
                        }
                        catch ( Exception )
                        {
                            return false ;
                        }
                    }

                    nExcelRow++;
                }

                //隐藏进度条   
                //tempProgressBar.Visible   =   false;   
                //保存文件   
                objWorkbook.SaveAs ( fileNameString , Missing.Value , Missing.Value , Missing.Value , Missing.Value ,
                        Missing.Value , Excel.XlSaveAsAccessMode.xlShared , Missing.Value , Missing.Value , Missing.Value ,
                        Missing.Value , Missing.Value );
            }
            catch ( Exception error )
            {
                MessageBox.Show ( error.Message , "警告 " , MessageBoxButtons.OK , MessageBoxIcon.Warning );
                return false;
            }
            finally
            {
                //关闭Excel应用   
                if ( objWorkbook != null ) objWorkbook.Close ( Missing.Value , Missing.Value , Missing.Value );
                if ( objExcel.Workbooks != null ) objExcel.Workbooks.Close ();
                if ( objExcel != null ) objExcel.Quit ();

                objsheet = null;
                objWorkbook = null;
                objExcel = null;
            }
            MessageBox.Show ( fileNameString + "\n\n导出完毕! " , "提示 " , MessageBoxButtons.OK , MessageBoxIcon.Information );

            return true;
        }

        /// <summary>
        /// 方法，导出DataTable中的数据到Excel文件 , 多个不同的数据结构显示在一个Excel页面中。  
        /// </summary>
        /// <remarks>  
        /// add com "Microsoft Excel 11.0 Object Library"  
        /// using Excel=Microsoft.Office.Interop.Excel;  
        /// using System.Reflection;  
        /// </remarks>  
        /// <param name="dgv">DataTable</param>
        /// <param name="strOutFileName">设定导出的文件名称</param>
        /// <param name="strsHeadName">导出的列的的HeadName, 如果为null,则导出全部列</param>
        /// <returns></returns>
        public static bool SaveDtToExcel(ArrayList aryParam)
        {
            if (aryParam == null || aryParam.Count == 0)
                return false;

            Excel.Application objExcel = null;
            Excel.Workbook objWorkbook = null;
            Excel.Worksheet objsheet = null;

            string fileNameString = "";     //Excel的文件名称。

            int n = 0;          //标明当前是第几个数据结构。 
            int nLine = 1;      //每个数据结构的开始的行数
            int nJG = 5;        //每个数据结构之间 间隔的行数

            foreach (EXCELPARAMEX param in aryParam)
            {
                DataTable dt = param.dt;
                string strOutFileName = param.strOutFile;
                string[] strsHeadName = param.strsHeadName;
                string[] strsFldName = param.strsFldName;

                int[] nsLineNo = null;

                if (dt.Rows.Count <= 0)
                {
                    MessageBox.Show("没有可以导出的数据！", "提示 ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }

                //处理第一个数据结构。 选择文件名称。
                if (n == 0)
                {

                    #region   验证可操作性

                    //申明保存对话框   
                    SaveFileDialog dlg = new SaveFileDialog();
                    //默然文件后缀   
                    dlg.FileName = strOutFileName;
                    dlg.DefaultExt = "xls ";
                    //文件后缀列表   
                    dlg.Filter = "EXCEL文件(*.XLS)|*.xls ";
                    //默然路径是系统当前路径   
                    dlg.InitialDirectory = Directory.GetCurrentDirectory();
                    //打开保存对话框   
                    if (dlg.ShowDialog() == DialogResult.Cancel)
                        return false;

                    //返回文件路径   
                    fileNameString = dlg.FileName;
                    //验证strFileName是否为空或值无效   
                    if (fileNameString.Trim() == " ")
                        return false;

                    //验证以fileNameString命名的文件是否存在，如果存在删除它   
                    FileInfo file = new FileInfo(fileNameString);
                    if (file.Exists)
                    {
                        try
                        {
                            file.Delete();
                        }
                        catch (Exception error)
                        {
                            MessageBox.Show(error.Message, "删除失败 ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return false;
                        }
                    }

                    //申明对象   
                    objExcel = new Microsoft.Office.Interop.Excel.Application();
                    objWorkbook = objExcel.Workbooks.Add(Missing.Value);
                    objsheet = (Excel.Worksheet)objWorkbook.ActiveSheet;
                    //设置EXCEL不可见   
                    objExcel.Visible = false;

                }


                //定义表格内数据的行数和列数   
                int rowscount = dt.Rows.Count;
                int colscount = dt.Columns.Count;
                //行数必须大于0   
                if (rowscount <= 0)
                {
                    MessageBox.Show("没有数据可供保存 ", "提示 ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }

                //列数必须大于0   
                if (colscount <= 0)
                {
                    MessageBox.Show("没有数据可供保存 ", "提示 ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }

                //行数不可以大于65536   
                if (rowscount > 65536)
                {
                    MessageBox.Show("数据记录数太多(最多不能超过65536条)，不能保存 ", "提示 ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }

                //列数不可以大于255   
                if (colscount > 255)
                {
                    MessageBox.Show("数据记录行数太多，不能保存 ", "提示 ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }


                    #endregion

                #region

                //取得要导出的列的HeadName.
                //如果没有指定特定的列，则默认转换 可见的 并且 有HeadName 的列。（控件列不用导出，控件列一般没有HeadName）
                if (strsHeadName == null)
                {
                    MessageBox.Show("没有指定字段名称！", "提示 ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }

                //取得所有要执行的行，（可能用户并不是要导出所有行，而是通过checkbox选择要导出的行）
                //如果没有指定特定的行，则默认转出全部的行
                if (nsLineNo == null)
                {
                    nsLineNo = new int[dt.Rows.Count];
                    for (int row = 0; row <= dt.Rows.Count - 1; row++)
                    {
                        nsLineNo[row] = row;
                    }
                }

                #endregion


                try
                {


                    //向Excel中写入表格的表头   
                    Excel.Range rag = objsheet.get_Range(objsheet.Cells[nLine, 1], objsheet.Cells[nLine, strsHeadName.Length]);
                    rag.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;

                    int displayColumnsCount = 1;
                    foreach (string strHeadName in strsHeadName)
                    {
                        objExcel.Cells[nLine, displayColumnsCount] = strHeadName;
                        displayColumnsCount++;
                    }

                    //定义每列的数据格式。
                    int nRow1 = nLine + 1, nRow2 = nRow1 + nsLineNo.Length;
                    int nColSel = 1;
                    foreach (string strFldName in strsFldName)
                    {
                        rag = objsheet.get_Range(objsheet.Cells[nRow1, nColSel], objsheet.Cells[nRow2, nColSel]);

                        switch (dt.Columns[strFldName].DataType.ToString())
                        {
                            case "System.String":
                                rag.NumberFormatLocal = "@";
                                break;

                            case "System.DateTime":
                                rag.NumberFormatLocal = "yyyy-MM-dd HH:mm";
                                break;

                            //可以根据自己的需要扩展。

                            default:
                                //rag.NumberFormatLocal = "G/通用格式";
                                break;
                        }

                        nColSel++;
                    }

                    //向Excel中逐行逐列写入表格中的数据   
                    int nCol, row;
                    int nExcelCol, nExcelRow = nLine + 1; //Execl的行列都从1开始起算。第一行是列名，数据从第二行开始写入。

                    for (int i = 0; i <= nsLineNo.Length - 1; i++)
                    {
                        row = nsLineNo[i];
                        nExcelCol = 1;              //Execl的行列都从1开始起算。第一行是列名，数据从第二行开始写入。

                        foreach (string strFldName in strsFldName)
                        {
                            try
                            {
                                objExcel.Cells[nExcelRow, nExcelCol++] = dt.Rows[row][strFldName].ToString().Trim();
                            }
                            catch (Exception)
                            {
                            }
                        }

                        nExcelRow++;
                    }

                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message, "警告 ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                //
                n++;
                nLine += nsLineNo.Length + nJG;
            }


            //保存文件   
            objWorkbook.SaveAs(fileNameString, Missing.Value, Missing.Value, Missing.Value, Missing.Value,
                    Missing.Value, Excel.XlSaveAsAccessMode.xlShared, Missing.Value, Missing.Value, Missing.Value,
                    Missing.Value, Missing.Value);


            //关闭Excel应用   
            if (objWorkbook != null) objWorkbook.Close(Missing.Value, Missing.Value, Missing.Value);
            if (objExcel.Workbooks != null) objExcel.Workbooks.Close();
            if (objExcel != null) objExcel.Quit();

            objsheet = null;
            objWorkbook = null;
            objExcel = null;


            MessageBox.Show(fileNameString + "\n\n导出完毕! ", "提示 ", MessageBoxButtons.OK, MessageBoxIcon.Information);

            return true;
        }

        #endregion

        string GetExportFile ( string strDefaultFile )
        {
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.FileName = strDefaultFile;
            dlg.DefaultExt = "xls ";
            dlg.Filter = "EXCEL文件(*.XLS)|*.xls ";
            dlg.InitialDirectory = Directory.GetCurrentDirectory();
            if (dlg.ShowDialog() == DialogResult.Cancel)
                return String.Empty;

            string strOutFile = dlg.FileName;

            //如文件已经存在，则删除
            DeleteFile(strOutFile);   

            return strOutFile;
        }

        /// <summary>
        /// 验证以fileNameString命名的文件是否存在，如果存在删除它   
        /// </summary>
        /// <param name="strFileName"></param>
        bool DeleteFile(string strFileName)
        {
            FileInfo file = new FileInfo( strFileName );
            if (file.Exists)
            {
                try
                {
                    file.Delete();
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message, "删除已有文件失败 ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }

            return true;
        }

        bool CreateExcelHead ( string[] strsHeadName )
        {
            if (strsHeadName == null || strsHeadName.Length <= 0)
                return false;

            Excel.Range rag = objSheet.get_Range(objSheet.Cells[1, 1], objSheet.Cells[1, strsHeadName.Length]);
            rag.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;

            int nColHead = 1;
            foreach (string strHeadName in strsHeadName)
            {
                objExcel.Cells[1, nColHead] = strHeadName;
                nColHead++;
            }

            return true;
        }

        bool CreateExcelHead( int nHeadLineNo , int nHeadWidth )
        {
            Excel.Range rag = objSheet.get_Range( objSheet.Cells[ nHeadLineNo, 1 ], objSheet.Cells[ nHeadLineNo, nHeadWidth ] );
            rag.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
            //rag.Cells.Font.Color = System.Drawing.ColorTranslator.ToOle(Color.FromArgb(000, 000, 255));  //等待之后给类添加一个类，用于表述表头的格式（颜色，字体，大小...）
            rag.Cells.Font.Bold = true;

            //
            AllColumnAutoFit( nHeadWidth );

            return true;
        }

        /// <summary>
        /// 方法，导出List中的数据到Excel文件   
        /// </summary>
        /// <remarks>  
        /// add com "Microsoft Excel 11.0 Object Library"  
        /// using Excel=Microsoft.Office.Interop.Excel;  
        /// using System.Reflection;  
        /// </remarks>  
        /// <param name="strsHeadName">导出的列的的HeadName, 如果为null,则导出全部列</param>
        /// <param name="lstDate">要导出的数据。横竖都是List-string</param>
        /// <param name="strOutFileName">设定导出的文件名称</param>
        /// <returns></returns>
        //public bool SaveList( string[] strsHeadName, List<List<string>> lstDate, string strDefaultFile )
        //{
        //    GRID2EXCEL grid2Excel = new GRID2EXCEL();

        //    //定义表格内数据的行数和列数   
        //    int nRowsCount = lstDate.Count;
        //    int nColsCount = lstDate[0].Count;

        //    #region 验证

        //    if ( nRowsCount <= 0 || nColsCount <= 0 )
        //    {
        //        MessageBox.Show("没有可以导出的数据！", "提示 ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //        return false;
        //    }

        //    //行数不可以大于65536   
        //    if (nRowsCount > 65536)
        //    {
        //        MessageBox.Show("数据记录数太多(最多不能超过65536条)，不能保存 ", "提示 ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //        return false;
        //    }

        //    //列数不可以大于255   
        //    if (nColsCount > 255)
        //    {
        //        MessageBox.Show("数据记录行数太多，不能保存 ", "提示 ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //        return false;
        //    }

        //    if ( strsHeadName == null || strsHeadName.Length <= 0)
        //    {
        //        MessageBox.Show("没有指定Excel列名称！", "提示 ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //        return false;
        //    }

        //    #endregion

        //    //获取输出Excel文件名   
        //    string strOutFileName = grid2Excel.GetExportFile(strDefaultFile);
        //    if (String.IsNullOrEmpty(strOutFileName))
        //        return false;


        //    try
        //    {
        //        OpenExcel();

        //        //设置Excel列表头
        //        CreateExcelHead(strsHeadName);

        //        //向Excel中逐行逐列写入表格中的数据   
        //        int nExcelCol, nExcelRow = 2; //Execl的行列都从1开始起算。第一行是列名，数据从第二行开始写入。
        //        for ( int i = 0; i < nRowsCount ; i++ )
        //        {
        //            nExcelCol = 1;              //Execl的行列都从1开始起算。第一行是列名，数据从第二行开始写入。

        //            for ( int j = 0 ; j < nColsCount; j ++ )
        //            {
        //                if ( j >= lstDate[i].Count )   //string[] 元素不够的情况
        //                    continue;

        //                try
        //                {
        //                    objExcel.Cells[ nExcelRow, nExcelCol++ ] = lstDate[i][j].Trim();
        //                }
        //                catch (Exception)
        //                {
        //                    return false;
        //                }
        //            }

        //            nExcelRow++;
        //        }

        //        //保存文件   
        //        objWorkbook.SaveAs( strOutFileName, 
        //                            Missing.Value, Missing.Value, Missing.Value, Missing.Value,
        //                            Missing.Value, Excel.XlSaveAsAccessMode.xlShared, Missing.Value, Missing.Value, Missing.Value,
        //                            Missing.Value, Missing.Value);

        //    }
        //    catch (Exception ex)
        //    {
        //        FF.Ctrl.MsgBox.ShowWarn(ex.Message);
        //        return false;
        //    }
        //    finally
        //    {
        //        CloseExcel();
        //    }

        //    FF.Ctrl.MsgBox.Show(strOutFileName + "\n\n导出完毕! ");

        //    return true;
        //}

        //public bool SaveList( string[] strsHeadName, List<List<string>> lstDate )
        //{
        //    return SaveList(strsHeadName, lstDate, String.Empty);
        //}

        #region List => Excel

        int GetMaxColCount( List<List<string>> lstDate )
        {
            int nMaxColCount = 0;
            foreach ( List<string> strs in lstDate)
            {
                if (strs.Count > nMaxColCount)
                    nMaxColCount = strs.Count;
            }

            return nMaxColCount;
        }

        /// <summary>
        /// 表头行一并写在数据List中。一般写在第一行。
        /// </summary>
        /// <param name="HeadLineNo">第几行是表头，默认是第一行.行号从0开始。</param>
        /// <param name="lstDate"></param>
        /// <param name="strDefaultFile"></param>
        /// <returns></returns>
        public bool SaveList( int nHeadLineNo, List<List<string>> lstDate, string strDefaultFile)
        {
            GRID2EXCEL grid2Excel = new GRID2EXCEL();

            //定义表格内数据的行数和列数   
            int nRowsCount = lstDate.Count;

            #region 验证

            if (nHeadLineNo <= 0)
                nHeadLineNo = 1;
            else if (nHeadLineNo >= lstDate.Count)
                nHeadLineNo = 1;
            else
                nHeadLineNo++;

            int nMaxColCount = GetMaxColCount(lstDate);

            if (nRowsCount <= 0 || nMaxColCount <= 0)
            {
                MessageBox.Show("没有可以导出的数据！", "提示 ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            //行数不可以大于65536   
            if (nRowsCount > 65536)
            {
                MessageBox.Show("数据记录数太多(最多不能超过65536条)，不能保存 ", "提示 ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            //列数不可以大于255   
            if (nMaxColCount > 255)
            {
                MessageBox.Show("数据记录行数太多，不能保存 ", "提示 ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            #endregion

            //获取输出Excel文件名   
            string strOutFileName = grid2Excel.GetExportFile(strDefaultFile);
            if (String.IsNullOrEmpty(strOutFileName))
                return false;

            try
            {
                OpenExcel();

                //设置Excel列表头
                int nHeadColCount = lstDate[nHeadLineNo - 1].Count;  //nHeadLineNo原来从0开始的，后来被加了1改为Excel计数方式的行数.
                CreateExcelHead( nHeadLineNo, nHeadColCount );

                //向Excel中逐行逐列写入表格中的数据   
                int nExcelCol, nExcelRow = 1; //Execl的行都从1开始起算。
                for (int i = 0; i < nRowsCount; i++)
                {
                    nExcelCol = 1;              //Execl的列都从1开始起算。

                    for (int j = 0; j < lstDate[i].Count; j++)
                    {
                        try
                        {
                            objExcel.Cells[nExcelRow, nExcelCol++] = lstDate[i][j].Trim();
                        }
                        catch (Exception)
                        {
                            return false;
                        }
                    }

                    nExcelRow ++;
                }

                //保存文件   
                objWorkbook.SaveAs(strOutFileName,
                                    Missing.Value, Missing.Value, Missing.Value, Missing.Value,
                                    Missing.Value, Excel.XlSaveAsAccessMode.xlShared, Missing.Value, Missing.Value, Missing.Value,
                                    Missing.Value, Missing.Value);

            }
            catch (Exception ex)
            {
                FF.Ctrl.MsgBox.ShowWarn(ex.Message);
                return false;
            }
            finally
            {
                CloseExcel();
            }

            FF.Ctrl.MsgBox.Show(strOutFileName + "\n\n导出完毕! ");

            return true;
        }

        public bool SaveList( List<List<string>> lstDate, string strDefaultFile )
        {
            return SaveList( 0, lstDate, strDefaultFile );
        }

        public bool SaveList(List<List<string>> lstDate)
        {
            return SaveList( 0, lstDate, String.Empty );
        }

        #endregion


        //this is testwill finish
        //public static bool SaveListToExcel( ArrayList aryParam )
        //{
        //    if ( aryParam == null || aryParam.Count == 0 )
        //        return false;

        //    Excel.Application objExcel = null;
        //    Excel.Workbook objWorkbook = null;
        //    Excel.Worksheet objsheet = null;

        //    string fileNameString = "";     //Excel的文件名称。

        //    int n = 0;          //标明当前是第几个数据结构。 
        //    int nLine = 1;      //每个数据结构的开始的行数
        //    int nJG = 5;        //每个数据结构之间 间隔的行数

        //    foreach ( EXCELPARAMEX param in aryParam )
        //    {
        //        DataTable dt = param.dt;
        //        string strOutFileName = param.strOutFile;
        //        string[] strsHeadName = param.strsHeadName;
        //        string[] strsFldName = param.strsFldName;

        //        int[] nsLineNo = null;

        //        if ( dt.Rows.Count <= 0 )
        //        {
        //            MessageBox.Show( "没有可以导出的数据！", "提示 ", MessageBoxButtons.OK, MessageBoxIcon.Information );
        //            return false;
        //        }

        //        //处理第一个数据结构。 选择文件名称。
        //        if ( n == 0 )
        //        {

        //            #region   验证可操作性

        //            //申明保存对话框   
        //            SaveFileDialog dlg = new SaveFileDialog();
        //            //默然文件后缀   
        //            dlg.FileName = strOutFileName;
        //            dlg.DefaultExt = "xls ";
        //            //文件后缀列表   
        //            dlg.Filter = "EXCEL文件(*.XLS)|*.xls ";
        //            //默然路径是系统当前路径   
        //            dlg.InitialDirectory = Directory.GetCurrentDirectory();
        //            //打开保存对话框   
        //            if ( dlg.ShowDialog() == DialogResult.Cancel )
        //                return false;

        //            //返回文件路径   
        //            fileNameString = dlg.FileName;
        //            //验证strFileName是否为空或值无效   
        //            if ( fileNameString.Trim() == " " )
        //                return false;

        //            //验证以fileNameString命名的文件是否存在，如果存在删除它   
        //            FileInfo file = new FileInfo( fileNameString );
        //            if ( file.Exists )
        //            {
        //                try
        //                {
        //                    file.Delete();
        //                }
        //                catch ( Exception error )
        //                {
        //                    MessageBox.Show( error.Message, "删除失败 ", MessageBoxButtons.OK, MessageBoxIcon.Warning );
        //                    return false;
        //                }
        //            }

        //            //申明对象   
        //            objExcel = new Microsoft.Office.Interop.Excel.Application();
        //            objWorkbook = objExcel.Workbooks.Add( Missing.Value );
        //            objsheet = (Excel.Worksheet)objWorkbook.ActiveSheet;
        //            //设置EXCEL不可见   
        //            objExcel.Visible = false;

        //        }


        //        //定义表格内数据的行数和列数   
        //        int rowscount = dt.Rows.Count;
        //        int colscount = dt.Columns.Count;
        //        //行数必须大于0   
        //        if ( rowscount <= 0 )
        //        {
        //            MessageBox.Show( "没有数据可供保存 ", "提示 ", MessageBoxButtons.OK, MessageBoxIcon.Information );
        //            return false;
        //        }

        //        //列数必须大于0   
        //        if ( colscount <= 0 )
        //        {
        //            MessageBox.Show( "没有数据可供保存 ", "提示 ", MessageBoxButtons.OK, MessageBoxIcon.Information );
        //            return false;
        //        }

        //        //行数不可以大于65536   
        //        if ( rowscount > 65536 )
        //        {
        //            MessageBox.Show( "数据记录数太多(最多不能超过65536条)，不能保存 ", "提示 ", MessageBoxButtons.OK, MessageBoxIcon.Information );
        //            return false;
        //        }

        //        //列数不可以大于255   
        //        if ( colscount > 255 )
        //        {
        //            MessageBox.Show( "数据记录行数太多，不能保存 ", "提示 ", MessageBoxButtons.OK, MessageBoxIcon.Information );
        //            return false;
        //        }


        //            #endregion

        //        #region

        //        //取得要导出的列的HeadName.
        //        //如果没有指定特定的列，则默认转换 可见的 并且 有HeadName 的列。（控件列不用导出，控件列一般没有HeadName）
        //        if ( strsHeadName == null )
        //        {
        //            MessageBox.Show( "没有指定字段名称！", "提示 ", MessageBoxButtons.OK, MessageBoxIcon.Information );
        //            return false;
        //        }

        //        //取得所有要执行的行，（可能用户并不是要导出所有行，而是通过checkbox选择要导出的行）
        //        //如果没有指定特定的行，则默认转出全部的行
        //        if ( nsLineNo == null )
        //        {
        //            nsLineNo = new int[dt.Rows.Count];
        //            for ( int row = 0 ; row <= dt.Rows.Count - 1 ; row++ )
        //            {
        //                nsLineNo[row] = row;
        //            }
        //        }

        //        #endregion


        //        try
        //        {


        //            //向Excel中写入表格的表头   
        //            Excel.Range rag = objsheet.get_Range( objsheet.Cells[nLine, 1], objsheet.Cells[nLine, strsHeadName.Length] );
        //            rag.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;

        //            int displayColumnsCount = 1;
        //            foreach ( string strHeadName in strsHeadName )
        //            {
        //                objExcel.Cells[nLine, displayColumnsCount] = strHeadName;
        //                displayColumnsCount++;
        //            }

        //            //定义每列的数据格式。
        //            int nRow1 = nLine + 1, nRow2 = nRow1 + nsLineNo.Length;
        //            int nColSel = 1;
        //            foreach ( string strFldName in strsFldName )
        //            {
        //                rag = objsheet.get_Range( objsheet.Cells[nRow1, nColSel], objsheet.Cells[nRow2, nColSel] );

        //                switch ( dt.Columns[strFldName].DataType.ToString() )
        //                {
        //                    case "System.String":
        //                        rag.NumberFormatLocal = "@";
        //                        break;

        //                    case "System.DateTime":
        //                        rag.NumberFormatLocal = "yyyy-MM-dd HH:mm";
        //                        break;

        //                    //可以根据自己的需要扩展。

        //                    default:
        //                        //rag.NumberFormatLocal = "G/通用格式";
        //                        break;
        //                }

        //                nColSel++;
        //            }

        //            //向Excel中逐行逐列写入表格中的数据   
        //            int nCol, row;
        //            int nExcelCol, nExcelRow = nLine + 1; //Execl的行列都从1开始起算。第一行是列名，数据从第二行开始写入。

        //            for ( int i = 0 ; i <= nsLineNo.Length - 1 ; i++ )
        //            {
        //                row = nsLineNo[i];
        //                nExcelCol = 1;              //Execl的行列都从1开始起算。第一行是列名，数据从第二行开始写入。

        //                foreach ( string strFldName in strsFldName )
        //                {
        //                    try
        //                    {
        //                        objExcel.Cells[nExcelRow, nExcelCol++] = dt.Rows[row][strFldName].ToString().Trim();
        //                    }
        //                    catch ( Exception )
        //                    {
        //                    }
        //                }

        //                nExcelRow++;
        //            }

        //        }
        //        catch ( Exception error )
        //        {
        //            MessageBox.Show( error.Message, "警告 ", MessageBoxButtons.OK, MessageBoxIcon.Warning );
        //            return false;
        //        }

        //        //
        //        n++;
        //        nLine += nsLineNo.Length + nJG;
        //    }


        //    //保存文件   
        //    objWorkbook.SaveAs( fileNameString, Missing.Value, Missing.Value, Missing.Value, Missing.Value,
        //            Missing.Value, Excel.XlSaveAsAccessMode.xlShared, Missing.Value, Missing.Value, Missing.Value,
        //            Missing.Value, Missing.Value );


        //    //关闭Excel应用   
        //    if ( objWorkbook != null ) objWorkbook.Close( Missing.Value, Missing.Value, Missing.Value );
        //    if ( objExcel.Workbooks != null ) objExcel.Workbooks.Close();
        //    if ( objExcel != null ) objExcel.Quit();

        //    objsheet = null;
        //    objWorkbook = null;
        //    objExcel = null;


        //    MessageBox.Show( fileNameString + "\n\n导出完毕! ", "提示 ", MessageBoxButtons.OK, MessageBoxIcon.Information );

        //    return true;
        //}
    }

    public class EXCELPARAMEX
    {
        public DataTable dt = new DataTable ();
        public string strOutFile = "";
        public string [] strsHeadName = null;
        public string [] strsFldName = null;
    }

    //public class LIST_EXCEL_PARAM<T>
    //{
    //    List<T> mList = new List<T>();  
    //    public string strOutFile = "";
    //    public string[] strsHeadName = null;
    //    public string[] strsFldName = null;
    //}
}
