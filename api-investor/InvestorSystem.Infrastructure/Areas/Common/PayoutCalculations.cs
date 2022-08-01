using AutoMapper;
using InvestorSystem.Core.Areas.Common;
using InvestorSystem.Core.Areas.Common.DTOs;
using InvestorSystem.Core.Areas.Investors.Model;
using InvestorSystem.DataModel.Table;
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
        private const double DAY = 30.0;
        private int interestRate = -1;

        ICommon _common;
        IMapper _mapper;
        AppDBContext _dBContext;

        public PayoutCalculations(ICommon common,
                                  IMapper mapper,
                                  AppDBContext appDBContext)
        {
            _common = common;
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
        public async Task<bool> CalculateNextPayoutNew(PayoutCalculationsDTO payoutCalculationsDTO, int role)
        {

            switch (role)
            {
                case 2:                  
                    return CalculateInvestorAmount(payoutCalculationsDTO,role);
                //break;
                default:
                    break;
            }
            return true;
        }
        private bool CalculateInvestorAmount(PayoutCalculationsDTO payoutCalculationsDTO,int role)
        {
            try
            {
                //Insert payout amount
                InvestorPayoutMainDTO investorPayoutMainDTO = new InvestorPayoutMainDTO();
                investorPayoutMainDTO.InvestorID = payoutCalculationsDTO.ID;
                investorPayoutMainDTO.Amount = payoutCalculationsDTO.PayoutAmount;
                investorPayoutMainDTO.LastModified = payoutCalculationsDTO.ForDate;

                Investor_Payout_Investment _PayoutInvestment = _mapper.Map<InvestorPayoutMainDTO, Investor_Payout_Investment>(investorPayoutMainDTO);
                _dBContext.Investor_Payout_Investment.AddAsync(_PayoutInvestment);
                _dBContext.SaveChangesAsync();

                InvestorPayoutIntermediateDTO investorPayoutIntermediateDTO = new InvestorPayoutIntermediateDTO();
                investorPayoutIntermediateDTO.InvestorID = payoutCalculationsDTO.ID;
                investorPayoutIntermediateDTO.ForDate = payoutCalculationsDTO.ForDate;

                //Insert compouding amount
                InvestorCompoundingDTO investorCompoundingDTO = new InvestorCompoundingDTO();
                investorCompoundingDTO.InvestorID = payoutCalculationsDTO.ID;
                investorCompoundingDTO.Amount = payoutCalculationsDTO.CompoundingAmount;
                investorCompoundingDTO.LastModified = payoutCalculationsDTO.ForDate;

                Investor_Comp_Investment _CompoundingInvestment = _mapper.Map<InvestorCompoundingDTO, Investor_Comp_Investment>(investorCompoundingDTO);
                _dBContext.Investor_Comp_Investment.AddAsync(_CompoundingInvestment);
                _dBContext.SaveChangesAsync();

                InvestorCompoundingIntermediateDTO compoundingIntermediateDTO = new InvestorCompoundingIntermediateDTO();
                compoundingIntermediateDTO.InvestorID = payoutCalculationsDTO.ID;
                compoundingIntermediateDTO.AsOfDate = payoutCalculationsDTO.ForDate;
                compoundingIntermediateDTO.Amount = payoutCalculationsDTO.CompoundingAmount;

                long totalAmount = (payoutCalculationsDTO.PayoutAmount + payoutCalculationsDTO.CompoundingAmount);

                interestRate = _common.GetInterestRateAsPerAmount(investorPayoutMainDTO.Amount, role);

                int investmentAddedDay = investorPayoutMainDTO.LastModified.Day;
                int forDays = Convert.ToInt32(DAY) - investmentAddedDay;
                if (payoutCalculationsDTO.PayoutAmount > 2500000)
                {
                    if (interestRate == 0)  //special case
                    {
                        long amount = 2500000;
                        long remainingAmount = (investorPayoutMainDTO.Amount - amount);
                        double calculatedInterestFor25L = ((forDays * 4) / DAY);
                        long calculatedAmountFor25L = Convert.ToInt64((amount * calculatedInterestFor25L) / 100);

                        double calculatedInterestForRemaining = ((forDays * 5) / DAY);
                        long calculatedAmtForRemaining = Convert.ToInt64((remainingAmount * calculatedInterestForRemaining) / 100);

                        long nextPayout = calculatedAmountFor25L + calculatedAmtForRemaining;
                        investorPayoutIntermediateDTO.Amount = nextPayout;
                    }
                }
                else if (totalAmount > 2500000)
                {
                    interestRate = 4;
                    double calculatedInterestForDays = ((forDays * interestRate) / DAY);
                    long nextPayout = Convert.ToInt64((investorPayoutMainDTO.Amount * calculatedInterestForDays) / 100);
                    investorPayoutIntermediateDTO.Amount = nextPayout;
                }
                else
                {
                    double calculatedInterestForDays = ((forDays * interestRate) / DAY);
                    long nextPayout = Convert.ToInt64((investorPayoutMainDTO.Amount * calculatedInterestForDays) / 100);
                    investorPayoutIntermediateDTO.Amount = nextPayout;
                }

                //Insert next payout in intermediate table
                Investor_Payout_Intermediate payout_Intermediate = _mapper.Map<InvestorPayoutIntermediateDTO, Investor_Payout_Intermediate>(investorPayoutIntermediateDTO);
                _dBContext.Investor_Payout_Intermediate.AddAsync(payout_Intermediate);
                _dBContext.SaveChangesAsync();

                //Insert next compounding in intermediate table- In this case original amount
                Investor_Comp_Intermediate compounding_Intermediate = _mapper.Map<InvestorCompoundingIntermediateDTO, Investor_Comp_Intermediate>(compoundingIntermediateDTO);
                _dBContext.Investor_Comp_Intermediate.AddAsync(compounding_Intermediate);
                _dBContext.SaveChangesAsync();
                return true;

            }
            catch (Exception)
            {
                return false;
            }

        }

    }
}
