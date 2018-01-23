
using System.Windows.Automation;
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
            foreach (char digit in number.ToString())
            {
                var digitButton = window.Get<Button>(SearchCriteria.ByControlType(ControlType.Button)
                .AndByClassName("Button").AndByText(digit.ToString()));
                digitButton.Click();
            }
        }
    }
}
