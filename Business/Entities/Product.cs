using System;
using System.Collections.Generic;

namespace Business.Entities
{
    public partial class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; } = null!;
        public double Price { get; set; }
        public string Description { get; set; } = null!;
        public string CategoryName { get; set; } = null!;
        public string ImageUrl { get; set; } = null!;
    }
}
