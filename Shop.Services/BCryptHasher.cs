using System;
using Shop.ServicesAbstract;
using BCrypt.Net;

namespace Shop.Services
{
    public class BCryptHasher : ICryptoService
    {
        public string EncryptPassword(string password)
        {
            return BCrypt.Net.BCrypt.HashPassword(password);
        }

        public bool VerifyPassword(string password, string passwordCandidate)
        {
            return BCrypt.Net.BCrypt.Verify(passwordCandidate, password);
        }
    }
}
