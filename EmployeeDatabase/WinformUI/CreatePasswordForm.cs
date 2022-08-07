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
namespace WinformUI
{
    public partial class CreatePasswordForm : Form
    {
        
        SqlConnection sqlCon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\oreng\source\repos\EmployeeDatabase\WinformUI\EmployeeDB.mdf;Integrated Security=True");
        bool decision = false;
        public CreatePasswordForm()
        {
            InitializeComponent();
        }

        private void verifySubmit_button_Click(object sender, EventArgs e)
        {
            bool exists = false;
            string sqlStatement = "SELECT COUNT(*) FROM dbo.EmployeeTable WHERE fName = '" + enterFName_textBox.Text + "' AND lName = '"+enterLName_textBox.Text+"' AND phoneNumber = '"+enterPhoneNumber_textBox.Text+"'";
            using (SqlCommand sqlCom = new SqlCommand(sqlStatement, sqlCon))
            {
                try
                {
                    sqlCon.Open();
                    sqlCom.Parameters.AddWithValue(@"fName", enterFName_textBox.Text);
                    sqlCom.Parameters.AddWithValue(@"lName", enterLName_textBox.Text);
                    sqlCom.Parameters.AddWithValue(@"phoneNumber", enterPhoneNumber_textBox.Text);
                    exists = (int)sqlCom.ExecuteScalar() > 0;

                    if (exists)
                    {
                        userName_textBox.Visible = true;
                        password_textBox.Visible = true;
                        password_textBox2.Visible = true;
                        createPassword2_label.Visible = true;
                        createPassword_label.Visible = true;
                        createUserName_label.Visible = true;

                    }
                    else
                    {
                        MessageBox.Show("User does not exists");
                    }
                    sqlCon.Close();
                }
                catch
                {
                    
                }
            }
        }

        private void exitForm_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EncryptUserNamePassword()
        {
            decision = true;
            var plainText = Encoding.ASCII.GetBytes(userName_textBox.Text);
            var salt = Encoding.ASCII.GetBytes("ALgoFiveTwelve");

            string sqlStatement = "INSERT into dbo.EmployeeTable(userName, password) values ('"+userName_textBox.Text+"','"+password_textBox.Text+"')";

            sqlCon.Open();//Open SQL Connection

            using (SqlCommand sqlCom = new SqlCommand(sqlStatement, sqlCon))//Execute sql statement 
            {
                //Prevent sql injection by using parameters for insertion
                sqlCom.Parameters.AddWithValue(@"userName", userName_textBox.Text = Convert.ToBase64String(GenerateSaltedHash256(plainText, salt, ref decision)));
                sqlCom.Parameters.AddWithValue(@"password", password_textBox.Text = Convert.ToBase64String(GenerateSaltedHash256(plainText, salt, ref decision)));

                sqlCom.ExecuteNonQuery();
                sqlCon.Close();
            }
        }       
        static byte[] GenerateSaltedHash256(byte[] plainText, byte[] salt, ref bool decision)
        {
            //SHA-512 Algorithm
            HashAlgorithm algorithm = new SHA512Managed();
             
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
    }
}
