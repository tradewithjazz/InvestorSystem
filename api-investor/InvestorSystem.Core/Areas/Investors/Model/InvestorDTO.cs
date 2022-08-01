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
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public DateTime DOB { get; set; }
        public string Email { get; set; }
        //public string District { get; set; }
        public string MobileNo { get; set; }
        public string AlternateMobile { get; set; }
        public MaritalStatusDTO MaritalStatus{ get; set; }
        public GenderDTO Gender { get; set; }
        public short MaritalStatusID { get; set; }
        public short GenderID { get; set; }

        //Investor properties
        public long PersonID { get; set; }
        public long BankDetailsID { get; set; }
        public long NomineeID { get; set; } 
        public BankDetailsDTO BankDetails { get; set; }
        public NomineeDTO Nominee { get; set; }
    }
    public class MaritalStatusDTO
    {
        public short ID { get; set; }
        public string Name { get; set; } 
    }

    public class GenderDTO
    {
        public short ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }

    public class BankDetailsDTO
    {
        public long ID { get; set; }
        public string BankName { get; set; } 
        public string AccountNumber { get; set; } 
        public string AccountName { get; set; }
        public string IFSC { get; set; } 
        public short AccountTypeID { get; set; }
        public virtual AccountTypeDTO? Accounttype { get; set; }
    }

    public class AccountTypeDTO
    {
        public short ID { get; set; }
        public string Name { get; set; }
    }
    public class NomineeDTO
    {
        public long ID { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; } 
        public int Age { get; set; }
        public short RelationshipID { get; set; }
        public RelationshipDTO? Relationship { get; set; }
    }
    public class RelationshipDTO
    {
        public short ID { get; set; }
        public string Name { get; set; }
    }
}
