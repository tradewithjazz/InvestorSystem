using System;
using System.ComponentModel.DataAnnotations;

namespace InvestorSystem.DataModel.Table
{
    public class Investor
    {
        [Key]
        public int ID { get; set; }
        public int personID { get; set; }
        public int bankDetailsID { get; set; }
        public int nomineeID { get; set; }

    }
}

