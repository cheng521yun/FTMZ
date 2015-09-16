using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Def.Pair.MenuCommand
{
    public class MENU_COMMAND
    {
        public string MenuText = String.Empty;
        public int nCommand = -1;
        public string strParam = String.Empty;
        //public object objParam = null;


        #region Comm Fun

        public static List<MENU_COMMAND> GetMenuCommandList( int nCommand, string[] strsMenuItemText, bool hasParam )
        {
            List<MENU_COMMAND> lstMenu = new List<MENU_COMMAND>();
            foreach ( string str in strsMenuItemText )
            {
                MENU_COMMAND stru = new MENU_COMMAND()
                {
                    MenuText = str,
                    nCommand = nCommand,
                    strParam = hasParam ? str : String.Empty,
                };
                lstMenu.Add( stru );
            }

            return lstMenu;
        }

        public static List<MENU_COMMAND> GetMenuCommandList( int nCommand, string[] strsMenuItemText )
        {
            return GetMenuCommandList( nCommand, strsMenuItemText, true );
        }

        #endregion
    }
}
