using InvestorSystem.Core.Areas.Common.DTOs;
using InvestorSystem.Core.Areas.Employee.Model;
using InvestorSystem.Core.Areas.Investors.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvestorSystem.Core.Areas.Employee.Services
{
    public interface IEmployeeService
    {
        public Task<EmployeePayoutDTO> DisplayInvestments(long id);
        public Task<AddUpdateInvestmentDTO> AddEmployeePayoutInvestment(long EmployeeID, long Amount);
        public Task<AddUpdateInvestmentDTO> UpdateEmployeePayoutInvestment(long EmployeeID, long Amount);
        public Task<AddUpdateInvestmentDTO> AddEmployeeCompoundInvestment(long EmployeeID, long Amount);
        public Task<AddUpdateInvestmentDTO> UpdateEmployeeCompoundInvestment(long EmployeeID, long Amount);
        public Task<List<AddUpdateInvestmentDTO>> DisplayPayoutHistory(long EmployeeID);
        //public Task<List<AddUpdateInvestmentDTO>> DisplayCompoundingHistory(long EmployeeID);
    }
}
