using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Def.Pair.MenuCommand;
using Global;

namespace UI.Ctrl.Tree
{
    public partial class LeftMenu : UserControl
    {
        public LeftMenu()
        {
            InitializeComponent();

            //tree.SetStyle( ControlStyles.SupportsTransparentBackColor, true );
            //BackColor = Color.FromArgb( 50, 40, 60, 82 );
        }

        public void SetMenu( List<MENU_COMMAND> lst )
        {
            foreach ( MENU_COMMAND stru in lst )
            {
                MENU_COMMAND tru = new MENU_COMMAND();
                tru.nCommand = stru.nCommand;

                TreeNode node = new TreeNode( stru.MenuText );
                node.Tag = tru;
                tree.Nodes.Add( node );
            }

            //
            SetTreeStyle();
        }

        public void SetSubMenu( int No,  List<MENU_COMMAND> lst)
        {
            if (tree.Nodes.Count <= No)
                return;

            TreeNode ParentNode = tree.Nodes[No];

            foreach ( MENU_COMMAND stru in lst )
            {
                TreeNode node = new TreeNode( stru.MenuText );
                node.Tag = stru;
                ParentNode.Nodes.Add( node );
            }

            //
            SetTreeStyle();
        }

        public void SetSubMenu( int No, int No2, List<MENU_COMMAND> lst )
        {
            if ( tree.Nodes.Count <= No )
                return;

            TreeNode ParentNode = tree.Nodes[ No ];

            if ( ParentNode.Nodes.Count <= No2 )
                return;

            ParentNode = ParentNode.Nodes[ No2 ];

            foreach ( MENU_COMMAND stru in lst )
            {
                TreeNode node = new TreeNode( stru.MenuText );
                node.Tag = stru;
                ParentNode.Nodes.Add( node );
            }

            //
            SetTreeStyle();
        }

        private void SetTreeStyle()
        {
            tree.ItemHeight = 30;

            string strFile = String.Format( @"{0}\Res\Skin\SideBar\{1}", System.Environment.CurrentDirectory, "SideBarBK.jpg" );
            Image img = new Bitmap( strFile );
            tree.Image = img;
        }

        private void tree_AfterSelect( object sender, TreeViewEventArgs e )
        {
            if ( e.Node.Tag == null )
                return;

            MENU_COMMAND stru = e.Node.Tag as MENU_COMMAND;
            GL.Command.Excute( stru.nCommand, stru.strParam );
        }
    }
}
