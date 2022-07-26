using System;
using InvestorSystem.DataModel.Table.MetaData;
using System.ComponentModel.DataAnnotations.Schema;

namespace InvestorSystem.DataModel.Table
{
    public class Employee_Comp_History
    {
            public long ID { get; set; }
            public long Amount { get; set; }

            [ForeignKey("EmployeeID")]
            public long EmployeeID { get; set; }
            public Employee Employee { get; set; }

            [ForeignKey("CredOrDebID")]
            public short CredOrDebID { get; set; }
            public CredOrDeb? CredOrDeb { get; set; }
    }
}

