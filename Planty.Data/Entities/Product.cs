namespace Planty.Data.Entities
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using Planty.Data.Interfaces;

    public class Product : IEntity
    {
        [Key]
        public Guid Id { get; set; }

        public DateTime CreatedAt { get; set; }

        public decimal Price { get; set; }

        public int Quantity { get; set; }

        [Required]
        public string Name { get; set; }

        public string LatinName { get; set; }
    }
}
