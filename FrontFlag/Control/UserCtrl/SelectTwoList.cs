using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace FrontFlag.Control.UserCtrl
{
    public partial class SelectTwoList : UserControl
    {
        public delegate void DGT_Param0();
        public DGT_Param0 dgtOK = null;
        public DGT_Param0 dgtCancel = null;

        private List<string> _lstResulut = new List<string>();

        public SelectTwoList()
        {
            InitializeComponent();
        }

        #region 属性

        public string strLeftTitle 
        {
            set { labLeftTitle.Text = value; UpdateUI_Title(); }
        }

        public string strRightTitle
        {
            set { labRightTitle.Text = value; UpdateUI_Title(); }
        }

        /// <summary>
        /// 可以通过这个属性，获取设置结果
        /// </summary>
        public List<string> lstResulut
        {
            get { return _lstResulut; }
        }

        #endregion

        #region event

        private void SelectTwoList_Load( object sender, EventArgs e )
        {
            LoadForm();
        }

        private void btnAdd_Click( object sender, EventArgs e )
        {
            Add();
        }

        private void btnRemove_Click( object sender, EventArgs e )
        {
            Remove();
        }

        private void btnOK_Click( object sender, EventArgs e )
        {
            OK();
        }

        private void btnCancel_Click( object sender, EventArgs e )
        {
            Cancel();
        }

        #endregion

        void LoadForm()
        {
            UpdateUI_Title();
        }

        void UpdateUI_Title()
        {
            pnlLeftTitle.Visible = !String.IsNullOrEmpty( labLeftTitle.Text.Trim() );
            pnlRightTitle.Visible = !String.IsNullOrEmpty( labRightTitle.Text.Trim() );
        }

        #region public

        public void SetAll( List<string> lst )
        {
            lstAll.Items.Clear();
            foreach ( string str in lst )
            {
                lstAll.Items.Add( str );
            }
        }

        public void SetInitSelect( List<string> lst )
        {
            ClearSelect();
            Add( lst ); 
        }

        #endregion

        bool InListView( string str, ListView lst )
        {
            foreach ( ListViewItem li in lst.Items )
            {
                if ( str == li.SubItems[0].Text )
                    return true;
            }

            return false;
        }

        void Add()
        {
            string str;

            foreach ( ListViewItem li in lstAll.SelectedItems )
            {
                str = li.SubItems[0].Text;

                if ( !InListView( str, lstSelect ) )
                {
                    ListViewItem li2 = new ListViewItem( str );
                    lstSelect.Items.Add( li2 );
                }
            }
        }

        void Add ( List<string> lstAdd  )
        {
            foreach ( string str in lstAdd )
            {
                if ( !InListView( str, lstSelect ) )
                {
                    ListViewItem li = new ListViewItem(str);
                    lstSelect.Items.Add(li);
                }
            }
        }

        void ClearSelect()
        {
            lstSelect.Items.Clear();
        }

        void Remove()
        {
            foreach ( ListViewItem li in lstSelect.SelectedItems )
                lstSelect.Items.Remove( li );
        }

        void OK()
        {
            _lstResulut.Clear();

            string str;
            foreach ( ListViewItem li in lstSelect.Items )
            {
                str = li.SubItems[0].Text;
                _lstResulut.Add( str );
            }

            if ( dgtOK != null )
                dgtOK();
        }

        void Cancel()
        {
            if ( dgtCancel != null )
                dgtCancel();
        }
    }
}
