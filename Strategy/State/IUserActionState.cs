using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.State
{
    public interface IUserActionState
    {
        void ExecuteAction(ReportSystem program);

        void Create(ReportSystem program);
        void Post(ReportSystem program);
        void Download(ReportSystem program);
        void EndSystem(ReportSystem program);

    }
}
