using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace InvestorSystem.DataModel.Table
{
    public class Employee_Payout_History
    {
        public long ID { get; set; }
        public long Amount { get; set; }

        [ForeignKey("EmployeeID")]
        public long EmployeeID { get; set; }
        public Employee Employee { get; set; }

        public DateTime PaidOn { get; set; }
    }
}

