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
namespace WinformUI
{
    public partial class AddEmployeeForm : Form
    {
        CreatePasswordForm passForm = new CreatePasswordForm();
        SqlConnection sqlCon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\oreng\source\repos\EmployeeDatabase\WinformUI\EmployeeDB.mdf;Integrated Security=True");
        public AddEmployeeForm()
        {
            InitializeComponent();
        }
        private void exit_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddEmployeeForm_Load(object sender, EventArgs e)
        {
            fName_textBox.Clear();
            lName_textBox.Clear();
            phoneNumber_textBox.Clear();
            dob_textBox.Clear();
            email_textBox.Clear();
            zipcode_textBox.Clear();
            state_textBox.Clear();
            city_textBox.Clear();
            address_textBox2.Clear();
            address_textBox.Clear();
        }

        private void submit_button_Click(object sender, EventArgs e)
        {

            string addEmployee = "INSERT into dbo.EmployeeTable(fName,lName,dob,phoneNumber,address,address2,city,state,zipcode,email) values('" + fName_textBox.Text + "','" + lName_textBox.Text + "','" + dob_textBox.Text + "'" +
                ",'" + phoneNumber_textBox.Text + "','" + email_textBox.Text + "','" + zipcode_textBox.Text + "','" + state_textBox.Text + "','" + city_textBox.Text + "','" + address_textBox2.Text + "','" + address_textBox.Text + "')";
            using (SqlCommand sqlCommand = new SqlCommand(addEmployee, sqlCon))
            {
                
                try
                {
                    sqlCon.Open();
                    sqlCommand.Parameters.AddWithValue("@fName",fName_textBox.Text);
                    sqlCommand.Parameters.AddWithValue("@lName",lName_textBox.Text);
                    sqlCommand.Parameters.AddWithValue("@dbo", dob_textBox.Text);
                    sqlCommand.Parameters.AddWithValue("@phoneNumber", email_textBox.Text);
                    sqlCommand.Parameters.AddWithValue("@address", zipcode_textBox.Text);
                    sqlCommand.Parameters.AddWithValue("@address2", state_textBox.Text);
                    sqlCommand.Parameters.AddWithValue("@city", city_textBox.Text);
                    sqlCommand.Parameters.AddWithValue("@state", state_textBox.Text);
                    sqlCommand.Parameters.AddWithValue("@zipcode", zipcode_textBox.Text);
                    sqlCommand.Parameters.AddWithValue("@email", email_textBox.Text);

                    sqlCommand.ExecuteNonQuery();
                    MessageBox.Show("Employee added successfully!");
                    sqlCon.Close();

                    passForm.Show();
                }
                catch(SqlException sqlE)
                {
                    MessageBox.Show($"Error{sqlE}");
                }
                

            }
             
        }
    }
}
