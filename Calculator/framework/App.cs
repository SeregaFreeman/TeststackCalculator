using TestStack.White;

namespace Calculator
{
    class App
    {
        private static App instance;
        readonly Application application;
        public static App GetInstance()
        {
            if (instance == null)
            {
                instance = new App();
            }
            return instance;
        }
        private App()
        {
            application = AppFactory.GetApp();
        }
        public Application GetApplication()
        {
            return application;
        }
    }
}
