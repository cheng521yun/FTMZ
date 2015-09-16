using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FrontFlag.Control;
using 福田民政.Forms.Work.数据管理.事务科.低收入居民数据.Tab.家庭成员;

namespace 福田民政.Forms.Work.数据管理.事务科.社会救助.Tab
{
    public partial class 家庭成员 : XForm
    {

        public 家庭成员()
        {
            InitializeComponent();
        }

        private void 成员信息_Load( object sender, EventArgs e )
        {
            LoadForm();
        }

        private void LoadForm()
        {
            InitList();
            InitTool();
        }

        private void InitList()
        {
            fl.SetGrdFld( new COLHEAD[] 
                { 
                    new COLHEAD("ID","ID"),
                    new COLHEAD("姓名",""),
                    new COLHEAD("性别",""),
                    new COLHEAD("身份证号码",""),
                    new COLHEAD("家庭人数",""),
                    new COLHEAD("保障人数",""),
                    new COLHEAD("家庭月收入",""),
                    new COLHEAD("成员类型",""),
                } );

            fl.strIDCol = "ID";
        }

        private void InitTool()
        {
            ButnTool fTool= new ButnTool();
            Form f = (Form) fTool;
            fl.AddFootPnl( ref f );

            fTool.dlgtAdd = Add;
            fTool.dlgtDelete = Delete;

        }

        private void Add()
        {
            //MessageBox.Show("Add");
            Edit fm = new Edit();
            fm.ShowDialog();
        }

        private void Delete()
        {
            MessageBox.Show( "Delete" );
        }
    }
}
