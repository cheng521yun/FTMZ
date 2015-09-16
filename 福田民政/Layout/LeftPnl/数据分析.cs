using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using FrontFlag.Control;

namespace 福田民政.Layout.LeftPnl
{
    public partial class 数据分析 : XForm
    {
        public 数据分析()
        {
            InitializeComponent();
        }

        private void 民管局_Load( object sender, EventArgs e )
        {
            LoadForm();
        }

        private void LoadForm()
        {
            //Act.Entry民管局 += Call;
        }

        private void Call( object obj )
        {
            ShowMe();
        }
    }
}
