using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InvestorManagementSystem.Core.Areas.Investors.Model;

namespace InvestorManagementSystem.Core.Areas.Investors.Services
{
    public interface IInvestorService
    {
        public Task<InvestorsDTO> DisplayInvestments();
    }
}
