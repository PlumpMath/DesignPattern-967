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
            VersionsType version;
            if("123".Equals(serial))
            {
                version = VersionsType.Premium;
            }
            else if("456".Equals(serial))
            {
                version = VersionsType.Standard;
            }
            else
            {
                version = VersionsType.Free;
            }
            var reportSystem = new ReportSystem(version, userName, password,  serial );
            reportSystem.Run();
        }
    }
}
