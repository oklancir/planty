namespace Planty.Data.Entities
{
    using System;
    using System.Collections.Generic;
    using Planty.Data.Interfaces;

    public class Cart : IEntity
    {
        public Guid Id { get; set; }

        public DateTime CreatedAt { get; set; }

        public Guid UserId { get; set; }

        public IEnumerable<CartItem> CartItems { get; set; }
    }
}
