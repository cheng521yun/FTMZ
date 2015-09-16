using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace FrontFlag
{
    public class DRAW
    {
        public Graphics g = null;

        public GRAPHICSPATH Path = new GRAPHICSPATH ( );

        public class GRAPHICSPATH
        {
            //Ë®¾§°´Å¥µÄÂÖÀª
            public GraphicsPath GetRound ( Rectangle rect )
            {
                GraphicsPath Path = new System.Drawing.Drawing2D.GraphicsPath ( );

                if ( rect.Width <= 0 )
                {
                    rect.Width = 1;
                }

                if ( rect.Height <= 0 )
                {
                    rect.Height = 1;
                }

                Path.AddArc ( rect.Left , rect.Top , rect.Height , rect.Height , 90f , 180f );
                Path.AddArc ( rect.Right - rect.Height , rect.Top , rect.Height , rect.Height , 270f , 180f );
                Path.CloseFigure ( );

                return Path;
            }

            public GraphicsPath GetRound ( Rectangle rc , int radius )
            {
                GraphicsPath Path = new System.Drawing.Drawing2D.GraphicsPath ( );

                Path.AddArc ( rc.Right - radius , rc.Top , radius , radius , 270f , 90f );
                Path.AddArc ( rc.Right - radius , rc.Bottom - radius , radius , radius , 0f , 90f );
                Path.AddArc ( rc.Left , rc.Bottom - radius , radius , radius , 90f , 90f );
                Path.AddArc ( rc.Left , rc.Top , radius , radius , 180f , 90f );

                //Path.AddLine ( rc.Left + radius , rc.Top , rc.Right - radius  , rc.Top );

                Path.CloseFigure ( );
                return Path;
            }

            public GraphicsPath GetHalfRoundN_ ( Rectangle rc , int radius )
            {
                GraphicsPath Path = new System.Drawing.Drawing2D.GraphicsPath ( );

                Path.AddArc ( rc.Left , rc.Top , radius , radius , 180f , 90f );
                Path.AddLine ( rc.Left + radius , rc.Top , rc.Right - radius , rc.Top );
                Path.AddArc ( rc.Right - radius , rc.Top , radius , radius , 270f , 90f );
                Path.AddLine ( rc.Right , rc.Top + radius , rc.Right , rc.Bottom );
                Path.AddLine ( rc.Right , rc.Bottom , rc.Left , rc.Bottom );
                Path.AddLine ( rc.Left , rc.Bottom , rc.Left , rc.Top + radius );

                Path.CloseFigure ( );
                return Path;
            }

            public GraphicsPath GetHalfRoundN ( Rectangle rc , int radius )
            {
                GraphicsPath Path = new System.Drawing.Drawing2D.GraphicsPath ( );

                Path.AddLine ( rc.Left , rc.Bottom , rc.Left , rc.Top + radius );
                Path.AddArc ( rc.Left , rc.Top , radius , radius , 180f , 90f );
                Path.AddLine ( rc.Left + radius , rc.Top , rc.Right - radius , rc.Top );
                Path.AddArc ( rc.Right - radius , rc.Top , radius , radius , 270f , 90f );
                Path.AddLine ( rc.Right , rc.Top + radius , rc.Right , rc.Bottom );

                return Path;
            }

            public GraphicsPath GetHalfRoundU ( Rectangle rc , int radius )
            {
                GraphicsPath Path = new System.Drawing.Drawing2D.GraphicsPath ( );

                Path.AddLine ( rc.Left , rc.Bottom - radius , rc.Left , rc.Top );
                Path.AddLine ( rc.Left , rc.Top , rc.Right , rc.Top );
                Path.AddLine ( rc.Right , rc.Top , rc.Right , rc.Bottom - radius );
                Path.AddArc ( rc.Right - radius , rc.Bottom - radius , radius , radius , 0f , 90f );
                Path.AddLine ( rc.Right - radius , rc.Bottom , rc.Left + radius , rc.Bottom );
                Path.AddArc ( rc.Left , rc.Bottom - radius , radius , radius , 90f , 90f );

                Path.CloseFigure ( );
                return Path;
            }

            public GraphicsPath GetRect ( Rectangle rect )
            {
                GraphicsPath Path = new System.Drawing.Drawing2D.GraphicsPath ( );

                if ( rect.Width <= 0 )
                {
                    rect.Width = 1;
                }

                if ( rect.Height <= 0 )
                {
                    rect.Height = 1;
                }

                int X1 = rect.Left;
                int X2 = X1 + rect.Width;
                int Y1 = rect.Top;
                int Y2 = Y1 + rect.Height;

                Path.AddLine ( X1 , Y1 , X2 , Y1 );
                Path.AddLine ( X2 , Y1 , X2 , Y2 );
                Path.AddLine ( X2 , Y2 , X1 , Y2 );
                Path.AddLine ( X1 , Y2 , X1 , Y1 );

                Path.CloseFigure ( );
                return Path;
            }

        }

        public void SinkLineV ( int X , int Y , int H )
        {
            Color clrLight = Color.FromArgb ( 200 , 200 , 200 );
            Color clrDark = Color.FromArgb ( 120 , 120 , 120 );

            Point pt1 = new Point ( X , Y );
            Point pt2 = new Point ( X , Y + H );
            Point pt3 = new Point ( X + 1 , Y );
            Point pt4 = new Point ( X + 1 , Y + H );

            Pen penLight = new Pen ( clrLight );
            Pen penDark = new Pen ( clrDark );

            g.DrawLine ( penLight , pt1 , pt2 );
            g.DrawLine ( penDark , pt3 , pt4 );
        }

        public void SinkLineV ( int X , int Y , int H , Color clr )
        {
            Point pt1 = new Point ( X , Y );
            Point pt2 = new Point ( X , Y + H );
            Pen pen = new Pen ( clr );
            g.DrawLine ( pen , pt1 , pt2 );
        }
    }

}
