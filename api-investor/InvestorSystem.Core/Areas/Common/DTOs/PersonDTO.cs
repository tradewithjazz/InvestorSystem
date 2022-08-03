using System;
namespace InvestorSystem.Core.Areas.Common.DTOs
{
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
}

