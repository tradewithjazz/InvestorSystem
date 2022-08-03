using System;
namespace InvestorSystem.Core.Areas.Common.DTOs
{
    public class BankDetailsDTO
    {
        public long ID { get; set; }
        public long InvestorID { get; set; }
        public string BankName { get; set; }
        public string AccountNumber { get; set; }
        public string AccountName { get; set; }
        public string IFSC { get; set; }
        public short AccountTypeID { get; set; }
    }
}

