using System;
using System.Collections.Generic;
using System.Text;
using System.Configuration;
using System.Runtime.InteropServices;
using System.Management;

namespace FrontFlag
{
    public class SYSTEMINFO
    {
        /*
        * LayoutKind.Automatic：为了提高效率允许运行态对类型成员重新排序
        * 注意：永远不要使用这个选项来调用不受管辖的动态链接库函数。
        * LayoutKind.Explicit：对每个域按照FieldOffset属性对类型成员排序
        * LayoutKind.Sequential：对出现在受管辖类型定义地方的不受管辖内存中的类型成员进行排序。
        */
        /// <summary>
        /// 定义CPU的信息结构
        /// </summary>
        [StructLayout(LayoutKind.Sequential)]
        public struct CpuInfo
        {
             /// <summary>
             /// OEM ID
             /// </summary>
             public uint dwOemId;
             /// <summary>
             /// 页面大小
             /// </summary>
             public uint dwPageSize;
             public uint lpMinimumApplicationAddress;
             public uint lpMaximumApplicationAddress;
             public uint dwActiveProcessorMask;
             /// <summary>
             /// CPU个数
             /// </summary>
             public uint dwNumberOfProcessors;
             /// <summary>
             /// CPU类型
             /// </summary>
             public uint dwProcessorType;
             public uint dwAllocationGranularity;
             /// <summary>
             /// CPU等级
             /// </summary>
             public uint dwProcessorLevel;
             public uint dwProcessorRevision;
        }

        /// <summary>
        /// 定义内存的信息结构
        /// </summary>
        [StructLayout(LayoutKind.Sequential)]
        public struct MemoryInfo
        {
             /// <summary>
             ///
             /// </summary>
             public uint dwLength;
             /// <summary>
             /// 已经使用的内存
             /// </summary>
             public uint dwMemoryLoad;
             /// <summary>
             /// 总物理内存大小
             /// </summary>
             public uint dwTotalPhys;
             /// <summary>
             /// 可用物理内存大小
             /// </summary>
             public uint dwAvailPhys;
             /// <summary>
             /// 交换文件总大小
             /// </summary>
             public uint dwTotalPageFile;
             /// <summary>
             /// 可用交换文件大小
             /// </summary>
             public uint dwAvailPageFile;
             /// <summary>
             /// 总虚拟内存大小
             /// </summary>
             public uint dwTotalVirtual;
             /// <summary>
             /// 可用虚拟内存大小
             /// </summary>
             public uint dwAvailVirtual;
        }

        /// <summary>
        /// 定义系统时间的信息结构
        /// </summary>
        [StructLayout(LayoutKind.Sequential)]
        public struct SystemTimeInfo
        {
             /// <summary>
             /// 年
             /// </summary>
             public ushort wYear;
             /// <summary>
             /// 月
             /// </summary>
             public ushort wMonth;
             /// <summary>
             /// 星期
             /// </summary>
             public ushort wDayOfWeek;
             /// <summary>
             /// 天
             /// </summary>
             public ushort wDay;
             /// <summary>
             /// 小时
             /// </summary>
             public ushort wHour;
             /// <summary>
             /// 分钟
             /// </summary>
             public ushort wMinute;
             /// <summary>
             /// 秒
             /// </summary>
             public ushort wSecond;
             /// <summary>
             /// 毫秒
             /// </summary>
             public ushort wMilliseconds;
        }

        private const int CHAR_COUNT = 128;

        public SYSTEMINFO ()
         {
         }

         [DllImport("kernel32")]
         private static extern void GetWindowsDirectory(StringBuilder WinDir, int count);

         [DllImport("kernel32")]
         private static extern void GetSystemDirectory(StringBuilder SysDir, int count);

         [DllImport("kernel32")]
         private static extern void GetSystemInfo(ref CpuInfo cpuInfo);

         [DllImport("kernel32")]
         private static extern void GlobalMemoryStatus(ref MemoryInfo memInfo);

         [DllImport("kernel32")]
         private static extern void GetSystemTime(ref SystemTimeInfo sysInfo);

         #region CPU

         /**/
         /// <summary>
         /// 查询CPU编号
         /// </summary>
         /// <returns></returns>
         public string GetCpuId()
         {
             ManagementClass mClass = new ManagementClass("Win32_Processor");
             ManagementObjectCollection moc = mClass.GetInstances();
             string cpuId=null;
             foreach (ManagementObject mo in moc)
             {
                 cpuId = mo.Properties["ProcessorId"].Value.ToString();
                 break;
             }
             return cpuId;
         }

