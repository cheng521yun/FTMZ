using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Buss.优抚科
{
    public class PARAM
    {


        #region 对象

        public string[] GetStrs_对象类别()
        {
            return Def.Strs.优抚科.优抚对象.对象类别;
        }
        public string[] GetStrs_子对象类别( string str对象类别 )
        {
            if ( str对象类别 == "伤残人员" )
                return Def.Strs.优抚科.优抚对象.伤残人员;
            else if ( str对象类别 == "三属" )
                return Def.Strs.优抚科.优抚对象.三属;
            else if ( str对象类别 == "三红" )
                return Def.Strs.优抚科.优抚对象.三红;
            else if ( str对象类别 == "参战涉核人员" )
                return Def.Strs.优抚科.优抚对象.参战涉核人员;
            else if ( str对象类别 == "部分烈士(错杀被平反人员)子女" )
                return Def.Strs.优抚科.优抚对象.部分烈士_错杀被平反人员__子女;
            else if ( str对象类别 == "港澳老战士和烈属" )
                return Def.Strs.优抚科.优抚对象.港澳老战士和烈属;
            else if ( str对象类别 == "五老人员" )
                return Def.Strs.优抚科.优抚对象.五老人员;

            return new string[] { String.Empty };
        }

        #endregion
 

    }
}
