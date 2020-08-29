namespace Planty.Data.Entities
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using Planty.Data.Interfaces;

    public class User : IEntity
    {
        [Key]
        public Guid Id { get; set; }

        public DateTime CreatedAt { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public string Email { get; set; }

        public DateTime DateOfBirth { get; set; }

        [Required]
        public string Username { get; set; }

        [Required]
        public string PasswordHash { get; set; }

        [Required]
        public string PasswordSalt { get; set; }
    }
}
