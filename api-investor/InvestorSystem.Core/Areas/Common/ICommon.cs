using InvestorSystem.Core.Areas.Common.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvestorSystem.Core.Areas.Common
{
    public interface ICommon
    {
        public int GetInterestRateAsPerAmount(long amount,int role);
    }
}
