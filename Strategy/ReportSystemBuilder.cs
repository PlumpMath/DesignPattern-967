using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class ReportSystemBuilder
    {
        public string UserName { get; private set; }
        public string Password { get; private set; }
        public string Serial { get; private set; }
        public VersionsType Version { get; private set; }

        public ReportSystemBuilder WithLogin(string username, string password)
        {
            this.UserName = username;
            this.Password = password;
            return this;
        }

        public ReportSystemBuilder WithSerial(string serial)
        {
            this.Serial = serial;
            if ("123".Equals(serial))
            {
                Version = VersionsType.Premium;
            }
            else if ("456".Equals(serial))
            {
                Version = VersionsType.Standard;
            }
            else
            {
                Version = VersionsType.Free;
            }
            return this;
        }

        public ReportSystem build()
        {
            return new ReportSystem(Version, UserName, Password, Serial);
        }
    }
}
