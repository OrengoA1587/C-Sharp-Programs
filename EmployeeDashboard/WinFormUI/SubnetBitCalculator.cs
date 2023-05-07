using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormUI
{
    public partial class SubnetBitCalculator : Form
    {
        public SubnetBitCalculator()
        {
            InitializeComponent();
        }

        private void calculateSubnets_button_Click(object sender, EventArgs e)
        {
            string splitSubits = Regex.Replace(networkBits_textBox.Text, @"[^0-9a-zA-Z]+", "");
            int subnetBits = int.Parse(splitSubits);
            if(subnetBits >= 0 && subnetBits <= 32) 
            {
                totalSubnets_textBox.Text = Math.Pow(2, subnetBits).ToString("#,##0");
            }
            else
            {
                MessageBox.Show("Invlaid input! Network bits must be greater than 0 and less or equal to 32.");
            }    
        }
        

        private void calculateSubnets_button_MouseHover(object sender, EventArgs e)
        {
            calculateSubnets_button.BackgroundImage = Properties.Resources.Orange_image;
        }

        private void calculateSubnets_button_MouseLeave(object sender, EventArgs e)
        {
            calculateSubnets_button.BackgroundImage = Properties.Resources.Untitled_design_15_;
        }
    }
}
