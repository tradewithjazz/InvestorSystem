using System;
using System.ComponentModel.DataAnnotations;
using InvestorSystem.DataModel.Table.MetaData;
using System.ComponentModel.DataAnnotations.Schema;

namespace InvestorSystem.DataModel.Table
{
    public class Employee
    {
        [Key]
        public long ID { get; set; }

        public long PersonID { get; set; }
        [ForeignKey("PersonID")]
        public virtual Person? Person { get; set; }

        [ForeignKey("BankDetailsID")]
        public long BankDetailsID { get; set; }
        public BankDetails? BankDetails { get; set; }

        [ForeignKey("NomineeID")]
        public long NomineeID { get; set; }
        public Nominee? Nominee { get; set; }

        // Compounding Tables
        public ICollection<Employee_Comp_History>? Employee_Comp_History { get; set; }
        public Employee_Comp_Intermediate? Employee_Comp_Intermediate { get; set; }
        public Employee_Comp_Investment? Employee_Comp_Investment { get; set; }

        //Payout Tables
        public Employee_Payment_History? Employee_Payment_History { get; set; }
        public Employee_Payout_History? Employee_Payout_History { get; set; }
        public Employee_Payout_Intermediate? Employee_Payout_Intermediate { get; set; }
        public Employee_Payout_Investment? Employee_Payout_Investment { get; set; }
    }
}

