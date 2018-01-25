﻿using TestStack.White.UIItems.Finders;
using TestStack.White.UIItems.WindowItems;

namespace TestStackFramework.framework.elements
{
    public class MenuBar : BaseUiItem<TestStack.White.UIItems.WindowStripControls.MenuBar>
    {
        protected MenuBar(TestStack.White.UIItems.WindowStripControls.MenuBar uiItem, string itemName) : base(uiItem, itemName)
        {

        }

        public static MenuBar Get(SearchCriteria searchCriteria, string itemName, Window window = null)
        {
            if (window == null)
            {
                window = Scope.Window;
            }
            return new MenuBar(Find(searchCriteria, window), itemName);
        }

        public void SelectMenu(string path)
        {
            _uiItem.MenuItem(path).Click();
        }
    }
}
