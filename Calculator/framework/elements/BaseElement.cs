using Calculator.utils;
using NUnit.Framework;
using TestStack.White.UIItems;
using TestStack.White.UIItems.Finders;
using TestStack.White.UIItems.WindowItems;

namespace Calculator.framework.elements
{
    class BaseElement
    {
        protected string name;
        protected SearchCriteria searchCriteria;
        protected Window window;
        protected IUIItem uIItem;

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
            bool isVisible = false;

            IUIItem[] uIItems = window.GetMultiple(searchCriteria);
            if (uIItems.Length > 0)
            {
                foreach (var item in uIItems)
                {
                    if (item.Visible)
                    {
                        uIItem = item;
                        isVisible = true;
                        LoggerUtil.Log.Info("Element is visible");
                        break;
                    }
                    else
                    {
                        isVisible = false;
                        LoggerUtil.Log.Error("Element is not visible");
                    }
                }
            }
            else
            {
                LoggerUtil.Log.Error("No elements matching search criteria found.");
            }

            Assert.True(isVisible, "No elements matching search criteria found.");
        }

        public string GetName()
        {
            IsElementPresent();
            return uIItem.Name;
        }
    }
}
