using Strategy.State;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Informe o usuário: ");
            var userName = Console.ReadLine();
            Console.WriteLine("Informe a senha: ");
            var password = Console.ReadLine();
            Console.WriteLine("Informe o serial: ");
            var serial = Console.ReadLine();

            var reportBuilder = new ReportSystemBuilder();
            
            var reportSystem = reportBuilder
                .WithLogin(userName, password)
                .WithSerial(serial)
                .build();
            reportSystem.Run();
        }
    }
}
