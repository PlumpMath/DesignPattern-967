using Strategy.State;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class Program
    {
        public static void Main()
        {
            ReportSystem reportSystem = new ReportSystem();
            reportSystem.Run();
        }
    }
}
