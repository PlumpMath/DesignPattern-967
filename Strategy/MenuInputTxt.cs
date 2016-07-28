using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class MenuInputTxt : MenuInputBase
    {
        public MenuInputTxt()
        {
            Console.WriteLine();
        }
        public override IReport GetReport(string input)
        {
            if ("1".Equals(input))
            {
                return new ReportTxt();
            }

            return Next.GetReport(input);
        }
    }
}
