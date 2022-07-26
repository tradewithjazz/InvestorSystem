using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InvestorSystem.Core.Areas.Investors.Model;

namespace InvestorSystem.Core.Areas.Common
{
    public interface IPayoutCalculations
    {
        public Task<bool> CalculateNextPayout_New(string payoutDetails,int role);
    }
}
