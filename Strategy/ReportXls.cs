using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class ReportXls: IReport
    {
        public void GenerateReport(string[] data)
        {
            var dataSorted = data.OrderByDescending(d => d).ToArray();
            Console.WriteLine($"XLS Created {dataSorted?.Count()}");
        }
    }
}
