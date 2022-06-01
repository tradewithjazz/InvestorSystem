﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InvestorSystem.Core.Areas.Investors.Model;
using InvestorSystem.Core.Areas.Investors.Services;

namespace InvestorSystem.Infrastructure.Areas.Investors.Services
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
