using System;
using System.Collections.Generic;
using System.Text;


using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Design;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;


namespace FrontFlag
{
    public class API
    {
        public const int WM_RBUTTONDOWN = 0x0204;


            public const int LVM_FIRST = 0x1000;
            public const int LVM_GETHEADER = LVM_FIRST + 31;
            public const int LVM_SETITEMSTATE = LVM_FIRST + 43;
            public const int LVM_SETEXTENDEDLISTVIEWSTYLE = LVM_FIRST + 54;
            public const int LVM_SETITEM = LVM_FIRST + 76;
            public const int LVM_GETCOLUMN = LVM_FIRST + 95;
            public const int LVM_SETCOLUMN = LVM_FIRST + 96;

            public const int LVS_EX_SUBITEMIMAGES = 0x0002;

            public const int LVIF_TEXT = 0x0001;
            public const int LVIF_IMAGE = 0x0002;
            public const int LVIF_PARAM = 0x0004;
            public const int LVIF_STATE = 0x0008;
            public const int LVIF_INDENT = 0x0010;
            public const int LVIF_NORECOMPUTE = 0x0800;

            public const int LVCF_FMT = 0x0001;
            public const int LVCF_WIDTH = 0x0002;
            public const int LVCF_TEXT = 0x0004;
            public const int LVCF_SUBITEM = 0x0008;
            public const int LVCF_IMAGE = 0x0010;
            public const int LVCF_ORDER = 0x0020;
            public const int LVCFMT_LEFT = 0x0000;
            public const int LVCFMT_RIGHT = 0x0001;
            public const int LVCFMT_CENTER = 0x0002;
            public const int LVCFMT_JUSTIFYMASK = 0x0003;

            public const int LVCFMT_IMAGE = 0x0800;
            public const int LVCFMT_BITMAP_ON_RIGHT = 0x1000;
            public const int LVCFMT_COL_HAS_IMAGES = 0x8000;

            public const int HDM_FIRST = 0x1200;
            public const int HDM_HITTEST = HDM_FIRST + 6;
            public const int HDM_GETITEM = HDM_FIRST + 11;
            public const int HDM_SETITEM = HDM_FIRST + 12;

            public const int HDI_WIDTH = 0x0001;
            public const int HDI_TEXT = 0x0002;
            public const int HDI_FORMAT = 0x0004;
            public const int HDI_BITMAP = 0x0010;
            public const int HDI_IMAGE = 0x0020;

            public const int HDF_LEFT = 0x0000;
            public const int HDF_RIGHT = 0x0001;
            public const int HDF_CENTER = 0x0002;
            public const int HDF_JUSTIFYMASK = 0x0003;
            public const int HDF_RTLREADING = 0x0004;
            public const int HDF_STRING = 0x4000;
            public const int HDF_BITMAP = 0x2000;
            public const int HDF_BITMAP_ON_RIGHT = 0x1000;
            public const int HDF_IMAGE = 0x0800;
            public const int HDF_SORTUP = 0x0400;
            public const int HDF_SORTDOWN = 0x0200;

            public const int SB_HORZ = 0;
            public const int SB_VERT = 1;
            public const int SB_CTL = 2;
            public const int SB_BOTH = 3;

            public const int SIF_RANGE = 0x0001;
            public const int SIF_PAGE = 0x0002;
            public const int SIF_POS = 0x0004;
            public const int SIF_DISABLENOSCROLL = 0x0008;
            public const int SIF_TRACKPOS = 0x0010;
            public const int SIF_ALL = ( SIF_RANGE | SIF_PAGE | SIF_POS | SIF_TRACKPOS );

            [StructLayout ( LayoutKind.Sequential , CharSet = CharSet.Auto )]
            public struct LVITEM
            {
                public int mask;
                public int iItem;
                public int iSubItem;
                public int state;
                public int stateMask;
                [MarshalAs ( UnmanagedType.LPTStr )]
                public string pszText;
                public int cchTextMax;
                public int iImage;
                public IntPtr lParam;
                // These are available in Common Controls >= 0x0300
                public int iIndent;
                // These are available in Common Controls >= 0x056
                public int iGroupId;
                public int cColumns;
                public IntPtr puColumns;
            };

