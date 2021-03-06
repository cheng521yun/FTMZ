using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;

namespace FrontFlag
{
    public class FUN
    {
        public CONVERT MyConvert = new CONVERT ( );
        public DATE Date = new DATE ( );
        public POPEDOMBYTE PopedomByte = new POPEDOMBYTE();

        public class CONVERT
        {
            public byte Str2Byte ( string str )
            {
                byte b;
                try
                {
                    b = byte.Parse ( str );
                }
                catch ( Exception e )
                {
                    return 0;
                }
                return b;
            }

            public int Str2Int ( string str )
            {
                int n;
                try
                {
                    n = int.Parse ( str );
                }
                catch ( Exception e )
                {
                    return 0;
                }
                return n;
            }
            public int Str2Int ( string str , int nDefault )
            {
                int n;
                try
                {
                    n = int.Parse ( str );
                }
                catch ( Exception e )
                {
                    return nDefault;
                }
                return n;
            }

            public long Str2Long ( string str )
            {
                long n;
                try
                {
                    n = long.Parse ( str );
                }
                catch ( Exception e )
                {
                    return 0;
                }
                return n;
            }
            public long Str2Long ( string str , long nDefault )
            {
                long n;
                try
                {
                    n = long.Parse ( str );
                }
                catch ( Exception e )
                {
                    return nDefault;
                }
                return n;
            }

            public double Str2Double ( string str )
            {
                double f ;
                try
                {
                    f = double.Parse ( str );
                }
                catch ( Exception e )
                {
                    return 0;
                }
                return f;
            }
            public double Str2Double ( string str , double fDefault )
            {
                double f;
                try
                {
                    f = double.Parse ( str );
                }
                catch ( Exception e )
                {
                    return fDefault;
                }
                return f;
            }

            public Decimal Str2Decimal ( string str )
            {
                Decimal d;
                try
                {
                    d = Decimal.Parse ( str );
                }
                catch ( Exception e )
                {
                    return 0;
                }
                return d;
            }

            /// <summary>
            /// 保留0位小数
            /// </summary>
            /// <param name="str"></param>
            /// <returns></returns>
            public Decimal Str2Decimal_0P( string str )
            {
                string str2 = String.Format( "{0:0}", Str2Decimal( str ) );
                return Str2Decimal( str2 );
            }

            /// <summary>
            /// 保留1位小数
            /// </summary>
            /// <param name="str"></param>
            /// <returns></returns>
            public Decimal Str2Decimal_1P( string str )
            {
                string str2 = String.Format( "{0:0.0}", Str2Decimal( str ) );
                return Str2Decimal( str2 );
            }

            /// <summary>
            /// 保留2位小数
            /// </summary>
            /// <param name="str"></param>
            /// <returns></returns>
            public Decimal Str2Decimal_2P( string str )
            {
                string str2 = String.Format("{0:0.00}",Str2Decimal(str));
                return Str2Decimal( str2 );
            }
            public Decimal Decimal_2P( Decimal d )
            {
                return Str2Decimal_2P( d.ToString() );
            }

            /// <summary>
            /// 保留4位小数
            /// </summary>
            /// <param name="str"></param>
            /// <returns></returns>
            public Decimal Str2Decimal_4P( string str )
            {
                string str2 = String.Format( "{0:0.0000}", Str2Decimal( str ) );
                return Str2Decimal( str2 );
            }
            public Decimal Decimal_4P( Decimal d )
            {
                return Str2Decimal_4P( d.ToString() );

            }

            /// <summary>
            /// 小数点后有4个零，。超过2个0 的0 不要显示。eg：12.3000 显示为 12.30
            /// </summary>
            /// <param name="str"></param>
            /// <returns></returns>
            public string Str2Decimal_str0000_00 ( string str )
            {
                string strRet = ""; 
                Decimal d;
                try
                {
                    d = Decimal.Parse ( str );

                    int nlen = str.Length;
                    int ndot = str.IndexOf ( "." );  //有小数点

                    //这是整数
                    if ( ndot < 0 )
                    {
                        strRet = d.ToString ( "0.00" );
                        return strRet;
                    }

                    //处理带小数的类型
                    int nDotLen = nlen - 1 - ndot;   //小数点位数。   

                    if ( nDotLen >= 4 )
                        strRet = d.ToString ( "0.0000" );

                    else if ( nDotLen == 3 )
                        strRet = d.ToString ( "0.000" );

                    else 
                        strRet = d.ToString ( "0.00" );

                }
                catch ( Exception e )
                {
                    return "";
                }
                return strRet;
            }

