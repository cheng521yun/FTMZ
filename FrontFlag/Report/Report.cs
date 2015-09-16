using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.Xml;
using System.Reflection;
using System.IO;
using Microsoft.Reporting.WinForms;

namespace FrontFlag
{
    public class REPORT
    {
        public void SetParam ( ref LocalReport localReport , string strParam , string strValue )
        {
            ReportParameter Param = new ReportParameter ();
            Param.Name = strParam;
            Param.Values.Add ( strValue );
            localReport.SetParameters ( new ReportParameter [] { Param } );
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="strRdlcFile">rdlc在磁盘上的文件名。（路径+文件名）</param>
        /// <returns></returns>
        public XmlDocument GetXml_ByFile ( string strRdlcFile )
        {
            //Stram=>XmlDocument, 以便对XML文件进行处理。（rdlc是XML文件格式）
            System.Xml.XmlDocument xmldoc = new System.Xml.XmlDocument ();
            xmldoc.Load ( strRdlcFile );

            return xmldoc;
        }

        /// <summary>
        /// eg:
        /// Assembly asm = System.Reflection.Assembly.GetExecutingAssembly ();
        /// XmlDocument xmldoc = Report.GetXml_ByRes ( asm , CONST.Print.rdlcQuote );
        /// </summary>
        /// <param name="asm">rdlc资源的来源。调用者需要引用using System.Reflection;</param>
        /// <param name="strRdlc">rdlc在工程项目中的路径</param>
        /// <returns></returns>
        public XmlDocument GetXml_ByRes ( Assembly asm , string strRdlc ) 
        {
            //从资源中读取rdlc文件。
            Stream s = asm.GetManifestResourceStream ( strRdlc );  //rdlc在工程项目中的路径
            if ( s == null )
                return null;

            //Stram=>XmlDocument, 以便对XML文件进行处理。（rdlc是XML文件格式）
            System.Xml.XmlDocument xmldoc = new System.Xml.XmlDocument ();
            xmldoc.Load ( s );
            s.Close();

            return xmldoc;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="localReport">要操作的报表控件</param>
        /// <param name="xmldoc">rdlc内容</param>
        /// <returns></returns>
        public bool SetXml2Report ( ref LocalReport localReport , XmlDocument xmldoc )
        {
            //XmlDocument=>MemoryStream, 以便载入LocalReport中。
            MemoryStream ms = new MemoryStream ();
            xmldoc.Save ( ms );

            if ( ms == null )
                return false;

            ms.Seek ( 0 , SeekOrigin.Begin );

            //装载报表rdlc
            localReport.LoadReportDefinition ( ms );

            //释放
            ms.Close ();

            return true;
        }
    }
}
