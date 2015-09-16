/*
 * 检查系统运行环境
 * 
 * 
 */ 

using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Win32;

namespace FrontFlag.Sys
{
    public class CHECKENV
    {
        #region DotNet

        public bool InstallNet()
        {
            RegistryKey rk = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\NET Framework Setup", false);
            if (rk != null)
            {
                return true;
            }
            return false;
        }

        public bool InstallNet2()
        {
            RegistryKey rk = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\NET Framework Setup\NDP\v2.0.50727", false);
            if (rk != null)
            {
                string strRet = rk.GetValue("Install").ToString();
                if (strRet == "1")
                    return true;
            }
            return false;
        }

        public bool InstallNet35 ()
        {
            RegistryKey rk = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\NET Framework Setup\NDP\v3.5", false);
            if ( rk != null )
            {
                string strRet = rk.GetValue("Install").ToString();
                if (strRet == "1")
                    return true;
            }
            return false;
        }

        public bool InstallNet4_Client()
        {
            RegistryKey rk = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\NET Framework Setup\NDP\v4\Client", false);
            if (rk != null)
            {
                string strRet = rk.GetValue("Install").ToString();
                if (strRet == "1")
                    return true;
            }
            return false;
        }

        public bool InstallNet4_Full()
        {
            RegistryKey rk = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\NET Framework Setup\NDP\v4\Full", false);
            if (rk != null)
            {
                string strRet = rk.GetValue("Install").ToString();
                if (strRet == "1")
                    return true;
            }
            return false;
        }

        public bool InstallNet4()
        {
            return InstallNet4_Client() || InstallNet4_Full();
        }

        public string [] GetAllNetVersion()
        {
            string[] strs = null;
            RegistryKey rk = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\NET Framework Setup\NDP\", false);
            if (rk != null)
            {
                strs = rk.GetSubKeyNames();
            }
            return strs;
        }

        #endregion
    }
}
