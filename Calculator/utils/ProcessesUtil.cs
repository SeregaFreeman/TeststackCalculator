using System.Diagnostics;

namespace Calculator.utils
{
    class ProcessesUtil
    {
        public static void CloseAllProcessesByName(string processName)
        {
            Process[] processes = Process.GetProcessesByName(processName);
            foreach (Process p in processes)
            {
                p.Kill();
            }
        }
    }
}
