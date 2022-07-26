using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace InvestorSystem.DataModel.Table
{
    public class Employee_Payout_Investment
    {
        public long ID { get; set; }

        [ForeignKey("EmployeeID")]
        public long EmployeeID { get; set; }
        public Employee Employee { get; set; }

        public long Amount { get; set; }
        public DateTime LastModified { get; set; }
    }
}

