using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Decorator
{
    public abstract class LogBase
    {
        public LogBase OtherLog { get; set; }
        protected LogBase(LogBase log)
        {
            OtherLog = log;
        }
        protected LogBase() { }
        public abstract void Logger(TemplateReport report);
    }
}
