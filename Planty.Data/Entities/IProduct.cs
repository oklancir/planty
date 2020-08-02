namespace Planty.Data.Entities
{
    using System;
    using Planty.Data.Interfaces;

    public interface IProduct : IEntity
    {
        public new Guid Id { get; set; }

        public new DateTime CreatedAt { get; set; }

        public decimal Price { get; set; }

        public int Quantity { get; set; }
    }
}
