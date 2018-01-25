using log4net;
using log4net.Config;

namespace Framework.utils
{
    public static class LoggerUtil
    {
        private static ILog log = LogManager.GetLogger("LOGGER");

        public static ILog Log => log;

        public static void InitLogger()
        {
            XmlConfigurator.Configure();
        }
    }
}