        //获取计算机CPU的当前时钟频率
        public string GetCpuCurrentClockSpeed ()
        {
            ManagementClass mClass = new ManagementClass ( "Win32_Processor" );
            ManagementObjectCollection moc = mClass.GetInstances ();
            string strCurrentClockSpeed = null;
            foreach ( ManagementObject mo in moc )
            {
                float fHZ = ( ( float )Convert.ToInt16 ( mo.Properties [ "CurrentClockSpeed" ].Value ) ) / 1000 ;
                strCurrentClockSpeed = fHZ.ToString () + "GHz";
                break;
            }
            return strCurrentClockSpeed;
        }

        //获取计算机CPU的最大时钟频率
        public string GetCpuMaxClockSpeed ()
        {
            ManagementClass mClass = new ManagementClass ( "Win32_Processor" );
            ManagementObjectCollection moc = mClass.GetInstances ();
            string strMaxClockSpeed = null;
            foreach ( ManagementObject mo in moc )
            {
                float fHZ = ( ( float ) Convert.ToInt16 ( mo.Properties [ "MaxClockSpeed" ].Value ) ) / 1000;
                strMaxClockSpeed = fHZ.ToString () + "GHz";
                break;
            }
            return strMaxClockSpeed;
        }

        //获取计算机CPU的占用率
        public string GetCpuLoadPercentage ()
        {
            ManagementClass mClass = new ManagementClass ( "Win32_Processor" );
            ManagementObjectCollection moc = mClass.GetInstances ();
            string strLoadPercentage = null;
            foreach ( ManagementObject mo in moc )
            {
                strLoadPercentage = mo.Properties [ "LoadPercentage" ].Value.ToString () + "%";
                break;
            }
            return strLoadPercentage;
        }

        //获取计算机CPU的版本; eg:型号4 步进9
        public string GetCpuVersion ()
        {
            ManagementClass mClass = new ManagementClass ( "Win32_Processor" );
            ManagementObjectCollection moc = mClass.GetInstances ();
            string strVersion = null;
            foreach ( ManagementObject mo in moc )
            {
                strVersion = mo.Properties [ "Version" ].Value.ToString () ;
                break;
            }
            return strVersion;
        }

        //获取计算机CPU的产品名称 ; eg:"Intel(R) Pentium(R) 4 CPU 2.80GHz"
        public string GetCpuName ()
        {
            ManagementClass mClass = new ManagementClass ( "Win32_Processor" );
            ManagementObjectCollection moc = mClass.GetInstances ();
            string strName = null;
            foreach ( ManagementObject mo in moc )
            {
                strName = mo.Properties [ "Name" ].Value.ToString ();
                break;
            }
            return strName.Trim ();
        }

        //获取计算机CPU的制造商 
        public string GetCpuManufacturer ()
        {
            ManagementClass mClass = new ManagementClass ( "Win32_Processor" );
            ManagementObjectCollection moc = mClass.GetInstances ();
            string strManufacturer = null;
            foreach ( ManagementObject mo in moc )
            {
                strManufacturer = mo.Properties [ "Manufacturer" ].Value.ToString ();
                break;
            }
            return strManufacturer;
        }

        //获取计算机CPU的当前电压 
        public string GetCpuCurrentVoltage ()
        {
            ManagementClass mClass = new ManagementClass ( "Win32_Processor" );
            ManagementObjectCollection moc = mClass.GetInstances ();
            string strCurrentVoltage = null;
            foreach ( ManagementObject mo in moc )
            {
                strCurrentVoltage = mo.Properties [ "CurrentVoltage" ].Value.ToString ();
                break;
            }
            return strCurrentVoltage;
        }

        #endregion

         #region Memo

        /**/
        /// <summary>
        /// 获取系统内存信息
        /// </summary>
        /// <returns></returns>
        public MemoryInfo GetMemoryInfo ()
        {
            MemoryInfo memoryInfo = new MemoryInfo ();
            GlobalMemoryStatus ( ref memoryInfo );
            return memoryInfo;
        }

