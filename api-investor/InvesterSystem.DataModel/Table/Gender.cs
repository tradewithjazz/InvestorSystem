using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvestorSystem.DataModel.Table
{
    public class Gender
    {
        [Key]
        [MaxLength(1)]
        public string GenderCD { get; set; }

        public string GenderName { get; set; }

        public string Description { get; set; }
    }
}
