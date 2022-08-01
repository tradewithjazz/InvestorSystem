using InvestorSystem.DataModel.Table.MetaData;
using InvestorSystem.DataModel.Table;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvestorSystem.Core.Areas.Employee.Model
{
    public class EmployeeDTO
    {
        public long ID { get; set; }
        public Person Person { get; set; }
        // BankDetails? BankDetails { get; set; }
        //public Nominee? Nominee { get; set; }
        //public ICollection<Employee_Comp_History>? Employee_Comp_History { get; set; }
        public Employee_Comp_Intermediate? Employee_Comp_Intermediate { get; set; }
        public Employee_Comp_Investment? Employee_Comp_Investment { get; set; }

        public Employee_Payment_History? Employee_Payment_History { get; set; }
        public Employee_Payout_History? Employee_Payout_History { get; set; }
        public Employee_Payout_Intermediate? Employee_Payout_Intermediate { get; set; }
        public Employee_Payout_Investment? Employee_Payout_Investment { get; set; }
    }
}
