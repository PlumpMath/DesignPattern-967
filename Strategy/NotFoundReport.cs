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

        //TODO: alterar para virtual
        public void FreeReport(List<string> data)
        {
            
        }

        public void PremiumReport(List<string> data)
        {
            
        }

        public void StandardReport(List<string> data)
        {
        }
    }
}
