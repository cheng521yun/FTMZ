using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FrontFlag.Control;

namespace 福田民政.Forms.数据管理.福利中心.老人入住
{
    public partial class 列表 : XForm
    {
        public 列表()
        {
            InitializeComponent();
        }

        private void fl_Load( object sender, EventArgs e )
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
                    new COLHEAD("姓名",""),
                    new COLHEAD("性别",""),
                    new COLHEAD("本人成份",""),
                    new COLHEAD("户籍所在地",""),
                    new COLHEAD("籍贯",""),
                    new COLHEAD("身份证",""),
                    new COLHEAD("家庭住址",""),
                    new COLHEAD("身体状况",""),
                    new COLHEAD("申请事由",""),
                    new COLHEAD("押金费用",""),

                } );

            fl.strIDCol = "ID";

            //fl.OnShowPage = ShowPage;
            //fl.OnSelectionChanged = SelectChange;
        }

    }
}
