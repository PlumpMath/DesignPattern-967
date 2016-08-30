using Strategy.Logs;
using System;
using System.Collections.Generic;

namespace Strategy
{
    public static class ReportGenerator
    {
        public static void Run (List<string> data, string fileType)
        {
            var r1 = new ReportTxt();
            var r2 = new ReportCSV();
            var r3 = new ReportXls();
            var r4 = new NotFoundReport();

            r1.NextReport = r2;
            r2.NextReport = r3;
            r3.NextReport = r4;

            r1.CreateReportFile(data, fileType);

            Console.ReadKey();
        }
    }
}
