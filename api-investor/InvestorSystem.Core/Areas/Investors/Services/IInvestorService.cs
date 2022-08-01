using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InvestorSystem.Core.Areas.Common.DTOs;
using InvestorSystem.Core.Areas.Investors.Model;

namespace InvestorSystem.Core.Areas.Investors.Services
{
    public interface IInvestorService
    {
        public Task<InvestorDTO> DisplayInvestments();
        public Task<InvestorDTO> AddInvestorBasicDetails(InvestorDTO investorDTO);
        public Task<InvestorDTO> AddInvestorBankDetails(InvestorDTO investorDTO);
        public Task<InvestorDTO> AddInvestorNomineeDetails(InvestorDTO investorDTO);
        //public Task<List<UserDisplayList>> GetInvestorList();
    }
}
