namespace Planty.Data.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using Planty.Data.Interfaces;

    public class Cart : IEntity
    {
        [Key]
        public Guid Id { get; set; }

        public DateTime CreatedAt { get; set; }

        [ForeignKey(nameof(User))]
        public Guid UserId { get; set; }

        public virtual User User { get; set; }

        [InverseProperty(nameof(CartItem.Cart))]
        public virtual IEnumerable<CartItem> CartItems { get; set; }
    }
}
