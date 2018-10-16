using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace MedPortal
{
      
    class Hash
    {
      
        private static RNGCryptoServiceProvider rngCSP = new RNGCryptoServiceProvider();
        private LoginPage User = new LoginPage();

       

        //generates a hashed pw with salt
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
            try
            {
                return (from user in LoginPage.UserCollection
                        where user.user == username
                        select Convert.FromBase64String(user.salt)).First();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        //request stored hash 
        public static string GetHash(string username)
        {

            try
            {
                return (from user in LoginPage.UserCollection
                        where user.user == username
                        select user.pass).First();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
           
        }

        //test if user entered hash and stored hash are the same
        public static bool isValid(string password, string username)
        {
            byte[] salt = GetSalt(username);
            string testhash = Sha256(password, salt);
            string userHash = GetHash(username);

            if (!string.IsNullOrEmpty(userHash) && !string.IsNullOrEmpty(testhash))
            {
                return userHash.Equals(testhash);
            }
            else
            {
                return false;
            }
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
