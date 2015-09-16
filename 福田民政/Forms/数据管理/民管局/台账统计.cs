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
    public partial class 台账统计 : XForm
    {
        public 台账统计()
        {
            InitializeComponent();
        }

        private void 台账统计_Load( object sender, EventArgs e )
        {
            LoadForm();
        }

        private void LoadForm()
        {
            Act.Entry_数据管理_民管局_台账统计 += Call;
        }

        private void Call( object obj )
        {
            ShowMe();
        }
    }
}
