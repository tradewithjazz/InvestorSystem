using System;
using System.ComponentModel.DataAnnotations;

namespace InvestorSystem.DataModel.Table
{
    public class Branch
    {
        [Key]
        public int ID { get; set; }
        public string name { get; set; }
        public int bmID { get; set; }
        public string address { get; set; }
    }
}

