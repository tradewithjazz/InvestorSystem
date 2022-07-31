using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvestorSystem.Core.Areas.Common.DTOs
{
    public class PayoutCalculationsDTO
    {
        public long ID { get; set; }

        public long PayoutAmount { get; set; }

        public long CompoundingAmount { get; set; }

        public long PayoutIntermediate { get; set; }

        public long CompoundingIntermediate { get; set; }

        public DateTime ForDate { get; set; }

    }
}
