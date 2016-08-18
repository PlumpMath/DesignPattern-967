using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.State
{
    public class None : IUserActionState
    {
        public void Create(ReportSystem program)
        {
            program.CurrentState = new CreateNewFile();
        }

        public void Download(ReportSystem program)
        {
            throw new Exception("O Arquivo ainda não foi criado!");
        }

        public void EndSystem(ReportSystem program)
        {
            program.CurrentState = new EndTheSystem();
        }

        public void ExecuteAction(ReportSystem program)
        {
        }

        public void Post(ReportSystem program)
        {
            throw new Exception("O Arquivo ainda não foi criado!");
        }
    }
}
