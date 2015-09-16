using System;
using System.Data;
using System.Configuration;

using FrontFlag;


namespace FrontFlag.Test.ORM
{
    class TEST_LOG
    {
        public DataTable GetWhere(string strWhere)
        {
            DataTable dt = new DataTable();

            SQL Sql = new SQL(FF.TD.Def.ConnectStr);

            if (strWhere.Trim() != "")
                strWhere = " Where " + strWhere;

            string strSql = String.Format("select * from {0} {1} order by ID desc", Tab.TEST_LOG.TAB, strWhere);
            dt = Sql.ExecDataTable(strSql);

            Sql.Close();

            return dt;

        }

        #region Split to Page

        //Get one Page data from all 
        public DataTable GetPage(int nPageNo, string strWhere)
        {
            SQL Sql = new SQL(FF.TD.Def.ConnectStr);

            DataTable dt = new DataTable();
            string strSql = SQL.GetPageSql(Tab.TEST_LOG.TAB, nPageNo, FrontFlag.Test.DEF.PageSize, Tab.TEST_LOG.ID, strWhere);
            dt = Sql.ExecDataTable(strSql);

            Sql.Close();
            return dt;
        }

        public int GetPageMax(string strWhere)
        {
            SQL Sql = new SQL(FF.TD.Def.ConnectStr);

            int nRecCount = 0;

            int nPageNum = Sql.GetPageMaxPage(Tab.TEST_LOG.TAB, strWhere, ref nRecCount, FrontFlag.Test.DEF.PageSize);

            Sql.Close();

            return nPageNum;
        }

        #endregion

        public DataTable GetBlank()
        {
            SQL Sql = new SQL(FF.TD.Def.ConnectStr);

            DataTable dt = Sql.GetBlankDt(Tab.TEST_LOG.TAB);
            Sql.Close();
            return dt;
        }

        #region Save

        public string Save(ref DataTable dt)
        {
            if (!SQL.IsValid(ref dt))
                return "";

            SQL Sql = new SQL(FF.TD.Def.ConnectStr);

            string strID = Sql.Save(ref dt);

            Sql.Close();

            return strID;
        }

        public string Save(Stru.TEST_LOG stru)
        {
            DataTable dt = GetBlank();
            DataRow dr = dt.Rows[0];
            stru.Stru2Dr(ref dr);

            SQL Sql = new SQL(FF.TD.Def.ConnectStr);

            string strID = Sql.Save(ref dt);

            Sql.Close();

            return strID;
        }

        #endregion

        #region Delete

        public void Delete_Table()
        {
            SQL Sql = new SQL(FF.TD.Def.ConnectStr);

            string strSql = String.Format("delete from {0} ", Tab.TEST_LOG.TAB);
            Sql.Exec(strSql);

            Sql.Close();
        }

        public bool Delete_Where(string strWhere)
        {
            //Not allow delete all data in table
            if (strWhere.Trim() == "")
                return false;

            SQL Sql = new SQL(FF.TD.Def.ConnectStr);

            string strSql = String.Format("delete from {0} where {1}", Tab.TEST_LOG.TAB, strWhere);
            Sql.Exec(strSql);

            Sql.Close();

            return true;
        }

        public bool Delete_ByID(string strID)
        {
            string strWhere = String.Format("{0}='{1}'", Tab.TEST_LOG.ID, strID);
            return Delete_Where(strWhere);
        }

        #endregion
    }
}
