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

    public class PersonDTO
    {
        public long ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public DateTime DOB { get; set; }
        public string Email { get; set; }
        //public string District { get; set; }
        public string MobileNo { get; set; }
        public string AlternateMobile { get; set; }
        public short MaritalStatusID { get; set; }
        public short GenderID { get; set; }
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
