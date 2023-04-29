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
    public partial class EmployeeDashboard_Form : Form
    {
        public EmployeeDashboard_Form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SubnetForm subForm = new SubnetForm();
            subForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            HostCalculatorForm hostForm = new HostCalculatorForm();
            hostForm.Show();
        }

        private void SubnetCalculatorButton_Click(object sender, EventArgs e)
        {

        }
    }
}
