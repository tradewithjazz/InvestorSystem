using System;
using System.ComponentModel.DataAnnotations;

namespace InvestorSystem.DataModel.Table
{
    public class Relationship
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
    }
}