            public DateTime Str2Date ( string str )
            {
                DateTime dat;

                try
                {
                    dat = Convert.ToDateTime ( str );
                }
                catch
                {
                    //dat = new DateTime ( 1900,1,1 );
                    dat = DateTime.Now;
                }

                return dat;
            }

            public string Str2DateStr_yyyyMM( string str )
            {
                if ( str.Trim() == String.Empty )
                    return String.Empty;
                return Str2Date( str ).ToString( "yyyy-MM" );
            }

            public string Str2DateStr_yyyyMMdd ( string str )
            {
                if ( str.Trim() == String.Empty )
                    return String.Empty;
                return Str2Date(str).ToString("yyyy-MM-dd");
            }

            public string Str2DateStr_yyyyMMddHHmm ( string str )
            {
                if ( str.Trim() == String.Empty )
                    return  String.Empty;
                return Str2Date ( str ).ToString ( "yyyy-MM-dd HH:mm" );
            }

            /// <summary>
            /// 把日期字串转成 "yyyy-MM-dd" 格式字串， 非法字串转为空字串。
            /// 用于从数据库读取DateTime类型， 因为数据库的日期可能为null， 如为null， 就返回显示空白字串。
            /// </summary>
            /// <param name="str"></param>
            /// <returns></returns>
            public string Str2DateStr_Null(string str)
            {
                string strRet = "";

                try
                {
                    strRet = Convert.ToDateTime(str).ToString("yyyy-MM-dd");
                }
                catch
                {
                    strRet = "";
                }

                return strRet;
            }

            public string Date2Str_1900 ( string strDate )
            {
                string str ;

                try
                {
                    str = DateTime.Parse ( strDate ).ToString ( "yyyy-MM-dd" );
                    if ( str.Contains ( "1900" ) )  //表示当初填写的是空白字串
                        return "";
                }
                catch ( Exception e )
                {
                    string strErr = e.Message;
                    return "";
                }

                return str;
            }

            public DateTime Str2Date_1900 ( string str )
            {
                DateTime dat;

                try
                {
                    dat = Convert.ToDateTime ( str );
                }
                catch
                {
                    dat = new DateTime ( 1900,1,1 );   //表示填写的空白字串。
                }

                return dat;
            }

            public string Str2DateStr_1900 ( string str )
            {
                try
                {
                    if ( str.Contains ( "1900" ) )  //表示填写的空白字串。
                        return "";

                    str = str.Replace ( "0:00:00" , "" );
                    str = str.Replace ( "00:00:00" , "" );
                }
                catch
                {
                    return "";
                }

                return str;
            }

            public string Str2DateStr1900_yyyyMMdd( string str )
            {
                try
                {
                    if ( string.IsNullOrEmpty( str.Trim() ) || str.Contains( "1900" ) )  //表示填写的空白字串。
                        return String.Empty;

                    str = FF.Fun.MyConvert.Str2Date( str ).ToString("yyyy-MM-dd");
                }
                catch
                {
                    return String.Empty;
                }

                return str;
            }

            int MACRO_PricePoint = 3; //货币放大移位 //默认=3 ,精确到厘。
            public int PricePointW
            {
                get { return MACRO_PricePoint;  } 
            }

            //转换后，钱币数字同时放大 MACRO_PricePoint 倍，保证是一个没有小数点的 long性数字。
            public long Str2Price ( string str )
            {
                if ( str.Trim () == String.Empty )
                    return 0;

                int PricePointW = MACRO_PricePoint;

                long lPrice = 0;
                int PointW = 0;

                try
                {
                    int n = str.IndexOf ( "." ); //F.ind ( "." ) ;
                    if ( n < 0 )
                    {
                        lPrice = Convert.ToInt32 ( str ); //atol ( str ) ;
                        for ( int i = 0 ; i < PricePointW ; i++ )
                            lPrice *= 10;
                    }
                    else
                    {
                        int len = str.Length;
                        PointW = len - 1 - n;

                        string str1 , str2;
                        str1 = str.Substring ( 0 , n ); //str.Left ( n ) ;
                        str2 = str.Substring ( str.Length - PointW , PointW );  //str.Right ( PointW ) ;
                        str = str1 + str2;

                        lPrice = Convert.ToInt32 ( str ); //atol ( str ) ;

                        if ( PointW <= PricePointW )
                        {
                            for ( int i = 0 ; i < ( PricePointW - PointW ) ; i++ )
                                lPrice *= 10;
                        }
                        else
                        {
                            for ( int i = 0 ; i < ( PointW - PricePointW ) ; i++ )
                                lPrice /= 10;
                        }
                    }
                }
                catch ( Exception e )
                {
                    FrontFlag.CONTROL ctrl = new CONTROL () ;
                    ctrl.MsgBox.Show ( "Err at Str2Price() function" );
                }

                return lPrice;
            }

