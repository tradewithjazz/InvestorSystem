using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvestorSystem.Core.Areas.Common.DTOs
{
    public class UserDisplayList
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public long InvestedAmount { get; set; }
        public long CalculatedCompoudingAmount { get; set; }
}
}
