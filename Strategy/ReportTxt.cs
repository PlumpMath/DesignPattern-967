using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class ReportTxt : TemplateReport
    {
        public override IReport NextReport { get; set; }
        
        public override void FreeReport(List<string> data)
        {
            Console.WriteLine($"Generating Free version of {this}");
        }

        public override void StandardReport(List<string> data)
        {
            Console.WriteLine($"Generating Standard version of {this}");
        }

        public override void PremiumReport(List<string> data)
        {
            Console.WriteLine($"Generating Premium version of {this}");
        }

        //TODO: alterar para virtual
        internal override void IncrementCountReportGenerated()
        {
            return;
        }

        internal override bool CanGeneratePremium()
        {
            return false;
        }

        public override bool CanGenerateStandard()
        {
            return false;
        }

        public override List<string> GetDataSorted(List<string> data)
        {   
            return data.OrderBy(d => d).ToList();
        }

        public override string GetFileType()
        {
            return "1";
        }
    }
}
