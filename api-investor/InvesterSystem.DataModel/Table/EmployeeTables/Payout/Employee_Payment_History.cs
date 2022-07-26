using System;
namespace InvestorSystem.DataModel.Table
{
    public class Employee_Payment_History
    {
        public int ID { get; set; }
        public int employeeID { get; set; }
        public int amount { get; set; }
        public DateOnly paidOn { get; set; }
    }
}

