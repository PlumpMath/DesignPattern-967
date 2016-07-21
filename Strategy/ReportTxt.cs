using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class ReportTxt: IReport
    {
        public void GenerateReport(string[] data)
        {
            var dataSorted = data.OrderBy(d => d).ToArray();
            Console.WriteLine($"TXT Created {dataSorted?.Count()}");
        }
    }
}
