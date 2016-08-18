using System;

namespace Strategy.State
{
    public class DownloadFile : IUserActionState
    {
        public void Create(ReportSystem program)
        {
            throw new Exception("O Arquivo já foi criado!");
        }

        public void Download(ReportSystem program)
        {
            throw new Exception("O Arquivo já esta sendo baixado!");
        }

        public void EndSystem(ReportSystem program)
        {
            program.CurrentState = new EndTheSystem();
        }

        public void ExecuteAction(ReportSystem program)
        {
            Console.WriteLine("Arquivo esta sendo baixado");
        }

        public void Post(ReportSystem program)
        {
            throw new Exception("O Arquivo já foi postado");
        }
    }
}