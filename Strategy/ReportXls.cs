using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class ReportXls : TemplateReport
    {

        public override IReport NextReport { get; set; }
        public static int countReportGenerated = 0;  

        public override void FreeReport(List<string> data)
        {
            Console.WriteLine($"Generating Free version of {this}");
        }

        public override void StandardReport(List<string> data)
        {
            Console.WriteLine($"Generating Standard version of {this}");
        }

        public override void PremiumReport(List<string> data)
        {
            Console.WriteLine($"Generating Premium version of {this}");
        }

        internal override void IncrementCountReportGenerated()
        {
            countReportGenerated++;
        }

        internal override bool CanGeneratePremium()
        {
            return countReportGenerated < 5;
        }

        public override bool CanGenerateStandard()
        {
            return countReportGenerated < 3;
        }

        public override List<string> GetDataSorted(List<string> data)
        {
            return data.OrderByDescending(d => d).ToList();
        }

        public override string GetFileType()
        {
            return "3";
        }
        
    }
}
