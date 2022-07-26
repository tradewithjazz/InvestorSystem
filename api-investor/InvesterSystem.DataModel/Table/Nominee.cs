using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InvestorSystem.DataModel.Table.MetaData
{
    public class Nominee
    {
        [Key]
        public long ID { get; set; }
        public string Firstname { get; set; } = String.Empty;
        public string Lastname { get; set; } = String.Empty;
        public int Age { get; set; }

        [ForeignKey("RelationshipID")]
        public short RelationshipID { get; set; }
        public Relationship? Relationship { get; set; }
    }
}