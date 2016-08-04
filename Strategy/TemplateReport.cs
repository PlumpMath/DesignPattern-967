using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public abstract class TemplateReport : IReport
    {
        protected static int countReportGenerated = 0;
        protected int maxFree;
        protected int maxStandard;
        public void GenerateReport(string[] data)
        {
            Program.VersionsType version = Program.UserVersion;
            
            if (HasPremiumBenefits())
            {
                version = Program.VersionsType.Premium;
            }
            else
            if (HasStandardBenefits())
            {
                version = Program.VersionsType.Standard;
            }

            switch (version)
            {
                case Program.VersionsType.Free: FreeReport(); break;
                case Program.VersionsType.Standard: StandardReport(); break;
                case Program.VersionsType.Premium: PremiumReport(); break;
            }
            countReportGenerated++;
            Console.WriteLine($"{this} Created {data?.Count()}");
        }

        public virtual bool HasPremiumBenefits()
        {
            return false;
        }

        public virtual bool HasStandardBenefits()
        {
            return false;
        }

        public abstract void StandardReport();
        public abstract void FreeReport();
        public abstract void PremiumReport();
    }
}
