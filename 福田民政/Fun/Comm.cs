using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Def.Type;

namespace 福田民政.Fun
{
    public class Comm
    {
        static public bool CopyDt(System.Data.DataTable dtFrom, System.Data.DataTable dtTo, List<IntStr> lstIS )
        {
            foreach ( DataRow drFrom in dtFrom.Rows )
            {
                DataRow drTo = dtTo.NewRow();

                bool bValid = false;
                foreach ( IntStr IS in lstIS )
                {
                    if ( !String.IsNullOrEmpty( IS.strVal.Trim() ) && !String.IsNullOrEmpty(drFrom[ IS.nNo ].ToString().Trim() ) )
                    {
                        drTo[IS.strVal] = drFrom[IS.nNo];
                        bValid = true;
                    }
                }

                if ( bValid )
                    dtTo.Rows.Add(drTo);
            }

            return true;
        }

        static public string GetExcelFile()
        {
            string strCurPath = Environment.CurrentDirectory;

            OpenFileDialog Dlg = new System.Windows.Forms.OpenFileDialog();

            Dlg.DefaultExt = ".xls";
            Dlg.Filter = "xls files (*.xls)|*.xls";
            Dlg.InitialDirectory = Application.StartupPath;

            DialogResult ret = Dlg.ShowDialog();

            Environment.CurrentDirectory = strCurPath;

            if ( ret != DialogResult.OK )
                return String.Empty;


            return Dlg.FileName;
        }
    }
}
