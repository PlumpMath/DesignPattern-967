using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class ReportTxt : IReport
    {
        public IReport NextReport { get; set; }

        public void CreateReportFile(List<string> data, string fileType)
        {
            if (fileType == "1")
            {
                var dataSorted = data.OrderBy(d => d).ToArray();

                Console.WriteLine($"TXT Created {dataSorted?.Count()}");
            }
            else
            {
                NextReport.CreateReportFile(data, fileType);
            }

        }
    }
}