        //获取计算机的物理内存
        public string GetMemoryTotalPhysical ()
        {
            ManagementObjectSearcher searcher = new ManagementObjectSearcher ( "Select * From Win32_LogicalMemoryConfiguration" );
            String strTotalPhysicalMemory = null;
            foreach ( ManagementObject mo in searcher.Get () )
            {
                strTotalPhysicalMemory = mo [ "TotalPhysicalMemory" ].ToString ().Trim ();
                break;
            }
            return  ( strTotalPhysicalMemory ) ;
        }

        //获取计算机的虚拟内存
        public string GetMemoryTotalVirtual ()
        {
            ManagementObjectSearcher searcher = new ManagementObjectSearcher ( "Select * From Win32_LogicalMemoryConfiguration" );
            String strTotalVirtualMemory = null;
            foreach ( ManagementObject mo in searcher.Get () )
            {
                strTotalVirtualMemory = mo [ "TotalVirtualMemory" ].ToString ().Trim ();
                break;
            }
            return  ( strTotalVirtualMemory );
        }

        //获取计算机的页面文件
        public string GetMemoryTotalPageFileSpace ()
        {
            ManagementObjectSearcher searcher = new ManagementObjectSearcher ( "Select * From Win32_LogicalMemoryConfiguration" );
            String strTotalPageFileSpace = null;
            foreach ( ManagementObject mo in searcher.Get () )
            {
                strTotalPageFileSpace = mo [ "TotalPageFileSpace" ].ToString ().Trim ();
                break;
            }
            return strTotalPageFileSpace;
        }

        #endregion

         #region Disk

        /**/
        /// <summary>
         /// 查询硬盘编号
         /// </summary>
         /// <returns></returns>
         public string GetDiskId()
         {
             ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_PhysicalMedia");
             String hardDiskID=null;
             foreach (ManagementObject mo in searcher.Get())
             {
                 hardDiskID = mo["SerialNumber"].ToString().Trim();
                 break;
             }
             return hardDiskID;
         }

         //获得指定磁盘的容量 ; eg: param ="c:"
        public string GetDiskSize ( string strDiskSign )
        {
            String strDiskSize = null; 
            string strWSL = String.Format ( "select * from win32_logicaldisk where Name='{0}'" , strDiskSign );
            try
            {
                ManagementObjectSearcher searcher = new ManagementObjectSearcher ( strWSL );

                foreach ( ManagementObject mo in searcher.Get () )
                {
                    strDiskSize = mo [ "Size" ].ToString ().Trim ();
                    break;
                }
            }
            catch ( Exception e )
            {
                return e.Message;
            }

            return GetSizeUseUnit ( strDiskSize );
        }

        //获得指定磁盘的剩余容量 ; eg: param ="c:"
        public string GetDiskFreeSpace ( string strDiskSign )
        {
            String strDiskFreeSpace = null;
            string strWSL = String.Format ( "select * from win32_logicaldisk where Name='{0}'" , strDiskSign );
            try
            {
                ManagementObjectSearcher searcher = new ManagementObjectSearcher ( strWSL );

                foreach ( ManagementObject mo in searcher.Get () )
                {
                    strDiskFreeSpace = mo [ "FreeSpace" ].ToString ().Trim ();
                    break;
                }
            }
            catch ( Exception e )
            {
                return e.Message;
            }

            return GetSizeUseUnit ( strDiskFreeSpace );
        }

        #endregion

         #region Opreat

        /**/
        /// <summary>
        /// 获取系统名称
        /// </summary>
        /// <returns></returns>
        public string GetOperationSystemInName ()
        {
            OperatingSystem os = System.Environment.OSVersion;
            string osName = "UNKNOWN";
            switch ( os.Platform )
            {
                case PlatformID.Win32Windows:
                    switch ( os.Version.Minor )
                    {
                        case 0: osName = "Windows 95"; break;
                        case 10: osName = "Windows 98"; break;
                        case 90: osName = "Windows ME"; break;
                    }
                    break;
                case PlatformID.Win32NT:
                    switch ( os.Version.Major )
                    {
                        case 3: osName = "Windws NT 3.51"; break;
                        case 4: osName = "Windows NT 4"; break;
                        case 5: if ( os.Version.Minor == 0 )
                            {
                                osName = "Windows 2000";
                            }
                            else if ( os.Version.Minor == 1 )
                            {
                                osName = "Windows XP";
                            }
                            else if ( os.Version.Minor == 2 )
                            {
                                osName = "Windows Server 2003";
                            }
                            break;
                        case 6: osName = "Longhorn"; break;
                    }
                    break;
            }
            return String.Format ( "{0},{1}" , osName , os.Version.ToString () );
        }

