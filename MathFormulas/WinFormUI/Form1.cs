using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void slopebutton1_Click(object sender, EventArgs e)
        {

        }

        private void areaCircle_button_Click(object sender, EventArgs e)
        {
            AreaOfCircle ACForm = new AreaOfCircle(); // Instantiate a Form3 object.
            ACForm.Show(); // Show Area of Circle Form
        }

        private void areaTriangle_button_Click(object sender, EventArgs e)
        {

        }

        private void area_SquRec_button_Click(object sender, EventArgs e)
        {
            AreaRecSquare ACForm = new AreaRecSquare(); // Instantiate a Form3 object.
            ACForm.Show(); // Show Area of RecSquare Form
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void createAccountToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CreateUserForm userForm = new CreateUserForm();
            userForm.Show();
        }
    }
}
