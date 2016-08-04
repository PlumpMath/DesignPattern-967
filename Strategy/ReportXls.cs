using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class ReportXls: TemplateReport
    {
        
        public override bool HasStandardBenefits()
        {
            return countReportGenerated < 3;
        }

        public override bool HasPremiumBenefits()
        {
            return countReportGenerated < 5;
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
