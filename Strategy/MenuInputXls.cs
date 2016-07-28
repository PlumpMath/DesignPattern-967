using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class MenuInputXls : MenuInputBase
    {
        public override IReport GetReport(string input)
        {
            if ("3".Equals(input))
            {
                return new ReportXls();
            }

            return Next.GetReport(input);
        }
    }
}
