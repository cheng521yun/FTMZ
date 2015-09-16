using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms.VisualStyles;
using FrontFlag;

namespace UI.DefCtrl.Cmb.优抚科
{
    public class Cmb伤残等级 : CmbList 
    {
        public Cmb伤残等级()
        {
            if ( !DesignMode )
                SetItem( Def.Strs.优抚科.优抚对象.伤残等级 );
        }
    }
}
