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
    public partial class 机构信息 : XForm
    {
        public 机构信息()
        {
            InitializeComponent();
        }

        private void 机构信息_Load(object sender, EventArgs e)
        {
            LoadForm();
        }

        private void LoadForm()
        {
            InitList();
        }

        private void InitList()
        {
            fl.SetGrdFld( new COLHEAD[] 
                { 
                    new COLHEAD("备案日期","备案日期"),
                    new COLHEAD("机构名称","机构名称")
                } );
        }
    }
}
