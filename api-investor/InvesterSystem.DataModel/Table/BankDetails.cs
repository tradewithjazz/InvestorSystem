using System;
using System.ComponentModel.DataAnnotations.Schema;
using InvestorSystem.DataModel.Table.MetaData;

namespace InvestorSystem.DataModel.Table
{
    public class BankDetails
    {
        public long ID { get; set; }
        public string BankName { get; set; } = String.Empty;
        public string AccountNumber { get; set; } = String.Empty;
        public string AccountName { get; set; } = String.Empty;
        public string IFSC { get; set; } = String.Empty;

        [ForeignKey("AccountTypeID")]
        public short? AccountTypeID { get; set; }
        public virtual AccountType Accounttype { get; set; }
    }
}

