using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.IO;
using System.Xml.Serialization;
using System.Text;
namespace WinFormUI
{
    public class RsaEncryption
    {
    }
    public partial class CreateUserForm : Form
    {
       
        string connection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\oreng\source\repos\MathFormulas\WinFormUI\Database1.mdf;Integrated Security=True";
        string hash = "f0xle@rn";
        public CreateUserForm()
        {
            InitializeComponent();
        }

        private void submit_button_Click(object sender, EventArgs e)
        {
            var password = password_textBox.Text;
            EncryptEngine(ref password);
            using (SqlConnection sqlCon = new SqlConnection(connection))
            {

                try
                {
                    sqlCon.Open();

                    string insStmt = "INSERT INTO dbo.PlayerTable (fName,lName,age,email,phoneNumber,password) values ('" + firstName_textBox.Text + "','" + lastName_textBox.Text + "','" + age_textBox.Text + "', '" + email_textBox.Text + "','" + phoneNumber_textBox.Text + "', '" + password + "')";
                    SqlCommand insCmd = new SqlCommand(insStmt, sqlCon);

                    insCmd.Parameters.AddWithValue("@fName", firstName_textBox.Text);
                    insCmd.Parameters.AddWithValue("@lName", lastName_textBox.Text);
                    insCmd.Parameters.AddWithValue("@age", age_textBox.Text);
                    insCmd.Parameters.AddWithValue("@email", email_textBox.Text);
                    insCmd.Parameters.AddWithValue("@phoneNumber", phoneNumber_textBox.Text);
                    insCmd.Parameters.AddWithValue("@password", password);
                    insCmd.ExecuteNonQuery();
                    sqlCon.Close();
                    MessageBox.Show("Account Created!");

                }
                catch (SqlException sqlEx)
                {
                    MessageBox.Show("Account Creation Failed!");
                }


            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Clear all text boxes
            firstName_textBox.Clear();
            lastName_textBox.Clear();
            age_textBox.Clear();
            email_textBox.Clear();
            phoneNumber_textBox.Clear();
        }


      
        AesCryptoServiceProvider cryptProvider;
        private void AES()
        {
            cryptProvider = new AesCryptoServiceProvider();

            cryptProvider.BlockSize = 128;
            cryptProvider.KeySize = 256;
            cryptProvider.GenerateIV();
            cryptProvider.GenerateKey();
            cryptProvider.Mode = CipherMode.CBC;
            cryptProvider.Padding = PaddingMode.PKCS7;
        }
        private void EncryptEngine(ref string password)
        {
            byte[] data = UTF8Encoding.UTF8.GetBytes(password);
            using(MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            {
                byte[] keys = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(hash));
                using (TripleDESCryptoServiceProvider tripDE = new TripleDESCryptoServiceProvider()
                {
                    Key = keys, Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7
                })
                {
                    ICryptoTransform transform = tripDE.CreateEncryptor();
                    byte[] results = transform.TransformFinalBlock(data, 0, data.Length);
                    password = Convert.ToBase64String(results, 0, results.Length);
                }
            }             
            
        }
    }
}
