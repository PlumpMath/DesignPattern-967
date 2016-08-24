using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class ReportCSV : IReport
    {
        public IReport NextReport { get; set; }
        static int countReportGenerated = 0;

        public void CreateReportFile(List<string> data, string fileType)
        {
            if (fileType == "2")
            {
                switch (Program.UserVersion)
                {
                    case Program.VerionsType.Free:
                        if(countReportGenerated <= 1)
                            StandardReport(data);
                        else
                            FreeReport(data);
                        break;
                    case Program.VerionsType.Standard:
                        StandardReport(data);
                        break;
                    case Program.VerionsType.Premium:
                        PremiumReport(data);
                        break;
                }
                countReportGenerated++;
                Console.WriteLine($"CSV Created {data?.Count()}");
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
