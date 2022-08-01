using System;
using System.ComponentModel.DataAnnotations.Schema;
using InvestorSystem.DataModel.Table.MetaData;

namespace InvestorSystem.DataModel.Table
{
    public class Investor_Comp_History
    {
        public long ID { get; set; }
        public long Amount { get; set; }

        [ForeignKey("InvestorID")]
        public long? InvestorID { get; set; }
        public Investor Investor { get; set; }

        [ForeignKey("CredOrDebID")]
        public short? CredOrDebID { get; set; }
        public CredOrDeb? CredOrDeb { get; set; }
        
    }
}

