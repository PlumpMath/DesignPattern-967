using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class ReportXls
    {
        public void CreateReportFile(string[] data)
        {
            Console.WriteLine($"XLS Created {data?.Count()}");
        }
    }
}
