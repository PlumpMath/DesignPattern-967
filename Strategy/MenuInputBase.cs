using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public abstract class MenuInputBase
    {
        public abstract IReport GetReport(string input);
        public virtual MenuInputBase Next { get; set; }
    }
}
