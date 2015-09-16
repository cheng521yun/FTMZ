//////////////////////////////////////////////////////////////////////////
//
//
//  FrontFlag Lib fro DotNet 2.0 
//  2006/06/12 
//  徐力
//
//////////////////////////////////////////////////////////////////////////

using FrontFlag.Test;

namespace FrontFlag
{
    public class FF
    {
        public static VERSION Version = new VERSION ();
        public static FUN Fun = new FUN ( );
        public static JSON Json = new JSON();
        public static CONTROL Ctrl = new CONTROL ( );
        public static STRING Str = new STRING ( );
        public static DIR Dir = new DIR ();
        public static FILE File = new FILE ( );
        public static XML Xml = new XML ( );
        public static EMAIL Email = new EMAIL ( );
        public static DRAW Draw = new DRAW ( );
        public static ARRAY Ary = new ARRAY ( );
        public static SQL Sql = new SQL ();
        //public static SQLITE SQLite = new SQLITE();
        public static OLEDB Odb = new OLEDB () ; 
        public static DEBUG Debug = new DEBUG ();
        public static SYSTEMINFO SysInfo = new SYSTEMINFO ();
        public static XDictionary Dictionary = new XDictionary ();  

        //test
        public static FrontFlag.Test.TEST TD = new TEST();
        

    }  //end Class   
}
