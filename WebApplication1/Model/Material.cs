using System;
using System.Collections.Generic;

namespace WebApplication1.Model
{
    public partial class Material
    {
        public int Id { get; set; }
        public string? MaterialName { get; set; }
        public int? Quantity { get; set; }
        public int? Price { get; set; }
    }
}
