using System;
using System.Collections.Generic;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
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

            ReportGenerator.Run(data, fileType);
        }
    }
}
