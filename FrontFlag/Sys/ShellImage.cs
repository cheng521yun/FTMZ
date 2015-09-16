using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace FrontFlag.Sys
{
    /// <summary>
    /// 文件类型图标列表。
    /// 用于ListView显示文件名称时，同时显示文件类型图标。
    /// </summary>
    public class FILEICONLIST
    {
        //保存小图标列表
        private System.Windows.Forms.ImageList _SmallImageList = new ImageList();
        //保存大图标列表
        private System.Windows.Forms.ImageList _LargeImageList = new ImageList();

        //保存已经获取的图标后缀名称
        List<String> _listExt = new List<string>();

        public FILEICONLIST ()
        {
            //将 ImageList中的图标设置为32位色图标，这样可以得到较好的显示效果
            _SmallImageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            _LargeImageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            
            _LargeImageList.ImageSize = new Size(32, 32);
        }

        #region 属性

        /// <summary>
        /// 获取系统的小图标列表
        /// </summary>
        public System.Windows.Forms.ImageList SmallImageList
        {
            get
            {
                return _SmallImageList;
            }

        }
        /// <summary>
        /// 获取系统的大图标列表
        /// </summary>
        public System.Windows.Forms.ImageList LargeImageList
        {
            get
            {
                return _LargeImageList;
            }
        }

        #endregion

        #region Private

        /// <summary>
        /// 获取系统图标
        /// </summary>
        /// <param name="path">文件名</param>
        /// <param name="dwAttr">文件信息</param>
        /// <param name="dwFlag">获取信息控制字</param>
        /// <returns></returns>
        private Icon GetIcon( string path, FILE_ATTRIBUTE dwAttr, SHGFI dwFlag)
        {
           SHFILEINFO fi = new SHFILEINFO();
           Icon ic = null;
           int iTotal = (int)SHGetFileInfo(path, dwAttr, ref fi, 0, dwFlag);
           ic = Icon.FromHandle(fi.hIcon);
           return ic;
        }

        /// <summary>
        /// 向smallInamgeList和_LargeImageList中
        /// 加入相应文件对应的图标
        /// </summary>
        /// <param name="fileName"></param>
        private void AddFileIcon(string fileName)
        {
           _SmallImageList.Images.Add( GetIcon(fileName,FILE_ATTRIBUTE.NORMAL,SHGFI.USEFILEATTRIBUTES | SHGFI.ICON | SHGFI.LARGEICON));
           _LargeImageList.Images.Add( GetIcon(fileName,FILE_ATTRIBUTE.NORMAL,SHGFI.USEFILEATTRIBUTES | SHGFI.ICON | SHGFI.LARGEICON));

            //
           _listExt.Add ( fileName );
        }

        //private void AddForderIcon()
        //{
        //   _SmallImageList.Images.Add( GetIcon("dic",FILE_ATTRIBUTE.DIRECTORY,SHGFI.USEFILEATTRIBUTES | SHGFI.ICON | SHGFI.LARGEICON));
        //   _LargeImageList.Images.Add( GetIcon("dic",FILE_ATTRIBUTE.DIRECTORY,SHGFI.USEFILEATTRIBUTES | SHGFI.ICON | SHGFI.LARGEICON));

            ////
            //_listExt.Add ( fileName );
        //}

        int CheckExsitExt ( string strExt )
        {
            if ( _listExt == null )
                return -1;

            int n = 0;
            foreach ( string str in _listExt )
            {
                if ( str == strExt )
                    return n;

                n++;
            }

            return -1;
        }

        #endregion

        #region Public

        /// <summary>
        /// 文件对应的图标在ImageList中的索引号
        /// （在SmallImageList,LargeImageList中的索引号是相同的）
        /// </summary>
        /// <param name="fileName">文件名</param>
        /// <returns>索引号</returns>
        public int AddImage(string fileName)
        {
            int index = 0;
            int extIndex = fileName.LastIndexOf ( '.' );

            string strExt = "";
            if ( extIndex > 0 )
                strExt = fileName.Substring ( extIndex, fileName.Length - extIndex );

            //判断该扩展名的文件图标是否已装载到imageList中
            index = CheckExsitExt ( strExt );

            if ( index < 0 )
            {
                AddFileIcon ( strExt ); //装载图标到ImageList中
                index = _SmallImageList.Images.Count - 1;
            }

            return index;
        }

        #endregion

        #region Def

        #region DLLIMPORT

        // Retrieves information about an object in the file system,
        // such as a file, a folder, a directory, or a drive root.
        [DllImport ( "shell32", EntryPoint = "SHGetFileInfo", ExactSpelling = false, CharSet = CharSet.Auto, SetLastError = true )]
        private extern static IntPtr SHGetFileInfo ( string pszPath,      //指定的文件名
                                                    FILE_ATTRIBUTE dwFileAttributes, //文件属性
                                                    ref SHFILEINFO sfi,     //返回获得的文件信息,是一个记录类型
                                                    int cbFileInfo,      //文件的类型名
                                                    SHGFI uFlags );

        #endregion

        #region STRUCTS

        // Contains information about a file object
        [StructLayout ( LayoutKind.Sequential, CharSet = CharSet.Auto )]
        private struct SHFILEINFO
        {
            public IntPtr hIcon;    //文件的图标句柄
            public IntPtr iIcon;    //图标的系统索引号
            public uint dwAttributes;   //文件的属性值
            [MarshalAs ( UnmanagedType.ByValTStr, SizeConst = 260 )]
            public string szDisplayName;  //文件的显示名
            [MarshalAs ( UnmanagedType.ByValTStr, SizeConst = 80 )]
            public string szTypeName;   //文件的类型名
        };

        #endregion

        #region Enums

        // Flags that specify the file information to retrieve with SHGetFileInfo
        [Flags]
        public enum SHGFI : uint
        {
            ADDOVERLAYS = 0x20,
            ATTR_SPECIFIED = 0x20000,
            ATTRIBUTES = 0x800,   //获得属性
            DISPLAYNAME = 0x200,  //获得显示名
            EXETYPE = 0x2000,
            ICON = 0x100,    //获得图标
            ICONLOCATION = 0x1000,
            LARGEICON = 0,    //获得大图标
            LINKOVERLAY = 0x8000,
            OPENICON = 2,
            OVERLAYINDEX = 0x40,
            PIDL = 8,
            SELECTED = 0x10000,
            SHELLICONSIZE = 4,
            SMALLICON = 1,    //获得小图标
            SYSICONINDEX = 0x4000,
            TYPENAME = 0x400,   //获得类型名
            USEFILEATTRIBUTES = 0x10
        }

        // Flags that specify the file information to retrieve with SHGetFileInfo
        [Flags]
        public enum FILE_ATTRIBUTE
        {
            READONLY = 0x00000001,
            HIDDEN = 0x00000002,
            SYSTEM = 0x00000004,
            DIRECTORY = 0x00000010,
            ARCHIVE = 0x00000020,
            DEVICE = 0x00000040,
            NORMAL = 0x00000080,
            TEMPORARY = 0x00000100,
            SPARSE_FILE = 0x00000200,
            REPARSE_POINT = 0x00000400,
            COMPRESSED = 0x00000800,
            OFFLINE = 0x00001000,
            NOT_CONTENT_INDEXED = 0x00002000,
            ENCRYPTED = 0x00004000
        }

        #endregion

        #endregion

    }
}
