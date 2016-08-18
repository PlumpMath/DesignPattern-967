using Strategy.State;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class ReportSystem
    {
        public enum VersionsType { Free, Standard, Premium }
        public static VersionsType UserVersion = VersionsType.Free;
        public bool finalize = false;
        public enum UserActionState
        {
            None, CreateNewFile, DownloadFile, FinalizeSystem,
            End
        }
        public IUserActionState CurrentState;
        public void Run()
        {
            CurrentState = new None();
            while (!finalize)
            {
                try
                {
                    ChangeState();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        private void ChangeState()
        {
            Console.WriteLine("###########################################");
            Console.WriteLine("#      EXCOLHA UMA DAS OPÇÕES ABAIXO      #");
            Console.WriteLine("###########################################");
            Console.WriteLine("#1 - Criar arquivo                        #");
            Console.WriteLine("#2 - Post                                 #");
            Console.WriteLine("#3 - Fazer download do arquivo criado     #");
            Console.WriteLine("#4 - Sair                                 #");
            Console.WriteLine("###########################################");
            var action = Console.ReadLine();
            if ("1".Equals(action))
            {
                CurrentState.Create(this);
            }
            else if ("2".Equals(action))
            {

                CurrentState.Post(this);
            }
            else if ("3".Equals(action))
            {
                CurrentState.Download(this);
            }
            else if ("4".Equals(action))
            {
                CurrentState.EndSystem(this);
            }
            CurrentState.ExecuteAction(this);
        }

        public void FinalizeReport()
        {
            finalize = true;
        }
    }
}
