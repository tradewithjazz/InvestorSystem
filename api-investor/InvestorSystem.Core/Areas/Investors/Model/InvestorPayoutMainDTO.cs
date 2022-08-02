using InvestorSystem.DataModel.Table;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvestorSystem.Core.Areas.Investors.Model
{
    public class InvestorPayoutMainDTO
    {
        public long? InvestorID { get; set; }

        public Investor? Investor { get; set; }
        public long Amount { get; set; }        
        public DateTime LastModified { get; set; }
    }

}
