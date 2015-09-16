using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FrontFlag;
using FrontFlag.Control;

namespace 福田民政.Forms.Work.数据管理.老龄办.老龄津贴_停发
{
    public partial class FFind : XForm
    {
        public Def.dlgt.ActStr dlgtFind = null;
        public Def.dlgt.Act dlgtAdd = null;

        public FFind()
        {
            InitializeComponent();

            btnFind.dlgtClickFind = Find;
        }

        private void Find()
        {
            List<string> lst = new List<string>();
            string str;

            str = txt姓名.Text.Trim();
            if ( !String.IsNullOrEmpty( str ) )
                lst.Add( String.Format( "{0} like '%{1}%'", DB.Tab.老龄办.停发老龄津贴.姓名, str ) );

            str = txtSFZ.Text.Trim();
            if ( !String.IsNullOrEmpty( str ) )
                lst.Add( String.Format( "{0} like '%{1}%'", DB.Tab.老龄办.停发老龄津贴.身份证, str ) );

            string strWhere = FF.Str.Where.GetWhereByList( lst );

            if ( dlgtFind != null )
                dlgtFind( strWhere );
        }

        private void FFind_Load( object sender, EventArgs e )
        {
            LoadForm();
        }

        private void LoadForm()
        {
            ucListTool.dlgtAdd = Add;
        }

        private void Add()
        {
            if (dlgtAdd != null)
                dlgtAdd();
        }
    }
}
