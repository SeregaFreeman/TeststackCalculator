using TestStack.White;
using NUnit.Framework;
using TestStack.White.UIItems;
using TestStack.White.UIItems.Finders;
using TestStack.White.UIItems.WindowItems;
using TestStackFramework.utils;

namespace TestStackFramework.framework.elements
{
    public class BaseUiItem<T> where T: UIItem
    {
        private string _itemName;
        protected static T _uiItem;

        public string Name => _uiItem.Name;
        public string ItemName => _itemName;

        public BaseUiItem(T uiItem, string name)
        {
            _uiItem = uiItem;
            _itemName = name;
        }


        public static T Find(SearchCriteria searchCriteria, Window window = null)
        {
            if (window == null)
            {
                window = Scope.DefaultWindow;
            }
            
            try
            {
                _uiItem = window.Get<T>(searchCriteria);
                return _uiItem;
            }
            catch (AutomationException ex)
            {
                LoggerUtil.Info($"Element is not found: {ex}");
            }
            
            Assert.NotNull(_uiItem, "Element is not found");
            return _uiItem;
        }

        public void Click()
        {
            _uiItem.Click();
        }       
    }
}
