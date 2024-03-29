﻿namespace Planty.Business.Models
{
    using System;

    public class UserBase
    {
        public DateTime CreatedAt { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public DateTime DateOfBirth { get; set; }

        public string Username { get; set; }

        public string Password { get; set; }
    }
}
