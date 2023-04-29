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
    public partial class SubnetCalculatorForm : Form
    {
        public SubnetCalculatorForm()
        {
            InitializeComponent();
        }

        private void CalculatorButton_Click(object sender, EventArgs e)
        {
            int hostBits = int.Parse(hostBits_textBox.Text);

            double netBits = 0;
            double usableHostBits = 0;

            netBits = 32 - hostBits;

            subnet_textBox.Text = (Math.Pow(2,netBits).ToString("#,##0,00"));
             
        }

        private void CalculateHostsNeeded_Button_Click(object sender, EventArgs e)
        {
            int hosts = int.Parse(hosts_textBox.Text);
            double x = 0;
            double increment = 0;
            int hostbit = 0;
            for (int i = 0; i < hosts;i++)

            {
                 
                increment = Math.Pow(2, i);
                hostbit = i;
                 
                if (increment > (int.Parse(hosts_textBox.Text)))
                {
                    i = hosts;
                    hostsNeededtextBox.Text = hostbit.ToString();
                }
            }
             
        }
    }
}
