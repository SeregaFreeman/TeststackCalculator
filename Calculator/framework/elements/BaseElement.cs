using Calculator.utils;
using NUnit.Framework;
using System;
using System.Windows.Automation;
using TestStack.White.UIItems;
using TestStack.White.UIItems.Finders;
using TestStack.White.UIItems.WindowItems;

namespace Calculator.framework.elements
{
    class BaseElement
    {
        private string name;
        private SearchCriteria searchCriteria;
        private Window window;
        private IUIItem uIItem;

        public BaseElement(string name, SearchCriteria searchCriteria, Window window)
        {
            this.name = name;
            this.searchCriteria = searchCriteria;
            this.window = window;
        }

        public IUIItem GetElement()
        {
            IsElementPresent();
            return uIItem;
        }

        public void Click()
        {
            IsElementPresent();
            uIItem.Click();
        }

        public void IsElementPresent()
        {
            bool isVisible;
            try
            {
                uIItem = window.Get(searchCriteria);
                isVisible = uIItem.Visible;
            }
            catch (Exception ex)
            {
                isVisible = false;
                LoggerUtil.Log.Error("Element is not visible: " + ex);
            }
            Assert.True(isVisible);
        }
    }
}
