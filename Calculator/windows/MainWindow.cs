using Calculator.utils;
using System.Windows.Automation;
using Calculator.framework.elements;
using TestStack.White;
using TestStack.White.Factory;
using TestStack.White.UIItems;
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
                LoggerUtil.Log.Info("User is clicking: " + digit.ToString());
                framework.elements.Button digitButton = new framework.elements.Button(window, SearchCriteria.ByControlType(ControlType.Button)
                    .AndByClassName("Button")
                    .AndByText(digit.ToString()), "name");
                digitButton.Click();
            }
        }

        public void AddNumber(int number)
        {
            new framework.elements.Button(window, SearchCriteria.ByAutomationId("93"), "add").Click();
            EnterNumber(number);
            new framework.elements.Button(window, SearchCriteria.ByAutomationId("121"), "equals").Click();
        }

        public void RememberResult()
        {
            new framework.elements.Button(window, SearchCriteria.ByAutomationId("125"), "remember").Click();
        }

        public void GetNumberFromMemory()
        {
            new framework.elements.Button(window, SearchCriteria.ByAutomationId("123"), "get from memory").Click();
        }
    }
}
