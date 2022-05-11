using System;
using System.Security.Cryptography;
using System.Text;

namespace Crypto.CL
{
    class CryptageSHA
    {
        public static String Encrypt(String _Texte)
        {
            byte[] textAsByte = Encoding.Default.GetBytes(_Texte);

            SHA512 sha512 = SHA512Cng.Create();

            byte[] hash = sha512.ComputeHash(textAsByte);

            return Convert.ToBase64String(hash);
        }
    }
}