            //把放大处理后的整形（MACRO_PricePoint倍数精度）的钱币数值， 转换成带小数点(.角分厘)的字符串。
            public string Price2Str ( long lPrice )
            {
                int PricePointW = MACRO_PricePoint;
                string str , str1 , str2 , strRet = "";

                try
                {
                    str = String.Format ( "{0}" , lPrice );
                    int len = str.Length;
                    int n = len - PricePointW;
                    if ( n < 0 )
                    {
                        string strZreo = "0.";
                        for ( int i = 0 ; i < PricePointW - len ; i++ )
                            strZreo += "0";
                        strRet = string.Format ( "{0}{1}" , strZreo , lPrice ); 
                    }
                    else if ( n == 0 )
                    {
                        strRet = String.Format ( "0.{0}" , lPrice );
                    }
                    else
                    {
                        str1 = str.Substring ( 0 , len - PricePointW );                     //get left
                        str2 = str.Substring ( str.Length - PricePointW , PricePointW );    //get right
                        strRet = String.Format ( "{0}.{1}" , str1 , str2 );
                    }
                }
                catch ( Exception e )
                {
                    FrontFlag.CONTROL ctrl = new CONTROL ();
                    ctrl.MsgBox.Show ( "Err at Price2Str() function" );
                }

                return strRet;
            }

            //用于处理 带小数的字符串 转换成长整形. 
            //自动扩大倍数， 直到小数点消失为止， 最终的扩大倍数通过 PointW 返回.
            public long A2L ( string str , ref int PointW )
            {
                if ( str.Trim () == String.Empty )
                    return 0;

                PointW = 0;
                long l = 0;

                try
                {
                    int n = str.IndexOf ( "." ); 
                    if ( n < 0 )
                    {
                        l = Convert.ToInt32 ( str ); 
                    }
                    else
                    {
                        int len = str.Length; 
                        PointW = len - 1 - n;   //得到小数点位置， 转换后的字符串，即是按这个位置的放放大倍数的整数。

                        string str1 , str2;
                        str1 = str.Substring ( 0 , n );   //get left part of pint.
                        str2 = str.Substring ( str.Length - PointW , PointW );  //get right part of pint.
                        str = str1 + str2;   //combin without point.

                        l = Convert.ToInt32 ( str ); 
                    }
                }
                catch ( Exception e )
                {
                    FrontFlag.CONTROL ctrl = new CONTROL ();
                    ctrl.MsgBox.Show ( "Err at A2L() function" );
                }
                return l;
            }

            //用于处理 带小数的字符串 转换成长整形.
            //扩大指定的倍数, 如果小数点不足, 会在转换后的字符串后面补零.
            public long A2LFix ( string str , int PointW )  
            {
                if ( str.Trim () == String.Empty )
                    return 0;

                long lRet = 0;

	            try 
	            {
                    int n = str.IndexOf ( "." );    //是整数,直接扩大倍数.
		            if ( n < 0 )
		            {
			            lRet = Convert.ToInt32 ( str ) ;
			            for ( int i = 0 ; i < PointW ; i ++ )
				            lRet *= 10 ;
		            }
		            else
		            {
			            int len = str.Length ;
			            int curPW = len - 1 - n ;      //目前的小数点位数

			            string str1 , str2 ;
			            str1 = str.Substring ( 0 , n ) ;                        //get left part of pint.
                        str2 = str.Substring( str.Length - curPW , curPW ) ;    //get right part of pint.
			            str = str1 + str2 ;                                     //combin without point.
			            lRet = Convert.ToInt32 ( str ) ;

			            if ( curPW < PointW )           //指定的倍数大于目前的倍数， 扩大差额的部分。
			            {
				            for ( int i = 0 ; i < PointW-curPW ; i ++ )
					            lRet *= 10 ; 	
			            }
                        else if ( curPW > PointW )      //指定的倍数小于目前的倍数， 缩小差额的部分。会丢失部分精度.
			            {
				            for ( int i = 0 ; i < curPW-PointW ; i ++ )
					            lRet /= 10 ; 	
			            }
		            }
	            }
	            catch ( Exception e ) 
	            {
                    FrontFlag.CONTROL ctrl = new CONTROL ();
                    ctrl.MsgBox.Show ( "Err at A2LFix() function" );
	            }

	            return lRet ;
            }

