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
    public partial class HostCalculatorForm : Form
    {
        public HostCalculatorForm()
        {
            InitializeComponent();
        }

        private void submit_Click(object sender, EventArgs e)
        {
            int netBits = int.Parse(networkBits_textBox.Text);

            double hostBits = 0;
            double usableHostBits = 0;

            hostBits = 32 - netBits;
            
            host_textBox.Text = (Math.Pow(2, hostBits).ToString("#,##0,00"));
            usableHost_textBox.Text = (Math.Pow(2, hostBits)-2).ToString("#,##0,00");
        }
    }
}
