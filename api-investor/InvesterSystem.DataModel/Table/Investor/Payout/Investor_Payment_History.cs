using System;
namespace InvestorSystem.DataModel.Table.Investor
{
    public class Investor_Payment_History
    {
        public int ID { get; set; }
        public int investorID { get; set; }
        public int amount { get; set; }
        public DateOnly paidOn { get; set; }
    }
}

