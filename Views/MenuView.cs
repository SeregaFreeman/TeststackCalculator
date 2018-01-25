using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestStack.White.UIItems.Finders;
using TestStackFramework.framework.elements;

namespace Views
{
    public class MenuView
    {
        public static MenuBar ViewMenuBar => MenuBar.Get(SearchCriteria.ByText("View"), "View");
    }
}
