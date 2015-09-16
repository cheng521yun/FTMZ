using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FrontFlag;

namespace UI.DefCtrl.Cmb.优抚科
{
    public class Cmb婚姻状况 : CmbList 
    {
        public Cmb婚姻状况()
        {
            if ( !DesignMode )
                SetItem( Def.Strs.优抚科.优抚对象.婚姻状况 );
        }
    }
}
