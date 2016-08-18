using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class ReportXls : IReport
    {
       
        public IReport NextReport { get; set; }

        public void CreateReportFile(List<string> data, string fileType)
        {
            if (fileType == "3")
            {
                var dataSorted = data.OrderByDescending(d => d).ToArray();
                Console.WriteLine($"XLS Created {dataSorted?.Count()}");
            }else
            {
                NextReport.CreateReportFile(data, fileType);
            }
            
        }
    }
}
