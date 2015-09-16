using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FrontFlag;

namespace UI.DefCtrl.Cmb.优抚科
{
    public class Cmb生活能力 : CmbList 
    {
        public Cmb生活能力()
        {
            if ( !DesignMode )
                SetItem( Def.Strs.优抚科.优抚对象.生活能力 );
        }
    }
}
