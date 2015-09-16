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

namespace 福田民政.Forms.数据管理.事务科
{
    public partial class Wnd : XForm
    {
        public Wnd()
        {
            InitializeComponent();
        }

        #region Event

        private void Wnd_Load( object sender, EventArgs e )
        {
            LoadForm();
        }

        #endregion

        private void LoadForm()
        {
            InitForm();
            Act.Entry_数据管理_事务科 += Call;
        }

        void InitForm()
        {
            AddFormList( typeof( 福田民政.Forms.数据管理.事务科.社会救助 ), Def.FormId.数据管理_事务科_社会救助 );
            AddFormList( typeof( 福田民政.Forms.数据管理.事务科.临时救助 ), Def.FormId.数据管理_事务科_临时救助 );
            AddFormList( typeof( 福田民政.Forms.数据管理.事务科.居家养老服务补贴 ), Def.FormId.数据管理_事务科_居家养老服务补贴 );
            AddFormList( typeof( 福田民政.Forms.数据管理.事务科.救助统计 ), Def.FormId.数据管理_事务科_救助统计 );
        }

        private void Call( object obj )
        {
            ShowDefaultForm();
        }

        private void ShowDefaultForm()
        {
            GL.Command.Excute( Def.CommandId.数据管理_事务科_社会救助 );
        }
    }
}
