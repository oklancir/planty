namespace Planty.Business.Models
{
    using System;

    public class ProductBase
    {
        public DateTime CreatedAt { get; set; }

        public decimal Price { get; set; }

        public int Quantity { get; set; }

        public string Name { get; set; }

        public string LatinName { get; set; }
    }
}
