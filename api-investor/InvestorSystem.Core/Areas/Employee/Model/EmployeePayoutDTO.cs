using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvestorSystem.Core.Areas.Employee.Model
{
    public class EmployeePayoutDTO
    {
        public int EmployeeID { get; set; }// Remove this
        public long? Total { get; set; }
        public long? PayoutAmount { get; set; }
        public long? CompoundingAmount { get; set; }
        public long? NextPayoutAmount { get; set; }//Inter
        public long? NextCompoundingAmount { get; set; }//Inter

    }
}
