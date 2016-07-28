using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class MenuInputEmpty : MenuInputBase
    {
        public MenuInputEmpty()
        {
            Console.WriteLine();
        }
        public override IReport GetReport(string input)
        {
            return null;
        }
    }
}
