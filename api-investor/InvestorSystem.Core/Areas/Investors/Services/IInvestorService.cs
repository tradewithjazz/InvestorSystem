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
        public InvestorDashboardDTO DisplayInvestments(long investorID);
        public List<UserDisplayList> GetInvestorList(long investorID);

        public Task<InvestorDTO> AddInvestorBasicDetails(InvestorDTO investorDTO);
        public Task<BankDetailsDTO> AddInvestorBankDetails(BankDetailsDTO bankDetailsDTO);
        public Task<NomineeDTO> AddInvestorNomineeDetails(NomineeDTO nomineeDTO);

        public Task<InvestorDTO> UpdateInvestorBasicDetails(InvestorDTO investorDTO);
        public Task<BankDetailsDTO> UpdateInvestorBankDetails(BankDetailsDTO bankDetailsDTO);
        public Task<NomineeDTO> UpdateInvestorNomineeDetails(NomineeDTO nomineeDTO);

    }
}
