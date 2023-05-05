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
using System.Configuration;
using System.Text.RegularExpressions;
using System.Windows;
using System.IO;
namespace WinFormUI
{
    public partial class LoginPage : Form
    {
        EmployeeDashboard_Form emploDashForm = new EmployeeDashboard_Form();

        public LoginPage()
        {
            InitializeComponent();
        }

        private void CreateAccount_Click(object sender, EventArgs e)
        {
            AccountCreationForm acctCreate = new AccountCreationForm();
            acctCreate.Show();
        }

        private void login_button_Click(object sender, EventArgs e)
        {
            EncryptPassword encrypPass = new EncryptPassword();
            //string dir = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            //MessageBox.Show(dir);
            encrypPass.Pass = password_textBox.Text; ;
            string password = encrypPass.Pass;
            

            SqlConnection sqlcon = new SqlConnection();
            string statement = "SELECT * FROM EmployeeTest where Email = @username AND Password = @password";
            sqlcon.ConnectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString();

             
            using (SqlCommand sqlcom = new SqlCommand(statement, sqlcon))
            {
                sqlcon.Open();
                sqlcom.Parameters.Add("@username", SqlDbType.NVarChar).Value = username_textBox.Text;
                sqlcom.Parameters.Add("@password", SqlDbType.NVarChar).Value = password;


                 
                SqlDataReader reader = sqlcom.ExecuteReader();
                if (reader.Read())
                {
                    string userName = reader.GetValue(0).ToString();
                    string passwordCheck = reader.GetValue(1).ToString();
                    //MessageBox.Show("User Exist");
                    username_textBox.Text = "";
                    password_textBox.Text = "";
                    emploDashForm.Show();

                }
                else
                {
                    MessageBox.Show("User does not Exist!");
                }
                sqlcon.Close();
                
            }           

        }
        //Hide and Show Passwords
        private void showPass_Click(object sender, EventArgs e)
        {
            if (password_textBox.UseSystemPasswordChar == true )
            {               
                password_textBox.UseSystemPasswordChar = false;
            }
            else
            {                
                password_textBox.UseSystemPasswordChar = true;
            }
        }

        private void createAccount_MouseHover(object sender, EventArgs e)
        {
            create_accountButton.ForeColor = Color.Black;
        }

        private void createAccount_MouseLeave(object sender, EventArgs e)
        {
            create_accountButton.ForeColor = Color.White;
        }

        private void ForgotPass_button_MouseHover(object sender, EventArgs e)
        {
            ForgotPass_button.ForeColor = Color.Black;
        }

        private void ForgotPass_button_MouseLeave(object sender, EventArgs e)
        {
            ForgotPass_button.ForeColor = Color.White;
        }

         
    }
}
