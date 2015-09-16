using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DB.Orm.优抚科.优抚对象.伤残人员;

namespace Buss.优抚科.优抚对象
{
    public class 伤残人员
    {
        DB.Orm.优抚科.优抚对象.伤残人员.基本信息 Orm基本信息 = new 基本信息();

        public DB.Stru.优抚科.优抚对象.伤残人员.基本信息 Save基本信息( DB.Stru.优抚科.优抚对象.伤残人员.基本信息 stru基本信息 )
        {
            string strID = Orm基本信息.Save(stru基本信息);
            stru基本信息.ID = strID;

            return stru基本信息;
        }
    }
}
