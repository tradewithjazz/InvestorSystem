using System;
namespace InvestorSystem.DataModel.Table.Investor.Compounding
{
    public class Employee_Comp_Intermediate
    {
        public int ID { get; set; }
        public int employeeID { get; set; }
        public int amount { get; set; }
        public DateTime asOfDate { get; set; }
    }
}

