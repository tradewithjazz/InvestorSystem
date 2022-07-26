using System;
namespace InvestorSystem.DataModel.Table
{
    public class Employee_Payout_Intermediate
    {
        public int ID { get; set; }
        public int employeeID { get; set; }
        public int amount { get; set; }
        public DateOnly forDate { get; set; }
    }
}

