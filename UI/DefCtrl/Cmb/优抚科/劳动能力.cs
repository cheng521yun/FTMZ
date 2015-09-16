using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FrontFlag;

namespace UI.DefCtrl.Cmb.优抚科
{
    public class Cmb劳动能力 : CmbList 
    {
        public Cmb劳动能力()
        {
            if ( !DesignMode )
                SetItem( Def.Strs.优抚科.优抚对象.劳动能力 );
        }
    }
}
