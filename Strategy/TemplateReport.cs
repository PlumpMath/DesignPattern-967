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

        public int CountReport()
        {
            return countReportGenerated;
        }

        public void GenerateReport(string[] data)
        {
            VersionsType version = ReportSystem.UserVersion;
            
            if (HasPremiumBenefits())
            {
                version = VersionsType.Premium;
            }
            else
            if (HasStandardBenefits())
            {
                version = VersionsType.Standard;
            }

            switch (version)
            {
                case VersionsType.Free: FreeReport(); break;
                case VersionsType.Standard: StandardReport(); break;
                case VersionsType.Premium: PremiumReport(); break;
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
