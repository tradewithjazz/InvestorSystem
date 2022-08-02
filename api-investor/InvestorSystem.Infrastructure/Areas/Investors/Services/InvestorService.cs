using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using InvestorSystem.Core.Areas.Common.DTOs;
using InvestorSystem.Core.Areas.Investors.Model;
using InvestorSystem.Core.Areas.Investors.Services;
using InvestorSystem.DataModel.Table;
using InvestorSystem.DataModel.Table.MetaData;
using InvestorSystem.Infrastructure.DB;
using Microsoft.EntityFrameworkCore;

namespace InvestorSystem.Infrastructure.Areas.Investors.Services
{
    public class InvestorService : IInvestorService
    {

        private readonly AppDBContext _dBContext;
        IMapper _mapper;

        #region Constructor
        public InvestorService(AppDBContext dBContext, IMapper mapper)
        {
            this._dBContext = dBContext;
            _mapper = mapper;
        }

        #endregion

        #region IInvestors

        /******************************Insert API ********************************/

        public async Task<InvestorDTO> AddInvestorBasicDetails(InvestorDTO investorDTO)
        {
            //Insert basic details in Person table
            Investor investor =  _mapper.Map<InvestorDTO,Investor>(investorDTO);

            Person person = investor.Person;

            investor.Person = person;

            //Insert PersonID in Investor table
            await _dBContext.Investor.AddAsync(investor);
            await _dBContext.SaveChangesAsync();

            return investorDTO;
        }

        public async Task<BankDetailsDTO> AddInvestorBankDetails(BankDetailsDTO bankDetailsDTO)
        {
            Investor investor = new Investor();
            BankDetails bankDetails = _mapper.Map<BankDetails>(bankDetailsDTO);  
          
            await _dBContext.BankDetails.AddAsync(bankDetails);
            await _dBContext.SaveChangesAsync();

            investor.ID = bankDetailsDTO.InvestorID;
            investor.BankDetailsID = bankDetails.ID;
            _dBContext.Investor.Attach(investor);
            _dBContext.Entry(investor).Property(x => x.BankDetailsID).IsModified = true;
            _dBContext.SaveChangesAsync();

            return bankDetailsDTO;
        }

        public async Task<NomineeDTO> AddInvestorNomineeDetails(NomineeDTO nomineeDTO)
        {
            Investor investor = new Investor();
            Nominee nominee = _mapper.Map<Nominee>(nomineeDTO);
           
            await _dBContext.Nominee.AddAsync(nominee);
            await _dBContext.SaveChangesAsync();

            investor.ID = nomineeDTO.InvestorID;
            investor.NomineeID = nominee.ID;
           
            _dBContext.Investor.Attach(investor);
            _dBContext.Entry(investor).Property(x => x.NomineeID).IsModified = true;
            _dBContext.SaveChangesAsync();

            return nomineeDTO;
        }

        /******************************Update API ********************************/

        public async Task<InvestorDTO> UpdateInvestorBasicDetails(InvestorDTO investorDTO)
        {
            Investor investor = _mapper.Map<InvestorDTO, Investor>(investorDTO);
          
            investor.Person.ID = investorDTO.PersonID;

            _dBContext.Update(investor);
            _dBContext.SaveChanges();
            return investorDTO;
        }

        public async Task<BankDetailsDTO> UpdateInvestorBankDetails(BankDetailsDTO bankDetailsDTO)
        {
            BankDetails bankDetails = _mapper.Map<BankDetails>(bankDetailsDTO);
         
            bankDetails.ID = bankDetailsDTO.ID;
            _dBContext.Update(bankDetails);
            _dBContext.SaveChanges();
            return bankDetailsDTO;
        }

        public async Task<NomineeDTO> UpdateInvestorNomineeDetails(NomineeDTO nomineeDTO)
        {
            Nominee nominee = _mapper.Map<Nominee>(nomineeDTO);
          
            nominee.ID = nomineeDTO.ID;

            _dBContext.Update(nominee);
            _dBContext.SaveChanges();
            return nomineeDTO;
        }


        /******************************Dashboard API ********************************/

        public InvestorDashboardDTO DisplayInvestments(long investorID)
        {
            InvestorDashboardDTO investorDashboardDTO = new InvestorDashboardDTO();

            try
            {
                var investorDetails = from I in _dBContext.Investor
                                      join IPI in _dBContext.Investor_Payout_Investment
                                        on I.ID equals IPI.InvestorID into IPIGroup
                                      from m in IPIGroup.DefaultIfEmpty()

                                      join ICI in _dBContext.Investor_Comp_Investment
                                        on I.ID equals ICI.InvestorID into ICIGroup
                                      from n in ICIGroup.DefaultIfEmpty()

                                      join IPIn in _dBContext.Investor_Payout_Intermediate
                                        on I.ID equals IPIn.InvestorID into IPInGroup
                                      from o in IPInGroup.DefaultIfEmpty()

                                      join ICIn in _dBContext.Investor_Comp_Intermediate
                                        on I.ID equals ICIn.InvestorID into ICInGroup
                                      from p in ICInGroup.DefaultIfEmpty()
                                      where I.ID == investorID

                                      select new InvestorDashboardDTO()
                                      {
                                          InvestorID = I.ID,
                                          PayoutAmount = m.Amount == null ? 0 : m.Amount,
                                          CompoundingAmount = n.Amount == null ? 0 : n.Amount,
                                          NextPayoutAmount = o.Amount == null ? 0 : o.Amount,
                                          NextCompoundingAmount = p.Amount == null ? 0 : p.Amount,
                                          Total = (m.Amount == null ? 0 : m.Amount) + (n.Amount == null ? 0 : n.Amount)
                                      };

                 if (investorDetails == null) return null;

                 return investorDetails.AsEnumerable().Select(item =>
                 new InvestorDashboardDTO
                 {
                     InvestorID = item.InvestorID,
                     PayoutAmount = item.PayoutAmount,
                     CompoundingAmount = item.CompoundingAmount,
                     NextPayoutAmount = item.NextPayoutAmount,
                     NextCompoundingAmount = item.NextCompoundingAmount,
                     Total = item.Total
                 }).FirstOrDefault();
            }
            catch (Exception ex)
            {

            }
            return investorDashboardDTO;
        }

        public List<UserDisplayList> GetInvestorList(long investorID)//branchID
        {
             
            var investorList = (from I in _dBContext.Investor
                                join P in _dBContext.Person on I.PersonID equals P.ID
                                
                                join IP in _dBContext.Investor_Payout_Investment on I.ID equals IP.InvestorID into IPGroup
                                from xIP in IPGroup.DefaultIfEmpty()

                                join ICI in _dBContext.Investor_Comp_Intermediate on I.ID equals ICI.InvestorID into ICIGroup
                                from xICI in ICIGroup.DefaultIfEmpty()

                                where I.ID == investorID

                                select new UserDisplayList
                                {
                                    ID = investorID,
                                    FirstName = P.FirstName,
                                    LastName = P.LastName,
                                    Email = P.Email,
                                    InvestedPayoutAmount = xIP.Amount == null? 0: xIP.Amount,
                                    CalculatedCompoudingAmount = xICI.Amount == null ?0 : xICI.Amount
                                    
                                }).ToList();
            return investorList;
        }


        #endregion

    }
}
