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
    public partial class 台账列表 : XForm
    {
        public 台账列表()
        {
            InitializeComponent();
        }

        private void 台账列表_Load( object sender, EventArgs e )
        {
            LoadForm();
        }

        private void LoadForm()
        {
            Act.Entry_数据管理_民管局_台账列表 += Call;
        }

        private void Call( object obj )
        {
            ShowMe();
        }
    }
}
