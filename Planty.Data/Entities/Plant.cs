namespace Planty.Data.Entities
{
    using System;

    public class Plant : IProduct
    {
        public Guid Id { get; set; }

        public DateTime CreatedAt { get; set; }

        public decimal Price { get; set; }

        public int Quantity { get; set; }

        public string Name { get; set; }

        public string LatinName { get; set; }
    }
}
