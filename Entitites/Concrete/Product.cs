﻿using Entitites.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entitites.Concrete
{
    public class Product : IEntity //diger katmanlarda erisebilsin diye public

    {
        public int ProductId { get; set; }
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public short UnitInStock { get; set; }
        public decimal UnitPrice { get; set; }

    }
}
