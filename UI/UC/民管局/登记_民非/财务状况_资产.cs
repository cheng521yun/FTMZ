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
    public partial class 财务状况_资产 : UserControl
    {
        public 财务状况_资产()
        {
            InitializeComponent();
        }

        private void 财务状况_资产_Load( object sender, EventArgs e )
        {
            InitList();
        }

        private void InitList()
        {
            fl.SetGrdFld( new COLHEAD[] 
                { 
                    new COLHEAD("年份",""),
                    new COLHEAD("",""),
                    new COLHEAD("",""),
                    new COLHEAD("",""),
                    new COLHEAD("",""),
                    new COLHEAD("",""),
                    new COLHEAD("",""),
   
                } );
        }
    }
}
