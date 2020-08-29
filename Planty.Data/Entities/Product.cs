namespace Planty.Data.Entities
{
    using System;
    using Planty.Data.Interfaces;

    public class Product : IEntity
    {
        public Guid Id { get; set; }

        public DateTime CreatedAt { get; set; }

        public decimal Price { get; set; }

        public int Quantity { get; set; }

        public string Name { get; set; }

        public string LatinName { get; set; }

        public string Type { get; set; }
    }
}
