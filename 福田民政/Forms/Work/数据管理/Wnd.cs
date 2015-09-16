using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using FrontFlag.Control;

namespace 福田民政.Forms.数据管理
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
            Def.Act.Menu.Entry_数据管理_老龄办 += Call;

            InitForm();
        }

        private void InitForm()
        {
            AddFormList( typeof( 福田民政.Forms.数据管理.老龄办.Wnd ), Def.FormId.数据管理_老龄办 );
            AddFormList( typeof( 福田民政.Forms.数据管理.民管局.Wnd ), Def.FormId.数据管理_民管局 );
            AddFormList( typeof( 福田民政.Forms.数据管理.事务科.Wnd ), Def.FormId.数据管理_事务科 );
            AddFormList( typeof( 福田民政.Forms.数据管理.基层科.Wnd ), Def.FormId.数据管理_基层科 );
            AddFormList( typeof( 福田民政.Forms.数据管理.优抚科.Wnd ), Def.FormId.数据管理_优抚科 );
            AddFormList( typeof( 福田民政.Forms.数据管理.福利中心.Wnd ), Def.FormId.数据管理_福利中心 );
        }

        private void Call( object obj )
        {
            //MessageBox.Show( "in 老龄办" );

            ShowMe();
        }
    }
}
