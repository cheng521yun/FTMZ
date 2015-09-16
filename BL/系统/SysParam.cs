using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FrontFlag;

namespace Buss.系统
{
    public class SysParam
    {
        DB.Orm.系统.SysParam Orm =  new DB.Orm.系统.SysParam();

        public int GetVersion_Main()
        {
            int nVersion_Main = 0;

            string strWhere = String.Format("{0}='{1}'", DB.Tab.系统.SysParam.Param, "Version_Main");
            DB.Stru.系统.SysParam stru = Orm.GetFirst_ByWhere(strWhere);

            if (stru.IsValid())
            {
                nVersion_Main = FF.Fun.MyConvert.Str2Int(stru.Value);
            }

            return nVersion_Main;
        }

        public int GetVersion_Sub()
        {
            int nVersion_Main = 0;

            string strWhere = String.Format( "{0}='{1}'", DB.Tab.系统.SysParam.Param, "Version_Sub" );
            DB.Stru.系统.SysParam stru = Orm.GetFirst_ByWhere( strWhere );

            if ( stru.IsValid() )
            {
                nVersion_Main = FF.Fun.MyConvert.Str2Int( stru.Value );
            }

            return nVersion_Main;
        }

    }
}
