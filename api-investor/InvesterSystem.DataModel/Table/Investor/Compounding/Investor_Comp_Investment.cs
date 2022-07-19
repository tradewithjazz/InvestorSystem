using System;
namespace InvestorSystem.DataModel.Table.Investor
{
    public class Employee_Payout_Investment
    {
        public int ID { get; set; }
        public int investorID { get; set; }
        public int amount { get; set; }
        public DateTime lastModified { get; set; }
    }
}

