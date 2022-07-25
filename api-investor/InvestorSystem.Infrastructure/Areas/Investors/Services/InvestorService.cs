using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InvestorSystem.Core.Areas.Common.DTOs;
using InvestorSystem.Core.Areas.Investors.Model;
using InvestorSystem.Core.Areas.Investors.Services;
using InvestorSystem.Infrastructure.DB;

namespace InvestorSystem.Infrastructure.Areas.Investors.Services
{
    public class InvestorService : IInvestorService
    {

        private readonly AppDBContext _dBContext;
        
        #region Constructor
        public InvestorService(AppDBContext dBContext) 
        {
            this._dBContext = dBContext;
        }

        #endregion

        #region IInvestors

        public Task<InvestorDTO> DisplayInvestments()
        {
            throw new NotImplementedException();
        }

        //public async Task<InvestorDTO> AddInvestor(InvestorDTO investorDTO)
        //{
        //   return await _dBContext.Investor.Insert(investorDTO);
        //}

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