            //把整形 转换成(缩小指定倍数) 带小数点的 字符串.
            public string L2A ( long l , int PointW )
            {
                string str , str1 , str2 , strRet = "";

                try
                {
                    str = String.Format ( "{0}" , l );  
                    int len = str.Length;
                    int n = len - PointW ;
                    if ( n < 0 )
                    {
                        string strZreo = "0." ;
                        for ( int i = 0 ; i < PointW - len ; i++ )
                            strZreo += "0";
                        strRet = string.Format ( "{0}{1}" , strZreo , l ); 
                    }
                    else if ( n == 0 )
                    {
                        strRet = string.Format ( "0.{0}" , l ); 
                    }
                    else
                    {
                        str1 = str.Substring ( 0 , len - PointW );  //get left part
                        str2 = str.Substring ( str.Length - PointW , PointW ); //get right part
                        strRet = string.Format ( "{0}.{1}" , str1 , str2 ); //.Format ( "%s.%s" ,str1 , str2 ) ; 
                    }
                }
                catch ( Exception e )
                {
                    FrontFlag.CONTROL ctrl = new CONTROL ();
                    ctrl.MsgBox.Show ( "Err at L2A() function" );
                }

                int m = strRet.IndexOf ( '.' );     //让人看起来 是精确到分。
                if ( m < 0 )
                {   
                    strRet += ".00";
                }
                else 
                { 
                    if ( m == strRet.Length -1 )    //1234. 的 情况。
                        strRet += "00";
                    else if ( m == strRet.Length - 2 )    //1234.5 的 情况。
                        strRet += "0";
                }

                return strRet;
            }

            /// <summary>
            /// 精确到小数点后4位。最少小数是2位。
            /// </summary>
            /// <param name="d"></param>
            /// <returns></returns>
            public string Decimal2StrDot4 ( decimal d )
            {
                string str = d.ToString ( "0.0000" );
                if ( str.EndsWith ( "0000" ) )
                    str =  d.ToString ( "0.00" );
                else if ( str.EndsWith ( "000" ) )
                    str =  d.ToString ( "0.00" );
                else if ( str.EndsWith ( "00" ) )
                    str = d.ToString ( "0.00" );
                else if ( str.EndsWith ( "0" ) )
                    str = d.ToString ( "0.000" );

                return str;
            }
            public string Decimal2StrDot4 ( string str )
            {
                decimal d = Str2Decimal ( str );
                return Decimal2StrDot4 ( d );

            }

            #region 复合类型的字符串化转换

            public string Color2CombinStr ( Color color )
            {
                return string.Format ( "{0}|{1}|{2}", color.R, color.G, color.B );
            }

            public Color CombinStr2Color ( string strCombin )
            {
                Color clr = Color.Black;

                try
                {
                    char[] chs = new char[] {'|'};
                    string[] strs = strCombin.Split(chs);
                    if (strs == null || strs.Length != 3)
                        return clr;

                    int R = int.Parse(strs[0]);
                    int G = int.Parse(strs[1]);
                    int B = int.Parse(strs[2]);
                    clr = Color.FromArgb(R, G, B);
                }
                catch ( Exception e )
                {
                    FF.Ctrl.MsgBox.ShowWarn("FrontFlag.MyConert.CombinStr2Color转换发生错误!" + " " + e.Message);
                    return clr;
                }

                return clr;
            }

            public string strs2CombinStr ( string [] strs )
            {
                string strRet = "";

                if ( strs == null || strs.Length <= 0 )
                    return strRet;
 
                foreach ( string str in strs )
                {
                    if ( strRet != "" )
                        strRet += "|";

                    strRet += str;
                }

                return strRet;
            }

            public string [] CombinStr2strs ( string strCombin )
            {
                char [] chs = new char [] { '|' };
                return strCombin.Split ( chs );
            }

