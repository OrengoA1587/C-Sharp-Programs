using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.IO;
using System.Xml.Serialization;
using System.Text;
namespace EncryptAndDecryptUseInput
{
    public partial class Form1 : Form
    {
        RsaEncryption rsa = new RsaEncryption();
        string cypher = string.Empty;
        public Form1()
        {
            InitializeComponent();
        }

        private void encrypt_button_Click(object sender, EventArgs e)
        {
            var password = encryptInput_textBox.Text;
            //EncryptEngine(ref password);


            if (!string.IsNullOrEmpty(password))
            {
                cypher = rsa.Encrypt(ref password);
                encrypted_textBox.Text = cypher;

            }
        }

        
        private void Decrypt_Click(object sender, EventArgs e)
        {
            var password = decryptInput_textBox.Text;
            //EncryptEngine(ref password);


            if (!string.IsNullOrEmpty(password))
            {
                cypher = rsa.Decrypt(ref password);
                decrypted_textBox.Text = cypher;

            }
        }
    }
    //RSA Encryption---------------------------------------------------
    public class RsaEncryption
    {
        //RSA encryption 4096
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
        public string Encrypt(ref string plainText)
        {
            csp = new RSACryptoServiceProvider();
            csp.ImportParameters(_publicKey);
            var data = Encoding.Unicode.GetBytes(plainText);
            var cypher = csp.Encrypt(data, false);
            return Convert.ToBase64String(cypher);


        }
        public string Decrypt(ref string cypherText)
        {
            var dataBytes = Convert.FromBase64String(cypherText);
            csp.ImportParameters(_privateKey);
            var plainText = csp.Decrypt(dataBytes, false);
            return Encoding.Unicode.GetString(plainText);
        }
        //RSA------------------------------------------------------------------------------------------------------
    }

   
}
