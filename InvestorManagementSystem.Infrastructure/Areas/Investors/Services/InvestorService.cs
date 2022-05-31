using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InvestorManagementSystem.Core.Areas.Investors.Model;
using InvestorManagementSystem.Core.Areas.Investors.Services;

namespace InvestorManagementSystem.Infrastructure.Areas.Investors.Services
{
    public class InvestorService : IInvestorService
    {
        #region Constructor
        public InvestorService() 
        {
        }
        #endregion

        #region IInvestors
        public Task<InvestorsDTO> DisplayInvestments()
        {
            throw new NotImplementedException();
        }

        #endregion

    }
}
