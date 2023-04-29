using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
namespace WinFormUI
{
    public class EncryptPassword
    {
        private string _pass;
        public string Pass
        {
            get { return Convert.ToBase64String(Encrypt(_pass)); }
            set { _pass = value; }
        }
        public byte[] Encrypt(string text)
        {
            SHA512Managed algo = new SHA512Managed();
            var plainText = Encoding.ASCII.GetBytes(text);
            var salt = Encoding.ASCII.GetBytes("SecretPass");

            byte[] EncryptText = new byte[plainText.Length + salt.Length];

            for (int i = 0; i < plainText.Length; i++)
            {
                EncryptText[i] = plainText[i];
            }
            for (int i = 0; i < salt.Length; i++)
            {
                EncryptText[plainText.Length + i] = salt[i];
            }
            return algo.ComputeHash(EncryptText);
        }
    }
    
}
