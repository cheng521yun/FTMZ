using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using FrontFlag.Control;
using Global;

namespace 福田民政.Forms.数据管理.优抚科
{
    public partial class Wnd : XForm
    {
        public Wnd()
        {
            InitializeComponent();
        }

        private void Wnd_Load( object sender, EventArgs e )
        {
            InitForm();
            Def.Act.Menu.Entry_数据管理_优抚科 += Call;
        }

        void InitForm()
        {
            AddFormList( typeof( 福田民政.Forms.数据管理.优抚科.优抚对象_登记 ), Def.FormId.数据管理_优抚科_优抚对象_登记 );
            AddFormList( typeof( 福田民政.Forms.数据管理.优抚科.优抚对象_查询 ), Def.FormId.数据管理_优抚科_优抚对象_查询 );
            AddFormList( typeof( 福田民政.Forms.数据管理.优抚科.伤残物品_登记 ), Def.FormId.数据管理_优抚科_伤残物品_登记 );
            AddFormList( typeof( 福田民政.Forms.数据管理.优抚科.伤残物品_发放 ), Def.FormId.数据管理_优抚科_伤残物品_发放 );
            AddFormList( typeof( 福田民政.Forms.数据管理.优抚科.抚恤标准管理 ), Def.FormId.数据管理_优抚科_抚恤标准管理 );
            AddFormList( typeof( 福田民政.Forms.数据管理.优抚科.优抚资金发放 ), Def.FormId.数据管理_优抚科_优抚资金发放 );
        }

        private void Call( object obj )
        {
            if ( GL.User.Name == "LLB" )  //todo  test for 老龄办
            {
                GL.Command.Excute( Def.Command.Menu.首页 );
                return;
            } 

            ShowDefaultForm();
        }

        private void ShowDefaultForm()
        {
            GL.Command.Excute( Def.Command.Menu.数据管理_优抚科_优抚对象_登记 );
        }
    }
}
