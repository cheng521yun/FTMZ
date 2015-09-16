using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;


/*
 * 注意：返回主窗口的页码是从 0 开始的。 
 * 
 * 
 */

namespace FrontFlag.Control
{
    public partial class NaviPageDlgEx : Form
    {
        public delegate void entSetNavi ( int nPage );
        public event entSetNavi SetNaviPage;

        int _nMaxPage = 1 ;

        bool _bShowCountNum = false ;

        public NaviPageDlgEx()
        {
            InitializeComponent ();
            SetMaxPage ( 1 );
            ShowCountNum ( false );
        }

        #region Public Set

        //nMax from 1 .
        public void SetMaxPage ( int nMax )
        {
            if ( nMax <= 0 )
                nMax = 1;         //即使按条件没有任何数据，listView上也要保留一页（空白页），如果不更新cmbPage控件， listview上的内容不会更新。

            _nMaxPage = nMax;

            this.cmbPage.Items.Clear ();
            for ( int i = 1 ; i <= _nMaxPage ; i ++ )
            {
                this.cmbPage.Items.Add ( i.ToString () );
            }
            cmbPage.SelectedIndex = 0 ;
        }

        public void SetMaxPage ( int nMax , int nRecCount )
        {
            SetMaxPage(nMax);
            SetRecCount( nRecCount ); 
        }

        //nCur from 0 .
        public void SetCurPage ( int nCur )
        {
            nCur ++ ;
            if ( nCur <= 0 || nCur > _nMaxPage )
                return;

            this.cmbPage.SelectedIndex = nCur - 1;
        }

        /// <summary>
        /// 是否显示记录的总条数。
        /// </summary>
        /// <param name="bFlag"></param>
        public void ShowCountNum ( bool bFlag )
        {
            _bShowCountNum = bFlag;
            labCount.Visible = _bShowCountNum;
        }

        public void SetBKColor ( Color clr )
        {
            this.BackColor = clr;
        }

        #endregion

        public void SetRecCount(int nCount)
        {
            if ( nCount == 0 )
                labCount.Hide ();
            else
            {
                if ( _bShowCountNum )
                    labCount.Show ();
            }

            labCount.Text = String.Format("{0}", nCount);
        }

        #region Event

        private void btnFirst_Click ( object sender , EventArgs e )
        {
            if ( this.SetNaviPage != null )
            {
                SetCurPage ( 0 );
            }    
        }

        private void btnPre_Click ( object sender , EventArgs e )
        {
            if ( this.SetNaviPage != null && this.cmbPage.SelectedIndex > 0 )
            {
                cmbPage.SelectedIndex --;
                SetCurPage ( cmbPage.SelectedIndex );
            }
        }

        private void btnNext_Click ( object sender , EventArgs e )
        {
            if ( this.SetNaviPage != null && this.cmbPage.SelectedIndex < _nMaxPage - 1 )
            {
                cmbPage.SelectedIndex ++;
                SetCurPage ( cmbPage.SelectedIndex );
            }
        }

        private void btnLast_Click ( object sender , EventArgs e )
        {
            if ( this.SetNaviPage != null )
            {
                SetCurPage ( _nMaxPage - 1 );
            }
        }

        void GetcmbPageSel()
        {
            int No = this.cmbPage.SelectedIndex;

            if (this.SetNaviPage != null)
                this.SetNaviPage(No);
        }

        private void OnKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                GetcmbPageText();
        }

        private void OnSelChange(object sender, EventArgs e)
        {
            GetcmbPageSel();
        }

        private void OnLoad(object sender, EventArgs e)
        {
        }

        #endregion

        void GetcmbPageText () 
        {
            int No ;
            try
            {
                No = int.Parse ( this.cmbPage.Text.Trim () );
            }
            catch ( Exception e )
            {
                cmbPage.SelectedIndex = 0;
                return;
            }

            if ( No <= 0 || No > _nMaxPage )
            {
                cmbPage.SelectedIndex = 0;
                return;
            }

            cmbPage.SelectedIndex = No - 1;    //index from 0 ; text from 1;

//            if ( this.SetNaviPage != null )
                //this.SetNaviPage ( cmbPage.SelectedIndex );   
        }


    }
}