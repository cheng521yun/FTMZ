using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Global;

namespace UI.Ctrl.Btn
{
    public partial class LeftMenuBtn : UserControl
    {
        public Def.dlgt.ActStr dlgtRun = null ;
        private int _nCommandId = -1;

        public LeftMenuBtn()
        {
            InitializeComponent();

            Init();
        }

        #region Event

        private void labCaption_Click( object sender, EventArgs e )
        {
            DoCommand();
        }

        private void labCaption_MouseEnter( object sender, EventArgs e )
        {
            Fouce();
        }

        private void labCaption_MouseLeave( object sender, EventArgs e )
        {
            UnFouce();
        }

        private void LeftMenuBtn_Click( object sender, EventArgs e )
        {
            DoCommand();
        }

        private void LeftMenuBtn_MouseEnter( object sender, EventArgs e )
        {
            Fouce();
        }

        private void LeftMenuBtn_MouseLeave( object sender, EventArgs e )
        {
            UnFouce();
        }

        #endregion

        public string btnCaption
        {
            set { labCaption.Text = value; }
            get { return labCaption.Text; }
        }

        private void Init()
        {
            SetBtnColor_Comm();
        }

        public void Set(string strCaption, int nCommandID)
        {
            labCaption.Text = strCaption;
            _nCommandId = nCommandID;
        }

        private void DoCommand()
        {
            if (_nCommandId == -1)
            {
                DoDelgt();
                return;
            }

            GL.Command.Excute(_nCommandId);
        }


        private void DoDelgt()
        {
            string strCaption = labCaption.Text;
            if (dlgtRun != null)
                dlgtRun( strCaption );
        }

        private void Fouce()
        {
            SetBtnColor_Selected();
            this.labCaption.Font = new System.Drawing.Font( "宋体", 9F, ( (System.Drawing.FontStyle)( ( System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline ) ) ), System.Drawing.GraphicsUnit.Point, ( (byte)( 134 ) ) );
        }

        private void UnFouce()
        {
            SetBtnColor_Comm();
            this.labCaption.Font = new System.Drawing.Font( "宋体", 9F, ( (System.Drawing.FontStyle)( ( System.Drawing.FontStyle.Bold ) ) ), System.Drawing.GraphicsUnit.Point, ( (byte)( 134 ) ) );
        }

        #region  Button

        private void SetBtnColor( Color clr )
        {
            labCaption.ForeColor = clr;
        }

        private void SetBtnColor_Comm()
        {
            SetBtnColor( Def.Style.SysColor.LeftPnl_Btn_Comm );
        }
        private void SetBtnColor_Selected()
        {
            SetBtnColor( Def.Style.SysColor.LeftPnl_Btn_Selected );
        }

        #endregion


    }


}
