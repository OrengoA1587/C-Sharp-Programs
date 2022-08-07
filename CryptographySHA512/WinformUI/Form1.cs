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
namespace WinformUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void encrypt_button_Click(object sender, EventArgs e)
        {
            string plaintext = textToBeEncrypted_textBox.Text;

            encryptedText_textBox.Text = Convert.ToBase64String(GenerateEncryptedKey(plaintext));
        }

         static byte[] GenerateEncryptedKey(string plainText)
        {
            SHA512Managed algorithm = new SHA512Managed();
            var encypt = Encoding.ASCII.GetBytes(plainText);
            var salt = Encoding.ASCII.GetBytes("FiveTwelveAlgo");
            byte[] plainTextToBytes = new byte[encypt.Length + salt.Length];
            for(int i = 0; i < plainText.Length; i++)
            {
                plainTextToBytes[i] = encypt[i];
            }
            for(int i = 0; i < salt.Length; i++)
            {
                plainTextToBytes[encypt.Length + 1] = salt[i];

            }

            return algorithm.ComputeHash(plainTextToBytes);
        }
      
      
    }
}
