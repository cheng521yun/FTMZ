using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FrontFlag;
using UI.DefCtrl;

namespace UI.DefCtrl.Cmb
{
    public class Cmb性别 : CmbList 
    {
        public Cmb性别()
        {
            if ( ! DesignMode )
                SetItem( Def.Strs.优抚科.优抚对象.性别 );
        }
    }
}
