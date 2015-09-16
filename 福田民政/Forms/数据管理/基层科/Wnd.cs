using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Def.Delegate;
using FrontFlag.Control;
using Global;

namespace 福田民政.Forms.数据管理.基层科
{
    public partial class Wnd : XForm
    {
        public Wnd()
        {
            InitializeComponent();
        }

        private void Wnd_Load( object sender, EventArgs e )
        {
            LoadForm();
        }
        private void LoadForm()
        {
            InitForm();
            Act.Entry_数据管理_基层科 += Call;
        }

        void InitForm()
        {
            AddFormList( typeof( 福田民政.Forms.数据管理.基层科.民主管理信息管理 ), Def.FormId.数据管理_基层科_民主管理信息管理 );
            AddFormList( typeof( 福田民政.Forms.数据管理.基层科.社区建设信息管理 ), Def.FormId.数据管理_基层科_社区建设信息管理 );
            AddFormList( typeof( 福田民政.Forms.数据管理.基层科.社区服务信息管理 ), Def.FormId.数据管理_基层科_社区服务信息管理 );
            AddFormList( typeof( 福田民政.Forms.数据管理.基层科.数据统计 ), Def.FormId.数据管理_基层科_数据统计 );
        }

        private void Call( object obj )
        {
            ShowDefaultForm();
        }

        private void ShowDefaultForm()
        {
            GL.Command.Excute( Def.CommandId.数据管理_基层科_民主管理信息管理 );
        }
    }
}
