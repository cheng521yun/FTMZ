using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Global.Res
{
    public class FILE
    {
        public string Home
        {
            get { return GetWeb_TemplateFile( Def.File.Template.Home ); }
        }

        //Fun
        private string GetWeb_TemplateFile( string strFile )
        {
            return String.Format( "file://{0}/{1}{2}", GL.Path.StartUp, Def.Path.Template, strFile );
        }
    }
}
