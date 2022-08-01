using InvestorSystem.Core.Areas.Common.DTOs;
using InvestorSystem.Core.Areas.Employee.Model;
using InvestorSystem.Core.Areas.Employee.Services;
using InvestorSystem.DataModel.Table;
using InvestorSystem.Infrastructure.DB;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InvestorSystem.Infrastructure.Areas.Common;
using System.Xml.Linq;

namespace InvestorSystem.Infrastructure.Areas.Employee.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly AppDBContext dbContext;


        public EmployeeService(AppDBContext dBContext)
        {
            this.dbContext = dBContext;
        }

        public async Task<AddUpdateInvestmentDTO> AddEmployeeCompoundInvestment(long EmployeeID, long Amount)
        {
            AddUpdateInvestmentDTO addUpdateInvestmentDTO = new AddUpdateInvestmentDTO();
            Employee_Comp_Investment table = new Employee_Comp_Investment();
            table.EmployeeID = EmployeeID;
            table.Amount = Amount;
            table.LastModified = DateTime.Now.ToUniversalTime();

            dbContext.Add(table);
            dbContext.SaveChanges();

            var returnVal = from E in dbContext.Employee
                            join ECI in dbContext.Employee_Comp_Investment
                            on E.ID equals ECI.EmployeeID
                            join P in dbContext.Person
                            on E.PersonID equals P.ID
                            where E.ID == EmployeeID
                            select new
                            {
                                EmployeeID = E.ID,
                                Amount = ECI.Amount,
                                LastModified = ECI.LastModified,
                                Name = P.FirstName + " " + P.LastName
                            };
            
            return (AddUpdateInvestmentDTO)returnVal;
        }

        public async Task<AddUpdateInvestmentDTO> AddEmployeePayoutInvestment(long EmployeeID, long Amount)
        {
            AddUpdateInvestmentDTO addUpdateInvestmentDTO = new AddUpdateInvestmentDTO();
            Employee_Payout_Investment table = new Employee_Payout_Investment();
            table.EmployeeID = EmployeeID;
            table.Amount = Amount;
            table.LastModified = DateTime.Now.ToUniversalTime();

            dbContext.Add(table);
            dbContext.SaveChanges();

            var returnVal = from E in dbContext.Employee
                            join ECI in dbContext.Employee_Payout_Investment
                            on E.ID equals ECI.EmployeeID
                            join P in dbContext.Person
                            on E.PersonID equals P.ID
                            where E.ID == EmployeeID
                            select new
                            {
                                EmployeeID = E.ID,
                                Amount = ECI.Amount,
                                LastModified = ECI.LastModified,
                                Name = P.FirstName + " " + P.LastName
                            };

            return (AddUpdateInvestmentDTO)returnVal;
        }

        public async Task<EmployeePayoutDTO> DisplayInvestments(long id)
        {
            EmployeePayoutDTO employeePayoutDTO = new EmployeePayoutDTO();
            
            try
            {
                var employeeDetails = from E in dbContext.Employee
                                      join EPI in dbContext.Employee_Payout_Investment
                                        on E.ID equals EPI.EmployeeID into EPIGroup
                                      from m in EPIGroup.DefaultIfEmpty()
                                      
                                      join ECI in dbContext.Employee_Comp_Investment
                                        on E.ID equals ECI.EmployeeID into ECIGroup
                                      from n in ECIGroup.DefaultIfEmpty()

                                      join EPIn in dbContext.Employee_Payout_Intermediate
                                        on E.ID equals EPIn.EmployeeID into EPInGroup
                                      from o in EPInGroup.DefaultIfEmpty()

                                      join ECIn in dbContext.Employee_Comp_Intermediate
                                        on E.ID equals ECIn.EmployeeID into ECInGroup
                                      from p in ECInGroup.DefaultIfEmpty()
                                      where E.ID == id

                                      select new
                                      {
                                          EmployeeID = E.ID,
                                          PayoutAmount = m.Amount==null?0:m.Amount,
                                          CompoundingAmount = n.Amount == null ? 0 : n.Amount,
                                          NextPayoutAmount = o.Amount == null ? 0 : o.Amount,
                                          NextCompoundingAmount = p.Amount==null? 0: p.Amount,
                                          Total = (m.Amount == null ? 0 : m.Amount) + (n.Amount == null ? 0 : n.Amount)
                                      };


                employeePayoutDTO = (EmployeePayoutDTO)employeeDetails;
            }
            catch (Exception ex)
            {

            }
            return employeePayoutDTO;
        }

        public async Task<AddUpdateInvestmentDTO> UpdateEmployeeCompoundInvestment(long EmployeeID, long Amount)
        {
            Employee_Comp_Investment table = new Employee_Comp_Investment();
            table = (from ECI in dbContext.Employee_Comp_Investment where ECI.EmployeeID == EmployeeID select ECI).FirstOrDefault();
            if (table == null)
                return null;

            table.Amount = Amount;
            table.LastModified = DateTime.Now.ToUniversalTime();
            dbContext.SaveChanges();

            var returnVal = from E in dbContext.Employee
                            join ECI in dbContext.Employee_Comp_Investment
                            on E.ID equals ECI.EmployeeID
                            join P in dbContext.Person
                            on E.PersonID equals P.ID
                            where E.ID == EmployeeID
                            select new
                            {
                                EmployeeID = E.ID,
                                Amount = ECI.Amount,
                                LastModified = ECI.LastModified,
                                Name = P.FirstName + " " + P.LastName
                            };

            return (AddUpdateInvestmentDTO)returnVal;
        }

        public async Task<AddUpdateInvestmentDTO> UpdateEmployeePayoutInvestment(long EmployeeID, long Amount)
        {
            Employee_Payout_Investment table = new Employee_Payout_Investment();
            table = (from ECI in dbContext.Employee_Payout_Investment where ECI.EmployeeID == EmployeeID select ECI).FirstOrDefault();
            if (table == null)
                return null;

            table.Amount = Amount;
            table.LastModified = DateTime.Now.ToUniversalTime();
            dbContext.SaveChanges();

            var returnVal = from E in dbContext.Employee
                            join ECI in dbContext.Employee_Payout_Investment
                            on E.ID equals ECI.EmployeeID
                            join P in dbContext.Person
                            on E.PersonID equals P.ID
                            where E.ID == EmployeeID
                            select new
                            {
                                EmployeeID = E.ID,
                                Amount = ECI.Amount,
                                LastModified = ECI.LastModified,
                                Name = P.FirstName + " " + P.LastName
                            }; 
            

            return (AddUpdateInvestmentDTO)returnVal;
        }

        public async Task<List<AddUpdateInvestmentDTO>> DisplayCompoundingHistory(long EmployeeID)
        {
            throw new NotImplementedException();
        }

        public async Task<List<AddUpdateInvestmentDTO>> DisplayPayoutHistory(long EmployeeID)
        {
            List<AddUpdateInvestmentDTO> result = new List<AddUpdateInvestmentDTO>();
            var list = (from E in dbContext.Employee
                        join ECI in dbContext.Employee_Payout_History
                        on E.ID equals ECI.EmployeeID
                        join P in dbContext.Person
                        on E.PersonID equals P.ID
                        where E.ID == EmployeeID
                        orderby ECI.PaidOn
                        select new
                        {
                            EmployeeID = E.ID,
                            Amount = ECI.Amount,
                            LastModified = ECI.PaidOn,
                            Name = P.FirstName + " " + P.LastName
                        });

            return (List<AddUpdateInvestmentDTO>)list;
        }
    }
}