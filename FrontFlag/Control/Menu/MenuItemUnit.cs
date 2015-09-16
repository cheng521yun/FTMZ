using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FrontFlag.Control.Menu
{
    public class MENU_ITEM_UNIT
    {
        public string strId = String.Empty;          //菜单ID   
        public int nType = 0;                        //菜单类型。比如文字、分割线。默认是文字
        public string strText = String.Empty;        //菜单上显示的文字
        public int nIcon = -1;                       //前导Icon，使用主菜单类的ImageList的序号
        public int nCommandId = -1;                  //点击菜单要调用的功能编号。系统功能室枚举类型。

        public MENU_ITEM_UNIT()
        {
        }

        public MENU_ITEM_UNIT( string Id, string Text, int CommandId )
        {
            strId = Id;
            strText = Text;
            nCommandId = CommandId;
        }
    }
}
