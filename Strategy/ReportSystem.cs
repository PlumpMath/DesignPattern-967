using Strategy.State;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public enum VersionsType { Free, Standard, Premium }

    public class ReportSystem
    {
        private string Password;
        private string Serial;
        private string UserName;
        public static VersionsType UserVersion;
        public bool finalize = false;
   
        public IUserActionState CurrentState;

        public ReportSystem(VersionsType versionType, string userName, string password, string serial)
        {
            UserVersion = versionType;
            this.UserName = userName;
            this.Serial = serial;
            this.Password = password;
        }

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
