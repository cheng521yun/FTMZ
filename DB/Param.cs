using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DB
{
    public class DBParam
    {
        static public PARAM_SQL Sql = new PARAM_SQL();
    }

    public class PARAM_SQL
    {
        public string IP = String.Empty;
        public string DB = String.Empty;
        public string User = String.Empty;
        public string Pass = String.Empty;

        private int nTimeOut = 60;   //单位;秒

        public string Connect
        {
            get
            {
                return String.Format( "data source={0};initial catalog={1};uid={2};pwd={3};Connect Timeout={4}", IP, DB, User, Pass, nTimeOut );
            }
        }
    }
}
