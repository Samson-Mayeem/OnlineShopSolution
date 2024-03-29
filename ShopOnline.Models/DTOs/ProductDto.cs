﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopOnline.Models.DTOs
{
    public class ProductDto
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; } 
        public string ImageURL { get; set; }
        public decimal Price { get; set; }
        public decimal Qty { get; set; }
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
    }
}
