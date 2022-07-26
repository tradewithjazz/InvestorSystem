using AutoMapper;
using InvestorSystem.Core.Areas.Common;
using InvestorSystem.Core.Areas.Common.DTOs;
using InvestorSystem.Core.Areas.Investors.Model;
using InvestorSystem.Infrastructure.DB;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvestorSystem.Infrastructure.Areas.Common
{
    public class PayoutCalculations : IPayoutCalculations
    {
        ICommon _common;
        IPayoutCalculations _payoutCalculations;
        IMapper _mapper;
        AppDBContext _dBContext;

        public PayoutCalculations(ICommon common,
                                  IPayoutCalculations payoutCalculations,
                                  IMapper mapper,
                                  AppDBContext appDBContext)
        {
            _common = common;
            _payoutCalculations = payoutCalculations;
            _mapper = mapper;
            _dBContext = appDBContext;
        }

        /// <summary>
        /// 1.Add newly added amount in main table
        /// 2.Calculate next payout
        /// 3.Update calculated amount in intermediate table
        /// </summary>
        /// <param name="investorsDTO"></param>
        /// <returns></returns>
        public async Task<bool> CalculateNextPayout_New(string payoutDetails,int role)
        {

            //need to check compounding payout too
            if (payoutDetails == null) throw new ArgumentNullException(payoutDetails); 
           
            PayoutCalculationsDTO payoutCalculationsDTO = JsonConvert.DeserializeObject<PayoutCalculationsDTO>(payoutDetails);

            int interestRate = -1;

            switch (role)
            {
                case 2:  
                    InvestorPayoutMainDTO investorPayoutMainDTO  = new InvestorPayoutMainDTO();
                    investorPayoutMainDTO  = _mapper.Map<PayoutCalculationsDTO, InvestorPayoutMainDTO>(payoutCalculationsDTO);
                    //await _dBContext.Investor_Investment.Insert(investorPayoutMainDTO);

                    long totalAmount = (payoutCalculationsDTO.Amount_Main + payoutCalculationsDTO.Amount_compounding);

                    interestRate = _common.GetInterestRateAsPerAmount(investorPayoutMainDTO.Amount_Main, role);

                    int investmentAddedDay = investorPayoutMainDTO.LastAddedOn.Day;
                    int forDays = 30 - investmentAddedDay;
                    if (payoutCalculationsDTO.Amount_Main > 2500000)
                    {
                        if (interestRate == 0)  //special case
                        {
                            long amount = 2500000;
                            long remainingAmount = (investorPayoutMainDTO.Amount_Main - amount);
                            double calculatedInterestFor25L = ((forDays * 4) / 30);
                            long calculatedAmountFor25L = Convert.ToInt64((amount * calculatedInterestFor25L) / 100);

                            double calculatedInterestForRemaining = ((forDays * 5) / 30);
                            long calculatedAmtForRemaining = Convert.ToInt64((remainingAmount * calculatedInterestForRemaining) / 100);

                            long nextPayout = calculatedAmountFor25L + calculatedAmtForRemaining;
                            payoutCalculationsDTO.Amount_Intermediate = nextPayout;
                        }
                    }else if(totalAmount > 2500000)
                    {
                        interestRate = 4;
                        double calculatedInterestForDays = ((forDays * interestRate) / 30);
                        long nextPayout = Convert.ToInt64((investorPayoutMainDTO.Amount_Main * calculatedInterestForDays) / 100);

                        payoutCalculationsDTO.Amount_Intermediate = nextPayout;

                    }
                    else
                    {
                        double calculatedInterestForDays = ((forDays * interestRate) / 30);
                        long nextPayout = Convert.ToInt64((investorPayoutMainDTO.Amount_Main * calculatedInterestForDays) / 100);

                        payoutCalculationsDTO.Amount_Intermediate = nextPayout;
                    }

                    InvestorPayoutIntermediateDTO investorPayoutIntermediateDTO = _mapper.Map<PayoutCalculationsDTO, InvestorPayoutIntermediateDTO>(payoutCalculationsDTO);
                    //await _dBContext.Investor_Payout_Intermediate.Insert(investorPayoutIntermediateDTO);

                    break;
            }
           
            return true;

        }

        
        
    }
}
