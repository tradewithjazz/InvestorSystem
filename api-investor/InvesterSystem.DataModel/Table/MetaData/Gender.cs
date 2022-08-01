﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvestorSystem.DataModel.Table
{
    public class Gender
    {
        [Key]
        [MaxLength(1)]
        public short ID { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }
    }
}
