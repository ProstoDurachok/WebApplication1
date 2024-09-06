using System;
using System.Collections.Generic;

namespace WebApplication1.Model
{
    public partial class Responsible
    {
        public int Id { get; set; }
        public string? Lastname { get; set; }
        public string? Name { get; set; }
        public string? Patronymic { get; set; }
        public int? IdProduct { get; set; }
        public int? Deadlines { get; set; }
    }
}