            [StructLayout ( LayoutKind.Sequential , CharSet = CharSet.Auto )]
            public struct LVCOLUMN
            {
                public int mask;
                public int fmt;
                public int cx;
                [MarshalAs ( UnmanagedType.LPTStr )]
                public string pszText;
                public int cchTextMax;
                public int iSubItem;
                // These are available in Common Controls >= 0x0300
                public int iImage;
                public int iOrder;
            };

            /// <summary>
            /// Notify message header structure.
            /// </summary>
            [StructLayout ( LayoutKind.Sequential )]
            public struct NMHDR
            {
                public IntPtr hwndFrom;
                public IntPtr idFrom;
                public int code;
            }

            [StructLayout ( LayoutKind.Sequential )]
            public struct NMHEADER
            {
                public NMHDR nhdr;
                public int iItem;
                public int iButton;
                public IntPtr pHDITEM;
            }

            [StructLayout ( LayoutKind.Sequential )]
            public struct HDITEM
            {
                public int mask;
                public int cxy;
                public IntPtr pszText;
                public IntPtr hbm;
                public int cchTextMax;
                public int fmt;
                public IntPtr lParam;
                public int iImage;
                public int iOrder;
                //if (_WIN32_IE >= 0x0500)
                public int type;
                public IntPtr pvFilter;
            }

            [StructLayout ( LayoutKind.Sequential )]
            public class HDHITTESTINFO
            {
                public int pt_x;
                public int pt_y;
                public int flags;
                public int iItem;
            }

            //[StructLayout ( LayoutKind.Sequential )]
            //public class SCROLLINFO
            //{
            //    public int cbSize;
            //    public int fMask;
            //    public int nMin;
            //    public int nMax;
            //    public int nPage;
            //    public int nPos;
            //    public int nTrackPos;
            //    public SCROLLINFO ()
            //    {
            //        this.cbSize = Marshal.SizeOf ( typeof ( NativeMethods.SCROLLINFO ) );
            //    }
            //}

            //// Various flavours of SendMessage: plain vanilla, and passing references to various structures
            //[DllImport ( "user32.dll" , CharSet = CharSet.Auto )]
            //public static extern IntPtr SendMessage ( IntPtr hWnd , int msg , int wParam , int lParam );
            //[DllImport ( "user32.dll" , EntryPoint = "SendMessage" , CharSet = CharSet.Auto )]
            //public static extern IntPtr SendMessageLVItem ( IntPtr hWnd , int msg , int wParam , ref LVITEM lvi );
            //[DllImport ( "user32.dll" , EntryPoint = "SendMessage" , CharSet = CharSet.Auto )]
            //public static extern IntPtr SendMessageLVColumn ( IntPtr hWnd , int msg , int wParam , ref LVCOLUMN lvc );
            //[DllImport ( "user32.dll" , EntryPoint = "SendMessage" , CharSet = CharSet.Auto )]
            //public static extern IntPtr SendMessageHDItem ( IntPtr hWnd , int msg , int wParam , ref HDITEM hdi );
            //[DllImport ( "user32.dll" , EntryPoint = "SendMessage" , CharSet = CharSet.Auto )]
            //public static extern IntPtr SendMessageHDHITTESTINFO ( IntPtr hWnd , int Msg , IntPtr wParam , [In , Out] HDHITTESTINFO lParam );

            // Entry points used by this code
            //[DllImport ( "user32.dll" , CharSet = CharSet.Auto , ExactSpelling = true )]
            //public static extern bool GetScrollInfo ( IntPtr hWnd , int fnBar , SCROLLINFO si );

            //[DllImport ( "user32.dll" , EntryPoint = "GetUpdateRect" , CharSet = CharSet.Auto )]
            //public static extern IntPtr GetUpdateRectInternal ( IntPtr hWnd , ref Rectangle r , bool eraseBackground );

            //[DllImport ( "user32.dll" , CharSet = CharSet.Auto , ExactSpelling = true )]
            //public static extern bool SetScrollInfo ( IntPtr hWnd , int fnBar , SCROLLINFO si , bool fRedraw );

            //[DllImport ( "user32.dll" , EntryPoint = "ValidateRect" , CharSet = CharSet.Auto )]
            //public static extern IntPtr ValidatedRectInternal ( IntPtr hWnd , ref Rectangle r );

    }
}
