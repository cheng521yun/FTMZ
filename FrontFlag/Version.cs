using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms ;

namespace FrontFlag
{
    #region 版本历史
    /*
     * 2013-06-19 0.83 更新日期字段时，会强制转换为"YYY-MM-dd HH;MM:ss".(避免默认转换时，会加入星期等信息)
     * 
     * 2013-03-27 0.82 添加了 COMBO.SetSelectText_NoCaseSens(). 
     * 
     * 2012-06-20 0.81 添加了SQLITE类。  
     * 
     * 2012-01-08 0.80 添加了Sys.CheckEnv类。  
     * 
     * 2011-06-14 0.79 更正GetPageSql() 在desc的情况下，读取非0页面，都显示为0页面数据的问题。
     * 
     * 2010-12-12 0.78 FindList类添加了 OnCellFormatting 属性。用于代替AfterFill。 
     * 
     * 2010-10-12 0.76 添加FrontFlag.Control.DataGridView.XEditView 类。 
     * 
     * 2010-05-28 0.72 File目录添加了EXCEL类，可以支持导入Excel文件到Table。 
     * 
     * 2010-03-25 0.71 XEditListView类，添加了SetColorTag()函数，可以指定特定行的Tag列会特定背景色。
     * 
     * 2010-03-23 0.70 添加了UserCtrl/FindList 的GridView控件。.  
     * 
     * 2010-03-08 0.69 XListView 添加了 SaveDtToExcel(), 可以导出dt到 Excel。.  
     * 
     * 2009-06-03 0.68 Ctrol类添加了 SetReadOnly_WhiteBK() 
     * 
     * 2009-04-27 0.67 XEditListView的DateTimePicker类型改为MyDatePick自定义控件，可以Clear选择的日期。
     * 
     * 2009-04-07 0.66 XEditListView添加DateTimePicker类型。
     * 
     * 2009-02-13 0.65 SQL添加 CopyRow() 函数。
     * 
     * 2009-02-11 0.64 XListView控件中,money类型自动精确到最低2位，最多4位小数点。
     * 
     * 2009-01-23 0.63 精确到小数点后4位。最少小数是2位。
     * 
     * 2009-01-19 0.62 XListView类 添加 ItemUp(),ItemDown() 函数。
     * 
     * 2008-11-22 0.61 SQL类 添加 Save()。
     * 
     * 2008-11-04 0.51 更改ListView中隐藏列可以给拉出来的问题。
     * 
     * 2008-04-12 0.49 SQL添加ExecProcedureRet()函数。
     * 
     * 2007-12-20 0.48 修改XML, 可以在任意位置新添加变量。
     *                XListView 可以在XML中保存列宽度。  
     * 
     * 2007-12-06 0.47 添加 FUN.DATE.GetMonthLastDay ( int nYear , int nMonth ) 函数。
     * 
     * 2007-10-15 0.46 一点点小修改。
     * 
     * 2007-10-01 XListView按"yy-MM-dd HH:mm"格式显示日期。
     * 
     * 2007-10-31 SQL.InsertRow2DB() 支持布尔类型。
     * 
     * 2007-10-30 SQL.UpdateRow2DB() 支持布尔类型。
     * 
     * 2007-10-05 L2A() 后边追加".00"。
     * 
     * 2007-09-25 更正了 DataTable2List()在 dt=null 是会崩溃的问题。
     * 
     * 2007-09-15 更正了XEditList光标留在哪行，保存后，会把原来的EditBox的内容覆盖在哪行上 的问题.
     * 
     * 
    */
    #endregion

    public class VERSION
    {
        public string strDate = "2013-06-19";
        public int nMainVersion = 0;
        public int nSubVersion = 83;
        public string strVersionType = "M";     //General,通用版本.

        //0.1
        public string GetVerStr () 
        {
            return String.Format ( "{0}{1}.{2}" , strVersionType , nMainVersion , nSubVersion );
        }

        //Ver 0.1
        public string GetVerString ()
        {
            return String.Format ( "Ver {0}{1}.{2}" , strVersionType , nMainVersion , nSubVersion );
        }

        public bool CheckVer(string strType, int nNeedCheckMain, int nNeedCheckSub)
        {
            if ( strType != strVersionType )
                return false ;

            if (nMainVersion < nNeedCheckMain)
                return false ;

            if (nSubVersion < nNeedCheckSub)
                return false;

            return true;
        }

        public bool CheckVer ( string strVer )
        {
            STRING STR = new STRING (); 

            string strType = "";

            char [] chs = { '.' } ;
            string [] strs = null ;

            strs = strVer.Split ( chs ) ;
            
            if ( strs == null || strs.Length < 2 )
                return false ;

            strType = STR.SubStr.GetPreChar ( strs [ 0 ] );
            int nMain = FF.Fun.MyConvert.Str2Int ( strs [ 0 ] ) ;
            int nSub = FF.Fun.MyConvert.Str2Int ( strs [ 1 ] ) ;

            if ( !CheckVer ( strType , nMain , nSub ) )
                return false ;

            return true;
        }
    }
}
