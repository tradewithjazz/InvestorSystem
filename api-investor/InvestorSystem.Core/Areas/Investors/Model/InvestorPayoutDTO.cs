using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvestorSystem.Core.Areas.Investors.Model
{
    public class InvestorPayoutMainDTO
    {
        public int InvestorID { get; set; }
        public long Amount_Main { get; set; }        
        public DateTime LastAddedOn { get; set; }
    }

    public class InvestorPayoutIntermediateDTO
    {
        public int InvestorID { get; set; }
        public long Amount_Intermediate { get; set; }
        public DateTime LastAddedOn { get; set; }
    }

}
