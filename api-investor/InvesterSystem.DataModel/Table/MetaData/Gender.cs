﻿using System;
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
        public int ID { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }
    }
}
