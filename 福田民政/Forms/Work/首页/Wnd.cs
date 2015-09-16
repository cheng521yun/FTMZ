using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using FrontFlag;
using FrontFlag.Control;
using Global;
using 福田民政.Core;

namespace 福田民政.Forms.首页
{
    public partial class Wnd : WorkForm
    {
        public Wnd()
        {
            InitializeComponent();
        }

        protected override void Init()
        {
            strCaption = "首页";
            Def.Act.Menu.Entry_首页 += Call;

            LoadWeb();
        }

        private void LoadWeb()
        {
            System.Uri url = new Uri( GL.Res.File.Home );
            web.Navigate ( url );
        }

        private void web_DocumentCompleted( object sender, WebBrowserDocumentCompletedEventArgs e )
        {
            //WebBrowser web = (WebBrowser)sender;
            //HtmlElement Element = web.Document.GetElementById( "var01" );
            //if (Element != null)
            //{
            //    string str = Element.InnerText;
            //    Element.InnerText = "嗨你好";
            //}

            ////Element = web.Document.GetElementById("trMGJ");
            //Element = web.Document.GetElementById( "trMGJ" );
            //if ( Element != null )
            //{
            //    //web.Document.All[0]...GetElementById(/)
            //    //Element.InnerHtml = "<td >222</td><td >3333</td>";
            //    string strHtm = Element.InnerHtml;
            //    //strHtm = Regex.Replace( strHtm, @"<(.|\n)*?>", string.Empty );
            //    Element.InnerHtml = strHtm;
            //}


        }

        private void web_Navigating( object sender, WebBrowserNavigatingEventArgs e )
        {
            string strUrl = e.Url.ToString();
            string strNo = GetNaviNo(strUrl);

            GotoPage(strNo);
        }

        private string GetNaviNo( string strUrl )
        {
            if (strUrl == null)
                return string.Empty;

            int n = strUrl.IndexOf( "#" );
            if (n < 0)
                return string.Empty;

            string strNo = strUrl.Substring( n+1 );
            if (strNo == null)
                return string.Empty;

            return strNo;
        }

        private void GotoPage( string strNo )
        {
            if (String.IsNullOrEmpty(strNo))
                return;

            int nNo = FF.Fun.MyConvert.Str2Int(strNo);

            //App.fMain.bShowLeftPnl = true;
            
            switch (strNo)
            {
                //老龄办
                case "11" :
                    GL.Command.Excute( Def.Command.Menu.数据管理_老龄办_老龄优待证_发放 );
                    break;

                case "12" :
                    GL.Command.Excute( Def.Command.Menu.数据管理_老龄办_老龄优待证_统计 );
                    break ;
                case "13" :
                    GL.Command.Excute( Def.Command.Menu.数据管理_老龄办_老龄津贴_发放 );
                    break;
                case "14" :
                    GL.Command.Excute( Def.Command.Menu.数据管理_老龄办_老龄津贴_停发 );
                    break;
                case "15" :
                    GL.Command.Excute( Def.Command.Menu.数据管理_老龄办_老龄津贴_统计 );
                    break;

                //民管局
                case "21" :
                    GL.Command.Excute( Def.Command.Menu.数据管理_民管局_登记备案_民非 );
                    break;
                case "22" :
                    GL.Command.Excute( Def.Command.Menu.数据管理_民管局_登记备案_社团 );
                    break ;
                case "23":
                    GL.Command.Excute( Def.Command.Menu.数据管理_民管局_注销备案_民非 );
                    break;
                case "24":
                    GL.Command.Excute( Def.Command.Menu.数据管理_民管局_注销备案_社团 );
                    break;

                //事务科
                case "31":
                    GL.Command.Excute( Def.Command.Menu.数据管理_事务科_低收入居民数据 );
                    break;
                case "32":
                    GL.Command.Excute( Def.Command.Menu.数据管理_事务科_专项救助数据 );
                    break;
                case "33":
                    GL.Command.Excute( Def.Command.Menu.数据管理_事务科_居家养老服务补贴 );
                    break;
                case "34":
                    GL.Command.Excute( Def.Command.Menu.数据管理_事务科_救助统计 );
                    break;

                //基层科
                case "41":
                    GL.Command.Excute( Def.Command.Menu.数据管理_基层科_民主管理信息管理 );
                    break;
                case "42":
                    GL.Command.Excute( Def.Command.Menu.数据管理_基层科_社区建设信息管理 );
                    break;
                case "43":
                    GL.Command.Excute( Def.Command.Menu.数据管理_基层科_社区服务信息管理 );
                    break;
                case "44":
                    GL.Command.Excute( Def.Command.Menu.数据管理_基层科_数据统计 );
                    break;

                //优抚科
                case "51":
                    GL.Command.Excute( Def.Command.Menu.数据管理_优抚科_优抚对象_登记 );
                    break;
                case "52":
                    GL.Command.Excute( Def.Command.Menu.数据管理_优抚科_优抚对象_查询 );
                    break;
                case "53":
                    GL.Command.Excute( Def.Command.Menu.数据管理_优抚科_伤残物品_登记 );
                    break;
                case "54":
                    GL.Command.Excute( Def.Command.Menu.数据管理_优抚科_伤残物品_发放 );
                    break;
                case "55":
                    GL.Command.Excute( Def.Command.Menu.数据管理_优抚科_抚恤标准管理 );
                    break;
                case "56":
                    GL.Command.Excute( Def.Command.Menu.数据管理_优抚科_优抚资金发放 );
                    break;

                //福利中心
                case "61":
                    GL.Command.Excute( Def.Command.Menu.数据管理_福利中心_老人入住管理 );
                    break;
                case "62":
                    GL.Command.Excute( Def.Command.Menu.数据管理_福利中心_老人退住管理 );
                    break;
                case "63":
                    GL.Command.Excute( Def.Command.Menu.数据管理_福利中心_老人费用管理_费用登记 );
                    break;
                case "64":
                    GL.Command.Excute( Def.Command.Menu.数据管理_福利中心_老人费用管理_退费登记 );
                    break;
                case "65":
                    GL.Command.Excute( Def.Command.Menu.数据管理_福利中心_老人费用统计 );
                    break;

            }


            //

        
        }
    }
}
