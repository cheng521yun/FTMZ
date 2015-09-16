using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FrontFlag.Control;

namespace 福田民政.Forms.Work.数据管理.老龄办.老龄津贴_停发
{
    public partial class Tool : XForm
    {
        public Def.dlgt.Act dlgt停发老龄津贴 = null; 

        public Tool()
        {
            InitializeComponent();
        }

        private void 发放_Load( object sender, EventArgs e )
        {
            LoadForm();
        }

        void LoadForm()
        {
            btn停发.dlgtRun = 发放优待证;
        }

        private void 发放优待证()
        {
            if ( dlgt停发老龄津贴 != null )
                dlgt停发老龄津贴();
        }
    }
}