            public string ary2CombinStr ( ArrayList ary )
            {
                string strRet = "";

                if ( ary == null || ary.Count <= 0 )
                    return strRet;

                foreach ( string str in ary )
                {
                    if ( strRet != "" )
                        strRet += "|";

                    strRet += str;
                }

                return strRet;
            }

            public ArrayList CombinStr2ary ( string strCombin )
            {
                ArrayList ary = new ArrayList();

                char [] chs = new char [] { '|' };
                string [] strs =  strCombin.Split ( chs );
                if ( strs == null || strs.Length <= 0 )
                    return ary;

                foreach ( string str in strs )
                    ary.Add(str);

                return ary;
            }

            #endregion

            public ArrayList strs2Ary ( string [] strs )
            {
                if ( strs == null || strs.Length <= 0 )
                    return null;

                ArrayList ary = new ArrayList();
                foreach ( string str in strs )
                    ary.Add(str);
                return ary;
            }

            public ArrayList strs2Ary_WithBlank(string[] strs)
            {
                if (strs == null || strs.Length <= 0)
                    return null;

                ArrayList ary = new ArrayList();
                ary.Add(" ");
                foreach (string str in strs)
                    ary.Add(str);
                return ary;
            }

            public string [] Ary2strs ( ArrayList ary )
            {
                if ( ary.Count <= 0 )
                    return null;

                string [] strs = new string [ ary.Count ];

                int n = 0;
                foreach ( string str in ary )
                    strs[n++] = str;

                return strs;
            }

            public List<string> strs2List( string[] strs )
            {
                List<string> lst = new List<string>();

                if ( strs == null || strs.Length <= 0 )
                    return lst;

                foreach ( string str in strs )
                    lst.Add( str );

                return lst;
            }
        }

        public class DATE
        {
            public string GetTodayStr ()
            {
                string strToday = String.Format ( "{0}-{1}-{2}" , DateTime.Now.Year , DateTime.Now.Month , DateTime.Now.Day );
                return strToday;
            }

            public string GetFullTodayStr ()
            {
                string strToday = String.Format ( "{0}-{1}-{2} {3}:{4}:{5}" , DateTime.Now.Year , DateTime.Now.Month , DateTime.Now.Day , DateTime.Now.Hour , DateTime.Now.Minute , DateTime.Now.Second );
                return strToday;
            }

            public string GetNextDayStr ()
            {
                string strNextday = String.Format ( "{0}-{1}-{2}" , DateTime.Now.AddDays ( 1 ).Year , DateTime.Now.AddDays ( 1 ).Month , DateTime.Now.AddDays ( 1 ).Day );
                return strNextday;
            }
            public string GetNextDayStr ( DateTime date )
            {
                string strNextday = String.Format ( "{0}-{1}-{2}" , date.AddDays ( 1 ).Year , date.AddDays ( 1 ).Month , date.AddDays ( 1 ).Day );
                return strNextday;
            }
            public string GetAnyDayStr ( DateTime date )
            {
                string strday = String.Format ( "{0}-{1}-{2}" , date.Year , date.Month , date.Day );
                return strday;
            }
            public string GetMMDD ( DateTime date )
            {
                string strday = String.Format ( "{0,2:0}/{1,2:0}" , date.Month , date.Day );
                return strday;
            }
            public string Date2FullString ( DateTime date )
            {
                string str = String.Format ( "{0}-{1}-{2} {3}:{4}:{5}" , date.Year , date.Month , date.Day , date.Hour , date.Minute , date.Second );
                return str;
            }
            public string Date2DayString ( DateTime date )
            {
                string str = String.Format ( "{0}-{1}-{2}" , date.Year , date.Month , date.Day );
                return str;
            }

            public DateTime GetNextWeek ( DateTime dat , int n )  //1=Mon ;0=Sunday
            {
                int m = ( int ) dat.DayOfWeek;
                int dlt = 0;
                if ( n > m )
                    dlt = n - m;
                else if ( n < m )
                    dlt = n + 7 - m;

                return dat.AddDays ( dlt ); ;
            }
            public DateTime GetNextWeek ( int n )  //1=Mon ;0=Sunday
            {
                return GetNextWeek ( DateTime.Now , n );
            }

