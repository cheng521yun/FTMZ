using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.Xml;
using System.Reflection;
using System.IO;
//using Microsoft.Reporting.WinForms;

namespace FrontFlag
{
    public class RDLCXML
    {
        public string nsReportDef = "http://schemas.microsoft.com/sqlserver/reporting/2005/01/reportdefinition";

        XmlNamespaceManager nsmgr = null;
        public XmlDocument doc = new XmlDocument ();

        public RDLCXML ( string strRdrcFile )
        {
            doc.Load ( strRdrcFile );

            nsmgr = new XmlNamespaceManager ( doc.NameTable );
            nsmgr.AddNamespace ( "m" , nsReportDef );
        }

        #region 属性
        public XmlDocument XmlDoc
        { 
            get
            {
                RemoveBlankXmlns ();
                return doc ; 
            } 
        }
        #endregion

        #region Comm

        public void AfterAppendChild ()
        {
            RemoveBlankXmlns ();
        }

        public string Comm_GetInnerText ( XmlElement elment , string strName )
        {
            XmlNodeList lst = elment.ChildNodes;
            foreach ( XmlNode x in lst )
            {
                XmlElement xx = (XmlElement) x;
                if ( xx.Name == strName )
                    return xx.InnerText ;
            }

            return "";
        }

        public void Comm_SetInnerText ( ref XmlElement elment , string strName , string strValue )
        {
            XmlNodeList lst = elment.ChildNodes;
            foreach ( XmlNode x in lst )
            {
                XmlElement xx = ( XmlElement ) x ;
                if ( xx.Name == strName )
                    xx.InnerText = strValue ;
            }
        }

        /// <summary>
        /// //替换这种类型， 比如： =Parameters!Customer.Value 的Value内容
        /// </summary>
        /// <returns></returns>
        public string Comm_GetValue ( XmlElement elment , string strName )
        {
            string strRet = Comm_GetInnerText ( elment , strName );
            int n1 = strRet.IndexOf ( '!' );
            int n2 = strRet.IndexOf ( '.' );

            if ( n1 < 0 || n2 < 0 )
                return "";

            string strValue = strRet.Substring ( n1 + 1 , n2 - n1 - 1 );
            return strValue;
        }

        #endregion

        #region ReportParameter

        /// <summary>
        /// 建立参数
        /// </summary>
        /// <param name="strName"></param>
        /// <returns></returns>
        public XmlElement Paramer_AddNew ( string strName )
        {
            XmlElement xe = doc.CreateElement ( "ReportParameter" );
            xe.SetAttribute ( "Name" , strName );

            string strInnerXml = String.Format ( "<DataType>String</DataType><AllowBlank>true</AllowBlank><Prompt>Report_Parameter_{0}</Prompt>" , strName );
            xe.InnerXml = strInnerXml;

            //添加进Doc
            string strXPath = String.Format ( "//m:Report//m:ReportParameters" );
            XmlNode xn = (XmlNode) doc.SelectSingleNode ( strXPath , nsmgr );
            xn.AppendChild ( xe );

            AfterAppendChild ();

            return xe;
        }


        #endregion

        /// <summary>
        /// 清空 所有 xmlns=""  的属性，否则报表图像显示不出来。
        /// </summary>
        public void RemoveBlankXmlns ()
        {
            string strXml = Xml2String ();
            strXml = strXml.Replace ( "xmlns=\"\"" , "" );
            doc.Load ( new System.IO.MemoryStream ( System.Text.Encoding.GetEncoding ( "utf-8" ).GetBytes ( strXml ) ) );
        }

        /// <summary>
        /// 删除指定的节点。
        /// strXPath需要指明命名空间。比如："//m:Textbox[@Name='txtDiscount']"
        /// </summary>
        /// <param name="strXPath"></param>
        public bool DeleteNote ( string strXPath )
        {
            //先查找父节点。
            string strParent = String.Format ( "{0}/.." , strXPath );      
            XmlNode xnParent = doc.SelectSingleNode ( strParent , nsmgr );
            
            //查找节点。
            XmlNode xn = doc.SelectSingleNode ( strXPath , nsmgr );

            if ( xnParent == null || xn == null )
                return false;
                
            xnParent.RemoveChild ( xn ) ;
            return true ;
        }

