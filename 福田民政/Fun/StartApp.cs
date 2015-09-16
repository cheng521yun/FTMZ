using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Global;
using Utility;
using Buss;
using 福田民政.Forms.LogIn;

namespace 福田民政.Fun
{
    public class StartApp
    {
        public static bool Ready()
        {
            bool bRet = true;

            GL.Path.StartUp = Application.StartupPath;

            if ( !Util.File.Key.ReadKey() )
                return false;

            if ( !Login() )
                return false;

            LoadParam();

            return bRet;
        }

        static bool Login()
        {
            FLogin fm = new FLogin();
            if (fm.ShowDialog() != DialogResult.OK)
                return false;

            return fm.bCheckOK;
        }

        static private void LoadParam()
        {
            GL.Param.WebUrl = BL.Dict.GetValue( "SysParam/WebUrl" );
        }
    }
}
