﻿using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace InvestorSystem.DataModel.Table
{
    public class Investor_Comp_Intermediate
    {
        public long ID { get; set; }

        [ForeignKey("InvestorID")]
        public long InvestorID { get; set; }
        public Investor Investor { get; set; }

        public long Amount { get; set; }
        public DateTime AsOfDate { get; set; }
    }
}

