﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InvestorSystem.DataModel.Table
{
    public class Person
    {
        [Key]
        public long ID { get; set; }
        public string FirstName { get; set; } = String.Empty;
        public string LastName { get; set; } = String.Empty;
        public string AddressLine1 { get; set; } = String.Empty;
        public string AddressLine2 { get; set; } = String.Empty;
        public DateTime DOB { get; set; }
        public string Email { get; set; } = String.Empty;

        public string MobileNo { get; set; } = String.Empty;
        public string AlternateMobileNo { get; set; } = String.Empty;

        public MaritalStatus? MaritalStatus { get; set; }
        public Gender? Gender { get; set; }

        [ForeignKey("MaritalStatusID")]
        public short? MaritalStatusID { get; set; }

        [ForeignKey("GenderID")]
        public short? GenderID { get; set; }

    }
}

