using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FrontFlag.Control;

namespace UI.UC.民管局.登记_民非
{
    public partial class 机构负责人 : UserControl
    {
        public 机构负责人()
        {
            InitializeComponent();
        }

        private void 机构负责人_Load( object sender, EventArgs e )
        {
            InitList();
        }


        private void InitList()
        {
                fl.SetGrdFld( new COLHEAD[] 
                { 
                    new COLHEAD("职位",""),
                    new COLHEAD("姓名",""),
                    new COLHEAD("性别",""),
                    new COLHEAD("学历",""),
                    new COLHEAD("是否留学",""),
                    new COLHEAD("出生日期",""),
                    new COLHEAD("联系电话",""),
   
                } );
        }
    }
}
