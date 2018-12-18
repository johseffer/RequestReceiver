﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RequestReceiver.Domain.Entities
{
    public class Product : EntityBase
    {
        public virtual IList<OrderItem> OrderItems { get; set; }
        public decimal UnitPrice { get; set; }
        public int Multiple { get; set; }
    }
}
