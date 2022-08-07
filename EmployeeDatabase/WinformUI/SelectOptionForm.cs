using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinformUI
{
    public partial class SelectOptionForm : Form
    {
        public SelectOptionForm()
        {
            InitializeComponent();
        }

        private void CreateUser_button_Click(object sender, EventArgs e)
        {
            AddEmployeeForm addEmpl = new AddEmployeeForm();
            addEmpl.Show();
        }

        private void setUserPassword_button_Click(object sender, EventArgs e)
        {
            CreatePasswordForm createPass = new CreatePasswordForm();
            createPass.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {           
            this.Close();
            Application.Restart();
            //Environment.Exit(0);
        }
    }
}
