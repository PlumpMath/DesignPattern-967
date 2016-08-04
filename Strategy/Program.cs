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

        static void Main(string[] args)
        {
            while (true)
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
            }
        }
    }
}
