using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FrontFlag;

namespace 福田民政.Forms.Comm.人员
{
    public partial class 查找人员_Find : Form
    {
        public Def.dlgt.ActStr dlgtFind = null;

        public 查找人员_Find()
        {
            InitializeComponent();
        }

        private void btnFind_Click( object sender, EventArgs e )
        {
            Find();
        }

        private void Find()
        {
            List<string> lst = new List<string>();
            string str;

            str = txt姓名.Text.Trim();
            if (!string.IsNullOrEmpty(str))
                lst.Add( String.Format( "{0} like '%{1}%'", DB.Tab.人员.姓名, str ) );

            str = txt身份证.Text.Trim();
            if (! string.IsNullOrEmpty( str ) )
                lst.Add( String.Format( "{0} like '%{1}%'", DB.Tab.人员.身份证, str ) );

            str = txt手机.Text.Trim();
            if ( !string.IsNullOrEmpty( str ) )
                lst.Add( String.Format( "{0} like '%{1}%'", DB.Tab.人员.联系手机, str ) );

            string strWhere = FF.Str.Where.GetWhereByList(lst);
            
            if (dlgtFind != null)
                dlgtFind( strWhere );

        }

        private void 查找人员_Find_Load( object sender, EventArgs e )
        {
            LoadForm();
        }

        private void LoadForm()
        {
            btnAddNew.dlgtRun = AddNew;
        }

        private void AddNew()
        {
            F添加人员 fm = new F添加人员();
            if ( fm.ShowDialog() != DialogResult.OK )
                return;

            DB.Stru.人员 stru = fm.stru;

            string strWhere = String.Format("{0} like '%{1}%'", DB.Tab.人员.ID, stru.ID);

            if ( dlgtFind != null )
                dlgtFind( strWhere );
        }

    }
}
