using System;
using System.Collections.Generic;

namespace WebApplication1.Model
{
    public partial class CustomerProduct
    {
        public int Id { get; set; }
        public int? IdProduct { get; set; }
        public int? IdCustomer { get; set; }
    }
}
