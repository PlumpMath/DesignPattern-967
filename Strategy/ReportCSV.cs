using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class ReportCSV: TemplateReport
    {

        public override bool HasStandardBenefits()
        {
            return countReportGenerated <= 1;
        }
        public override void FreeReport()
        {
            Console.WriteLine($"Generating Free version of {this}");
        }

        public override void StandardReport()
        {
            Console.WriteLine($"Generating Standard version of {this}");
        }

        public override void PremiumReport()
        {
            Console.WriteLine($"Generating Premium version of {this}");
        }
    }
}
