﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WackyPurseHunt.Models
{
    public class ProductTheme
    {
        public int Id { get; set; }
        public string Theme { get; set; }
        public bool IsActive { get; set; } = true;
    }
}
