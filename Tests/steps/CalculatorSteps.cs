using System.Windows.Automation;
using TestStack.White.UIItems.Finders;
using TestStackFramework.framework.elements;
using TestStackFramework.utils;

namespace Tests.steps
{
    static class CalculatorSteps
    {
        public static void EnterNumber(int number)
        {
            LoggerUtil.Log.Info("User needs to enter: " + number);
            foreach (var digit in number.ToString())
            {
                Button.Get(SearchCriteria.ByControlType(ControlType.Button)
                    .AndByClassName("Button")
                    .AndByText(digit.ToString()), "digit button").Click();
            }
        }
    }
}
