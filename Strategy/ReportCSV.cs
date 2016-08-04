using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class ReportCSV: IReport
    {
        public void GenerateReport(string[] data)
        {
            switch (Program.UserVersion)
            {
                case Program.VerionsType.Free:
                    FreeReport();
                    break;
                case Program.VerionsType.Standard:
                    StandardReport();
                    break;
                case Program.VerionsType.Premium:
                    PremiumReport();
                    break;
            }

            Console.WriteLine($"CSV Created {data?.Count()}");
        }
        private void FreeReport()
        {
            Console.WriteLine($"Generating Free version of {this}");
        }

        private void StandardReport()
        {
            Console.WriteLine($"Generating Standard version of {this}");
        }

        private void PremiumReport()
        {
            Console.WriteLine($"Generating Premium version of {this}");
        }
    }
}
