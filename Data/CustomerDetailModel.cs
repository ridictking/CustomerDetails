﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorDemo.Data
{
    public class CustomerDetailModel
    {
        public int CustomerOrderId { get; set; }
        public int ItemId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
    }
}
