using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class ReportXls : IReport
    {

        public IReport NextReport { get; set; }
        static int countReportGenerated = 0;
        public void CreateReportFile(List<string> data, string fileType)
        {
            if (fileType == "3")
            {
                var dataSorted = data.OrderByDescending(d => d).ToList();
                switch (Program.UserVersion)
                {
                    case Program.VerionsType.Free:
                        if(countReportGenerated < 3)
                            StandardReport(dataSorted);
                        else
                            FreeReport(dataSorted);
                        break;
                    case Program.VerionsType.Standard:
                        if(countReportGenerated < 5)
                            PremiumReport(dataSorted);
                        else
                        StandardReport(dataSorted);
                        break;
                    case Program.VerionsType.Premium:
                        PremiumReport(dataSorted);
                        break;
                }
                countReportGenerated++;
                Console.WriteLine($"XLS Created {dataSorted?.Count()}");
            }
            else
            {
                NextReport.CreateReportFile(data, fileType);
            }
        }

        private void FreeReport(List<string> data)
        {
            Console.WriteLine($"Generating Free version of {this}");
        }

        private void StandardReport(List<string> data)
        {
            Console.WriteLine($"Generating Standard version of {this}");
        }

        private void PremiumReport(List<string> data)
        {
            Console.WriteLine($"Generating Premium version of {this}");
        }
    }
}
