
using TestStack.White.UIItems.Finders;
using TestStackFramework.framework.elements;

namespace Views
{
    public class MainView
    {
        public static Button ButtonEquals => Button.Get(SearchCriteria.ByAutomationId("121"), "equals button");
        public static Button ButtonAdd => Button.Get(SearchCriteria.ByAutomationId("93"), "add button");
        public static Button ButtonRemember => Button.Get(SearchCriteria.ByAutomationId("125"), "remember button");
        public static Button ButtonGetFromMemory => Button.Get(SearchCriteria.ByAutomationId("123"), "get from memory button");
        public static MenuBar AppMenuBar => MenuBar.Get(SearchCriteria.ByAutomationId("MenuBar"), "Main menu");
    }
}
