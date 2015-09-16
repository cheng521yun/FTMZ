using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using FrontFlag;

namespace DB.ORM.老龄办
{
    public partial class 老龄津贴统计
    {
        public List<DB.Stru.老龄办.老龄津贴统计> Get_统计( string strWhere )
        {
            DB.DA.老龄办.老龄津贴统计 da = new DB.DA.老龄办.老龄津贴统计();

            List<DB.Stru.老龄办.老龄津贴统计> lst = new List<Stru.老龄办.老龄津贴统计>();
            DataTable dt = da.Get统计( strWhere );

            if ( SQL.IsNotValid( ref dt ) )
                return lst;

            foreach ( DataRow dr in dt.Rows )
            {
                DB.Stru.老龄办.老龄津贴统计 stru = new Stru.老龄办.老龄津贴统计();
                stru.Dr2Stru_统计( dr );
                lst.Add( stru );
            }

            return lst;
        }
    }
}