            public DateTime GetNextMonth ( DateTime dat , int nJG )
            {
                DateTime datRet;

                int nYear = int.Parse ( dat.ToString ( "yyyy" ) );
                int nMonth = int.Parse ( dat.ToString ( "MM" ) );
                int nDay = int.Parse ( dat.ToString ( "dd" ) );

                int nNextMonth = ( nMonth + nJG > 12 ) ? nMonth + nJG - 12 : nMonth + nJG;
                int nNextYear = ( nMonth + nJG > 12 ) ? nYear + 1 : nYear;

                int daysNuminNextMonth = DateTime.DaysInMonth ( nNextYear , nNextMonth );

                if ( nDay > daysNuminNextMonth )
                {
                    datRet = new DateTime ( nNextYear , nNextMonth + 1 , nDay ); //maybe have err ?
                }
                else
                {
                    datRet = new DateTime ( nNextYear , nNextMonth , nDay );
                }

                return datRet;
            }

            public int DiffDay ( DateTime dat2 , DateTime dat1 )
            {
                TimeSpan ts = dat2 - dat1;
                return ts.Days;
            }

            //n 可以为负， 表示今天之前的日期。
            public string AddDay ( int n )
            {
                DateTime dat = DateTime.Now.AddDays ( n );
                return dat.ToShortDateString ( );
            }

            //2007-01-31 12:30:59 => 2007-01-31
            public string TrimDate ( string strDate )
            {
                int n = strDate.IndexOf ( " " );
                if ( n < 0 )
                    return strDate;

                string strRet = strDate.Substring ( 0 , n );
                return strRet;
            }

            /// <summary>
            /// 得到前/后几个月的当月1号的日期.   //nDiffMonth可正可负
            /// </summary>
            /// <param name="nDiffMonth"></param>
            /// <returns></returns>
            public DateTime GetMonthFirstDay ( int nDiffMonth )
            {
                //DateTime dat = DateTime.Now;
                DateTime dat = new DateTime ( DateTime.Now.Year , DateTime.Now.Month , DateTime.Now.Day , 0 , 0 , 0 );

                dat = dat.AddMonths ( nDiffMonth );
                int nDiffDay = dat.Day;
                dat = dat.AddDays ( -nDiffDay + 1 );   //不加1的话， 是上个月的最后一天。

                return dat;
            }

            /// <summary>
            /// 得到前/后几个月的当月最后一天的日期.   //nDiffMonth可正可负
            /// </summary>
            /// <param name="nDiffMonth"></param>
            /// <returns></returns>
            public DateTime GetMonthLastDay ( int nDiffMonth )
            {
                //DateTime dat = DateTime.Now;
                DateTime dat = new DateTime ( DateTime.Now.Year , DateTime.Now.Month , DateTime.Now.Day , 23 , 59 , 59 );

                dat = dat.AddMonths ( nDiffMonth + 1 );
                int nDiffDay = dat.Day;
                dat = dat.AddDays ( -nDiffDay );   //不加1的话， 是上个月的最后一天。

                return dat;
            }

            //得到指定年月的最后一天的日期. 
            public DateTime GetMonthLastDay ( int nYear , int nMonth )
            {
                DateTime dat = new DateTime ( nYear , nMonth , 1 );

                dat = dat.AddMonths ( 1 );
                int nDiffDay = dat.Day;
                dat = dat.AddDays ( -nDiffDay );   //不加1的话， 是上个月的最后一天。

                return dat;
            }

            //得到指定年月的第一天的日期. 
            public DateTime GetMonth_FirstDay ( DateTime d )
            {
                DateTime dat = new DateTime ( d.Year, d.Month, 1 );
                return dat;
            }

            //得到指定年月的最后一天的日期. 
            public DateTime GetMonth_LastDay ( DateTime d )
            {
                DateTime dat = new DateTime ( d.Year, d.Month, 1 );

                dat = dat.AddMonths ( 1 );
                dat = dat.AddDays ( -1 );
                dat = new DateTime ( dat.Year, dat.Month, dat.Day, 23, 59, 59 );
                return dat;
            }

            public DateTime 身份证2生日(string str身份证号码)
            {
                int nLen = str身份证号码.Length;
                if (nLen < 14) //xxxxxx 19700525 xxxx
                    return new DateTime( 1800, 1, 1 );  //SqlDateTime可以储存的最小年份是1753 

                string strYear = str身份证号码.Substring(6, 4);
                string strMonth = str身份证号码.Substring( 10, 2 );
                string strDay = str身份证号码.Substring( 12, 2 );

                int nYear = FF.Fun.MyConvert.Str2Int(strYear);
                int nMonth = FF.Fun.MyConvert.Str2Int( strMonth );
                int nDay = FF.Fun.MyConvert.Str2Int( strDay );

                DateTime dat生日 = new DateTime( nYear, nMonth, nDay );
                return dat生日;
            }
        }

