using System;
using System.ComponentModel.DataAnnotations;

namespace InvestorSystem.DataModel.Table
{
    public class MaritalStatus
    {
        [Key]
        public short ID { get; set; }
        public string Name { get; set; } = String.Empty;
    }
}

