using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InvestorSystem.DataModel.Table
{
    public class Branch
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; } = string.Empty;
        public string AddressLine1 { get; set; } = string.Empty;
        public string AddressLine2 { get; set; } = string.Empty;
        public long BranchManagerID { get; set; }
        [ForeignKey("BranchManagerID")]
        public virtual Employee? Employee { get; set; }
    }
}

