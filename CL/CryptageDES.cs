using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace Crypto.CL
{
    class CryptageDES
    {
        // À la création de l'instance de chiffrage, la clé et le IV sont également créés
        private static TripleDESCryptoServiceProvider TDES;

        public static String Encrypt(String _Texte)
        {
            byte[] textAsByte = Encoding.Default.GetBytes(_Texte);

            TDES = new TripleDESCryptoServiceProvider();

            // Cet objet est utilisé pour chiffrer les données.
            // Il reçoit en entrée les données en clair sous la forme d'un tableau de bytes.
            // Les données chiffrées sont également retournées sous la forme d'un tableau de bytes
            var encryptor = TDES.CreateEncryptor(TDES.Key, TDES.IV);

            byte[] cryptedTextAsByte = encryptor.TransformFinalBlock(textAsByte, 0, textAsByte.Length);

            return Convert.ToBase64String(cryptedTextAsByte);
        }

        //public static String Decrypt(String _Texte)
        //{

        //}
    }
}
