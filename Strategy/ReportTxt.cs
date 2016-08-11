using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class ReportTxt : Report
    {
        public void CreateReportFile(List<string> data)
        {
            var dataSorted = data.OrderBy(d => d).ToArray();
           
            Console.WriteLine($"TXT Created {dataSorted?.Count()}");
        }
    }
}
