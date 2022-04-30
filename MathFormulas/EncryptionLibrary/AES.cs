using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
namespace WinFormUI
{
    public class AES  

    {
        AesCryptoServiceProvider cryptProvider;
        public AES()
        {
            cryptProvider = new AesCryptoServiceProvider();

            cryptProvider.BlockSize = 128;
            cryptProvider.KeySize = 256;
            cryptProvider.GenerateIV();
            cryptProvider.GenerateKey();
            cryptProvider.Mode = CipherMode.CBC;
            cryptProvider.Padding = PaddingMode.PKCS7;
         }
        public string EncryptEngine(ref string password)
        {
            ICryptoTransform transform = cryptProvider.CreateEncryptor();
            byte[] encrypted_bytes = transform.TransformFinalBlock(ASCIIEncoding.ASCII.GetBytes(password), 0, password.Length);

            string str = Convert.ToBase64String(encrypted_bytes);
            return str;
        }
    }
}
