using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FrontFlag.Control;

namespace 福田民政.Forms.Work.数据管理.基层科.数据统计.Tab
{
    public partial class 民主管理信息管理 : XForm
    {

        public 民主管理信息管理()
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
                    new COLHEAD("本级社区居委会数","",160),
                    new COLHEAD("需要换届选举的社区居委会数","",200),
                    new COLHEAD("社区综合党组织班子总职数","",200),
                    new COLHEAD("社区居委会班子总职数","",200),
                    new COLHEAD("连选连任的成员数","",160),
                    new COLHEAD("与社区综合党组织交叉任职的成员数","",240),
                    new COLHEAD("与居委会党支部交叉任职的成员数","",240),
                    new COLHEAD("党员",""),                    
                    new COLHEAD("妇女",""),
                    new COLHEAD("在本居委会居住的居民当选成员数","",240),
                    new COLHEAD("非本市户籍居民当选成员数","",200),
                    new COLHEAD("大学生“村官”当选成员数","",200),
                } );

            fl.strIDCol = "ID";
        }

        private void InitTool()
        {
            //ButnTool fTool= new ButnTool();
            //Form f = (Form) fTool;
            //fl.AddFootPnl( ref f );

            //fTool.dlgtAdd = Add;
            //fTool.dlgtDelete = Delete;

        }

        private void Add()
        {
            MessageBox.Show("Add");
        }

        private void Delete()
        {
            MessageBox.Show( "Delete" );
        }
    }
}
