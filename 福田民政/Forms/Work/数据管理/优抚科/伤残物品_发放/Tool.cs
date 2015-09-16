using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FrontFlag.Control;

namespace 福田民政.Forms.Work.数据管理.优抚科.伤残物品_发放
{
    public partial class Tool : XForm
    {
        public Def.dlgt.Act dlgtSave = null;
        public Def.dlgt.Act dlgtDelete = null;
        public Def.dlgt.Act dlgtExcelIn = null;

        public Tool()
        {
            InitializeComponent();
        }

        private void Tool_Load( object sender, EventArgs e )
        {
            btnSave.dlgtRun = Save;
            btnDelete.dlgtRun = Delete;
            btnExcelIn.dlgtRun = ExcelIn;
        }

        private void Save()
        {
            if (dlgtSave != null)
                dlgtSave();
        }

        private void Delete()
        {
            if ( dlgtDelete != null )
                dlgtDelete();
        }

        private void ExcelIn()
        {
            if ( dlgtExcelIn != null )
                dlgtExcelIn();
        }
    }
}
