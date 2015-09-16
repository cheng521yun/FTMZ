using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Def.Delegate;
using FrontFlag.Control;

namespace 福田民政.Forms.数据管理.老龄办
{
    public partial class 老龄津贴_停发 : XForm
    {
        public 老龄津贴_停发()
        {
            InitializeComponent();
        }

        private void 老龄津贴_停发_Load( object sender, EventArgs e )
        {
            LoadForm();
        }

        private void LoadForm()
        {
            Act.Entry_数据管理_老龄办_老龄津贴_停发 += Call;
        }

        private void Call( object obj )
        {
            ShowMe();
        }
    }
}
