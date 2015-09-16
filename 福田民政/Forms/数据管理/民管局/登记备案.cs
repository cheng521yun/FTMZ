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

namespace 福田民政.Forms.数据管理.民管局
{
    public partial class 登记备案 : XForm
    {
        public 登记备案()
        {
            InitializeComponent();
        }

        private void 登记备案_Load( object sender, EventArgs e )
        {
            LoadForm();
        }

        private void LoadForm()
        {
            Act.Entry_数据管理_民管局_登记备案 += Call;
        }

        private void Call( object obj )
        {
            ShowMe();
        }
    }
}