        public string SetXOP ( string strSrc , string strSeed )
        {
            string strDes = "";

            char ch;
            //char [ ] chSeed2 = new char [ ] { 'a' , 'b' , 'c' , '1' , '2' };
            int nSeedCount = strSeed.Length;

            int Len = strSrc.Length;
            if ( Len <= 0 )
                return strDes;

            for ( int i = 0 ; i < Len ; i++ )
            {
                ch = strSrc [ i ];
                ch ^= strSeed [ i % nSeedCount ];
                strDes += ch;
            }

            return strDes;
        }

        /// <summary>
        /// 从 变量字串中体制指定的变量的值。
        /// 比如从  "a=1 b=2 c=3" 字串中，提取 b的变量2 ， 可以执行  PickParmaString( "a=1 b=2 c=3" , "a", "=" )
        /// </summary>
        /// <param name="strOrg"></param>
        /// <param name="strKey"></param>
        /// <param name="strJG"></param>
        /// <returns></returns>
        public string PickParmaString ( string strOrg , string strKey , string strJG )
        {
            string str , strTmp;

            int n = strOrg.IndexOf ( strKey );
            if ( n == -1 )
                return "";

            strOrg = strOrg.Substring ( n , strOrg.Length );    //remove left from strKey , remain right

            n = strOrg.IndexOf ( strJG );
            if ( n == -1 )
                return "";
            strOrg = strOrg.Substring(n + strJG.Length, strOrg.Length - n - strJG.Length);    //remove strJG , remain right

            n = strOrg.IndexOf ( " " );
            if ( n >= 0 )
                strOrg = strOrg.Substring ( 0 , n );

            return strOrg.Trim ( );
        }

        public string PickParmaString ( string strOrg , string strKey )
        {
            return PickParmaString ( strOrg , strKey , "=" );
        }

        public int GetIndexFromStrAry ( string [ ] strary , string str )
        {
            int n = strary.Length;
            for ( int i = 0 ; i < n ; i++ )
            {
                if ( str.ToLower ( ) == strary [ i ].ToLower ( ) )
                    return i;
            }
            return -1;
        }

        public bool IsDBNull ( object obj )
        {
            if ( obj.GetType ( ).FullName == "System.DBNull" )
                return true;
            else
                return false;
        }

        public bool IsEmail ( string strEmail )
        {
            if ( !Regex.IsMatch ( strEmail.Trim ( ) , "\\w+([-+.]\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*" ) )
            {
                return false;
            }
            return true;
        }

        public string Obj2String ( object obj )
        {
            string str = "";

            if ( obj.GetType ( ).FullName == "System.DBNull" )
                return str;
            else
                str = obj.ToString ( ).Trim ( );

            return str;
        }

        /// <summary>
        /// 设定权限的Int。用2进制的标志位，标明权限。1=有权限，0=无权限
        /// 可见 可改 可删 可建
        ///   1    1    1    1
        /// </summary>
        public class POPEDOMBYTE
        {
            byte _p = 0;

            byte bRead = 0x01;
            byte bModify = 0x02;
            byte bDelete = 0x04;
            byte bCreate = 0x08;

            #region 属性

            public byte p
            {
                set { _p = value; }
                get { return _p; }
            }

            public bool CanRead 
            {
                set { if (value) { p |= bRead; } else { p &= ((byte)~bRead); }; }
                get { return ( ( p & bRead ) == bRead) ? true : false; }
            }

            public bool CanModify
            {
                set { if (value) { p |= bModify; } else { p &= ((byte)~bModify); }; }
                get { return ((p & bModify) == bModify) ? true : false; }
            }

            public bool CanDelete
            {
                set { if (value) { p |= bDelete; } else { p &= ((byte)~bDelete); }; }
                get { return ((p & bDelete) == bDelete) ? true : false; }
            }

            public bool CanCreate
            {
                set { if (value) { p |= bCreate; } else { p &= ((byte)~bCreate); }; }
                get { return ((p & bCreate) == bCreate) ? true : false; }
            }

            public bool CanAll
            {
                set { p |= bRead; p |= bCreate; p |= bModify; p |= bDelete; }
                get { return CanRead && CanCreate && CanModify && CanDelete; }
            } 

            #endregion


        }



    }

}
