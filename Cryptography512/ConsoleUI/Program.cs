using System;
using System.Security.Cryptography;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //Users input
            Console.WriteLine("Enter word to be encrypted --> ");
            string text = Console.ReadLine();

            //Call method and display results to the user
            Console.WriteLine(Convert.ToBase64String(GenerateEncryptionKeys(text)));
            Console.ReadLine();
        }



        static byte[] GenerateEncryptionKeys(string text)
        {
            SHA512Managed algorithm = new SHA512Managed();
            var plainText = Encoding.ASCII.GetBytes(text);
            var salt = Encoding.ASCII.GetBytes("SHAfiveTwelve");
            byte[] encryptionKeys = new byte[plainText.Length + salt.Length];
            
            for(int i = 0; i < plainText.Length; i++)
            {
                encryptionKeys[i] = plainText[i];
            }
            for (int i = 0; i < salt.Length; i++)
            {
                encryptionKeys[plainText.Length + 1] = salt[i];
            }

            return algorithm.ComputeHash(encryptionKeys);

        }
    }
}
