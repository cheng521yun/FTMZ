using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FrontFlag.Control;

namespace 福田民政.Forms.Work.数据管理.基层科.社区建设
{
    public partial class Find : XForm
    {
        public Def.dlgt.ActStr dlgtFind = null;
        public Def.dlgt.Act dlgtAdd = null;
        public Def.dlgt.Act dlgtExcelIn = null;
        public Def.dlgt.Act dlgtExcelOut = null;

        public Find()
        {
            InitializeComponent();

            ucListTool.dlgtAdd = Add;
            ucListTool.dlgtExcelIn = ExcelIn;
            ucListTool.dlgtExcelOut = ExcelOut;
        }

        private void Add()
        {
            if ( dlgtAdd != null )
                dlgtAdd();
        }

        private void ExcelIn()
        {
            if ( dlgtExcelIn != null )
                dlgtExcelIn();
        }
        private void ExcelOut()
        {
            if ( dlgtExcelOut != null )
                dlgtExcelOut();
        }
    }
}
