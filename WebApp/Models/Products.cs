using System;
using System.Collections.Generic;

namespace WebApp.Models
{
    public partial class Products
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public decimal Prize { get; set; }
        public string Description { get; set; }
    }
}
