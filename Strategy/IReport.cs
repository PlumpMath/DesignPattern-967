using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public interface IReport
    {
        IReport NextReport { get; set; }

        void CreateReportFile(List<string> data,string fileType);
    }
}
