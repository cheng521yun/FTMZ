using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FrontFlag;

namespace UI.DefCtrl.Cmb.老龄办
{
    public class Cmb优待证类别 : CmbList 
    {
        public Cmb优待证类别()
        {
            if ( !DesignMode )
                SetItem( Def.Strs.老龄办.优待证.优待证类别 );
        }
    }
}
