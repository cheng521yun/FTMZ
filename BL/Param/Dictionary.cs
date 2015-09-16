using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FrontFlag;

namespace Buss.Param
{
    public class DICTIONARY
    {
        XDictionary Dict = new XDictionary();
        const string _strTabName = "Dict_Sys";

        public DICTIONARY()
        {
            Dict.SetSQLConnect( DB.DBParam.Sql.Connect, _strTabName );
        }

        public string GetValue( string strFullPath )
        {
            string[] strs = Dict.GetValues_ByPath(strFullPath);

            if (strs == null || strs.Length <= 0)
                return string.Empty;

            return strs[0];
        }

        public List<string> GetAllValue( string strFullPath )
        {
            List<string> lst = new List<string>();
            string[] strs = Dict.GetValues_ByPath( strFullPath );

            if (strs != null && strs.Length > 0)
            {
                foreach ( string str in strs)
                {
                    lst.Add( str );
                }
            }

            return lst;
        }

        public bool Append( string strFullPath, List<string> lstStrs )
        {
            Dict.Append( strFullPath, lstStrs );
            return true;
        }

        public bool Append( string strFullPath, string strValue )
        {
            Dict.Append( strFullPath, strValue );
            return true;
        }

        public bool Update( string strFullPath, List<string> lstStrs )
        {
            Dict.Update( strFullPath, lstStrs );
            return true;
        }

        public bool Update( string strFullPath, string strValue )
        {
            List<string> lstStrs = new List<string>();
            lstStrs.Add( strValue );

            Dict.Update( strFullPath, lstStrs );
            return true;
        }
    }
}
