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

namespace WinFormUI
{
    public partial class AccountCreationForm : Form
    {
        public AccountCreationForm()
        {
            InitializeComponent();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
 
            if (EvaluatePassword() == true)
            {
                EncryptPassword encrypPass = new EncryptPassword();//Declare object class
                encrypPass.Pass = password_textBox.Text; //Set password to textbox text
                string password = encrypPass.Pass;//Get Encryption for password
                SqlConnection sqlcon = new SqlConnection();
                sqlcon.ConnectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString();
                try
                {
                    sqlcon.Open();
                    string statement = "INSERT INTO EmployeeTest(FName,LName,DOB,Address,City,State,Zipcode,Password,Email,Username) Values(@fName,@lName,@dob,@address,@city,@state,@zipcode,@password,@email,@username)";

                    using (SqlCommand sqlCom = new SqlCommand(statement, sqlcon))
                    {
                        sqlCom.Parameters.Add("@fName", SqlDbType.NVarChar).Value = fName_textBox.Text;
                        sqlCom.Parameters.Add("@lName", SqlDbType.NVarChar).Value = lName_textBox.Text;
                        sqlCom.Parameters.Add("@dob", SqlDbType.Date).Value = dob_textBox.Text;
                        sqlCom.Parameters.Add("@address", SqlDbType.NVarChar).Value = address_textBox.Text;
                        sqlCom.Parameters.Add("@city", SqlDbType.NChar).Value = city_textBox.Text;
                        sqlCom.Parameters.Add("@state", SqlDbType.NChar).Value = state_textBox.Text;
                        sqlCom.Parameters.Add("@zipcode", SqlDbType.NChar).Value = zipcode_textBox.Text;
                        sqlCom.Parameters.Add("@email", SqlDbType.NVarChar).Value = email_textBox.Text;
                        sqlCom.Parameters.Add("@username", SqlDbType.NVarChar).Value = email_textBox.Text;
                        sqlCom.Parameters.Add("@password", SqlDbType.NVarChar).Value = password;
                        sqlCom.ExecuteNonQuery();
                    }
                    sqlcon.Close();
                    MessageBox.Show("Good");
                    MessageBox.Show(dob_textBox.Text);
                }
                catch(SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }  
            }
            else
            {
                MessageBox.Show("Password Invalid!\n" +
                    "Password must contain \n" +
                    "*1 uppercase letter\n" +
                    "*1 Special character \"@,#,$,&\"\n" +
                    "*1 number\n" +
                    "*Greater than 10 characters");
            }  
        }  
        
        
        //Evaluates password for correctness
        private bool EvaluatePassword()
        {
            //bool passwordEval;

            if(password_textBox.Text == password2_textBox.Text && password_textBox.Text.Length >= 10)
            {
                string regex = "^(?=.*[a-z])(?=."
                    + "*[A-Z])(?=.*\\d)"
                    + "(?=.*[-+_!@#$%^&*., ?]).+$";

                // Compile the ReGex
                Regex p = new Regex(regex); 

                // Find match between given string
                // & regular expression
                Match m = p.Match(password_textBox.Text);

                // Print Yes if string
                // matches ReGex
                if (m.Success)
                    return true;
                else
                    return false;                                   
            }

            return false;
        }
        //Hide and Show Passwords
        private void showPassword_button_Click(object sender, EventArgs e)
        {
            if(password2_textBox.UseSystemPasswordChar == true && password_textBox.UseSystemPasswordChar == true)
            {
                password2_textBox.UseSystemPasswordChar = false;
                password_textBox.UseSystemPasswordChar = false;
            }
            else
            {
                password2_textBox.UseSystemPasswordChar = true;
                password_textBox.UseSystemPasswordChar = true;
            }
        }
        private void TextBox_LostFocus(object sender, EventArgs e)
        {
            if (((TextBox)sender).Text.Length < 3 && ((TextBox)sender).Text.Length > 0)
            {
                characterLimit.Visible = true;
                lName_limit.Visible = true;
            }
            else
            {
                characterLimit.Visible = false;
                lName_limit.Visible = false;
            }
        }








        //private bool CheckTextBoxNull()
        //{

        //    if (fName_textBox.Text.Length < 2 || lName_textBox.Text.Length < 2)
        //    {
        //        return false;
        //    }


        //    return false;
        //}
    }
}
