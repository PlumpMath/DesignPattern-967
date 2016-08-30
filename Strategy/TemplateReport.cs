using Strategy.Logs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public abstract class TemplateReport : IReport
    {
        public abstract IReport NextReport { get; set; }

        public void CreateReportFile(List<string> data, string fileType)
        {
            if (fileType == GetFileType())
            {
                var reportTxt = this as ReportTxt;
                if(reportTxt != null)
                {
                    new EmailToAdmin().Send(nameof(ReportTxt));
                    new TextFileLog().Log(nameof(ReportCSV));
                }
                else
                {
                    var reportCSV = this as ReportCSV;
                    if(reportCSV != null)
                    {
                        new EmailToAdmin().Send(nameof(ReportTxt));
                        new TextFileLog().Log(nameof(ReportCSV));
                    }
                    else
                    {
                        var reportXls = this as ReportXls;
                        if(reportXls != null)
                        {
                            new WindowsEventViewerLog().Log(nameof(ReportXls));
                            new TextFileLog().Log(nameof(ReportCSV));
                        }
                    }
                }
                
                var dataSorted = GetDataSorted(data);

                switch (Program.UserVersion)
                {
                    case Program.VerionsType.Free:
                        if (CanGenerateStandard())
                        {
                            StandardReport(dataSorted);
                        }
                        else
                        {
                            FreeReport(dataSorted);
                        }
                        break;
                    case Program.VerionsType.Standard:
                        if (CanGeneratePremium())
                        {
                            PremiumReport(dataSorted);
                        }
                        else
                        {
                            StandardReport(dataSorted);
                        }
                        break;
                    case Program.VerionsType.Premium:
                        PremiumReport(dataSorted);
                        break;
                }
                IncrementCountReportGenerated();
                Console.WriteLine($"{this} Created {dataSorted?.Count()}");
            }
            else
            {
                NextReport.CreateReportFile(data, fileType);
            }
        }

        internal abstract void IncrementCountReportGenerated();
        internal abstract bool CanGeneratePremium();
        public abstract bool CanGenerateStandard();
        public abstract List<string> GetDataSorted(List<string> data);

        public abstract string GetFileType();
        public abstract void FreeReport(List<string> data);
        public abstract void StandardReport(List<string> data);
        public abstract void PremiumReport(List<string> data);
    }
}
