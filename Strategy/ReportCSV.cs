using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class ReportCSV : TemplateReport
    {
        public override IReport NextReport { get; set; }

        static int countReportGenerated = 0;

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
            return false;
        }

        public override bool CanGenerateStandard()
        {
            return (countReportGenerated <= 1);
        }

        public override List<string> GetDataSorted(List<string> data)
        {
            return data;
        }

        public override string GetFileType()
        {
            return "2";
        }

    }
}
