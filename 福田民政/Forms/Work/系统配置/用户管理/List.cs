using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Buss;
using DB.Stru;
using FrontFlag.Control;

namespace 福田民政.Forms.Work.系统配置.用户管理
{
    public partial class List : XForm
    {
        public delegate void DLGTParamStru( DB.Stru.USER stru );

        public DLGTParamStru dlgtSelected = null;

        List<DB.Stru.USER> _lst职员 = new List<USER>();
        private string _strWhere = String.Empty;

        public List()
        {
            InitializeComponent();
        }

        private void List_Load( object sender, EventArgs e )
        {
            LoadForm();
        }

        private void LoadForm()
        {
            fl.SetGrdFld( new COLHEAD[] 
                { 
                    new COLHEAD("ID",""),
                    new COLHEAD("建立日期","CreateDate"),
                    new COLHEAD("创建人","Creator"),
                    new COLHEAD("姓名","Name"),
                    new COLHEAD("性别","GranderStr"),
                    new COLHEAD("角色","Role"),
                    new COLHEAD("状态	","Status"),
                } );

            fl.strIDCol = "ID";
            fl.OnDBClickCell = Modify;
        }


        public void LoadData()
        {
            ShowPage(0);
        }

        void ShowPage( int nPageNo )
        {
            _lst职员 = BL.User.GetWhere( _strWhere ); ;

            //
            Fill();
        }

        void Fill()
        {
            fl.SortBindingList( _lst职员 );
            fl.Refresh();
        }

         void Modify( int nRow, int nCol )
        {
            if ( nRow < 0 || nRow >= _lst职员.Count )
                return;

            DB.Stru.USER struSel = fl.grd.Rows[ nRow ].DataBoundItem as DB.Stru.USER;
            if ( struSel == null )
                return;

            //FEdit fm = new FEdit();
            //fm.stru出货 = struSel;
            //if ( fm.ShowDialog() != DialogResult.OK )
            //    return;

            //if ( fm.stru出货.ID == "" )   //delete
            //    _出货List.RemoveAt( nRow );
            //else    //modify
            //    _出货List[ nRow ] = fm.stru出货;

            if (dlgtSelected != null)
                dlgtSelected( struSel );
        }
    }

}