        XmlNode AddVisibilityElement ( bool bFlag )
        {
            XmlNode ndV = doc.CreateElement ( "Visibility" );
            
            XmlNode ndH = doc.CreateElement ( "Hidden" );
            ndH.InnerText = ( bFlag ) ? "false" : "true" ;

            ndV.AppendChild ( ndH );

            AfterAppendChild ();

            return ndV;
        }

        #region PutOut 

        /// <summary>
        /// 报表内容输出为字符串。
        /// </summary>
        /// <returns></returns>
        public string Xml2String ()
        {
            return doc.OuterXml;
        }

        /// <summary>
        /// 报表写入文件
        /// </summary>
        /// <param name="strRdrcFileOut"></param>
        /// <returns></returns>
        public bool Save ( string strRdrcFileOut )
        {
            RemoveBlankXmlns ();

            doc.Save ( strRdrcFileOut );
            return true;
        }

        /// <summary>
        /// 获取MemoryStream格式。
        /// </summary>
        /// <returns></returns>
        public MemoryStream Xml2MemoryStream ()
        {
            RemoveBlankXmlns ();

            MemoryStream stream = new MemoryStream ();
            doc.Save ( stream );
            stream.Position = 0;
            return stream;
        }

        public XmlDocument ToXmlDocument ()
        {
            return doc;
        }

        public void SaveFile ( string strFileName )
        {
            doc.Save ( strFileName );

        }

        #endregion 

        #region Textbox

        public bool AddTextBox ( ref XmlDocument xmlDoc , string strName , string strParam , decimal dL , decimal dT , decimal dW , decimal dH , string strFont , int nFontSize , int nFontWeight )
        {
            /*
            //string strT = "      <Textbox Name=\"$Name\">        <Top>$Tcm</Top>         <Width>$Wcm</Width>          <Style>           <FontFamily>$Font</FontFamily>          <FontSize>$FntSizept</FontSize>          <FontWeight>$FntWeight</FontWeight>        </Style>        <CanGrow>true</CanGrow>        <Left>$Lcm</Left>        <Height>$Hcm</Height>        <Value>=Parameters!$Param.Value</Value>      </Textbox>";
            //string strRet = strT;

            //strRet = strRet.Replace ( "$Name" , strName );
            //strRet = strRet.Replace ( "$Param" , strParam );
            //strRet = strRet.Replace ( "$L" , dL.ToString() );
            //strRet = strRet.Replace ( "$T" , dT.ToString () );
            //strRet = strRet.Replace ( "$W" , dW.ToString () );
            //strRet = strRet.Replace ( "$H" , dH.ToString () );

            //strRet = strRet.Replace ( "$Font" , strFont );
            //strRet = strRet.Replace ( "$FntSize" , strFontSize );
            //strRet = strRet.Replace ( "$FntWeight" , nFontWeight.ToString() );

            //return strRet ;

            XmlNode root = xmlDoc.DocumentElement;//获取文档的根节点

            //XmlNode xReportItems = root.SelectSingleNode ( "Body" );//查找<bookstore>  
            //XmlNode xReportItems = xmlDoc.SelectSingleNode ( "/Report/Body/ReportItems" );//查找<bookstore>  
            XmlNode xReportItems = xmlDoc.SelectSingleNode ( "//ReportParameters" );//查找<bookstore>  

            XmlNodeList xList = xmlDoc.SelectNodes ( "Body/ReportItems" );

            XmlElement xTextBox = xmlDoc.CreateElement ( "Textbox" );//创建一个<book>节点  
            xTextBox.SetAttribute ( "Name" , strName );//设置该节点genre属性  

            XmlElement xTop = xmlDoc.CreateElement ( "Top" );
            xTop.InnerText = dT.ToString () + "cm";//设置文本节点  
            xTextBox.AppendChild ( xTop );//添加到<book>节点中   

            //
            xReportItems.AppendChild ( xTextBox );
              
            AfterAppendChild ();
             
            */
            return true;
        }

