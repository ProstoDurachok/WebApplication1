using System;
using System.Collections.Generic;

namespace WebApplication1.Model
{
    public partial class MaterialProduct
    {
        public int Id { get; set; }
        public int? IdProduct { get; set; }
        public int? IdMaterial { get; set; }
    }
}
