

using System;
using System.Data;
using System.Configuration;

using FrontFlag;
using Def.Const;

namespace DB.DA.老龄办
{
    partial class 老龄津贴统计
    {
        public DataTable GetBlank()
        {
            SQL Sql = new SQL( DBParam.Sql.Connect );

            DataTable dt = Sql.GetBlankDt( DB.Tab.老龄办.老龄津贴统计.TAB );
            dt.Rows.Clear();
            Sql.Close();
            return dt;
        }

        public DataTable GetWhere( string strWhere )
        {
            DataTable dt = new DataTable();

            SQL Sql = new SQL( DBParam.Sql.Connect );

            if ( strWhere.Trim() != "" )
                strWhere = " Where " + strWhere;

            string strSql = String.Format( "select * from {0} {1} order by ID desc", DB.Tab.老龄办.老龄津贴统计.TAB, strWhere );
            dt = Sql.ExecDataTable( strSql );

            Sql.Close();

            return dt;
        }

        #region Split to Page

        //Get one Page data from all 
        public DataTable GetPage( int nPageNo, string strWhere )
        {
            SQL Sql = new SQL( DBParam.Sql.Connect );

            DataTable dt = new DataTable();
            string strSql = SQL.GetPageSql2005( DB.Tab.老龄办.老龄津贴统计.TAB, nPageNo, CONST.PageSize, DB.Tab.老龄办.老龄津贴统计.ID, strWhere, false );
            dt = Sql.ExecDataTable( strSql );

            Sql.Close();
            return dt;
        }

        public int GetPageMax( string strWhere )
        {
            SQL Sql = new SQL( DBParam.Sql.Connect );

            int nRecCount = 0;

            int nPageNum = Sql.GetPageMaxPage( DB.Tab.老龄办.老龄津贴统计.TAB, strWhere, ref nRecCount, CONST.PageSize );

            Sql.Close();

            return nPageNum;
        }

        #endregion

        #region Save

        public string Save( ref DataTable dt )
        {
            if ( !SQL.IsValid( ref dt ) )
                return "";

            SQL Sql = new SQL( DBParam.Sql.Connect );

            string strID = Sql.Save( ref dt );

            Sql.Close();

            return strID;
        }

        #endregion

        #region Delete

        public void Delete_Table()
        {
            SQL Sql = new SQL( DBParam.Sql.Connect );

            string strSql = String.Format( "delete from {0} ", DB.Tab.老龄办.老龄津贴统计.TAB );
            Sql.Exec( strSql );

            Sql.Close();
        }

        public bool Delete_Where( string strWhere )
        {
            //Not allow delete all data in table
            if ( strWhere.Trim() == "" )
                return false;

            SQL Sql = new SQL( DBParam.Sql.Connect );

            string strSql = String.Format( "delete from {0} where {1}", DB.Tab.老龄办.老龄津贴统计.TAB, strWhere );
            Sql.Exec( strSql );

            Sql.Close();

            return true;
        }

        public bool Delete_ByID( string strID )
        {
            string strWhere = String.Format( "{0}='{1}'", DB.Tab.老龄办.老龄津贴统计.ID, strID );
            return Delete_Where( strWhere );
        }

        #endregion


        #region Update

        public void Update_ByID( string strID, string strFld, string strVal )
        {
            SQL Sql = new SQL( DBParam.Sql.Connect );

            string strSql = String.Format( "update {0} set {1}='{2}' where ID='{3}'", DB.Tab.老龄办.老龄津贴统计.TAB, strFld, strVal, strID );
            Sql.Exec( strSql );

            Sql.Close();
        }

        #endregion

        #region Sum

        public DataTable GetCount( string strWhere )
        {
            DataTable dt = new DataTable();

            SQL Sql = new SQL( DBParam.Sql.Connect );

            if ( strWhere.Trim() != "" )
                strWhere = " Where " + strWhere;

            string strSql = String.Format( "select Count(*) from {0} {1} ", DB.Tab.老龄办.老龄津贴统计.TAB, strWhere );
            dt = Sql.ExecDataTable( strSql );

            Sql.Close();

            return dt;
        }

        public DataTable GetSum( string strFld, string strWhere )
        {
            DataTable dt = new DataTable();

            SQL Sql = new SQL( DBParam.Sql.Connect );

            if ( strWhere.Trim() != "" )
                strWhere = " Where " + strWhere;

            string strSql = String.Format( "select Sum({2}) from {0} {1} ", DB.Tab.老龄办.老龄津贴统计.TAB, strWhere, strFld );
            dt = Sql.ExecDataTable( strSql );

            Sql.Close();

            return dt;
        }

        #endregion
    }
}
