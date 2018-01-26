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
        public void GivenViewTypeIs(string p0)
        {
            MainView.AppMenuBar.SelectMenu("View", p0);
        }


        [Given(@"new instance is open")]
        public void GivenNewInstanceIsOpen()
        {
            Scope.Application = MyApp.Launch();
            Scope.DefaultWindow = MyApp.Window;
        }

        [When(@"User adds '(.*)' to '(.*)'")]
        public void WhenUserAddsTo(int p0, int p1)
        {
            EnterNumber(p0);
            MainView.ButtonAdd.Click();
            EnterNumber(p1);
            MainView.ButtonEquals.Click();
        }

        [When(@"Adds result to memory")]
        public void WhenAddsResultToMemory()
        {
            MainView.ButtonRemember.Click();
        }

        [When(@"User enters '(.*)' and adds it to number in memory")]
        public void WhenUserEntersAndAddsItToNumberInMemory(int p0)
        {
            EnterNumber(p0);
            MainView.ButtonAdd.Click();
            MainView.ButtonGetFromMemory.Click();
            MainView.ButtonEquals.Click();
        }

        [Then(@"the result should be '(.*)' on the screen")]
        public void ThenTheResultShouldBeOnTheScreen(int p0)
        {
            Assert.AreEqual(p0, int.Parse(MainView.Resultlabel.Name));
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
