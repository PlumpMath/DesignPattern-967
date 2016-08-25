using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Decorator
{
    public class LogBenefits : LogBase
    {
        public LogBenefits(LogBase log) 
            : base (log)
        {

        }
        public LogBenefits() : base() { }

        public override void Logger(TemplateReport report)
        {
            if(report.HasPremiumBenefits())
            {
                Console.WriteLine("Log premium");
            }
            else if(report.HasStandardBenefits())
            {
                Console.WriteLine("Log standard");
            }
            else
            {
                Console.WriteLine("Log free");
            }

            OtherLog?.Logger(report);
        }
    }
}
