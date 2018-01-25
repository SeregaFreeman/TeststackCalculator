using TestStack.White;

namespace Calculator
{
    class App
    {
        private static App _instance;
        readonly Application _application;

        public static App GetInstance()
        {
            return _instance ?? (_instance = new App());
        }
        private App()
        {
            _application = AppFactory.GetApp();
        }
        public Application GetApplication()
        {
            return _application;
        }
    }
}
