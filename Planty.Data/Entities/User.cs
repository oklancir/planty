namespace Planty.Data.Entities
{
    using System;
    using Planty.Data.Interfaces;

    public class User : IEntity
    {
        public Guid Id { get; set; }

        public DateTime CreatedAt { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public DateTime DateOfBirth { get; set; }

        public string Username { get; set; }

        public string PasswordHash { get; set; }

        public string PasswordSalt { get; set; }
    }
}
