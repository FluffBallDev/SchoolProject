using System;
using System.Security.Cryptography;
using System.Text;

namespace SchoolProject.Util
{
    public static class PassEncrypt
    {
        /// <summary>
        /// Password Encryption method using SHA-512 encoding.
        /// </summary>
        /// <param name="stringToEncrypt">String to encode</param>
        /// <param name="salt">Salt to apply to the string to encode. Unique to each user.</param>
        /// <returns>a SHA-512 encoded string with salting.</returns>
        public static string Encrypt(string stringToEncrypt, string salt)
        {
            using (SHA512 sha512 = SHA512.Create())
            {
                string mixedString = stringToEncrypt + salt;
                var data = Encoding.UTF8.GetBytes(mixedString);

                byte[] eData = sha512.ComputeHash(data);

                return Convert.ToBase64String(eData);
            }
        }
    }
}