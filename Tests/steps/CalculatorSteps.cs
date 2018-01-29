using NUnit.Framework;
using TechTalk.SpecFlow;
using TestStackFramework.framework;
using TestStackFramework.utils;
using Views;

namespace Tests.steps
{
    [Binding]
    public class CalculatorSteps
    {
        [Given(@"All old instances of app are closed")]
        public void GivenAllOldInstancesOfAppAreClosed()
        {
            ProcessesUtil.CloseAllProcessesByName(Settings.Default.processName);
        }

        [Given(@"view type is '(.*)'")]
        public void GivenViewTypeIs(string viewType)
        {
            MainView.AppMenuBar.SelectMenu("View", viewType);
        }


        [Given(@"new instance is open")]
        public void GivenNewInstanceIsOpen()
        {
            Scope.Application = MyApp.Launch();
            Scope.DefaultWindow = MyApp.Window;
        }

        [When(@"User adds '(.*)' to '(.*)'")]
        public void WhenUserAddsTo(int numberToAdd, int numberToWhichToAdd)
        {
            EnterNumber(numberToWhichToAdd);
            MainView.ButtonAdd.Click();
            EnterNumber(numberToAdd);
            MainView.ButtonEquals.Click();
        }

        [When(@"Adds result to memory")]
        public void WhenAddsResultToMemory()
        {
            MainView.ButtonRemember.Click();
        }

        [When(@"User enters '(.*)' and adds it to number in memory")]
        public void WhenUserEntersAndAddsItToNumberInMemory(int numberToAdd)
        {
            EnterNumber(numberToAdd);
            MainView.ButtonAdd.Click();
            MainView.ButtonGetFromMemory.Click();
            MainView.ButtonEquals.Click();
        }

        [Then(@"the result should be '(.*)' on the screen")]
        public void ThenTheResultShouldBeOnTheScreen(int expectedResult)
        {
            Assert.AreEqual(expectedResult, int.Parse(MainView.Resultlabel.Name), "Result is not equal expected");
        }

        public static void EnterNumber(int number)
        {
            LoggerUtil.Log.Info("User needs to enter: " + number);
            foreach (var digit in number.ToString())
            {
                MainView.ButtonName = digit.ToString();
                MainView.ButtonNumber.Click();
            }
        }

    }
}
