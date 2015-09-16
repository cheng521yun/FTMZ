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

namespace 福田民政.Forms.数据管理.福利中心
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
            Def.Act.Menu.Entry_数据管理_福利中心 += Call;
        }

        void InitForm()
        {
            AddFormList( typeof( 福田民政.Forms.数据管理.福利中心.老人入住管理 ), Def.FormId.数据管理_福利中心_老人入住管理 );
            AddFormList( typeof( 福田民政.Forms.数据管理.福利中心.老人退住管理 ), Def.FormId.数据管理_福利中心_老人退住管理 );
            AddFormList( typeof( 福田民政.Forms.数据管理.福利中心.老人费用管理_费用登记 ), Def.FormId.数据管理_福利中心_老人费用管理_费用登记 );
            AddFormList( typeof( 福田民政.Forms.数据管理.福利中心.老人费用管理_退费登记 ), Def.FormId.数据管理_福利中心_老人费用管理_退费登记 );
            AddFormList( typeof( 福田民政.Forms.数据管理.福利中心.老人费用统计 ), Def.FormId.数据管理_福利中心_老人费用统计 );
        }

        private void Call( object obj )
        {
            if (GL.User.Name == "LLB")  //todo  test for 老龄办
            {
                GL.Command.Excute( Def.Command.Menu.首页 );
                return;
            } 
            
            ShowDefaultForm();
        }

        private void ShowDefaultForm()
        {
            GL.Command.Excute( Def.Command.Menu.数据管理_福利中心_老人入住管理 );
        }
    }
}
