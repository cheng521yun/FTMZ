using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FrontFlag;

namespace UI.DefCtrl.Cmb.优抚科
{
    public class Cmb就业情况 : CmbList 
    {
        public Cmb就业情况()
        {
            if ( !DesignMode )
                SetItem( Def.Strs.优抚科.优抚对象.就业情况 );
        }
    }
}
