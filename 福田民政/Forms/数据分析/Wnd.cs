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

namespace 福田民政.Forms.数据分析
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
            //Act.Entry老龄办 += Call;

            InitForm();
        }

        private void InitForm()
        {
            AddFormList( typeof( 福田民政.Forms.数据分析.老龄办.Wnd ), Def.FormId.数据分析_老龄办 );
            AddFormList( typeof( 福田民政.Forms.数据分析.民管局.Wnd ), Def.FormId.数据分析_民管局 );
            AddFormList( typeof( 福田民政.Forms.数据分析.事务科.Wnd ), Def.FormId.数据分析_事务科 );
            AddFormList( typeof( 福田民政.Forms.数据分析.基层科.Wnd ), Def.FormId.数据分析_基层科 );
            AddFormList( typeof( 福田民政.Forms.数据分析.优抚科.Wnd ), Def.FormId.数据分析_优抚科 );
            AddFormList( typeof( 福田民政.Forms.数据分析.福利中心.Wnd ), Def.FormId.数据分析_福利中心 );
        }

        private void Call( object obj )
        {
            //MessageBox.Show( "in 老龄办" );

            ShowMe();
        }
    }
}
