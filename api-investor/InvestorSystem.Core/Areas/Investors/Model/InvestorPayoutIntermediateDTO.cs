using InvestorSystem.DataModel.Table;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvestorSystem.Core.Areas.Investors.Model
{
    public class InvestorPayoutIntermediateDTO
    {
        public Investor? Investor { get; set; }
        public long InvestorID { get; set; }
        public long Amount { get; set; }
        public DateTime ForDate { get; set; }
    }
}
