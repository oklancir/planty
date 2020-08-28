namespace Planty.Data.Entities
{
    using System;
    using Planty.Data.Interfaces;

    public class CartItem : IEntity
    {
        public Guid Id { get; set; }

        public DateTime CreatedAt { get; set; }

        public Guid CartId { get; set; }

        public Guid ProductId { get; set; }

        public int Amount { get; set; }
    }
}