        public bool ShowTextBox ( string strTextBoxName , bool bFlag )
        {
            //查找节点。
            string strXPath = String.Format ( "//m:Textbox[@Name='{0}']" , strTextBoxName );
            XmlNode xn = doc.SelectSingleNode ( strXPath , nsmgr );

            if ( xn == null )
                return false;

            //检查是否已经有<Visibility>节点。
            XmlNode xnOldVisib = xn.SelectSingleNode ( "/Visibility" );   //这句有问题，要重写。
            //string strXPathVisib = String.Format ( "//m:Textbox[@Name='{0}']/Visibility" , strTextBoxName );
            //XmlNode xnOldVisib = doc.SelectSingleNode ( strXPathVisib , nsmgr );

            XmlNode xnNewVisib = AddVisibilityElement ( bFlag );

            if ( xnOldVisib == null )
                xn.AppendChild ( xnNewVisib );                  //之前没有<Visibility>节点，添加。
            else
                xn.ReplaceChild ( xnNewVisib , xnOldVisib );       //之前已有<Visibility>节点，替换。

            AfterAppendChild ();

            return true;
        }

        public bool DeleteTextBox ( string strTextBoxName )
        {
            string strXPath = String.Format ( "//m:Textbox[@Name='{0}']" , strTextBoxName );
            return DeleteNote ( strXPath );
        }

        public bool TextBox_Rename ( string strOldName , string strNewName )
        {
            //查找节点。
            string strXPath = String.Format ( "//m:Textbox[@Name='{0}']" , strOldName );
            XmlNode xn = doc.SelectSingleNode ( strXPath , nsmgr );

            if ( xn == null )
                return false;

            XmlElement xe = (XmlElement) xn;
            xe.SetAttribute ( "Name" , strNewName );

            return true;
        }

        //这个凡属有问题。得到的 xn 会包含报表的所有节点， 为什么？
        //public bool TextBox_Value ( string strName , string strValue )
        //{
        //    //查找节点。
        //    string strXPath = String.Format ( "//m:Textbox[@Name='{0}']" , strName );
        //    XmlNode xn = doc.SelectSingleNode ( strXPath , nsmgr );

        //    if ( xn == null )
        //        return false;

        //    strXPath = String.Format ( "//m:Value" );
        //    XmlElement xe = (XmlElement) xn.SelectSingleNode ( strXPath , nsmgr ) ;
        //    string str = xe.InnerText;
        //    xe.InnerText = strValue ;

        //    return true;
        //}

        public bool TextBox_Value( string strName , string strValue )
        {
            //查找节点。
            string strXPath = String.Format ( "//m:Textbox[@Name='{0}']//m:Value" , strName );
            XmlNode xn = doc.SelectSingleNode ( strXPath , nsmgr );

            if ( xn == null )
                return false;

            xn.InnerText = strValue;

            return true;
        }


        //测试一下，是不是也有上面的函数的问题？
        public bool TextBox_XY ( string strName , int L , int T )
        {
            //查找节点。
            string strXPath = String.Format ( "//m:Textbox[@Name='{0}']" , strName );
            XmlNode xn = doc.SelectSingleNode ( strXPath , nsmgr );

            if ( xn == null )
                return false;

            strXPath = String.Format ( "//m:Left" );
            XmlElement xe = (XmlElement) xn.SelectSingleNode ( strXPath , nsmgr );
            xe.InnerText = String.Format ( "{0}cm" , L );

            strXPath = String.Format ( "//m:Top" );
            xe = (XmlElement) xn.SelectSingleNode ( strXPath , nsmgr );
            xe.InnerText = String.Format ( "{0}cm" , T ); 

            return true;
        }

        public bool TextBox_WH ( string strName , int W , int H )
        {
            //查找节点。
            string strXPath = String.Format ( "//m:Textbox[@Name='{0}']" , strName );
            XmlNode xn = doc.SelectSingleNode ( strXPath , nsmgr );

            if ( xn == null )
                return false;

            if ( W != 0 )
            {
                strXPath = String.Format ( "//m:Width" );
                XmlElement xe = (XmlElement) xn.SelectSingleNode ( strXPath , nsmgr );
                xe.InnerText = String.Format ( "{0}cm" , W );
            }

            if ( H != 0 )
            {
                strXPath = String.Format ( "//m:Height" );
                XmlElement xe = (XmlElement) xn.SelectSingleNode ( strXPath , nsmgr );
                xe.InnerText = String.Format ( "{0}cm" , H );
            }

            return true;
        }

        public void TextBox_XYWH ( string strName , int L , int T , int W , int H )
        {
            TextBox_XY ( strName , L , T );
            TextBox_WH ( strName , W , H );
        }

