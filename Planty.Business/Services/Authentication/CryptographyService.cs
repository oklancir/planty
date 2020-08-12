﻿namespace Planty.Business.Services.Authentication
{
    using System;
    using System.Security.Cryptography;
    using Microsoft.AspNetCore.Cryptography.KeyDerivation;

    public static class CryptographyService
    {
        public static string CreateHash(string value, string salt, string pepper)
        {
            var bytes = KeyDerivation.Pbkdf2(value + pepper, Convert.FromBase64String(salt ?? string.Empty), KeyDerivationPrf.HMACSHA512, 10000, 256 / 8);
            var hash = Convert.ToBase64String(bytes);
            return hash;
        }

        public static string CreateHash(string value, string salt)
        {
            var bytes = KeyDerivation.Pbkdf2(value, Convert.FromBase64String(salt ?? string.Empty), KeyDerivationPrf.HMACSHA512, 10000, 256 / 8);
            var hash = Convert.ToBase64String(bytes);
            return hash;
        }

        public static string CreateSalt()
        {
            byte[] salt = new byte[128 / 8];
            using (var random = RandomNumberGenerator.Create())
            {
                random.GetBytes(salt);
            }

            return Convert.ToBase64String(salt);
        }
    }
}
