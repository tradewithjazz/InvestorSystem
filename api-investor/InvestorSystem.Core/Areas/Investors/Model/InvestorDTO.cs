using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvestorSystem.Core.Areas.Investors.Model
{
    public class InvestorDTO
    {
        public int? ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public DateTime DOB { get; set; }
        public string Email { get; set; }
        public string District { get; set; }
        public string MobileNo { get; set; }
        public string AlternateMobile { get; set; }
        public int MartialStatusID { get; set; }
        public int GenderID { get; set; }
        public int BankDetailsID { get; set; }
    }
}
