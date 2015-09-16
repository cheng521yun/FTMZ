using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FrontFlag;

namespace 福田民政.Forms.Work.数据管理.老龄办.Comm.查找
{
    public partial class 已发老龄津贴老人_Find : Form
    {
        public Def.dlgt.ActStr dlgtFind = null;

        public 已发老龄津贴老人_Find()
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
                lst.Add( String.Format( "{0} like '%{1}%'", DB.Tab.老龄办.发放老龄津贴.姓名, str ) );

            str = txt身份证.Text.Trim();
            if (! string.IsNullOrEmpty( str ) )
                lst.Add( String.Format( "{0} like '%{1}%'", DB.Tab.老龄办.发放老龄津贴.身份证, str ) );

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
        }


    }
}
