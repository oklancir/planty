namespace Planty.Data.Entities
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using Planty.Data.Interfaces;

    public class CartItem : IEntity
    {
        [Key]
        public Guid Id { get; set; }

        public DateTime CreatedAt { get; set; }

        public int Quantity { get; set; }

        [ForeignKey(nameof(Cart))]
        public Guid CartId { get; set; }

        [ForeignKey(nameof(Product))]
        public Guid ProductId { get; set; }

        public virtual Cart Cart { get; set; }

        public virtual Product Product { get; set; }
    }
}
