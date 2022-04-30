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
using System.IO;
using System.Security.Cryptography;
namespace ConsoleUI
{
    public partial class LoginForm : Form
    {
        
        public LoginForm()
        {
            InitializeComponent();
        }

        private void login_button_Click(object sender, EventArgs e)
        {
            string dir = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            string userPass = Convert.ToBase64String(GetEncryptedKeys(password_textBox.Text));   
            string connectionString = "";
            string sqlStatement = $"SELECT * FROM dbo.PlayerTable WHERE UserName = '"+userName_textBox.Text+"' AND Password = '"+userPass+"'";
            using (StreamReader readDoc = new StreamReader(dir + $@"/SqlDataConString.txt"))
            {
                connectionString = readDoc.ReadToEnd();//Get connection string from document
            }
            SqlConnection sqlCon = new SqlConnection($@"{connectionString}");//open sql connection
            sqlCon.Open();
            using (SqlCommand sqlCom = new SqlCommand(sqlStatement, sqlCon))
            {
                sqlCom.Parameters.AddWithValue(@"UserName", userName_textBox.Text);
                sqlCom.Parameters.AddWithValue(@"Password",userPass);

                SqlDataReader reader = sqlCom.ExecuteReader();
                if (reader.Read())
                {
                    string userName = reader.GetValue(0).ToString();
                    string password = reader.GetValue(1).ToString();
                    MessageBox.Show("User Exist");
                    //Load player Data-----------------------------------------------------------------------------

                }
                else
                {
                    MessageBox.Show("User does not Exist!");
                }
                sqlCon.Close();
            }
        }

        static byte[] GetEncryptedKeys(string text)
        {
            SHA512Managed alogrithm = new SHA512Managed();//Create sha512 algorithm class
            string dir = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location); //Get directory location of text doc
            var plainText = Encoding.ASCII.GetBytes(text); //Get bytes from string
            //Get Hash from text doc
            string getHash;
            using (StreamReader readLine = new StreamReader(dir + $@"/CrytKHS.txt"))
            {
                getHash = readLine.ReadToEnd(); //read hash from document               
            }
            var hash = Encoding.ASCII.GetBytes(getHash);//Get bytes from string
            byte[] encryptKeys = new byte[plainText.Length + hash.Length];

            for(int i = 0; i < plainText.Length; i++)
            {
                encryptKeys[i] = plainText[i];
            }
            for(int i = 0; i < hash.Length; i++)
            {
                encryptKeys[plainText.Length + i] = hash[i];
            }
            return alogrithm.ComputeHash(encryptKeys);
        }
    }
}
