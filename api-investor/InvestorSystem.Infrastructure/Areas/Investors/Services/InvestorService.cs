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

        public Task<InvestorDTO> DisplayInvestments()
        {
            throw new NotImplementedException();
        }

        public async Task<InvestorDTO> AddInvestorBasicDetails(InvestorDTO investorDTO)
        {
            //Insert basic details in Person table
            Person person =  _mapper.Map<InvestorDTO,Person>(investorDTO);
            MaritalStatus maritalStatus = _dBContext.MaritalStatuse.Find(investorDTO.MaritalStatusID);
            Gender gender = _dBContext.Gender.Find(investorDTO.GenderID);

            person.MaritalStatus = maritalStatus;
            person.Gender = gender;
            //Insert PersonID in Investor table
            Investor investor = new Investor(); 
            investor.Person = person;
            await _dBContext.Investor.AddAsync(investor);
            await _dBContext.SaveChangesAsync();

            return investorDTO;
        }

        public async Task<InvestorDTO> AddInvestorBankDetails(InvestorDTO investorDTO)
        {
            Investor investor = new Investor();
            BankDetails bankDetails = _mapper.Map<BankDetails>(investorDTO.BankDetails);  
            AccountType accountType = _dBContext.AccountType.Find(investorDTO.BankDetails.AccountTypeID);
            bankDetails.Accounttype = accountType;
            await _dBContext.BankDetails.AddAsync(bankDetails);
            await _dBContext.SaveChangesAsync();

            investor.ID = investorDTO.ID;
            investor.BankDetailsID = bankDetails.ID;
            _dBContext.Investor.Attach(investor);
            _dBContext.Entry(investor).Property(x => x.BankDetailsID).IsModified = true;
            _dBContext.SaveChangesAsync();

            return investorDTO;
        }

        public async Task<InvestorDTO> AddInvestorNomineeDetails(InvestorDTO investorDTO)
        {
            Investor investor = new Investor();
            Nominee nominee = _mapper.Map<Nominee>(investorDTO.Nominee);
            Relationship relationship = _dBContext.Relationship.Find(investorDTO.Nominee.RelationshipID);
            nominee.Relationship = relationship;
            await _dBContext.Nominee.AddAsync(nominee);
            await _dBContext.SaveChangesAsync();

            investor.ID = investorDTO.ID;
            investor.NomineeID = nominee.ID;
           
            _dBContext.Investor.Attach(investor);
            _dBContext.Entry(investor).Property(x => x.NomineeID).IsModified = true;
            _dBContext.SaveChangesAsync();

            return investorDTO;
        }


        //public async Task<List<UserDisplayList>> GetInvestorList()
        //{
        //    var investorList = (FROM I in _dBContext.Investor
        //                        JOIN II in _dBContext.Investor_Investment
        //                        ON  I.ID = II.InvestorID
        //                        JOIN IC IN _dBContext.Investor_Payout_Intermediate
        //                        ON I.ID= IC.InvestorID
        //                        select new
        //                        {
        //                        ID = I.ID
        //                        FirstName = I.FirstName
        //                        LastName =I.LastName
        //                        Email = I.Email
        //                        InvestedAmount = II.Amount
        //                        CalculatedCompoudingAmount =  IC.Amount
        //                        }).ToList();
        //    return investorList;
        //}


         #endregion

    }
}
