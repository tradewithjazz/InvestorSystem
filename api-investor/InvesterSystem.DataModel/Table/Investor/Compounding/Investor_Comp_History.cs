using System;
namespace InvestorSystem.DataModel.Table.Investor.Compounding
{
    public class Investor_Comp_History
    {
        public int ID { get; set; }
        public int amount { get; set; }
        public int investorID { get; set; }
        public int credOrDebID { get; set; }
    }
}

