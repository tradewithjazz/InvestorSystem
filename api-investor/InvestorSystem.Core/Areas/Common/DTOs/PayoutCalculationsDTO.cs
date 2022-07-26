using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvestorSystem.Core.Areas.Common.DTOs
{
    public class PayoutCalculationsDTO
    {
        public int ID { get; set; }

        public long Amount_Main { get; set; }

        public long Amount_Intermediate { get; set; }

        public long Amount_compounding { get; set; }

        public DateTime LastAddedOn { get; set; }

    }
}
