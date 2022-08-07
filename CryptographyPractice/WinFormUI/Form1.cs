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
namespace WinFormUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void encrypt_button_Click(object sender, EventArgs e)
        {
            string plainText = plainText_textBox.Text;
            encryptedText_textBox.Text = Convert.ToBase64String(GenerateSha512Encryption(plainText));

        }

        static byte[] GenerateSha512Encryption(string plainText)
        {
            SHA512Managed algorithm = new SHA512Managed();
            var textToBeEncrypted = Encoding.ASCII.GetBytes(plainText);
            var saltKey = Encoding.ASCII.GetBytes("ShaFiveTwelve");

            byte[] GetBytesToEncrypt = new byte[textToBeEncrypted.Length + saltKey.Length];
            for (int i = 0; i < plainText.Length; i++)
            {
                GetBytesToEncrypt[i] =textToBeEncrypted[i];

            }
            for(int i = 0; i < saltKey.Length; i++)
            {
                GetBytesToEncrypt[textToBeEncrypted.Length + i] = saltKey[i];
            }
            return algorithm.ComputeHash(GetBytesToEncrypt);
        }
    }
}
