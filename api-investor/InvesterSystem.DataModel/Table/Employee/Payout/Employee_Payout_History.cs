using System;
namespace InvestorSystem.DataModel.Table.Investor
{
    public class Employee_Payout_History
    {
        public int ID { get; set; }
        public int amount { get; set; }
        public int employeeID { get; set; }
        public int credOrDebID { get; set; }
    }
}

