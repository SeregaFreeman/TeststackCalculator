using System.Windows.Automation;
using TestStack.White.UIItems.Finders;
using TestStackFramework.framework.elements;

namespace Views
{
    public class MainView
    {
        public static string ButtonName { get; set; }

        public static Button ButtonEquals => Button.Get(SearchCriteria.ByAutomationId("121"), "equals button");
        public static Button ButtonAdd => Button.Get(SearchCriteria.ByAutomationId("93"), "add button");
        public static Button ButtonRemember => Button.Get(SearchCriteria.ByAutomationId("125"), "remember button");
        public static Button ButtonGetFromMemory => Button.Get(SearchCriteria.ByAutomationId("123"), "get from memory button");

        public static Button ButtonNumber => Button.Get(SearchCriteria.ByControlType(ControlType.Button)
            .AndByClassName("Button")
            .AndByText(ButtonName), "digit button");

        public static Label Resultlabel => Label.Get(SearchCriteria.ByAutomationId("150"), "Result label");
        public static MenuBar AppMenuBar => MenuBar.Get(SearchCriteria.ByAutomationId("MenuBar"), "Main menu");

    }
}
