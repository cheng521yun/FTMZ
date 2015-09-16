using System;
using System.Collections.Generic;
using System.Linq;
//using System.Threading.Tasks;
using System.Windows.Forms;
using 福田民政.Fun;

namespace 福田民政
{
    static class App
    {
        public static Core.CCommand Commander = new Core.CCommand();
        public static MainForm m_formMain = null;

        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault( false );

            bool bRet = StartApp.Ready();
            if ( !bRet )
                return;

            m_formMain = new MainForm();
            Application.Run( m_formMain );

            //Application.Run( new Test() );

            
        }
    }
}
