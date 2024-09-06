using System;
using System.Collections.Generic;

namespace WebApplication1.Model
{
    public partial class Product
    {
        public int Id { get; set; }
        public string? ProductName { get; set; }
        public string? Quantity { get; set; }
        public int? Price { get; set; }
    }
}
