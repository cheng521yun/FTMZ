//=======================================================================================================================
//
//  文件: Code39.cs
//
//  版本: V1.0
//
//  描述：
//
//  作者: 徐力
//
//  创建日期：2007-12-9
//
//  修改历史：	日期		修改内容
//
//
//=======================================================================================================================

using System;
using System.Collections.Generic;
using System.Collections;
using System.Drawing;

namespace FrontFlag.BarCode
{
    public class BARCODE39
    {
        int [] m_CodeDef = new int [ 44 ];
        int [] m_Mask = new int [ 9 ];

        int m_Bar_H = 50;				//条型码高度
        int m_Bar_Blod_W = 10;			//条型码粗条的宽度
        int m_Bar_Thin_W = 4;			//条型码细条的宽度
        int m_Space_Per_Char = 4;

        bool m_IsBlak = true;

        int m_X = 0;
        int m_Y = 0;

        Color m_White_Color = Color.White;
        Color m_Black_Color = Color.Black;

        string m_Str;

        Graphics m_g = null;

        public BARCODE39 ()
        {
            m_CodeDef [ 0 ] = 0x34; //strBarTable(0)="000110100"注释：0 
            m_CodeDef [ 1 ] = 0x121; //strBarTable(0)="100100001"注释：0 
            m_CodeDef [ 2 ] = 0x61;  //strBarTable(1)="001100001"注释：1 
            m_CodeDef [ 3 ] = 0x160; //strBarTable(2)="101100000"注释：2 
            m_CodeDef [ 4 ] = 0x31;  //strBarTable(4)="000110001"注释：4 
            m_CodeDef [ 5 ] = 0x130; //strBarTable(5)="100110000"注释：5 
            m_CodeDef [ 6 ] = 0x70;  //strBarTable(6)="001110000"注释：6 
            m_CodeDef [ 7 ] = 0x25;  //strBarTable(7)="000100101"注释：7 
            m_CodeDef [ 8 ] = 0x124; //strBarTable(8)="100100100"注释：8 
            m_CodeDef [ 9 ] = 0x64;  //strBarTable(9)="001100100"注释：9 
            m_CodeDef [ 10 ] = 0x109; //strBarTable(10)="100001001"注释：A 
            m_CodeDef [ 11 ] = 0x49;  //strBarTable(11)="001001001"注释：B 
            m_CodeDef [ 12 ] = 0x148; //strBarTable(12)="101001000"注释：C 
            m_CodeDef [ 13 ] = 0x19;  //strBarTable(13)="000011001"注释：D 
            m_CodeDef [ 14 ] = 0x118; //strBarTable(14)="100011000"注释：E 
            m_CodeDef [ 15 ] = 0x58;  //strBarTable(15)="001011000"注释：F 
            m_CodeDef [ 16 ] = 0xd;   //strBarTable(16)="000001101"注释：G 
            m_CodeDef [ 17 ] = 0x10c; //strBarTable(17)="100001100"注释：H 
            m_CodeDef [ 18 ] = 0x4c;  //strBarTable(18)="001001100"注释：I 
            m_CodeDef [ 19 ] = 0x1c;  //strBarTable(19)="000011100"注释：J 
            m_CodeDef [ 20 ] = 0x103; //strBarTable(20)="100000011"注释：K 
            m_CodeDef [ 21 ] = 0x43;  //strBarTable(21)="001000011"注释：L 
            m_CodeDef [ 22 ] = 0x142; //strBarTable(22)="101000010"注释：M 
            m_CodeDef [ 23 ] = 0x13;  //strBarTable(23)="000010011"注释：N 
            m_CodeDef [ 24 ] = 0x112; //strBarTable(24)="100010010"注释：O 
            m_CodeDef [ 25 ] = 0x52;  //strBarTable(25)="001010010"注释：P 
            m_CodeDef [ 26 ] = 0x7;   //strBarTable(26)="000000111"注释：Q 
            m_CodeDef [ 27 ] = 0x106; //strBarTable(27)="100000110"注释：R 
            m_CodeDef [ 28 ] = 0x46;  //strBarTable(28)="001000110"注释：S 
            m_CodeDef [ 29 ] = 0x16;  //strBarTable(29)="000010110"注释：T 
            m_CodeDef [ 30 ] = 0x181; //strBarTable(30)="110000001"注释：U 
            m_CodeDef [ 31 ] = 0xc1;  //strBarTable(31)="011000001"注释：V 
            m_CodeDef [ 32 ] = 0x1c0; //strBarTable(32)="111000000"注释：W 
            m_CodeDef [ 33 ] = 0x91;  //strBarTable(33)="010010001"注释：X 
            m_CodeDef [ 34 ] = 0x190; //strBarTable(34)="110010000"注释：Y 
            m_CodeDef [ 35 ] = 0xd0;  //strBarTable(35)="011010000"注释：Z 
            m_CodeDef [ 36 ] = 0x85;  //strBarTable(36)="010000101"注释：- 
            m_CodeDef [ 37 ] = 0x184; //strBarTable(36)="110000100"注释：. 
            m_CodeDef [ 38 ] = 0xc4;  //strBarTable(36)="011000100"注释：空格 	
            m_CodeDef [ 39 ] = 0x94;  //strBarTable(36)="010010100"注释：* 	
            m_CodeDef [ 40 ] = 0xa8;  //strBarTable(36)="010101000"注释：$ 	
            m_CodeDef [ 41 ] = 0xa2;  //strBarTable(36)="010100010"注释：/ 	
            m_CodeDef [ 42 ] = 0x8a;  //strBarTable(36)="010001010"注释：+ 		
            m_CodeDef [ 43 ] = 0x2a;  //strBarTable(36)="000101010"注释：% 		

            m_Mask [ 0 ] = 0x100;
            m_Mask [ 1 ] = 0x80;
            m_Mask [ 2 ] = 0x40;
            m_Mask [ 3 ] = 0x20;
            m_Mask [ 4 ] = 0x10;
            m_Mask [ 5 ] = 0x8;
            m_Mask [ 6 ] = 0x4;
            m_Mask [ 7 ] = 0x2;
            m_Mask [ 8 ] = 0x1;

        }

