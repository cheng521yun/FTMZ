using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FrontFlag;

namespace UI.DefCtrl.Cmb.优抚科
{
    public class Cmb伤残性质 : CmbList 
    {
        public Cmb伤残性质()
        {
            if ( !DesignMode )
                SetItem( Def.Strs.优抚科.优抚对象.伤残性质 );
        }
    }
}
