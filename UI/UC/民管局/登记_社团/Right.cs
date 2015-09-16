using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FrontFlag.Control;
using UI.UC.民管局.登记_民非;

namespace UI.UC.民管局.登记_社团
{
    public partial class Right : XForm
    {
        法定代表人 f法定代表人 = new 法定代表人();
        联系信息 f联系信息 = new 联系信息();
        组织管理架构 f组织管理架构 = new 组织管理架构();
        会员情况 f会员情况 = new 会员情况();
        财务状况 f财务状况 = new 财务状况();
        机构章程 f机构章程 = new 机构章程();

        public Right()
        {
            InitializeComponent();
        }

        private void Right_Load( object sender, EventArgs e )
        {
            LoadForm();
        }

        private void LoadForm()
        {
            f联系信息.SetParent( this );
            f法定代表人.SetParent( this );
            f组织管理架构.SetParent( this );
            f会员情况.SetParent( this );
            f财务状况.SetParent( this );
            f机构章程.SetParent( this );

            //
            ShowWnd("法定代表人");
        }

        private void HideAll()
        {
            f联系信息.Hide();
            f法定代表人.Hide();
            f组织管理架构.Hide();
            f会员情况.Hide();
            f财务状况.Hide();
            f机构章程.Hide();
        }

        public void ShowWnd(string strName)
        {
            HideAll();

            if ( strName == "法定代表人" )
                f法定代表人.Show();

            else if ( strName == "联系信息" )
                f联系信息.Show();

            else if ( strName == "组织管理架构" )
                f组织管理架构.Show();

            else if ( strName == "会员情况" )
                f会员情况.Show();

            else if ( strName == "财务状况" )
                f财务状况.Show();

            else if ( strName == "机构章程" )
                f机构章程.Show();

        }
    }
}
