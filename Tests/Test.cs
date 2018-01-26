using System.Threading;
using NUnit.Framework;
using Tests.steps;
using TestStackFramework.framework;
using TestStackFramework.utils;
using Views;

namespace Tests
{
    [TestFixture]
    public class Test
    {
        [SetUp]
        public void StartApp()
        {
            LoggerUtil.InitLogger();
            LoggerUtil.Info("Precondition started");
            ProcessesUtil.CloseAllProcessesByName("calc1");
            LoggerUtil.Info("Precondition completed");
        }

        [Test]
        public void UiTest()
        {
            CalculatorSteps.EnterNumber(12);
            MainView.AppMenuBar.SelectMenu("View");
            Thread.Sleep(1000);
        }

        [TearDown]
        public void Cleanup()
        {
            Scope.Application.Kill();
            LoggerUtil.Info("Test finished\n");
        }
    }
}
