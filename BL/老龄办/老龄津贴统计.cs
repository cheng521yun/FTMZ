using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Buss.老龄办
{
    public class 老龄津贴统计
    {
        DB.Orm.老龄办.发放老龄津贴 orm发放 = new DB.Orm.老龄办.发放老龄津贴();
        DB.Orm.老龄办.停发老龄津贴 orm停发 = new DB.Orm.老龄办.停发老龄津贴();

        public List<DB.Stru.老龄办.老龄津贴统计> Get_统计( string strWhere )
        {
            List<DB.Stru.老龄办.老龄津贴统计> lst = new List<DB.Stru.老龄办.老龄津贴统计>();

           

            return lst;
        }
    }
}