        public bool TextBox_OffsetXY ( string strName , int dL , int dT )
        {
            /*
            //查找节点。
            string strXPath = String.Format ( "//m:Textbox[@Name='{0}']" , strName );
            XmlNode xn = doc.SelectSingleNode ( strXPath , nsmgr );

            if ( xn == null )
                return false;

            strXPath = String.Format ( "//m:Left" );
            XmlElement xe = (XmlElement) xn.SelectSingleNode ( strXPath , nsmgr );
            decimal L = FF.Fun.MyConvert.Str2Decimal ( xe.InnerText.Replace ( "cm" , "" ) );
            xe.InnerText = String.Format ( "{0}cm" , L + dL );

            strXPath = String.Format ( "//m:Top" );
            xe = (XmlElement) xn.SelectSingleNode ( strXPath , nsmgr );
            decimal T = FF.Fun.MyConvert.Str2Decimal ( xe.InnerText.Replace ( "cm" , "" ) );
            xe.InnerText = String.Format ( "{0}cm" , T + dT );
            */

            //查找节点。
            string strXPath = String.Format ( "//m:Textbox[@Name='{0}']" , strName );
            XmlNode xn = doc.SelectSingleNode ( strXPath , nsmgr );

            if ( xn == null )
                return false;

            XmlElement xe;

            XmlNodeList lst = xn.ChildNodes;
            foreach ( XmlNode x in lst )
            {
                xe = (XmlElement) x;
                if ( xe.Name == "Left" )
                {
                    decimal L = FF.Fun.MyConvert.Str2Decimal ( xe.InnerText.Replace ( "cm" , "" ) );
                    xe.InnerText = String.Format ( "{0}cm" , L + dL );
                }
                else if ( xe.Name == "Top" )
                {
                    decimal T = FF.Fun.MyConvert.Str2Decimal ( xe.InnerText.Replace ( "cm" , "" ) );
                    xe.InnerText = String.Format ( "{0}cm" , T + dT );
                }
            }

            return true;
        }

        #endregion

        #region Rectangle

        public bool Rectangle_XY ( string strName , int L , int T )
        {
            //查找节点。
            string strXPath = String.Format ( "//m:Rectangle[@Name='{0}']" , strName );
            XmlNode xn = doc.SelectSingleNode ( strXPath , nsmgr );

            if ( xn == null )
                return false;

            XmlElement xe;

            XmlNodeList lst = xn.ChildNodes;
            foreach ( XmlNode x in lst )
            {
                xe = (XmlElement) x;
                if ( xe.Name == "Left" )
                {
                    xe.InnerText = String.Format ( "{0}cm" , L );
                }
                else if ( xe.Name == "Top" )
                {
                    xe.InnerText = String.Format ( "{0}cm" , T );
                }
            }

            return true;
        }

        public bool Rectangle_OffsetXY ( string strName , int dL , int dT )
        {
            //查找节点。
            string strXPath = String.Format ( "//m:Rectangle[@Name='{0}']" , strName );
            XmlNode xn = doc.SelectSingleNode ( strXPath , nsmgr );

            if ( xn == null )
                return false;

            XmlElement xe;

            XmlNodeList lst = xn.ChildNodes ;
            foreach ( XmlNode x in lst )
            {
                xe = (XmlElement) x ;
                if ( xe.Name == "Left" )
                {
                    decimal L = FF.Fun.MyConvert.Str2Decimal ( xe.InnerText.Replace ( "cm" , "" ) );
                    xe.InnerText = String.Format ( "{0}cm" , L + dL );
                }
                else if ( xe.Name == "Top" )
                {
                    decimal T = FF.Fun.MyConvert.Str2Decimal ( xe.InnerText.Replace ( "cm" , "" ) );
                    xe.InnerText = String.Format ( "{0}cm" , T + dT );
                }
            }

            return true;
        }

        public string Rectangle_GetInnerXml ( string strName )
        {
            //查找节点。
            string strXPath = String.Format ( "//m:Rectangle[@Name='{0}']" , strName );
            XmlNode xn = doc.SelectSingleNode ( strXPath , nsmgr );

            if ( xn == null )
                return "";

            return xn.InnerXml;
        }