        //获取操作系统名称
        public string GetOperationSystem ()
        {
            ManagementObjectSearcher searcher = new ManagementObjectSearcher ( "SELECT * FROM Win32_OperatingSystem" );
            String strOperationSystem = null;
            foreach ( ManagementObject mo in searcher.Get () )
            {
                strOperationSystem = mo [ "Caption" ].ToString ().Trim ();
                break;
            }
            return strOperationSystem;
        }

        //获取计算机名称
        public string GetOperationPCName ()
        {
            ManagementObjectSearcher searcher = new ManagementObjectSearcher ( "SELECT * FROM Win32_OperatingSystem" );
            String strPCName = null;
            foreach ( ManagementObject mo in searcher.Get () )
            {
                strPCName = mo [ "csname" ].ToString ().Trim ();
                break;
            }
            return strPCName;
        }

        //获取操作系统版本
        public string GetOperationVersion ()
        {
            ManagementObjectSearcher searcher = new ManagementObjectSearcher ( "SELECT * FROM Win32_OperatingSystem" );
            String strVersion = null;
            foreach ( ManagementObject mo in searcher.Get () )
            {
                strVersion = mo [ "Version" ].ToString ().Trim ();
                break;
            }
            return strVersion;
        }

        //获取操作系统开发商名称
        public string GetOperationManufacturer ()
        {
            ManagementObjectSearcher searcher = new ManagementObjectSearcher ( "SELECT * FROM Win32_OperatingSystem" );
            String strManufacturer = null;
            foreach ( ManagementObject mo in searcher.Get () )
            {
                strManufacturer = mo [ "Manufacturer" ].ToString ().Trim ();
                break;
            }
            return strManufacturer;
        }
        #endregion

         #region Path

         /**/
         /// <summary>
         /// 获取Windows目录
         /// </summary>
         /// <returns></returns>
         public string GetWinDirectory()
         {
             StringBuilder sBuilder = new StringBuilder(CHAR_COUNT);
             GetWindowsDirectory(sBuilder, CHAR_COUNT);
             return sBuilder.ToString();
         }

         /**//// <summary>
         /// 获取系统目录
         /// </summary>
         /// <returns></returns>
         public string GetSysDirectory()
         {
             StringBuilder sBuilder = new StringBuilder(CHAR_COUNT);
             GetSystemDirectory(sBuilder, CHAR_COUNT);
             return sBuilder.ToString();
         }

        /**//// <summary>
        /// 获取CPU信息
        /// </summary>
        /// <returns></returns>
         public CpuInfo GetCpuInfo()
         {
             CpuInfo cpuInfo = new CpuInfo();
             GetSystemInfo(ref cpuInfo);
             return cpuInfo;
         }

        #endregion

         #region Time

         /**/
         /// <summary>
         /// 获取系统时间信息
         /// </summary>
         /// <returns></returns>
         public SystemTimeInfo GetSystemTimeInfo()
         {
             SystemTimeInfo systemTimeInfo = new SystemTimeInfo();
             GetSystemTime(ref systemTimeInfo);
             return systemTimeInfo;
         }

         #endregion

         #region private

        private string GetSizeUseUnit ( string size )
        {
            double dSpace = Convert.ToDouble ( size );
            string sSpace = dSpace.ToString ( "N" );
            string [ ] tmp;
            string rtnSize = "0";
            tmp = sSpace.Split ( ',' );
            switch ( tmp.GetUpperBound ( 0 ) )
            {
                case 0:
                    rtnSize = tmp [ 0 ] + " 字节";
                    break;
                case 1:
                    rtnSize = tmp [ 0 ] + "." + tmp [ 1 ].Substring ( 0 , 2 ) + " K";
                    break;
                case 2:
                    rtnSize = tmp [ 0 ] + "." + tmp [ 1 ].Substring ( 0 , 2 ) + " M";
                    break;
                case 3:
                    rtnSize = tmp [ 0 ] + "." + tmp [ 1 ].Substring ( 0 , 2 ) + " G";
                    break;
                case 4:
                    rtnSize = tmp [ 0 ] + "." + tmp [ 1 ].Substring ( 0 , 2 ) + " T";
                    break;
            }
            return rtnSize;
        } 

        #endregion
     }
}
