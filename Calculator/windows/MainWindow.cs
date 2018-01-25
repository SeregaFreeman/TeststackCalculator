using Calculator.utils;
using System.Windows.Automation;
using Calculator.framework.elements;
using TestStack.White;
using TestStack.White.Factory;
using TestStack.White.UIItems.Finders;
using TestStack.White.UIItems.WindowItems;

namespace Calculator.windows
{
    class MainWindow
    {
        readonly Window _window;

        public MainWindow(Application application)
        {
            _window = application.GetWindow(Settings.Default.MainWindowName, InitializeOption.NoCache);
        }

        public void EnterNumber(int number)
        {
            LoggerUtil.Log.Info("User needs to enter: " + number);
            foreach (var digit in number.ToString())
            {
                Button digitButton = new Button(_window, SearchCriteria.ByControlType(ControlType.Button)
                    .AndByClassName("Button")
                    .AndByText(digit.ToString()), "digit button");
                digitButton.Click();
            }
        }

        public void AddNumber(int number)
        {
            new Button(_window, SearchCriteria.ByAutomationId("93"), "add").Click();
            EnterNumber(number);
            new Button(_window, SearchCriteria.ByAutomationId("121"), "equals").Click();
        }

        public void RememberResult()
        {
            new Button(_window, SearchCriteria.ByAutomationId("125"), "remember").Click();
        }

        public void GetNumberFromMemory()
        {
            new Button(_window, SearchCriteria.ByAutomationId("123"), "get from memory").Click();
        }

        public void PressAdd()
        {
            new Button(_window, SearchCriteria.ByAutomationId("93"), "add").Click();
        }

        public void PressEquals()
        {
            new Button(_window, SearchCriteria.ByAutomationId("121"), "equals").Click();
        }

        public string GetResult()
        {
            return new TextBox(_window, SearchCriteria.ByAutomationId("158"), "result").GetName();
        }

        public void SelectMode(string mode)
        {
            _window.MenuBar.MenuItem("View", mode).Click();
        }
    }
}
