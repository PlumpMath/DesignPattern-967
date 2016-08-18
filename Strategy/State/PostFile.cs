using System;

namespace Strategy.State
{
    public class PostFile : IUserActionState
    {
        public void Create(ReportSystem program)
        {
            throw new Exception("O Arquivo já está sendo criado!");
        }

        public void Download(ReportSystem program)
        {
            program.CurrentState = new DownloadFile();
        }

        public void EndSystem(ReportSystem program)
        {
            throw new Exception("Faça o download do arquivo primeiro!");
        }

        public void ExecuteAction(ReportSystem program)
        {
            Console.WriteLine("Arquivo esta sendo postado");
        }

        public void Post(ReportSystem program)
        {
            throw new Exception("O Arquivo já foi postado");
        }
    }
}