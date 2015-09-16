using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FrontFlag;

namespace UI.DefCtrl.Cmb.优抚科
{
    public class Cmb户口簿住址类别 : CmbList 
    {
        public Cmb户口簿住址类别()
        {
            if ( !DesignMode )
                SetItem( Def.Strs.优抚科.优抚对象.户口簿上住址类别 );
        }
    }
}
