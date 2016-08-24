using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class ReportTxt : IReport
    {
        public IReport NextReport { get; set; }

        public void CreateReportFile(List<string> data, string fileType)
        {
            if (fileType == "1")
            {
                var dataSorted = data.OrderBy(d => d).ToList();
                switch (Program.UserVersion)
                {
                    case Program.VerionsType.Free:
                        FreeReport(dataSorted);
                        break;
                    case Program.VerionsType.Standard:
                        StandardReport(dataSorted);
                        break;
                    case Program.VerionsType.Premium:
                        PremiumReport(dataSorted);
                        break;
                }
                Console.WriteLine($"TXT Created {dataSorted?.Count()}");
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
