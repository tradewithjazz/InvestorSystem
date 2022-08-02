using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvestorSystem.Core.Areas.Investors.Model
{
    public class InvestorDashboardDTO
    {
        public long? InvestorID { get; set; }
        public long? Total { get; set; }
        public long? PayoutAmount { get; set; }
        public long? CompoundingAmount { get; set; }
        public long? NextPayoutAmount { get; set; }
        public long? NextCompoundingAmount { get; set; }
    }
}
