using Calculator.utils;
using NUnit.Framework;
using TestStack.White.UIItems;
using TestStack.White.UIItems.Finders;
using TestStack.White.UIItems.WindowItems;

namespace Calculator.framework.elements
{
    class BaseElement
    {
        protected string Name;
        protected SearchCriteria SearchCriteria;
        protected Window Window;
        protected IUIItem UiItem;

        public BaseElement(string name, SearchCriteria searchCriteria, Window window)
        {
            Name = name;
            SearchCriteria = searchCriteria;
            Window = window;
        }

        public IUIItem GetElement()
        {
            IsElementPresent();
            return UiItem;
        }

        public void Click()
        {
            IsElementPresent();
            LoggerUtil.Log.Info($"Clicking element {UiItem.Name}");
            UiItem.Click();
        }

        public void IsElementPresent()
        {
            bool isVisible = false;

            IUIItem[] uIItems = Window.GetMultiple(SearchCriteria);
            if (uIItems.Length > 0)
            {
                foreach (var item in uIItems)
                {
                    if (item.Visible)
                    {
                        UiItem = item;
                        isVisible = true;
                        LoggerUtil.Log.Info($"Element {UiItem.Name} is visible");
                        break;
                    }
                    LoggerUtil.Log.Error($"Element {UiItem.Name} is not visible");
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
            return UiItem.Name;
        }
    }
}
