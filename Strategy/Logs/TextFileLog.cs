using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Logs
{
    public class TextFileLog
    {
        public void Log(string reportType)
        {
            Console.WriteLine($"O usuário esta imprimindo o relatório do tipo {reportType}");
        }
    }
}
