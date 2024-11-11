using System;
using System.Security.Cryptography;
using System.Text;

namespace Admin.Models
{
    public class SimpleAesEncryption
    { 

        public static string Encrypt(string plainText)
        {
            byte[] passwordBytes = Encoding.UTF8.GetBytes(plainText);
            return Convert.ToBase64String(passwordBytes);
        }

        public static string Decrypt(string encryptedText)
        {
            try
            {
                byte[] passwordBytes = Convert.FromBase64String(encryptedText);
                return Encoding.UTF8.GetString(passwordBytes);
            } catch (Exception e)
            {
                return encryptedText;
            }
        }
    }
}
