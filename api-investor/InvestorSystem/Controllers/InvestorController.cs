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
        #endregion

        #region Constructor
        public InvestorController(IInvestorService investorService,
                                  IPayoutCalculations payoutCalculations)
        {
            _investorService = investorService;
            _payoutCalculations = payoutCalculations;
        }

        #endregion

        #region Actions

        /******************** Investor Insertion Methods ******************/
        /// <summary>
        /// Add Investor basic details
        /// </summary>
        /// <param name="investorsDTO"></param>
        /// <returns></returns>
        [HttpPost("addInvestorBasicDetails")]
        public async Task<ActionResult> AddInvestorBasicDetails([FromBody] InvestorDTO investorsDTO)
        {
            var result = await _investorService.AddInvestorBasicDetails(investorsDTO);
            return Ok(result);
        }

        /// <summary>
        /// Add investor bank details
        /// </summary>
        /// <param name="investorsDTO"></param>
        /// <returns></returns>
        [HttpPost("addInvestorBankDetails")]
        public async Task<ActionResult> AddInvestorBankDetails([FromBody] InvestorDTO investorsDTO)
        {
            var result = await _investorService.AddInvestorBankDetails(investorsDTO);
            return Ok(result);

        }

        /// <summary>
        /// Add investor nominee details
        /// </summary>
        /// <param name="investorsDTO"></param>
        /// <returns></returns>
        [HttpPost("addInvestorNomineeDetails")]
        public async Task<ActionResult> AddInvestorNomineeDetails([FromBody] InvestorDTO investorsDTO)
        {
            var result = await _investorService.AddInvestorNomineeDetails(investorsDTO);
            return Ok(result);
        }

        /// <summary>
        /// Calculate user's next payout- newly added amount
        /// </summary>
        /// <param name="payoutCalculationsDTO"></param>
        /// <param name="role"></param>
        /// <returns></returns>
        [HttpPost("calculateNextPayoutNew")]
        public async Task<ActionResult> CalculateNextPayoutNew([FromBody] PayoutCalculationsDTO payoutCalculationsDTO, int role)
        {
            var result = await _payoutCalculations.CalculateNextPayoutNew(payoutCalculationsDTO, role);
            return Ok(result);
        }


        [HttpGet("displayinvestments")]
        public async Task<ActionResult<InvestorDTO>> DisplayInvestments([FromServices] IInvestorService investorServices)
        {
            var result = await investorServices.DisplayInvestments();
            return Ok(result);
        }

        /******************** Investor Updation Methods ******************/

        /// <summary>
        /// Update Investor basic information
        /// </summary>
        /// <param name="investorsDTO"></param>
        /// <returns></returns>
        [HttpPost("updateInvestorBasicDetails")]
        public async Task<ActionResult> UpdateInvestorBasicDetails([FromBody] InvestorDTO investorsDTO)
        {
            var result = await _investorService.UpdateInvestorBasicDetails(investorsDTO);
            return Ok(result);
        }

        /// <summary>
        /// Update investor bank details
        /// </summary>
        /// <param name="investorsDTO"></param>
        /// <returns></returns>
        [HttpPost("updateInvestorBankDetails")]
        public async Task<ActionResult> UpdateInvestorBankDetails([FromBody] InvestorDTO investorsDTO)
        {
            var result = await _investorService.UpdateInvestorBankDetails(investorsDTO);
            return Ok(result);

        }

        /// <summary>
        /// Update Investor nominee details
        /// </summary>
        /// <param name="investorsDTO"></param>
        /// <returns></returns>
        [HttpPost("updateInvestorNomineeDetails")]
        public async Task<ActionResult> UpdateInvestorNomineeDetails([FromBody] InvestorDTO investorsDTO)
        {
            var result = await _investorService.UpdateInvestorNomineeDetails(investorsDTO);
            return Ok(result);
        }


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
