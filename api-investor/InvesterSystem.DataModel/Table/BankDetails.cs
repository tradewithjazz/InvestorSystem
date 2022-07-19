using System;
namespace InvestorSystem.DataModel.Table
{
    public class BankDetails
    {
        public int ID { get; set; }
        public string bankName { get; set; }
        public string accountNumber { get; set; }
        public string accountName { get; set; }
        public string IFSC { get; set; }
        public int accountTypeID { get; set; }
    }
}

