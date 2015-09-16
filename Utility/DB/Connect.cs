using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using FrontFlag;
using Global;

namespace Utility.DB
{
    public class CONNECT
    {
        public bool ReadKey()
        {
            string strSeed = "_mogultech_key_";
            string strParamFile = @"param\sql.dat";

            string[] str = new string[ 4 ];
            BinaryReader br = null;

            try
            {
                FileStream fs = new FileStream( strParamFile, FileMode.Open, FileAccess.Read );
                br = new BinaryReader( fs );
            }
            catch ( Exception ex )
            {
                string strMsg = String.Format( "程序终止运行!\n请检查 {0} 配置文件是否存在！", strParamFile );
                FF.Ctrl.MsgBox.ShowWarn( strMsg );
                return false;
            }

            int len, n = br.ReadInt32();

            byte[] Buf = new byte[ 256 ];
            for ( int i = 0 ; i < n ; i++ )
            {
                len = br.ReadInt32();
                Buf = br.ReadBytes( len );

                str[ i ] = "";
                for ( int j = 0 ; j < len ; j++ )
                {
                    str[ i ] += (char)Buf[ j ];
                }
            }

            string strTmp = str[ 0 ];
            GL.Param.Sql.IP = FF.Fun.SetXOP( strTmp, strSeed );

            strTmp = str[ 1 ];
            GL.Param.Sql.DB = FF.Fun.SetXOP( strTmp, strSeed );

            strTmp = str[ 2 ];
            GL.Param.Sql.User = FF.Fun.SetXOP( strTmp, strSeed );

            strTmp = str[ 3 ];
            GL.Param.Sql.Pass = FF.Fun.SetXOP( strTmp, strSeed );

            return true;
        }
    }
}
