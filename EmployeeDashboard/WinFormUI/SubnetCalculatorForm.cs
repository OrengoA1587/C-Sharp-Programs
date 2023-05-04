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

           
             CalculateSubBits();
        }

        private void CalculateHostsNeeded_Button_Click(object sender, EventArgs e)
        {
            CalculateBits();
             
        }
        private void CalculateBits()
        {
            try
            {
                string hostString = Regex.Replace(hosts_textBox.Text, @"[^0-9a-zA-Z]+", "");
                double hosts = double.Parse(hostString);
                double netBits = 0;
                double x = 0;
                double increment = 0;
                double hostbit = 0;
                for (double i = 0; i < hosts; i++)
                {
                    increment = Math.Pow(2, i);
                    hostbit = i - 1;
                    if (increment > hosts && hosts < Math.Pow(2, i + 1))
                    {
                        i = hosts;
                        hostbit++;
                        netBits = 32 - hostbit;
                        hostsNeededtextBox.Text = hostbit.ToString();//Dislay number of host bits
                                                                     //totalSubnets_textBox.Text = netBits.ToString();// Dislay number of network bits
                    }
                    else if (increment > hosts && hosts > Math.Pow(2, i - 1) || hosts == Math.Pow(2, i))
                    {
                        hostbit++; //Increment hostbits by 1 to calculate difference with netbits
                        i = hosts; //Stops loop when hosts number reaches disired number
                        netBits = 32 - hostbit;
                        hostsNeededtextBox.Text = hostbit.ToString();//Display number of hostbits
                                                                     //totalSubnets_textBox.Text = netBits.ToString();//Dislay number of network bits
                    }
                }
            }
            catch
            {
                MessageBox.Show("Invalid Input!");
            }
            
            

            
        }
        private void CalculateSubBits()
        {

            try
            {
                string hostString = Regex.Replace(subBits_textBox.Text, @"[^0-9a-zA-Z]+", "");
                double hosts = double.Parse(hostString);
                double netBits = 0;
                double x = 0;
                double increment = 0;
                double hostbit = 0;
                for (double i = 0; i < hosts; i++)
                {
                    increment = Math.Pow(2, i);
                    hostbit = i - 1;
                    if (increment > hosts && hosts < Math.Pow(2, i + 1))
                    {
                        i = hosts;
                        hostbit++;
                        netBits = 32 - hostbit;
                        subnet_textBox.Text = hostbit.ToString();//Dislay number of subnet bits
                                                                 //totalSubnets_textBox.Text = netBits.ToString();// Dislay number of network bits
                    }
                    else if (increment > hosts && hosts > Math.Pow(2, i - 1) || hosts == Math.Pow(2, i))
                    {
                        hostbit++; //Increment hostbits by 1 to calculate difference with netbits
                        i = hosts; //Stops loop when hosts number reaches disired number
                        netBits = 32 - hostbit;
                        subnet_textBox.Text = hostbit.ToString();//Display number of hostbits
                                                                 //totalSubnets_textBox.Text = netBits.ToString();//Dislay number of network bits
                    }
                }
            }
            catch
            {
                MessageBox.Show("Invalid Input!");
            }
            
        }

        
    }
}
