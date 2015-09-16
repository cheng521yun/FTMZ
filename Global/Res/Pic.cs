using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Global.Res
{
    public class PIC
    {
        public string CompanyLogo
        {
            get { return String.Format( @"{0}\{1}", GL.Path.StartUp, Def.Style.Pic.Logo ); }
        }
    }
}
