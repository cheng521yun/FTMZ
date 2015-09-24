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
    public partial class 联系信息 : XForm
    {
        public 联系信息()
        {
            InitializeComponent();
        }

        private void 联系信息_Load( object sender, EventArgs e )
        {
            InitList();
        }

        private void InitList()
        {
            fl.SetGrdFld( new COLHEAD[] 
                { 
                    new COLHEAD("住所","住所"),
                    new COLHEAD("公开办公电话","公开办公电话"),
                    new COLHEAD("机构网站","机构网站"),
                    new COLHEAD("机构固定联系人","机构固定联系人")
                } );
        }
    }
}
