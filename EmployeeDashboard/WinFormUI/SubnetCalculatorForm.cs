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
    public partial class SubnetCalculatorForm : Form
    {
        public SubnetCalculatorForm()
        {
            InitializeComponent();
        }

        private void CalculatorButton_Click(object sender, EventArgs e)
        {
            
            string convertString = Regex.Replace(hostBits_textBox.Text, @"[^0-9a-zA-Z]+", "");
            int hostBits = int.Parse(convertString);

            double netBits = 0;
            double usableHostBits = 0;
            if(hostBits <= 32)
            {
                netBits = 32 - hostBits;
                 
                subnet_textBox.Text = (Math.Pow(2, netBits).ToString("#,##0"));
            }
            else
            {
                MessageBox.Show("Invalid Input!\n\nHost Bits can not exceed 32 bits!");
            } 
             
        }

        private void CalculateHostsNeeded_Button_Click(object sender, EventArgs e)
        {   
            string hostString = Regex.Replace(hosts_textBox.Text, @"[^0-9a-zA-Z]+", "");
             
            double hosts = double.Parse(hostString);
            double netBits = 0;
            double x = 0;
            double increment = 0;
            double hostbit = 0;
            for (double i = 0; i < hosts;i++)

            {
                 
                increment = Math.Pow(2, i);
                hostbit = i -1;
                 
                if (increment > hosts)
                {
                    i = hosts;
                    netBits = 32 - hostbit;
                    hostsNeededtextBox.Text = hostbit.ToString();
                    totalSubnets_textBox.Text = netBits.ToString();
                }
            }
             
        }
    }
}
