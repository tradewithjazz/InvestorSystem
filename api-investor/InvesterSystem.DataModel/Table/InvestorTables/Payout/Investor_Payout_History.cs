using System;
using System.ComponentModel.DataAnnotations.Schema;
using InvestorSystem.DataModel.Table.MetaData;

namespace InvestorSystem.DataModel.Table
{
    public class Investor_Payout_History
    {
        public long ID { get; set; }
        public long Amount { get; set; }

        [ForeignKey("InvestorID")]
        public long? InvestorID { get; set; }
        public Investor Investor { get; set; }

        public DateTime PaidOn { get; set; }
    }
}

