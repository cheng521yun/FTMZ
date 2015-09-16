using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FrontFlag.Control;

namespace 福田民政.Forms.Work.数据管理.民管局.台账统计
{
    public partial class 其他管理 : XForm
    {
        public 其他管理()
        {
            InitializeComponent();
        }

        private void 其他管理_Load( object sender, EventArgs e )
        {
            LoadForm();
        }

        private void LoadForm()
        {
            InitList();
        }

        private void InitList()
        {
            fl.Title = "其他管理";

            fl.SetGrdFld( new COLHEAD[] 
                { 
                    new COLHEAD("ID","ID"),
                    new COLHEAD("身份证号码","身份证"),
                    new COLHEAD("姓名","姓名"),
                    new COLHEAD("性别","性别Str"),
                    new COLHEAD("电话","电话"),
                    new COLHEAD("手机","联系手机"),
                    new COLHEAD("地址","地址"),
                } );

            fl.strIDCol = "ID";
        }
    }
}