        public XmlElement Rectangle_Create ( string strName , string strInnerXml )
        {
            //createElement生成一个动态对象，这个对象创建之后是个无主对象，没有加到创建它的document中，需要使用appendChild或者insertBefore插入到document的DOM模型中才能生效。
            XmlElement xe = doc.CreateElement ( "Rectangle" );
            xe.SetAttribute ( "Name" , strName );
            xe.InnerXml = strInnerXml;

            //Rectabgle里面的所有Element更换Name
            string str;
            XmlNode xReportItems = xe.SelectSingleNode ( "//m:ReportItems" , nsmgr );
            XmlNodeList lst = xReportItems.ChildNodes;
            foreach ( XmlNode x in lst )
            {
                XmlElement xx = ( XmlElement ) x ;
                str = xx.GetAttribute ( "Name" );
                xx.SetAttribute ( "Name" , str + "_" + strName );

                //替换这种类型， 比如： =Parameters!Customer.Value 的Value内容
                str = Comm_GetValue ( xx , "Value" );
                if ( str != "" )   //str="", 说明不是动态变量。
                {
                    //添加参数。
                    Paramer_AddNew ( str + "_" + strName );

                    //关联参数
                    str = String.Format ( "=Parameters!{0}.Value" , str + "_" + strName );
                    Comm_SetInnerText ( ref xx , "Value" , str );
                }
            }

            //添加这个新节点。
            string strXPath = String.Format ( "//m:Body//m:ReportItems" );
            XmlNode xn = (XmlNode) doc.SelectSingleNode ( strXPath , nsmgr );
            xn.AppendChild ( xe );

            //AppendChild() 之后，一定要添加这句，否者添加的东西在doc中找不到。
            AfterAppendChild ();

            return xe;
        }

        #endregion

        #region Imgae

        /// <summary>
        /// 添加一个内含图像。
        /// </summary>
        /// <param name="strName"></param>
        /// <param name="strImgDate"></param>
        /// <returns></returns>
        public bool AddEmbeddedImage ( string strImgName , string strImgData )
        {
            try
            {
                bool bHaveImgs = true;
                XmlNode nodeReport = doc.SelectSingleNode ( "//m:Report" , nsmgr );
                XmlNode nodeImgs = doc.SelectSingleNode ( "//m:Report/EmbeddedImages" , nsmgr );

                //如果没有EmbeddedImages节，就先添加。
                if ( nodeImgs == null )
                {
                    bHaveImgs = false;
                    nodeImgs = doc.CreateElement ( "EmbeddedImages" );
                }

                XmlElement xImg = doc.CreateElement ( "EmbeddedImage" );
                xImg.SetAttribute ( "Name" , strImgName );

                XmlElement xeType = doc.CreateElement ( "MIMEType" );
                xeType.InnerText = "image/jpeg";
                xImg.AppendChild ( xeType );

                XmlElement xeData = doc.CreateElement ( "ImageData" );
                xeData.InnerText = strImgData;
                xImg.AppendChild ( xeData );

                //在EmbeddedImages节中，添加一个Image。
                nodeImgs.AppendChild ( xImg );

                if ( !bHaveImgs )
                    nodeReport.AppendChild ( nodeImgs );

                //加这一句，打印环球Invoice会出错。
                //AfterAppendChild ();
            }
            catch ( Exception e )
            {
                return false;
            }

            return true;
        }

        public bool ShowEmbeddedImage(string strImgName, bool bFlag)
        {
            //查找节点。
            string strXPath = String.Format("//m:Image[@Name='{0}']", strImgName);
            XmlNode xn = doc.SelectSingleNode(strXPath, nsmgr);

            if (xn == null)
                return false;

            //检查是否已经有<Visibility>节点。
            string strXPathVisib = String.Format("//m:Image[@Name='{0}']//m:Visibility", strImgName);
            XmlNode xnOldVisib = doc.SelectSingleNode(strXPathVisib, nsmgr);

            XmlNode xnNewVisib = AddVisibilityElement(bFlag);

            if (xnOldVisib == null)
                xn.AppendChild(xnNewVisib);                  //之前没有<Visibility>节点，添加。
            else
                xn.ReplaceChild(xnNewVisib, xnOldVisib);       //之前已有<Visibility>节点，替换。

            //AfterAppendChild();

            return true;
        }

        #endregion

    }
}
