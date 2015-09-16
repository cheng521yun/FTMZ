using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FrontFlag.Control.Tree
{
    public class XTreeCtrl : System.Windows.Forms.TreeView
    {
        private Image mImage;
        public Image Image
        {
            get { return mImage; }
            set { mImage = value; Invalidate(); }
        }

        public XTreeCtrl() 
        {
            this.DrawMode = TreeViewDrawMode.OwnerDrawText;
        }


        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // XTreeCtrl
            // 
            this.ForeColor = System.Drawing.Color.White;
            this.LineColor = System.Drawing.Color.White;
            //this.DrawNode += new System.Windows.Forms.DrawTreeNodeEventHandler(this.XTreeCtrl_DrawNode);
            this.ResumeLayout(false);

        }

        protected override void OnAfterCollapse( TreeViewEventArgs e )
        {
            if ( mImage != null ) Invalidate();
            base.OnAfterCollapse( e );
        }
        protected override void OnAfterExpand( TreeViewEventArgs e )
        {
            //foreach ( TreeNode myNode in Nodes[ 0 ].Nodes )
            //{
            //    // Check whether the tree node is checked. 
            //    if (myNode.Checked)
            //    {
            //        // Set the node's backColor.
            //        myNode.ForeColor = Color.BlueViolet;
            //        myNode.BackColor = Color.Brown;

            //    }
            //    else
            //    {
            //        myNode.BackColor = Color.Transparent;
            //        myNode.ForeColor = Color.BurlyWood;
            //    }
            //}

            if ( mImage != null ) Invalidate();
            base.OnAfterExpand( e );
        }

        //private void treeView1_AfterSelect( object sender, TreeViewEventArgs e )
        //{
        //    if ( previousSelectedNode != null )
        //    {
        //        previousSelectedNode.BackColor = treeView1.BackColor;
        //        previousSelectedNode.ForeColor = treeView1.ForeColor;
        //    }
        //}


        protected override void WndProc( ref Message m )
        {
            base.WndProc( ref m );
            if ( m.Msg == 0x14 && mImage != null )
            {
                using ( var gr = Graphics.FromHdc( m.WParam ) )
                {
                    gr.DrawImage( mImage, Point.Empty );
                }
            }
        }

        SolidBrush greenBrush = new SolidBrush( Color.Green );
        SolidBrush redBrush = new SolidBrush( Color.Red );

        //private void CustomDrawNode( object sender, DrawTreeNodeEventArgs e )
        //{
        //    if ( e.Node.IsSelected )
        //    {
        //        if ( Focused )
        //            e.Graphics.FillRectangle( greenBrush, e.Bounds );
        //        else
        //            e.Graphics.FillRectangle( redBrush, e.Bounds );
        //    }
        //    else
        //        e.Graphics.FillRectangle( Brushes.White, e.Bounds );

        //    e.Graphics.DrawRectangle( SystemPens.Control, e.Bounds );

        //    TextRenderer.DrawText( e.Graphics,
        //                           e.Node.Text,
        //                           e.Node.TreeView.Font,
        //                           e.Node.Bounds,
        //                           e.Node.ForeColor );
        //}

        //private void XTreeCtrl_DrawNode( object sender, DrawTreeNodeEventArgs e )
        //{
        //    Font nodeFont = e.Node.NodeFont;
        //    if ( nodeFont == null ) nodeFont = ( (TreeView)sender ).Font;

        //    string txt = e.Node.Text;
        //    int idx = txt.IndexOf( ' ' );
        //    string greenTxt;
        //    string redTxt;
        //    if ( idx >= 0 )
        //    {
        //        greenTxt = txt.Substring( 0, idx );
        //        redTxt = txt.Substring( idx );
        //    }
        //    else
        //    {
        //        greenTxt = txt;
        //        redTxt = string.Empty;
        //    }
        //    Rectangle greenRect = new Rectangle( e.Bounds.Location, new Size( (int)Math.Ceiling( e.Graphics.MeasureString( greenTxt, nodeFont ).Width ), e.Bounds.Height ) );
        //    Rectangle redRect = new Rectangle( e.Bounds.Location + new Size( greenRect.Width, 0 ), new Size( (int)Math.Ceiling( e.Graphics.MeasureString( redTxt, nodeFont ).Width ), e.Bounds.Height ) );
        //    e.Graphics.DrawString( greenTxt, nodeFont, Brushes.Green, greenRect );
        //    if ( !string.IsNullOrEmpty( redTxt ) )
        //        e.Graphics.DrawString( redTxt, nodeFont,
        //            Brushes.Red, redRect );
        //}

        protected override void OnDrawNode( DrawTreeNodeEventArgs e )
        {
            TreeNodeStates treeState = e.State;
            Font treeFont = e.Node.NodeFont ?? e.Node.TreeView.Font;
            treeFont = new Font( "宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( (byte)( 134 ) ) );

            // Colors.
            Color foreColor = e.Node.ForeColor;
            string strDeselectedColor = @"#32C195", strSelectedColor = @"#32C195"; 
            Color selectedColor = System.Drawing.ColorTranslator.FromHtml( strSelectedColor );
            Color deselectedColor = System.Drawing.ColorTranslator.FromHtml( strDeselectedColor );

            // New brush.
            SolidBrush selectedTreeBrush = new SolidBrush( selectedColor );
            SolidBrush deselectedTreeBrush = new SolidBrush( deselectedColor );

            // Set default font color.
            if ( foreColor == Color.Empty )
                foreColor = e.Node.TreeView.ForeColor;

            // Draw bounding box and fill.
            if ( e.Node == e.Node.TreeView.SelectedNode )  //选中节点
            {
                // Use appropriate brush depending on if the tree has focus.
                if ( this.Focused )
                {
                    foreColor = SystemColors.HighlightText;
                    e.Graphics.FillRectangle( selectedTreeBrush /*SystemBrushes.Highlight*/, e.Bounds );
                    ControlPaint.DrawFocusRectangle( e.Graphics, e.Bounds, foreColor, SystemColors.Highlight );
                    TextRenderer.DrawText( e.Graphics, e.Node.Text, treeFont, e.Bounds, foreColor, TextFormatFlags.VerticalCenter );
                }
                else
                {
                    foreColor = SystemColors.HighlightText;
                    e.Graphics.FillRectangle( deselectedTreeBrush /*SystemBrushes.Highlight*/, e.Bounds );
                    ControlPaint.DrawFocusRectangle( e.Graphics, e.Bounds, foreColor, SystemColors.Highlight );
                    TextRenderer.DrawText( e.Graphics, e.Node.Text, treeFont, e.Bounds, foreColor, TextFormatFlags.VerticalCenter );
                }
            }
            else  //其他节点
            {
                // This is firing but is being over written, perhaps by the above?
                if ( ( e.State & TreeNodeStates.Hot ) == TreeNodeStates.Hot )
                {
                    e.DrawDefault = true;
                    e.Graphics.FillRectangle( deselectedTreeBrush, e.Bounds );
                    TextRenderer.DrawText( e.Graphics, e.Node.Text, treeFont, e.Bounds, System.Drawing.Color.Blue, TextFormatFlags.VerticalCenter );
                }
                else
                {
                    e.Graphics.FillRectangle( deselectedTreeBrush, e.Bounds );
                    TextRenderer.DrawText( e.Graphics, e.Node.Text, treeFont, e.Bounds, foreColor, TextFormatFlags.VerticalCenter );
                }
            }
        }
    }



}
