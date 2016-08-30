using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Logs
{
    public class WindowsEventViewerLog
    {
        public void Log(string reportType)
        {
            Console.WriteLine($"Escrevendo no log do windows {reportType} {DateTime.Now.ToString()}");
        }
    }
}
