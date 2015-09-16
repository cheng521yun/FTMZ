using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Buss;
using FrontFlag;

namespace UI.Ctrl.Cmb
{
    public partial class 优抚对象 : UserControl
    {
        public Def.dlgt.Act dlgtChange对象类别 = null;

        public 优抚对象()
        {
            InitializeComponent();
        }

        #region 属性

        public string str对象
        {
            get { return cmb对象类别.Text; }
        }
        public string str对象类别
        {
            get { return cmb子对象类别.Text; }
        }

        #endregion

        #region Event

        private void 优抚对象_Load( object sender, EventArgs e )
        {
            Init();
        }
        private void cmb对象类别_SelectedIndexChanged( object sender, EventArgs e )
        {
            Get子对象类别();

            if (dlgtChange对象类别 != null)
                dlgtChange对象类别();
        }

        #endregion

        private void Init()
        {
            string[] strs = BL.优抚科.Param.GetStrs_对象类别();
            FF.Ctrl.Combo.Strs2Combo( cmb对象类别, strs  );
        }

        private bool IsBlank( string[] strs )
        {
            if ( strs == null || strs.Length <= 0)
                return true ;

            if ( strs.Length == 1 || strs[0]==String.Empty )
                return true;

            return false;
        }

        private void Get子对象类别()
        {
            string str对象类别 = cmb对象类别.Text;
            string[] strs = BL.优抚科.Param.GetStrs_子对象类别( str对象类别 );

            if (IsBlank(strs))
            {
                cmb子对象类别.Hide();
            }
            else
            {
                cmb子对象类别.Show();
                FF.Ctrl.Combo.Strs2Combo(cmb子对象类别, strs);
            }
        }
    }
}
