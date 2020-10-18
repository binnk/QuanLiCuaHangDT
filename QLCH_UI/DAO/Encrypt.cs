using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace QLCH_UI.DAO
{
    public class Encrypt
    {
        byte[] hashPass;

        private static Encrypt instance;

        public static Encrypt Instance
        {
            get { if (instance == null) instance = new Encrypt(); return instance; }
            private set => instance = value;
        }

        private Encrypt() { }

        public String Hash(String pass)

        {
            this.hashPass = System.Text.Encoding.UTF8.GetBytes(pass);
            using (SHA1Managed sha1 = new SHA1Managed())
            {
                var hash = sha1.ComputeHash(hashPass);
                return Convert.ToBase64String(hash);
            }
        }
    }
}
