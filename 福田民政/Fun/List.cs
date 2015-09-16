using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FrontFlag.Control;
using Global;

namespace 福田民政.Fun
{
    public class List
    {
        static public void SetCommStyle( FindList2 fl, string strListName )
        {
            string strExePath = System.Windows.Forms.Application.StartupPath;
            string strXmlFile = String.Format( @"{0}\Param\List.xml", strExePath );
            //string strRoot = String.Format( @"FTMZ/{0}/{1}", GL.User.Name, strListName );
            string strRoot = String.Format( @"FTMZ/{0}/{1}", "xtra", strListName );

            fl.grd.AllowSaveColWidth( strXmlFile, strRoot );

            //
            fl.grd.RestoreColWidth();

            //
            fl.grd.LineHight = 26;
            fl.grd.LineTextSize =12;
        }
    }
}
