using Microsoft.AspNetCore.Mvc;
using InvestorManagementSystem.Core.Areas.Investors.Model;
using InvestorManagementSystem.Core.Areas.Investors.Services;
using System.Net.Mime;

namespace InvestorManagementSystem.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class InvestorController : ControllerBase
    {
        #region Fields

        private readonly IInvestorService _investorService;

        #endregion

        #region Constructor
        public InvestorController(IInvestorService investorService)
        { 
            _investorService = investorService;
        }

        #endregion

        #region Actions

        [HttpGet("displayinvestments")]
        public async Task<ActionResult<InvestorsDTO>> DisplayInvestments([FromServices] IInvestorService investorServices)
        {
            var result = await investorServices.DisplayInvestments();
            return Ok(result);
        }

        #endregion

    }
}
