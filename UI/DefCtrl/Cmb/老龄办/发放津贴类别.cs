using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FrontFlag;

namespace UI.DefCtrl.Cmb.老龄办
{
    public class Cmb发放津贴类别 : CmbList 
    {
        public Cmb发放津贴类别()
        {
            if ( !DesignMode )
                SetItem( Def.Strs.老龄办.发放津贴.类别 );
        }
    }
}
