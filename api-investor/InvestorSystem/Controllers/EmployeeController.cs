using InvestorSystem.Core.Areas.Common;
using InvestorSystem.Core.Areas.Common.DTOs;
using InvestorSystem.Core.Areas.Employee.Model;
using InvestorSystem.Core.Areas.Employee.Services;
using InvestorSystem.Core.Areas.Investors.Model;
using InvestorSystem.Core.Areas.Investors.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace InvestorSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private IEmployeeService _employeeService;
        //private IPayoutCalculations _payoutCalculations;
        //private ICommon _common;

        public EmployeeController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
            //_payoutCalculations = payoutCalculations;
            //_common = common;
        }

        [HttpGet("DisplayEmployeeInvestments")]
        public async Task<ActionResult<EmployeePayoutDTO>> DisplayEmployeeInvestments(long id)
        {
            var result = await _employeeService.DisplayInvestments(id);
            return Ok(result);
        }

        [HttpPost("AddEmployeePayoutInvestment")]
        public async Task<ActionResult<AddUpdateInvestmentDTO>> AddEmployeePayoutInvestment(long EmployeeID, long Amount)
        {
            AddUpdateInvestmentDTO result = new AddUpdateInvestmentDTO();
            result= await _employeeService.AddEmployeePayoutInvestment(EmployeeID, Amount);
            return Ok(result);
           
        }

        [HttpPost("AddEmployeeCompoundInvestment")]
        public async Task<ActionResult<AddUpdateInvestmentDTO>> AddEmployeeCompoundInvestment(long EmployeeID, long Amount)
        {
            AddUpdateInvestmentDTO result = new AddUpdateInvestmentDTO();
            result = await _employeeService.AddEmployeeCompoundInvestment(EmployeeID, Amount);
            return Ok(result);
        }

        [HttpPost("UpdateEmployeePayoutInvestment")]
        public async Task<ActionResult<AddUpdateInvestmentDTO>> UpdateEmployeePayoutInvestment(long EmployeeID, long Amount)
        {
            var result = await _employeeService.UpdateEmployeePayoutInvestment(EmployeeID, Amount);
            return Ok(result);
        }

        

        [HttpPost("UpdateEmployeeCompoundInvestment")]
        public async Task<ActionResult<AddUpdateInvestmentDTO>> UpdateEmployeeCompoundInvestment(long EmployeeID, long Amount)
        {
            var result = await _employeeService.UpdateEmployeeCompoundInvestment(EmployeeID, Amount);
            return Ok(result);
        }

        [HttpGet("DisplayEmployeePayoutHistory")]
        public async Task<List<AddUpdateInvestmentDTO>> DisplayPayoutHistory(long EmployeeID)
        {
            List<AddUpdateInvestmentDTO> result = new List<AddUpdateInvestmentDTO>();
            result = await _employeeService.DisplayPayoutHistory(EmployeeID);
            return result;
        }
    }
}
