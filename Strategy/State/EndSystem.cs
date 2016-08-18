using System;

namespace Strategy.State
{
    public class EndTheSystem : IUserActionState
    {
        public void Create(ReportSystem program)
        {
            throw new Exception("O Arquivo já foi criado!");
        }

        public void Download(ReportSystem program)
        {
            throw new Exception("O Arquivo já foi baixado!");
        }

        public void EndSystem(ReportSystem program)
        {
            throw new Exception("O Arquivo já esta sendo finalizado!");
        }

        public void ExecuteAction(ReportSystem program)
        {
            program.FinalizeReport();
        }

        public void Post(ReportSystem program)
        {
            throw new Exception("O Arquivo já foi postado");
        }
    }
}