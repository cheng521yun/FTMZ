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

namespace 福田民政.Forms.数据管理.老龄办
{
    public partial class Wnd : XForm
    {
        public Wnd()
        {
            InitializeComponent();
        }

        #region Event

        private void FWnd_Load( object sender, EventArgs e )
        {
            LoadForm();
        }

        #endregion

        private void LoadForm()
        {
            InitForm();
            Act.Entry_数据管理_老龄办 += Call;
        }

        void InitForm()
        {
            AddFormList( typeof( 福田民政.Forms.数据管理.老龄办.老龄优待证_发放 ), Def.FormId.数据管理_老龄办_老龄优待证_发放 );
            AddFormList( typeof( 福田民政.Forms.数据管理.老龄办.老龄优待证_统计 ), Def.FormId.数据管理_老龄办_老龄优待证_统计 );
            AddFormList( typeof( 福田民政.Forms.数据管理.老龄办.老龄津贴_发放 ), Def.FormId.数据管理_老龄办_老龄津贴_发放 );
            AddFormList( typeof( 福田民政.Forms.数据管理.老龄办.老龄津贴_停发 ), Def.FormId.数据管理_老龄办_老龄津贴_停发 );
        }

        private void Call( object obj )
        {
            ShowDefaultForm();
        }

        private void ShowDefaultForm()
        {
            GL.Command.Excute(Def.CommandId.数据管理_老龄办_老龄优待证_发放);
        }
    }
}
