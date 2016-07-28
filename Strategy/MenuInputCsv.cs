using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class MenuInputCsv : MenuInputBase
    {
        public override IReport GetReport(string input)
        {
            if ("2".Equals(input))
            {
                return new ReportCSV();
            }

            return Next.GetReport(input);
        }
    }
}
