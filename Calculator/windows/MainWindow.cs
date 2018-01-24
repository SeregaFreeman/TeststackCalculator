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
        readonly Window window;

        public MainWindow(Application application)
        {
            this.window = application.GetWindow(Settings.Default.MainWindowName, InitializeOption.NoCache);
        }

        public void EnterNumber(int number)
        {
            LoggerUtil.Log.Info("User needs to enter: " + number.ToString());
            foreach (char digit in number.ToString())
            {
                Button digitButton = new Button(window, SearchCriteria.ByControlType(ControlType.Button)
                    .AndByClassName("Button")
                    .AndByText(digit.ToString()), "digit button");
                LoggerUtil.Log.Info("User is clicking: " + digit.ToString());
                digitButton.Click();
            }
        }

        public void AddNumber(int number)
        {
            new Button(window, SearchCriteria.ByAutomationId("93"), "add").Click();
            EnterNumber(number);
            new Button(window, SearchCriteria.ByAutomationId("121"), "equals").Click();
        }

        public void RememberResult()
        {
            new Button(window, SearchCriteria.ByAutomationId("125"), "remember").Click();
        }

        public void GetNumberFromMemory()
        {
            new Button(window, SearchCriteria.ByAutomationId("123"), "get from memory").Click();
        }

        public void PressAdd()
        {
            new Button(window, SearchCriteria.ByAutomationId("93"), "add").Click();
        }

        public void PressEquals()
        {
            new Button(window, SearchCriteria.ByAutomationId("121"), "equals").Click();
        }

        public string GetResult()
        {
            return new TextBox(window, SearchCriteria.ByAutomationId("158"), "result").GetName();
        }
    }
}
