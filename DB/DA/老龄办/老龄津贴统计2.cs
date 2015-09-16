using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using FrontFlag;

namespace DB.DA.老龄办
{
    partial class 老龄津贴统计
    {
        public DataTable Get统计( string strWhere )
        {
            int nYNow = DateTime.Now.Year;
            int nY80 = nYNow - 80;
            int nY90 = nYNow - 90;
            int nY100 = nYNow - 100;

            string str80 = String.Format("{0}-01-01", nY80);
            string str90 = String.Format( "{0}-01-01", nY90 );
            string str100 = String.Format( "{0}-01-01", nY100 );

            DataTable dt = new DataTable();

            SQL Sql = new SQL( DBParam.Sql.Connect );

            if ( strWhere.Trim() != "" )
                strWhere = " Where " + strWhere;

            string strSql = String.Format( @"select 街道, 
                                            SUM( CASE WHEN 出生日期 >= '{0}' and 出生日期 < '{1}' THEN 1 ELSE 0 END) as 年龄段80,
                                            SUM( CASE WHEN 出生日期 >= '{1}' and 出生日期 < '{2}' THEN 1 ELSE 0 END) as 年龄段90,
                                            SUM( CASE WHEN 出生日期 >= '{2}' THEN 1 ELSE 0 END) as 年龄段100
                                                                          
                                            from {3} {4}  group by 街道 ",
                                            str80, str90, str100,
                                            DB.Tab.老龄办.发放老龄津贴.TAB, strWhere );
            dt = Sql.ExecDataTable( strSql );

            Sql.Close();

            return dt;
        }
    }
}
