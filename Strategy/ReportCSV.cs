using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class ReportCSV : IReport
    {
        public IReport NextReport { get; set; }


        public void CreateReportFile(List<string> data, string fileType)
        {
            if (fileType == "2")
            {
                Console.WriteLine($"CSV Created {data?.Count()}");
            }
            else
            {
                NextReport.CreateReportFile(data, fileType);
            }

        }
    }
}
