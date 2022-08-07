using System;
using System.Security.Cryptography;
using System.IO;
using System.Xml.Serialization;
using System.Text;

namespace CryptographyPublicPrivateKeys
{

    public class RsaEncryption 
    {
        private static RSACryptoServiceProvider csp = new RSACryptoServiceProvider(4096);
        private RSAParameters _privateKey;
        private RSAParameters _publicKey;


        public RsaEncryption()
        {
            _privateKey = csp.ExportParameters(true);
            _publicKey = csp.ExportParameters(false);
        }
        public string GetPublicKey()
        {
            var stringWriter = new StringWriter();
            var xs = new XmlSerializer(typeof(RSAParameters));
            xs.Serialize(stringWriter, _publicKey);
            return stringWriter.ToString();
        }
        public string Encrypt(string plainText)
        {
            csp = new RSACryptoServiceProvider();
            csp.ImportParameters(_publicKey);
            var data = Encoding.Unicode.GetBytes(plainText);
            var cypher = csp.Encrypt(data, false);
            return Convert.ToBase64String(cypher);


        }

        public string Decrypt(string cypherText)
        {
            var dataBytes = Convert.FromBase64String(cypherText);
            csp.ImportParameters(_privateKey);
            var plainText = csp.Decrypt(dataBytes, false);
            return Encoding.Unicode.GetString(plainText);
        }
    }
   
    class Program
    {
        static void Main(string[] args)
        {
            RsaEncryption rsa = new RsaEncryption();
            string cypher = string.Empty;

            Console.WriteLine($"Public Key: {rsa.GetPublicKey()}");

            Console.WriteLine("enter your text to encrypt ");
            var text = Console.ReadLine();
            if (!string.IsNullOrEmpty(text))
            {
                cypher = rsa.Encrypt(text);
                Console.WriteLine($"Encrypted Text: {cypher}");
            }
            Console.WriteLine("Press any key to encrypt");
            Console.ReadLine();

            var plainText = rsa.Decrypt(cypher);

            Console.WriteLine($"Decrypted Message: {plainText}");
            Console.ReadLine();

        }
    }
}
