using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class NotFoundReport : IReport
    {
        public IReport NextReport
        {
            get; set;
        }

        public void CreateReportFile(List<string> data, string fileType)
        {
            Console.WriteLine("Report not found");
        }
    }
}
