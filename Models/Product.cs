﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Crud_Application.Models
{
    public class Product
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public int Rate { get; set; }

        public string Quantity { get; set; }
    }
}
