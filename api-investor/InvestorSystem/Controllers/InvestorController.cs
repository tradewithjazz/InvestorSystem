using Microsoft.AspNetCore.Mvc;
using InvestorSystem.Core.Areas.Investors.Model;
using InvestorSystem.Core.Areas.Investors.Services;
using System.Net.Mime;
using InvestorSystem.Core.Areas.Common;
using InvestorSystem.Core.Areas.Common.DTOs;

namespace InvestorSystem.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class InvestorController : ControllerBase
    {
        #region Fields

        private readonly IInvestorService _investorService;
        private readonly IPayoutCalculations _payoutCalculations;
        private readonly ICommon _common;

        #endregion

        #region Constructor
        public InvestorController(IInvestorService investorService,
                                  IPayoutCalculations payoutCalculations,
                                  ICommon common)
        {
            _investorService = investorService;
            _payoutCalculations = payoutCalculations;
            _common = common;
        }

        #endregion

        #region Actions

        [HttpGet("displayinvestments")]
        public async Task<ActionResult<InvestorDTO>> DisplayInvestments([FromServices] IInvestorService investorServices)
        {
            var result = await investorServices.DisplayInvestments();
            return Ok(result);
        }

        /// <summary>
        /// Calculate user's next payout- newly added amount
        /// payoutDetails format should be {investorID,amount_main,lastAddedOn,amount_intermediate,amount_compounding,lastAddedOn}    
        /// </summary>
        /// <param name="investorServices"></param>
        /// <param name="role"></param>
        /// <returns></returns>
        [HttpPost("calculateNextPayout")]
        public async Task<ActionResult> CalculateNextPayout([FromBody] string payoutDetails, int role)
        {
            var result = await _payoutCalculations.CalculateNextPayout_New(payoutDetails, role);
            return Ok(result);
        }

        /// <summary>
        /// Add Investor
        /// </summary>
        /// <param name="investorsDTO"></param>
        /// <returns></returns>
        //public async Task<ActionResult> AddInvestor([FromBody] InvestorDTO investorsDTO)
        //{
        //    var result = await _investorService.AddInvestor(investorsDTO);
        //    return Ok(result);

        //}

        /// <summary>
        /// Get all investors
        /// </summary>
        /// <returns></returns>
        //public async Task<ActionResult<List<UserDisplayList>>> GetInvestorList()
        //{
        //    List<UserDisplayList> userDisplayList = await _common.GetInvestorList();
        //    return Ok(userDisplayList);
        //}

    #endregion

    }
}
