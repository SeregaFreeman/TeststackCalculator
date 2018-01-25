using System.Linq;
using TestStack.White;
using TestStack.White.UIItems.WindowItems;

namespace TestStackFramework.framework
{
    public static class Scope
    {
        public static Application Application { get; } = App.GetInstance().GetApplication();
        public static Window Window
        {
            get { return Application.GetWindows().FirstOrDefault(); }
            set { }
        }

        private static void SetWindow(string locator)
        {
            Window = Application.GetWindow(locator);
        }
    }
}
