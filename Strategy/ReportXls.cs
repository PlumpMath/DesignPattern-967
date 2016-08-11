using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class ReportXls : Report
    {
        public void CreateReportFile(List<string> data)
        {
            var dataSorted = data.OrderByDescending(d => d).ToArray();
            Console.WriteLine($"XLS Created {dataSorted?.Count()}");
        }
    }
}
