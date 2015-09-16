using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FrontFlag.Control;

namespace UI.UC.民管局.登记_民非
{
    public partial class Left : XForm
    {
        public Def.dlgt.ActStr dlgtRun = null;

        public Left()
        {
            InitializeComponent();
        }

        private void Left_Load( object sender, EventArgs e )
        {
            btn法定代表人.dlgtRun = Run;
            btn联系信息.dlgtRun = Run;
            btn组织管理架构.dlgtRun = Run;
            btn财务状况.dlgtRun = Run;
            btn机构章程.dlgtRun = Run;
        }

        private void Run(string strCaption)
        {
            if (dlgtRun != null)
                dlgtRun( strCaption );
        }
    }
}
