using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinformUI
{
     
    public partial class SHA512Encryption : Form
    {
        bool decision = false;
        public SHA512Encryption()
        {
            InitializeComponent();
        }

        private void shaEncrypt256_button_Click(object sender, EventArgs e)
        {
            decision = false;
            var plainText = Encoding.ASCII.GetBytes(inputEncrypt_textBox.Text);
            var salt = Encoding.ASCII.GetBytes("happy");
            encrypted_textBox.Text = Convert.ToBase64String(GenerateSaltedHash256(plainText, salt,ref decision));
           
        }
        private void shaEncrypt512_button_Click(object sender, EventArgs e)
        {
            decision = true;
            var plainText = Encoding.ASCII.GetBytes(encryptInput512_textBox.Text);
            var salt = Encoding.ASCII.GetBytes("happy");
            encrypted512_textBox.Text = Convert.ToBase64String(GenerateSaltedHash256(plainText, salt,ref decision));

        }
        static byte[] GenerateSaltedHash256(byte[] plainText, byte[] salt,ref bool decision)
        {

            HashAlgorithm algorithm;
            if(decision == false)
            {
                algorithm = new SHA256Managed();
            }
            else 
            {
                algorithm = new SHA512Managed();
            }

            byte[] plainTextWithSaltBytes =
              new byte[plainText.Length + salt.Length];
            for (int i = 0; i < plainText.Length; i++)
            {
                plainTextWithSaltBytes[i] = plainText[i];
            }
            for (int i = 0; i < salt.Length; i++)
            {
                plainTextWithSaltBytes[plainText.Length + i] = salt[i];
            }
             return algorithm.ComputeHash(plainTextWithSaltBytes);
             
        }

        private void reset_button_Click(object sender, EventArgs e)
        {
            encrypted_textBox.Clear();
            inputEncrypt_textBox.Clear();
            encrypted512_textBox.Clear();
            encryptInput512_textBox.Clear();
        }
    }
}
