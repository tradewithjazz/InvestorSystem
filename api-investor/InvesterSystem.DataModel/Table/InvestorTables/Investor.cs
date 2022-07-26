using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using InvestorSystem.DataModel.Table.MetaData;

namespace InvestorSystem.DataModel.Table
{
    public class Investor
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
        public ICollection<Investor_Comp_History>? Investor_Comp_History { get; set; }
        public Investor_Comp_Intermediate? Investor_Comp_Intermediate { get; set; }
        public Investor_Comp_Investment? Investor_Comp_Investment { get; set; }

        //Payout Tables
        public Investor_Payment_History? Investor_Payment_History { get; set; }
        public Investor_Payout_History? Investor_Payout_History { get; set; }
        public Investor_Payout_Intermediate? Investor_Payout_Intermediate { get; set; }
        public Investor_Payout_Investment? Investor_Payout_Investment { get; set; }

    }
}

