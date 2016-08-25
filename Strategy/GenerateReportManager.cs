using Strategy.Decorator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class GenerateReportManager
    {
        public void GenerateReport(IReport report, string[] data)
        {
            report.GenerateReport(data);
            LogBase log = new LogBenefits(new LogCountReport());
            log.Logger((TemplateReport)report);
        }
    }
}
