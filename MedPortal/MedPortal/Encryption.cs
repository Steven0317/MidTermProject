using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace MedPortal
{
    class Encryption
    {
      
        private static RNGCryptoServiceProvider rngCSP = new RNGCryptoServiceProvider();

        //generate a hashed and salted pw on user create
        public static string Sha256(string input)
        {
            if (!string.IsNullOrEmpty(input))
            {

                byte[] salt = GenerateSalt();

                using (var sha = SHA256.Create())
                {
                    var bytes = Encoding.UTF8.GetBytes(input);
                    byte[] combined = Concat(salt, bytes);
                    var hash = sha.ComputeHash(combined);

                    return Convert.ToBase64String(hash);
                }
            }
            else
            {
                return string.Empty;
            }
        }

        //generates a hashed pw in order to check against stored hash
        public static string Sha256(string password, byte [] salt)
        {
            if (!string.IsNullOrEmpty(password))
            {

                using (var sha = SHA256.Create())
                {
                    var bytes = Encoding.UTF8.GetBytes(password);
                    byte[] combined = Concat(salt, bytes);
                    var hash = sha.ComputeHash(combined);

                    return Convert.ToBase64String(hash);
                }
            }
            else
            {
                return string.Empty;
            }
        }

        //salt bae
        public static byte[] GenerateSalt()
        {
            byte[] salt = new byte[32];
            rngCSP.GetBytes(salt);
            return salt;

        }


        //requests salt from storage
        public static byte [] GetSalt(string username)
        {
            return from user in Users
                   where user.username == username
                   select user.salt;
        }

        //request stored hash 
        public static string GetHash(string username)
        {
            return from user in Users
                   where user.username == username
                   select user.hash;
        }

        //test if user entered hash and stored hash are the same
        public static bool isValid(string password, string username)
        {
            byte[] salt = GetSalt(username);
            string testhash = Sha256(password, salt);
            string userHash = GetHash(username);
            bool validLogin = userHash.Equals(testhash);
            return validLogin ;
        }

        //combines salt and hash byte arrays
        static byte[] Concat(byte[] a, byte[] b)
        {
            byte[] output = new byte[a.Length + b.Length];
            for (int i = 0; i < a.Length; i++)
                output[i] = a[i];
            for (int j = 0; j < b.Length; j++)
                output[a.Length + j] = b[j];
            return output;
        }

    }
}
