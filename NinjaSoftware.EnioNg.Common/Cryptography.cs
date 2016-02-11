using System;
using System.Security.Cryptography;
using System.Text;

namespace NinjaSoftware.EnioNg.Common
{
    public class Cryptography
    {
        public static string GetPasswordHash(string plainPassword, string salt)
        {
            SHA512CryptoServiceProvider cryptoProvider = new SHA512CryptoServiceProvider();

            byte[] bytes = Encoding.UTF8.GetBytes(plainPassword + salt);
            byte[] hashedBytes = cryptoProvider.ComputeHash(bytes);

            return Convert.ToBase64String(hashedBytes).Substring(0, 64);
        }
        
        public static bool ValidatePassword(string passwordPackage, string plainPassword)
        {
            string passwordHash = passwordPackage.Substring(0, 64);
            string passwordSalt = passwordPackage.Substring(64);
            
            return passwordHash == GetPasswordHash(plainPassword, passwordSalt);
        }
        
        public static string CreatePasswordPackage(string plainPassword)
        {
            string salt = Guid.NewGuid().ToString().Replace("-", "");
            string passwordHash = GetPasswordHash(plainPassword, salt);
            
            return passwordHash + salt;
        }
    }
}