        #region property

        public int Bar_H
        {
            set { m_Bar_H = value; }
            get { return m_Bar_H; }
        }

        public int Bar_Blod_W
        {
            set { m_Bar_Blod_W = value; }
            get { return m_Bar_Blod_W; }
        }

        public int Bar_Thin_W
        {
            set { m_Bar_Thin_W = value; }
            get { return m_Bar_Thin_W; }
        }

        public int Space_Per_Char
        {
            set { m_Space_Per_Char = value; }
            get { return m_Space_Per_Char; }
        }

        #endregion

        #region Private

        int Convert_Char_To_No ( char ch )
        {
            int n = -1;
            if ( ch >= '0' && ch <= '9' )
            {
                n = ch - '0';
            }
            else if ( ch >= 'a' && ch <= 'z' )
            {
                n = ch - 'a' + 10;
            }
            else if ( ch >= 'A' && ch <= 'Z' )
            {
                n = ch - 'A' + 10;
            }
            else if ( ch == '-' )
            {
                n = 36;
            }
            else if ( ch == '.' )
            {
                n = 37;
            }
            else if ( ch == ' ' )
            {
                n = 38;
            }
            else if ( ch == '*' )
            {
                n = 39;
            }
            else if ( ch == '$' )
            {
                n = 40;
            }
            else if ( ch == '/' )
            {
                n = 41;
            }
            else if ( ch == '+' )
            {
                n = 42;
            }
            else if ( ch == '%' )
            {
                n = 43;
            }

            return n;
        }

        void Draw ()
        {
            int Len = m_Str.Length;
            for ( int i = 0 ; i < Len ; i++ )
            {
                Draw_a_Char ( m_Str [ i ] );
                m_X += m_Space_Per_Char;
            }
        }

        void Draw_a_Char ( char Ch )
        {
            try
            {
                if ( m_g == null )
                    return;

                m_IsBlak = true;
                int n = Convert_Char_To_No ( Ch );
                long Code = m_CodeDef [ n ];

                bool b;
                for ( int i = 0 ; i < 9 ; i++ ) //每个char由9个条组成.
                {
                    b = ( ( ( Code & m_Mask [ i ] ) >> ( 8 - i ) ) == 1 ) ? true : false;

                    Draw_Box ( b, m_IsBlak );
                    m_IsBlak = !m_IsBlak;
                }
            }
            catch ( Exception e )
            {
                return;
            }
        }

        void Draw_Box ( bool bWidth, bool bColor )
        {
            try
            {
                if ( m_g == null )
                    return;

                Color color = bColor ? m_Black_Color : m_White_Color;
                int w = bWidth ? m_Bar_Blod_W : m_Bar_Thin_W;

                SolidBrush brush = new SolidBrush ( color );
                Rectangle rc = new Rectangle ( m_X, m_Y, w, m_Bar_H );
                m_g.FillRectangle ( brush, rc );

                m_X += w;
            }
            catch ( Exception e )
            {
                return;
            }
        }

        #endregion

        public void Draw ( Graphics g, int X, int Y, string Str )
        {
            m_g = g;

            m_X = X;
            m_Y = Y;

            Str = "*" + Str;
            Str = Str + "*";

            m_X = X;
            m_Y = Y;
            m_Str = Str;

            Draw ();
        }
    }
}