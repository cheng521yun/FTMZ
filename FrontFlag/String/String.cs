using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace FrontFlag
{
    public class STRING
    {
        public DATE Date = new DATE();
        public WHERE Where = new WHERE();
        public COMBIN Combin = new COMBIN();
        public ARRAY Array = new ARRAY();
        public FORMAT Format = new FORMAT();
        public HTM Htm = new HTM();
        public STRS Strs = new STRS();
        public CHECK Check = new CHECK();
        public SUBSTR SubStr = new SUBSTR();
        public HELPER Helper = new HELPER();
    }

    public class DATE
    {
        //06.31
        public string GetMMDD( string strDate )
        {
            string strRet = "";
            char[] ch = { '-', ' ', ':' };
            string[] strs = strDate.Split( ch );

            if ( strs.Length >= 3 )
                strRet = String.Format( "{0,2:00}/{1,2:00}", strs[ 1 ], strs[ 2 ] );

            return strRet;
        }

        //2006-06-31
        public string GetYYYYMMDD( string strDate )
        {
            string strRet = "";
            char[] ch = { '-', ' ', ':' };
            string[] strs = strDate.Split( ch );
            string strYear = strs[ 0 ];
            if ( strYear.Length > 2 )
                strYear = strYear.Substring( 2, 2 ); //2007->07

            if ( strs.Length >= 3 )
                strRet = String.Format( "{0}-{1,2:00}-{2,2:00}", strYear, strs[ 1 ], strs[ 2 ] );

            return strRet;
        }

        //2006-06-31 12:30
        public string GetYYMMDDhhmm( string strDate )
        {
            string strRet = "";
            char[] ch = { '-', ' ', ':' };
            string[] strs = strDate.Split( ch );

            if ( strs.Length >= 5 )
                strRet = String.Format( "{0}-{1}-{2} {3}:{4}", strs[ 0 ], strs[ 1 ], strs[ 2 ], strs[ 3 ], strs[ 4 ] );

            return strRet;
        }

        public string GetNow_yyyyMMddHHmmss()
        {
            return DateTime.Now.ToString( "yyyy-MM-dd HH:mm:ss" );
        }

        public string GetNow_yyyyMMddHHmm()
        {
            return DateTime.Now.ToString( "yyyy-MM-dd HH:mm" );
        }

        public string GetNow_yyyyMMdd()
        {
            return DateTime.Now.ToString( "yyyy-MM-dd" );
        }

        public string GetNow_yyMMddHHmmss()
        {
            return DateTime.Now.ToString( "yy-MM-dd HH:mm:ss" );
        }

        public string GetNow_yyMMddHHmm()
        {
            return DateTime.Now.ToString( "yy-MM-dd HH:mm" );
        }

        public string GetNow_yyMMdd()
        {
            return DateTime.Now.ToString( "yy-MM-dd" );
        }

        public string GetBeforeDay( int nDeforeDay )
        {
            TimeSpan Span = new TimeSpan( nDeforeDay, 0, 0, 0 );

            DateTime day = DateTime.Now;
            day += Span;

            string strRet = String.Format( "{0,4}-{1,2:00}-{2,2:00}", day.Year, day.Month, day.Day );
            return strRet;
        }

        public string GetOnlyDay( string strFullDate )
        {
            string strRet = strFullDate;

            int n = strFullDate.IndexOf( " " );
            if ( n <= 0 )
                return strRet;

            strRet = strRet.Substring( 0, n ).Trim();
            return strRet;
        }

        public string Get_yyyyMMddHHmm_1900( string str )
        {
            if ( str.Trim() == String.Empty || str.Contains( "1900" ) )
                return String.Empty;

            DateTime dat;
            try
            {
                dat = Convert.ToDateTime( str );
            }
            catch
            {
                return String.Empty;
            }

            return dat.ToString( "yyyy-MM-dd HH:mm" );
        }

        public string Get_yyyyMMdd_1900( string str )
        {
            if ( str.Trim() == String.Empty || str.Contains( "1900" ) )
                return String.Empty;

            DateTime dat;
            try
            {
                dat = Convert.ToDateTime( str );
            }
            catch
            {
                return String.Empty;
            }

            return dat.ToString( "yyyy-MM-dd" );
        }
    }

    public class WHERE
    {
        public void AndWhereCause( ref string strWhere, string strCause )
        {
            if ( strCause.Trim() == "" )
                return;

            if ( strWhere.Trim() == "" )
                strWhere = strCause;
            else
            {
                strWhere = string.Format( "( {0} )", strWhere );
                strWhere += " and ( " + strCause + " ) ";
            }

            return;
        }

        public void ORWhereCause( ref string strWhere, string strCause )
        {
            if ( strCause.Trim() == "" )
                return;

            if ( strWhere.Trim() == "" )
                strWhere = strCause;
            else
            {
                strWhere = string.Format( "( {0} )", strWhere );
                strWhere += " OR ( " + strCause + " ) ";
            }

            return;
        }

        public string GetWhereByAry( ref ArrayList aryStr )
        {
            string strWhere = "";
            int i = 0;
            foreach ( string str in aryStr )
            {
                if ( str.Trim() == "" )
                    continue;

                if ( i > 0 )
                    strWhere += " AND ";

                strWhere += " (" + str + ") ";
                i++;
            }

            return strWhere;
        }

        public string GetWhereByList( List<string> lstWhere )
        {
            string strWhere = "";
            int i = 0;
            foreach ( string str in lstWhere )
            {
                if ( str.Trim() == "" )
                    continue;

                if ( i > 0 )
                    strWhere += " AND ";

                strWhere += " (" + str + ") ";
                i++;
            }

            return strWhere;
        }

        public string GetWhereByAry_WithOR( ref ArrayList aryStr )
        {
            string strWhere = "";
            int i = 0;
            foreach ( string str in aryStr )
            {
                if ( str.Trim() == "" )
                    continue;

                if ( i > 0 )
                    strWhere += " OR ";

                strWhere += " (" + str + ") ";
                i++;
            }

            return strWhere;
        }

        public string GetWhereByList_WithOR( List<string> lstWhere )
        {
            string strWhere = "";
            int i = 0;
            foreach ( string str in lstWhere )
            {
                if ( str.Trim() == "" )
                    continue;

                if ( i > 0 )
                    strWhere += " OR ";

                strWhere += " (" + str + ") ";
                i++;
            }

            return strWhere;
        }

        public string CauseAddWhereWord( string strWhere )
        {
            if ( !String.IsNullOrEmpty( strWhere.Trim() ) )
                strWhere = String.Format( " Where {0}", strWhere );
            return strWhere;
        }
    }

    public class COMBIN
    {
        char _chSplit = '|';
        string _strSplit = "|";

        #region 属性

        public char SplitSign
        {
            set { _chSplit = value; _strSplit = value.ToString(); }
        }

        #endregion

        public string Add( string str1, string str2, string strSign )
        {
            if ( str1.Trim() == "" && str2.Trim() == "" )
                return "";

            if ( str1.Trim() == "" )
                return str2;

            if ( str2.Trim() == "" )
                return str1;

            return str1 + " " + strSign + " " + str2;
        }

        public string Add( string str1, string str2 )
        {
            return Add( str1, str2, "|" );
        }

        /// <summary>
        /// 把所有参数用|符号串联起来.
        /// Combin( "A","B","C" ) => A|B|C
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public string Combin( params  string[] args )
        {
            string strResult = "";
            foreach ( string str in args )
            {
                if ( strResult.Length > 0 )
                    strResult += _strSplit;

                strResult += str;
            }
            return strResult;
        }

        public string Combin( List<string> lst )
        {
            string strResult = "";
            foreach ( string str in lst )
            {
                if ( strResult.Length > 0 )
                    strResult += _strSplit;

                strResult += str;
            }
            return strResult;
        }

        /// <summary>
        /// 初始的strCombin一定要是"".
        /// </summary>
        /// <param name="strCombin"></param>
        /// <param name="str"></param>
        public void CombinAppend( ref string strCombin, string str )
        {
            if ( strCombin == "" )
            {
                if ( str == "" )
                    str = " ";      //为了和初始的""相区分。
                strCombin = str;
            }
            else
                strCombin = strCombin + _strSplit + str;
            return;
        }

        public string[] UnCombin( string strCombin )
        {
            char[] chs = { _chSplit };
            string[] strs = strCombin.Split( chs );

            if ( strs == null )
                return null;

            int nCount = strs.Length;
            for ( int i = 0 ; i < nCount ; i++ )
            {
                if ( strs[ i ] == null )
                    strs[ i ] = "";
                else
                    strs[ i ] = strs[ i ].Trim();
            }

            return strs;
        }

        public string UnCombin2Str( string strCombin )
        {
            string strRet = "";

            char[] chs = { _chSplit };
            string[] strs = strCombin.Split( chs );

            if ( strs == null )
                return "";

            int nCount = strs.Length;
            for ( int i = 0 ; i < nCount ; i++ )
            {
                if ( strs[ i ] != null )
                    strRet += strs[ i ].Trim() + " ";
            }

            return strRet.Trim();
        }

        public List<string> UnCombin2List( string strCombin )
        {
            List<string> lst = new List<string>();

            char[] chs = { _chSplit };
            string[] strs = strCombin.Split( chs );

            if ( strs == null )
                return lst;

            int nCount = strs.Length;
            for ( int i = 0 ; i < nCount ; i++ )
            {
                if ( strs[ i ] != null && ! String.IsNullOrEmpty( strs[ i ].Trim() ) )
                    lst.Add( strs[ i ].Trim() ); 
            }

            return lst;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="strCombin"></param>
        /// <param name="No"></param>
        /// <returns>返回null,表示No超界，无有效值。返回""，表示可以取到合法值，但内容是空。</returns>
        public string GetUnit( string strCombin, int No )
        {
            string[] strs = UnCombin( strCombin );
            if ( strs == null || No < 0 || No >= strs.Length )
                return null;

            return strs[ No ];
        }

        /// <summary>
        /// 从一个合并字串中读取指定Key的内容
        /// 合并字串的样式类似于 Width:100|Height:200|Unit:张
        /// </summary>
        /// <param name="strCombin"></param>
        /// <param name="No"></param>
        /// <returns>返回null,表示No超界，无有效值。返回""，表示可以取到合法值，但内容是空。</returns>
        public string GetKeyValue( string strCombin, string strKey )
        {
            string[] strsUnit = UnCombin( strCombin );
            if ( strsUnit == null )
                return null;

            foreach ( string str in strsUnit )
            {
                COMBIN cb = new COMBIN();
                cb.SplitSign = ':';

                string[] strs = cb.UnCombin( str );
                if ( strs == null || strs.Length != 2 )
                    continue;

                if ( strs[ 0 ] == strKey )
                    return strs[ 1 ];
            }

            return null;
        }

    };

    public class ARRAY
    {
        public bool IsStrInAry( ref ArrayList ary, string strItem )
        {
            foreach ( string str in ary )
            {
                if ( str == strItem )
                    return true;
            }
            return false;
        }

        public int IndexOfAry( ref ArrayList ary, string strItem )
        {
            int i = 0;
            foreach ( string str in ary )
            {
                if ( str == strItem )
                    return i;

                i++;
            }
            return -1;
        }

        public int IndexOfAry( ref ArrayList ary, Object strItem )
        {
            int i = 0;
            foreach ( string str in ary )
            {
                if ( str == strItem )
                    return i;

                i++;
            }
            return -1;
        }
    };

    public class STRS
    {
        /// <summary>
        /// 查看一个字符串是否是string[]里的元素。
        /// 区分大小写。case-sensitive 大小写敏感。
        /// </summary>
        /// <param name="strs"></param>
        /// <param name="strUnit"></param>
        /// <returns></returns>
        public bool IsElement( ref string[] strs, string strUnit )
        {
            foreach ( string str in strs )
            {
                if ( str == strUnit )
                    return true;
            }
            return false;
        }

        /// <summary>
        /// 查看一个字符串是否是string[]里的元素。
        /// 不区分大小写。case-insensitive 大小写不敏感。
        /// </summary>
        /// <param name="strs"></param>
        /// <param name="strUnit"></param>
        /// <returns></returns>
        public bool IsElement_CI( ref string[] strs, string strUnit )
        {
            foreach ( string str in strs )
            {
                if ( str.Trim().ToLower() == strUnit.Trim().ToLower() )
                    return true;
            }
            return false;
        }

        public int GetIndex( string[] strs, string strUnit )
        {
            int nIndex = -1;
            foreach ( string str in strs )
            {
                nIndex++;
                if ( str == strUnit )
                    return nIndex;
            }
            return -1;
        }

    }

    public class FORMAT
    {
        /// <summary>
        /// 首字母大写
        /// </summary>
        /// <param name="strOrg"></param>
        /// <returns></returns>
        public string FirstCaptal( string strOrg )
        {
            strOrg = strOrg.ToLower();

            int n = strOrg.Length;
            if ( n <= 0 )
            {
                return strOrg;
            }

            char ch = strOrg[ 0 ];
            if ( ch > '~' )        //可能是汉字
                return strOrg;

            if ( n > 1 )
            {
                string str1, str2;
                str1 = strOrg.Substring( 0, 1 );
                str1 = str1.ToUpper();
                str2 = strOrg.Substring( 1, strOrg.Length - 1 );
                strOrg = str1 + str2;
            }

            return strOrg;
        }

        #region 千分符
        public string MicrometerOpt( int nOrg )
        {
            return String.Format( "{0:N}", nOrg );
        }

        public string MicrometerOpt( decimal dOrg )
        {
            return String.Format( "{0:N}", dOrg );
        }

        public string MicrometerOpt_2P( decimal dOrg )
        {
            dOrg = FF.Fun.MyConvert.Decimal_2P( dOrg );
            return String.Format( "{0:N}", dOrg );
        }

        public string MicrometerOpt_4P( decimal dOrg )
        {
            dOrg = FF.Fun.MyConvert.Decimal_4P( dOrg );
            return String.Format( "{0:N}", dOrg );
        }

        #endregion
    };

    public class HTM
    {
        //Create Table
        public string GetTable( string strTabTag, string strTDTag, int nCol, ArrayList aryCell )
        {
            string strRet = "", str;

            int nCount = aryCell.Count;
            int nLine = ( nCount % nCol ) == 0 ? ( nCount / nCol ) : ( nCount / nCol ) + 1;
            int No;

            strRet = "<table " + strTabTag + ">";
            for ( int n = 0 ; n < nLine ; n++ )
            {
                strRet += "<tr>";
                for ( int m = 0 ; m < nCol ; m++ )
                {
                    strRet += "<td " + strTDTag + " >";

                    No = n * nCol + m;
                    if ( No < nCount )
                        strRet += aryCell[ No ].ToString().Trim();

                    strRet += "</td>";
                }
                strRet += "</tr>";
            }
            strRet += "</table>";

            return strRet;

        }

        //Create Table 可以设置每个cell的属性可以不一样, 但每行都一样.
        public string GetTable( string strTabTag, string[] strsTDTag, ArrayList aryCell )
        {
            string strRet = "", str;

            int nCount = aryCell.Count;
            int nCol = strsTDTag.Length;
            int nLine = ( nCount % nCol ) == 0 ? ( nCount / nCol ) : ( nCount / nCol ) + 1;
            int No;

            strRet = "<table " + strTabTag + ">";
            for ( int n = 0 ; n < nLine ; n++ )
            {
                strRet += "<tr>";
                for ( int m = 0 ; m < nCol ; m++ )
                {
                    strRet += "<td " + strsTDTag[ m ] + " >";

                    No = n * nCol + m;
                    if ( No < nCount )
                        strRet += aryCell[ No ].ToString().Trim();

                    strRet += "</td>";
                }
                strRet += "</tr>";
            }
            strRet += "</table>";

            return strRet;
        }

        //Create Table 可以设置每个cell的属性可以不一样, 每一行,每一列都可以不一样. aryTDTag中的元素是string []，用于描述每一cell的样式属性。
        public string GetTable( string strTabTag, ArrayList aryTDTag, ArrayList aryCell )
        {
            string strRet = "", str;

            if ( aryTDTag.Count <= 0 )
                return "";

            int nCount = aryCell.Count;
            string[] strsTDTag = (string[])aryTDTag[ 0 ];
            int nCol = strsTDTag.Length;
            int nLine = ( nCount % nCol ) == 0 ? ( nCount / nCol ) : ( nCount / nCol ) + 1;
            int No;

            strRet = "<table " + strTabTag + ">";
            for ( int n = 0 ; n < nLine ; n++ )
            {
                strsTDTag = (string[])aryTDTag[ n ];

                strRet += "<tr>";
                for ( int m = 0 ; m < nCol ; m++ )
                {
                    strRet += "<td " + strsTDTag[ m ] + " >";

                    No = n * nCol + m;
                    if ( No < nCount )
                        strRet += aryCell[ No ].ToString().Trim();

                    strRet += "</td>";
                }
                strRet += "</tr>";
            }
            strRet += "</table>";

            return strRet;
        }

    }

    public class CHECK
    {
        //是否是整数; 只包含0-9 
        public bool IsInteger( string str )
        {
            bool bFlag = true;
            foreach ( char ch in str )
            {
                if ( !Char.IsDigit( ch ) )
                    return false;
            }
            return bFlag;
        }

        //是否是小数. 只能有一个点。 一般用于输入浮点数 或者 钱币金额。
        public bool IsFloat( string str )
        {
            int n = 0;
            foreach ( char ch in str )
            {
                if ( ch == '.' )
                {
                    n++;
                    if ( n > 1 )
                        return false;
                }
                else if ( Char.IsDigit( ch ) )  //0-9
                {
                }
                else
                    return false;
            }
            return true;
        }
        public bool IsPrice( string str )
        {
            return IsFloat( str );
        }

        //是否是数字， 包括整形和浮点性。
        public bool IsNumber( string str )
        {
            bool bRet = false;
            bRet |= IsInteger( str );
            bRet |= IsFloat( str );

            return bRet;
        }

        //是否是数字或者空白， 包括整形和浮点性。
        public bool IsNumberBlank( string str )
        {
            if ( str.Trim() == String.Empty )
                return true;

            bool bRet = false;
            bRet |= IsNumber( str );
            return bRet;
        }

        public bool IsLetter( string str )
        {
            bool bFlag = true;
            foreach ( char ch in str )
            {
                if ( !Char.IsLetter( ch ) )
                    return false;
            }
            return bFlag;
        }

        public string FilterCtrlChar( string strOrg )
        {
            List<char> lstCh = new List<char>();
            char[] chs = strOrg.ToCharArray();

            foreach ( char ch in chs )
            {
                if ( ch < ' ' )
                {
                }
                else if ( ch > '~' )
                {
                    lstCh.Add( ch );
                }
                else
                {
                    lstCh.Add( ch );
                }
            }

            string strRet = new string( lstCh.ToArray() );
            return strRet;
        }
    }

    public class SUBSTR
    {
        //ABC123 => ABC
        public string GetPreChar( string strOrg )
        {
            string strRet = "";

            foreach ( char ch in strOrg )
            {
                if ( !Char.IsLetter( ch ) )
                    break;
                strRet += ch;
            }
            return strRet;
        }
    }

    public class HELPER
    {
        public string GetSexStr( string strDBVal )
        {
            return ( strDBVal == "True" ) ? "男" : "女";
        }
    }

}
