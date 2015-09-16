using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using FrontFlag.Control;
using UI.Dlg;
using 福田民政.Forms.Comm.人员;
using 福田民政.Forms.Work.数据管理.老龄办.老龄津贴_停发;

namespace 福田民政.Forms.数据管理.老龄办
{
    public partial class 老龄津贴_停发 : WorkForm
    {
        FFind fFind = new FFind();
        列表 fList = new 列表();
        //Tool fTool = new Tool();


        public 老龄津贴_停发()
        {
            InitializeComponent();
        }

        protected override void Init()
        {
            strCaption = "老龄津贴 停发";
            Def.Act.Menu.Entry_数据管理_老龄办_老龄津贴_停发 += Call;

            InitForm();
            InitAction();
        }

        private void InitForm()
        {
            fFind.SetParent( pnlTop );
            fFind.dlgtFind = Find;
            fFind.dlgtAdd = 停发老龄津贴;

            fList.SetParent( pnlList );

            //fTool.SetParent( pnlBottom );
            //fTool.dlgt停发老龄津贴 = 停发老龄津贴;
        }

        private void InitAction()
        {
            //Def.Act.数据管理.老龄办.老龄津贴_停发 += Call老龄津贴_停发;
        }

        public override void ShowWnd()
        {
            Show();
            Find( String.Empty );
        }

        private void Find( string strWhere )
        {
            fList.Find( strWhere );
        }

        //private void Call老龄津贴_停发( object obj )
        //{
        //    //MessageBox.Show( "Call老龄津贴_发放" );
        //    F查找人员 fm = new F查找人员();
        //    if ( fm.ShowDialog() != DialogResult.OK )
        //        return;

        //    UI.Dlg.AskDlg dlg = new AskDlg();
        //    dlg.strNote = String.Format( "是否停发 {0} 的老龄津贴？", fm.stru.姓名 );
        //    if ( dlg.ShowDialog() != DialogResult.OK )
        //        return;

        //    MessageBox.Show( "停发" );
        //}

        private void 停发老龄津贴()
        {
            FEdit fm = new FEdit();
            if ( fm.ShowDialog() != DialogResult.OK )
                return;
        }
    }
}
