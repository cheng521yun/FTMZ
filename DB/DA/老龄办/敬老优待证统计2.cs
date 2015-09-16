using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using FrontFlag;

namespace DB.DA.老龄办
{
    partial class 敬老优待证统计
    {
        public DataTable Get统计( string strWhere )
        {
            DataTable dt = new DataTable();

            SQL Sql = new SQL( DBParam.Sql.Connect );

            if ( strWhere.Trim() != "" )
                strWhere = " Where " + strWhere;

            string strSql = String.Format( @"select 街道, 
                                            SUM( CASE WHEN 优待证类别 = '黄证' THEN 1 ELSE 0 END) as 黄证,
                                            SUM( CASE WHEN 优待证类别 = '蓝证' THEN 1 ELSE 0 END) as 蓝证,
                                            SUM( CASE WHEN 优待证类别 = '免费乘车证' THEN 1 ELSE 0 END) as 免费乘车证,   
                                            Count(*) as 合计                                            
                                            from {0} {1}  group by 街道 ",
                                            DB.Tab.老龄办.敬老优待证.TAB, strWhere );
            dt = Sql.ExecDataTable( strSql );

            Sql.Close();

            return dt;
        }
    }
}
