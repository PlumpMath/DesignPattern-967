using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    class Program
    {
        public enum VersionsType { Free, Standard, Premium }
        public static VersionsType UserVersion = VersionsType.Free;
        public enum UserActionState { None, CreateNewFile, DownloadFile, FinalizeSystem,
            End
        }
        static UserActionState CurrentState = UserActionState.None;
        
        static void Main(string[] args)
        {
            
            while (true)
            {
                if (CurrentState == UserActionState.None)
                {
                    ChangeState();
                }
                else if(CurrentState == UserActionState.CreateNewFile)
                {
                    Console.WriteLine("###########################################");
                    Console.WriteLine("#            TIPOS DE RELATÓRIOS          #");
                    Console.WriteLine("###########################################");
                    Console.WriteLine("#1 - TXT                                  #");
                    Console.WriteLine("#2 - CSV                                  #");
                    Console.WriteLine("#3 - XLS                                  #");
                    Console.WriteLine("###########################################");
                    Console.WriteLine("Informe o tipo de arquivo para ser gerado: ");

                    var fileType = Console.ReadLine();
                    var data = new List<string>()
                    {
                        "PAULO HENRIQUE REGIS MARINHO       ",
                        "THIAGO FOGACA VIEIRA DE SOUZA      ",
                        "AYRTON GISSONI CERQUEIRA           ",
                        "LUIZ RENATO FERNANDES DE FREITAS   ",
                        "MONTAIR AR COND E S TCNICOS LTDA ME",
                        "EDSON ROBERTO NUNES JUNIOR         ",
                        "ALLAN MELCHIADES DE SOUZA          ",
                        "LIVIA KRASSUSKI BARBOZA            ",
                        "MASTER RENT A CAR LTDA ME          ",
                        "WAGNER LOUREIRO DE ALMEIDA         ",
                        "ADRIANA DIAS DE OLIVEIRA           ",
                        "NEVALDO CABRAL MEDEIROS            ",
                        "GRAZIELA DALLA ROSA BERNARDINO     ",
                        "HERBENIA MESQUITA DE OLIVEIRA      ",
                        "ISLANE PEREIRA TEIXEIRA            ",
                        "PAULO ROBERTO MARTINS              ",
                        "BRUNO ARLEY SOUSA PEREIRA          ",
                        "WAGNER VASQUES JUNIOR              ",
                        "SINARA DA SILVA GUERREIRO          ",
                        "ANTONIA VALNEIDE PINHEIRO          ",
                        "CLEYDSON PEREIRA DE SOUZA          ",
                    };

                    var generateReportManager = new GenerateReportManager();

                    IReport report = null;
                    MenuInputBase menuTxt = new MenuInputTxt();
                    MenuInputBase menuCsv = new MenuInputCsv();
                    MenuInputBase menuXls = new MenuInputXls();
                    MenuInputBase menuEmpty = new MenuInputEmpty();

                    menuTxt.Next = menuCsv;
                    menuCsv.Next = menuXls;
                    menuXls.Next = menuEmpty;

                    report = menuTxt.GetReport(fileType);

                    if (report == null)
                    {
                        Console.WriteLine("Report not found");
                    }
                    else
                    {
                        generateReportManager.GenerateReport(report, data.ToArray());
                    }
                    ChangeState();
                }
                else if(CurrentState == UserActionState.DownloadFile)
                {
                    Console.WriteLine("Arquivo baixado para a pasta Download");
                    ChangeState();
                }
                else if(CurrentState == UserActionState.FinalizeSystem)
                {
                    CurrentState = UserActionState.None;
                }
                else if (CurrentState == UserActionState.End)
                {
                    break;//Breaks while
                }
            }
        }

        private static void ChangeState()
        {
            while (true)
            {
                Console.WriteLine("###########################################");
                Console.WriteLine("#      EXCOLHA UMA DAS OPÇÕES ABAIXO      #");
                Console.WriteLine("###########################################");
                Console.WriteLine("#1 - Criar arquivo                        #");
                Console.WriteLine("#2 - Fazer download do arquivo criado     #");
                Console.WriteLine("#3 - Finalizar                            #");
                Console.WriteLine("#4 - Sair                                 #");
                Console.WriteLine("###########################################");
                var action = Console.ReadLine();
                if ("1".Equals(action))
                {
                    if (new List<UserActionState>() { UserActionState.None, UserActionState.FinalizeSystem }.Contains(CurrentState))
                    {
                        CurrentState = UserActionState.CreateNewFile;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("É preciso Finalizar antes de criar um novo arquivo.");
                    }
                }
                else if ("2".Equals(action))
                {
                    if (CurrentState == UserActionState.CreateNewFile)
                    {
                        CurrentState = UserActionState.DownloadFile;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("É preciso Criar um arquivo antes de fazer download.");
                    }
                }
                else if ("3".Equals(action))
                {
                    if (new List<UserActionState>() { UserActionState.CreateNewFile, UserActionState.DownloadFile }.Contains(CurrentState))
                    {
                        CurrentState = UserActionState.FinalizeSystem;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Não tem nada para ser finalizado");
                    }
                }
                else if("4".Equals(action))
                {
                    if (CurrentState == UserActionState.FinalizeSystem)
                    {
                        CurrentState = UserActionState.End;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("É preciso Finalizar antes de Sair.");
                    }
                }
            }
        }
    }
}
