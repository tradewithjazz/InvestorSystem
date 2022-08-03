using InvestorSystem.Core.Areas.Common.DTOs;
using InvestorSystem.DataModel.Table;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvestorSystem.Core.Areas.Investors.Model
{
    public class InvestorDTO
    {
        //Person Properties
        public long ID { get; set; }
       
        //Investor properties
        public PersonDTO Person { get; set; }
        public long PersonID { get; set; }
        public long? BankDetailsID { get; set; }
        public long? NomineeID { get; set; } 
    }

    public class BankDetailsDTO
    {
        public long ID { get; set; }
        public long InvestorID { get; set; }
        public string BankName { get; set; } 
        public string AccountNumber { get; set; } 
        public string AccountName { get; set; }
        public string IFSC { get; set; } 
        public short AccountTypeID { get; set; }
    }
    public class NomineeDTO
    {
        public long ID { get; set; }
        public long InvestorID { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; } 
        public int Age { get; set; }
        public short RelationshipID { get; set; }
    }
}
