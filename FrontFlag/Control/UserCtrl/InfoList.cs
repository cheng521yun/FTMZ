using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FrontFlag.Control.UserCtrl
{
    public partial class InfoList : UserControl
    {
        public InfoList()
        {
            InitializeComponent();
        }

        #region Event

        private void grd_SelectionChanged( object sender, EventArgs e )
        {
            grd.ClearSelection();
        }

        private void InfoList_Load( object sender, EventArgs e )
        {
            LoadForm();
        }

        #endregion

        private void LoadForm()
        {
            //grd.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; 

            //grd.Columns[ 0 ].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            //grd.Columns[ 1 ].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill; 

            //设置爽缓冲
            //SetStyle( ControlStyles.DoubleBuffer | ControlStyles.OptimizedDoubleBuffer | ControlStyles.AllPaintingInWmPaint, true );
            //UpdateStyles();
        }

        //让最后一列撑满空间
        private void SetLastColumnFill()
        {
            int nCount = grd.Columns.Count;
            if ( nCount < 1 )
                return;

            int nLastCol = nCount - 1;
            grd.Columns[ nLastCol ].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        #region public

        public void SetGrdFld( COLHEAD[] ColHeads )
        {
            grd.SetGrdFld( ColHeads );
            SetLastColumnFill();
        }

        public void BindingList<T>( System.Collections.Generic.IList<T> list )
        {
            bindSrc.DataSource = new BindingList<T>( list );
        }

        public void Refresh()
        {
            grd.Bind( bindSrc );
        }

        #region Style

        public void SetLineColor( Color clr, Color clr2 )
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            dataGridViewCellStyle1.BackColor = clr;
            this.grd.DefaultCellStyle = dataGridViewCellStyle1;

            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            dataGridViewCellStyle2.BackColor = clr2;
            grd.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;

            grd.BackgroundColor = clr;
        }

        public void SetLineHeight( int nHeight )
        {
            grd.LineHight = nHeight;
        }

        public void SetListEnable( bool bFlag )
        {
            grd.Enabled = bFlag;
        }

        #endregion

        #endregion


    }
}
