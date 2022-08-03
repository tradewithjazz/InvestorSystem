using System;
namespace InvestorSystem.Core.Areas.Common.DTOs
{
    public class NomineeDTO
    {
        public long ID { get; set; }
        public long InvestorID { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public int Age { get; set; }
        public short RelationshipID { get; set; }
    }
}

