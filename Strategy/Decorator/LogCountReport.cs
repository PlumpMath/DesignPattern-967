using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Decorator
{
    public class LogCountReport : LogBase
    {
        public LogCountReport(LogBase log) : base(log) { }
        public LogCountReport() : base() { }
        public override void Logger(TemplateReport report)
        {
            Console.WriteLine($"LogCount {report.CountReport()}");
            OtherLog?.Logger(report);
        }
    }
}
