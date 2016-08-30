using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Logs
{
    public class EmailToAdmin
    {
        public void Send(string reportType)
        {
            Console.WriteLine($"Enviando email com o tipo do relatório {reportType}");
        }
    }
}
