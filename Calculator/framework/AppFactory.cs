using System.IO;
using TestStack.White;

namespace Calculator
{
    class AppFactory
    {
        public static Application GetApp()
        {
            var applicationPath = Path.Combine(Settings.Default.Path, Settings.Default.EXE);
            var application = Application.Launch(applicationPath);
            return application;
        }
    }
}
