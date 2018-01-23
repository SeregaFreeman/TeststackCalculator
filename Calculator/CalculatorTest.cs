using NUnit.Framework;
using Calculator.utils;
using Calculator.windows;
using TestStack.White;
using System.Threading;

namespace Calculator
{
    [TestFixture]
    public class CalculatorTest
    {
        private Application _app;

        [SetUp]
        public void StartApp()
        {
            LoggerUtil.InitLogger();
            LoggerUtil.Log.Info("Test started");
            ProcessesUtil.CloseAllProcessesByName(Settings.Default.processName);
            _app = App.GetInstance().GetApplication();
            LoggerUtil.Log.Info("Precondition completed");
        }

        [Test]
        public void UITest()
        {
            MainWindow mainWindow = new MainWindow(_app);
            mainWindow.EnterNumber(123456);
            Thread.Sleep(1000);
        }

        [TearDown]
        public void Cleanup()
        {
            _app.Kill();
            LoggerUtil.Log.Info("Test finished");
        }
    }
}
