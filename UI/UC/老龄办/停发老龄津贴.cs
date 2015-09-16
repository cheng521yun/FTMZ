using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FrontFlag;
using Global;

namespace UI.UC.老龄办
{
    public partial class 停发老龄津贴 : UserControl
    {
        public Def.dlgt.Act dlgtFindPerson = null;
        DB.Stru.老龄办.停发老龄津贴 _stru = new DB.Stru.老龄办.停发老龄津贴();

        public 停发老龄津贴()
        {
            InitializeComponent();
        }

        #region 属性

        public DB.Stru.老龄办.停发老龄津贴 stru
        {
            set 
            { 
                _stru = value;
                SetData();
            }
            get
            {
                GetData();
                return _stru;
            }
        }

        #endregion

        private void 优待证_Load( object sender, EventArgs e )
        {
            btnFind.dlgtClickFind = FindPerson;

            uc街道办.bShow工作站 = false;
        }

        void SetData( )
        {
            txt姓名.Text = _stru.姓名;
            uc街道办.str街道办 = _stru.街道;
            txt身份证号码.Text = _stru.身份证;
            dat领取时间.strDate = _stru.停发日期;
            txt原因.Text = _stru.停发原因;

        }

        public void GetData()
        {
            if ( String.IsNullOrEmpty( _stru.Creator.Trim() ) )
                _stru.Creator = GL.User.Name;

            _stru.姓名 = txt姓名.Text.Trim();
            _stru.街道 = uc街道办.str街道办 ;
            _stru.身份证 = txt身份证号码.Text.Trim();
            _stru.停发日期 = dat领取时间.strDate;
            _stru.停发原因 = txt原因.Text.Trim()  ;

        }

        //private void btnFind_Load( object sender, EventArgs e )
        //{
        //    FindPersion();
        //}

        private void FindPerson()
        {
            if ( dlgtFindPerson != null )
                dlgtFindPerson();
        }

    }
}
