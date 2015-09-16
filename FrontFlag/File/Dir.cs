using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace FrontFlag
{
    public class DIR
    {
        //可直接建立多层目录,比如 c:\a\b\c 
        public bool CreateDir ( string strDir )
        {
            char [ ] chsInvalid = new char [ ] { '/' , ':' , '*' , '?' , '"' , '<' , '>' , '|' };   //\被用做了分隔符，所以不过滤。
            string strtmp;
            foreach ( char c in chsInvalid )
            {
                strtmp = String.Format ( "{0}" , c );
                if ( strDir.Contains ( strtmp ) )
                    return false;
            }

            strDir = strDir.Replace ( @"\\" , "?" );    //为了支持局域网，局域网路径起头是\\,这会被下面的Split分解掉。

            char [ ] chs = new char [ ] { '\\' };
            string [ ] strsDir = strDir.Split ( chs );

            if ( strsDir.Length > 0 )
                strsDir [ 0 ] = strsDir [ 0 ].Replace ( "?" , @"\\" );    //还原局域网路径的起头\\,

            try
            {
                string strPath = "";
                foreach ( string str in strsDir )
                {
                    if ( str.Trim () == String.Empty )
                        continue;

                    strPath = Path.Combine ( strPath , str );

                    if ( str.Contains ( @"\\" ) )       //是局域网路径的起头，放弃判断，因为总是返回false, Exists()不能对局域网的根路径判别。从第二级目录开始判断。默认传入\\xx.xx.xx.xx是正确的。
                        continue;

                    if ( !Directory.Exists ( strPath ) )
                        Directory.CreateDirectory ( strPath );
                }
            }
            catch
            {
                return false;
            }

            return true;
        }
    }
}
