using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvestorSystem.Core.Areas.Common.DTOs
{
    public class AddUpdateInvestmentDTO
    {
        public long ID { get; set; }

        public string Name { get; set; }

        public long Amount { get; set; }

        public DateTime LastModified { get; set; }

    }
}
