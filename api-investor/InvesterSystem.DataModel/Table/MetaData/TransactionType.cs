using System;
using System.ComponentModel.DataAnnotations;

namespace InvestorSystem.DataModel.Table
{
    public class TransactionType
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
    }
}

