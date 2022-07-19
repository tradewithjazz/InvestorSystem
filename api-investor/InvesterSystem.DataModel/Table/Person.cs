using System;
using System.ComponentModel.DataAnnotations;

namespace InvestorSystem.DataModel.Table
{
    public class Person
    {
        [Key]
        public int ID { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string addressLine1 { get; set; }
        public string addressLine2 { get; set; }
        public DateOnly dob { get; set; }
        public string email { get; set; }
        public int districtID { get; set; }
        public string mobileNo { get; set; }
        public string alternateMobileNo { get; set; }
        public int maritalStatusID { get; set; }
        public int genderID { get; set; }

    }
}

