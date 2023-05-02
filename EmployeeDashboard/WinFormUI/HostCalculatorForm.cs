using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
namespace WinFormUI
{
    public partial class HostCalculatorForm : Form
    {
        public HostCalculatorForm()
        {
            InitializeComponent();
        }

        private void submit_Click(object sender, EventArgs e)
        {
            
            string convertNetBits = Regex.Replace(networkBits_textBox.Text, @"[^0-9a-zA-Z]+", "");
            int netBits = int.Parse(convertNetBits);

            double hostBits = 0;
            double usableHostBits = 0;

            if(netBits < 32 && netBits > 0)
            {
                hostBits = 32 - netBits;

                host_textBox.Text = (Math.Pow(2, hostBits).ToString("#,##0,00"));
                usableHost_textBox.Text = (Math.Pow(2, hostBits) - 2).ToString("#,##0,00");
            }
            else
            {
                MessageBox.Show("Invalid Input!\n\nNetwork bits must be greater than 0 and less than 32!");
            }
        }
    }
}
