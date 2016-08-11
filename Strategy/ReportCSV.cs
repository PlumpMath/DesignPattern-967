using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class ReportCSV : Report
    {
        public void CreateReportFile(List<string> data)
        {
            Console.WriteLine($"CSV Created {data?.Count()}");
        }
    }
}
