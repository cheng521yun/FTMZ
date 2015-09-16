using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FrontFlag.Control;
using FrontFlag.Control.Menu;

namespace 福田民政
{
    public partial class Test : Form
    {
        public Test()
        {
            InitializeComponent();
        }

        private void menuItem01ToolStripMenuItem_DisplayStyleChanged( object sender, EventArgs e )
        {

        }

        private void menuItem01ToolStripMenuItem_Click( object sender, EventArgs e )
        {

        }

        private void Test_Load( object sender, EventArgs e )
        {
            LoadForm();
        }

        private void LoadForm()
        {
            PERMISSION p = new PERMISSION();
            p.CanEnable = false;

            MenuItem01.SetPermission( p );

            p = new PERMISSION();
            p.CanShow = false;
            MenuItem02.SetPermission( p );


            XToolStripMenuItem itemA = new XToolStripMenuItem( "", "xxx", 99 );
            itemA.dlgtAction = ActionMe;
            menu.Items.Add( itemA );

            XToolStripMenuItem itemB = new XToolStripMenuItem( "", "yyy", 100 );
            itemB.dlgtAction = ActionMe;
            itemA.DropDownItems.Add( itemB );

            p = new PERMISSION();
            p.CanEnable = false;
            itemB.SetPermission( p );

        }

        private void ActionMe(int n)
        {
            MessageBox.Show(n.ToString());
        }

        private void button1_Click( object sender, EventArgs e )
        {

        }

        private void button1_MouseDown( object sender, MouseEventArgs e )
        {
            MouseEventArgs Mouse_e = (MouseEventArgs)e;

            if ( Mouse_e.Button == MouseButtons.Right )
            {
                //MessageBox.Show( "右键!" );
                Button btn = sender as Button;
                //ContextMenu menu btn.ContextMenu.GetContextMenu();

                menu.Visible = false;
                //btn.ContextMenu.
            }  
        }
    }
}
