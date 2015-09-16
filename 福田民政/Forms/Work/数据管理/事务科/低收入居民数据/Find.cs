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

namespace 福田民政.Forms.Work.数据管理.事务科.社会救助
{
    public partial class Find : XForm
    {
        public Def.dlgt.Act dlgtAddNew = null;
        public Def.dlgt.Act dlgtDelete = null;
        public Def.dlgt.ActStr dlgtFind = null;

        public Find()
        {
            InitializeComponent();
        }

        private void Find_Load( object sender, EventArgs e )
        {
            LoadForm();
        }



        private void LoadForm()
        {
            btnAdd.dlgtRun = Add;
            //btnDelete.dlgtRun = Add;
            btnFind.dlgtClickFind = RunFind;
        }

        private void Add()
        {
            if ( dlgtAddNew != null )
                dlgtAddNew();
        }

        private void Delete()
        {
            if ( dlgtDelete != null )
                dlgtDelete();
        }



        private void RunFind()
        {
            List<string> lst = new List<string>();
            string str;

            str = txt姓名.Text.Trim();
            if( ! String.IsNullOrEmpty( str ) )
                lst.Add( String.Format( "{0} like '%{1}%'", DB.Tab.事务科.低收入居民.户主姓名, str ) );

            str = txtSFZ.Text.Trim();
            if ( !String.IsNullOrEmpty( str ) )
                lst.Add( String.Format( "{0} like '%{1}%'", DB.Tab.事务科.低收入居民.身份证, str ) );

            string strWhere = FF.Str.Where.GetWhereByList(lst);

            if ( dlgtFind != null )
                dlgtFind( strWhere );
        }




    }
}
