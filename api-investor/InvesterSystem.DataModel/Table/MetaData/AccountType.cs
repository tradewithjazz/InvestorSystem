using System;
using System.ComponentModel.DataAnnotations;

namespace InvestorSystem.DataModel.Table.MetaData
{
    public class AccountType
    {
        [Key]
        public short ID { get; set; }
        public string Name { get; set; }

    }
}

