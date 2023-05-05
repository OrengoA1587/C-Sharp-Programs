using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace WinFormUI
{
    public partial class SubnetForm : Form
    {
        public SubnetForm()
        {
            InitializeComponent();
            subnetNumber_textBox.Text = "1";
        }
        private void submit_button_Click(object sender, EventArgs e)
        {
            

            
            try
            {
                int oct1 = int.Parse(oct_one.Text);
                int oct2 = int.Parse(oct_two.Text);
                int oct3 = int.Parse(oct_three.Text);
                int oct4 = int.Parse(oct_four.Text);
                int cidr = int.Parse(cidrNotat.Text);

                int keyNum = GetCidr(cidr);
                subnetNumber_textBox.Text = "1";
                if (oct_one.Text.Length <= 3 && oct_one.Text.Length >= 0 && oct_two.Text.Length <= 3 && oct_two.Text.Length >= 0
                    && oct_three.Text.Length <= 3 && oct_three.Text.Length >= 0 && oct_four.Text.Length <= 3 && oct_four.Text.Length >= 0)
                {
                    
                    GetNetAddress(cidr, oct1, oct2, oct3, oct4);
                }
                else
                {
                    MessageBox.Show("Invalid Input!\n\nThe octet number length must not exceed 3 digits!");
                }                    

            }
            catch
            {
                //MessageBox.Show("Invalid Input!");
            }

        }

        private int GetCidr(int cidr)
        {

            if (cidr == 1 || cidr == 9 || cidr == 17 || cidr == 25)
            {
                cidr = 128;
            }
            return cidr;
        }
        private void GetNetAddress(int cidr, int oct1, int oct2, int oct3, int oct4)
        {
             
            GetIncrement(cidr, oct1, oct2, oct3, oct4);
        }
        private void GetIncrement(int cidr, int oct1, int oct2, int oct3, int oct4)
        {

             
            if (cidr == 1 || cidr == 9 || cidr == 17 || cidr == 25)
            {
                
                int incrementNum = 128;
                if (cidr == 1)
                {
                    int octetNum = 0;
                    octetNum = GetNum.GetNetAddress(incrementNum, oct1);
                    interval_textBox.Text = incrementNum.ToString();
                    octet_textBox.Text = "1";
                    networkAddress_textBox.Text = $"{octetNum}.0.0.0";
                    firstUseable_textBox.Text = $"{octetNum}.0.0.1";
                    lastUseable_textBox.Text = $"{(octetNum + incrementNum)-1}.255.255.254";
                    broadcastAddress_textBox.Text = $"{(octetNum + incrementNum) - 1}.255.255.255";  
                    if(octetNum + incrementNum > 255)
                    {
                        nextAddress_textBox.Text = $"Limit";
                    }
                    else
                    {
                        nextAddress_textBox.Text = $"{(octetNum + incrementNum)}.0.0.0";
                    }
                     
                }
                if (cidr == 9)
                {
                    
                     
                    int octetNum = 0;
                    octetNum = GetNum.GetNetAddress(incrementNum, oct2);
                    interval_textBox.Text = octetNum.ToString();
                    interval_textBox.Text = incrementNum.ToString();
                    octet_textBox.Text = "2";
                    networkAddress_textBox.Text = $"{oct1}.{octetNum}.0.0";
                    firstUseable_textBox.Text = $"{oct1}.{octetNum}.0.1";
                    lastUseable_textBox.Text = $"{oct1}.{(octetNum + incrementNum) - 1}.255.254";
                    broadcastAddress_textBox.Text = $"{oct1}.{(octetNum + incrementNum) - 1}.255.255";
                    if (broadcastAddress_textBox.Text == "255.255.255.255")
                    {
                        nextAddress_textBox.Text = $"Limit";
                    }
                    else if (octetNum + incrementNum > 255 && oct1 < 255)
                    {

                        nextAddress_textBox.Text = $"{oct1 + 1}.0.0.0";
                    }
                    else
                    {
                        nextAddress_textBox.Text = $"{oct1}.{(octetNum + incrementNum)}.0.0";
                    }
                }
                if (cidr == 17)
                {
                    int octetNum = 0;
                    octetNum = GetNum.GetNetAddress(incrementNum, oct3);
                    interval_textBox.Text = octetNum.ToString();
                    interval_textBox.Text = incrementNum.ToString();
                    octet_textBox.Text = "3";
                    networkAddress_textBox.Text = $"{oct1}.{oct2}.{octetNum}.0";
                    firstUseable_textBox.Text = $"{oct1}.{oct2}.{octetNum}.1";
                    lastUseable_textBox.Text = $"{oct1}.{oct2}.{(octetNum + incrementNum) - 1}.254";
                    broadcastAddress_textBox.Text = $"{oct1}.{oct2}.{(octetNum + incrementNum) - 1}.255";
                    if (broadcastAddress_textBox.Text == "255.255.255.255")
                    {
                        nextAddress_textBox.Text = $"Limit";
                    }
                    else if (octetNum + incrementNum > 255 && oct2 < 255)
                    {

                        nextAddress_textBox.Text = $"{oct1}.{oct2 + 1}.0.0";
                    }
                    else if (octetNum + incrementNum > 255 && oct2 < 255 && oct2 < 255)
                    {

                        nextAddress_textBox.Text = $"{oct1}.{oct2 + 1}.0.0";
                    }
                    else if (octetNum + incrementNum > 255 && oct2 >= 255 && oct2 < 255)
                    {

                        nextAddress_textBox.Text = $"{oct1 + 1}.0.0.0";
                    }
                    else
                    {
                        nextAddress_textBox.Text = $"{oct1}.{oct2}.{(octetNum + incrementNum)}.0";
                    }
                }
                if (cidr == 25)
                {
                    int octetNum = 0;
                    octetNum = GetNum.GetNetAddress(incrementNum, oct4);
                    interval_textBox.Text = octetNum.ToString();
                    interval_textBox.Text = incrementNum.ToString();
                    octet_textBox.Text = "4";
                    networkAddress_textBox.Text = $"{oct1}.{oct2}.{oct3}.{octetNum}";
                    firstUseable_textBox.Text = $"{oct1}.{oct2}.{oct3}.{octetNum + 1}";
                    lastUseable_textBox.Text = $"{oct1}.{oct2}.{oct3}.{(octetNum + incrementNum) - 2}";
                    broadcastAddress_textBox.Text = $"{oct1}.{oct2}.{oct3}.{(octetNum + incrementNum) - 1}";
                    if (octetNum + incrementNum > 255 && oct1 >= 255 && oct2 >= 255 && oct3 >= 255)
                    {
                        nextAddress_textBox.Text = $"Limit";
                    }
                    else if (octetNum + incrementNum > 255 && oct3 < 255)
                    {

                        nextAddress_textBox.Text = $"{oct1}.{oct2}.{oct3 + 1}.0";
                    }
                    else if (octetNum + incrementNum > 255 && oct3 >= 255 && oct2 < 255)
                    {

                        nextAddress_textBox.Text = $"{oct1}.{oct2 + 1}.0.0";
                    }
                    else if (octetNum + incrementNum > 255 && oct2 >= 255 && oct3 >= 255)
                    {

                        nextAddress_textBox.Text = $"{oct1 + 1}.0.0.0";
                    }
                    else
                    {
                        nextAddress_textBox.Text = $"{oct1}.{oct2}.{oct3}.{(octetNum + incrementNum)}";
                    }
                }

            }
            if (cidr == 2 || cidr == 10 || cidr == 18 || cidr == 26)
            {
                int incrementNum = 64;
                if (cidr == 2)
                {
                    int octetNum = 0;
                    octetNum = GetNum.GetNetAddress(incrementNum, oct1);
                    interval_textBox.Text = incrementNum.ToString();
                    octet_textBox.Text = "1";
                    networkAddress_textBox.Text = $"{octetNum}.0.0.0";
                    firstUseable_textBox.Text = $"{octetNum}.0.0.1";
                    lastUseable_textBox.Text = $"{(octetNum + incrementNum) - 1}.255.255.254";
                    broadcastAddress_textBox.Text = $"{(octetNum + incrementNum) - 1}.255.255.255";
                    if (octetNum + incrementNum > 255)
                    {
                        nextAddress_textBox.Text = $"Limit";
                    }
                    else
                    {
                        nextAddress_textBox.Text = $"{(octetNum + incrementNum)}.0.0.0";
                    }
                }
                if (cidr == 10)
                {
                    int octetNum = 0;
                    octetNum = GetNum.GetNetAddress(incrementNum, oct2);
                    interval_textBox.Text = incrementNum.ToString();
                    octet_textBox.Text = "2";
                    networkAddress_textBox.Text = $"{oct1}.{octetNum}.0.0";
                    firstUseable_textBox.Text = $"{oct1}.{octetNum}.0.1";
                    lastUseable_textBox.Text = $"{oct1}.{(octetNum + incrementNum) - 1}.255.254";
                    broadcastAddress_textBox.Text = $"{oct1}.{(octetNum + incrementNum) - 1}.255.255";
                    if (broadcastAddress_textBox.Text == "255.255.255.255")
                    {
                        nextAddress_textBox.Text = $"Limit";
                    }
                    else if (octetNum + incrementNum > 255 && oct1 < 255)
                    {

                        nextAddress_textBox.Text = $"{oct1 + 1}.0.0.0";
                    }
                    else
                    {
                        nextAddress_textBox.Text = $"{oct1}.{(octetNum + incrementNum)}.0.0";
                    }
                }
                if (cidr == 18)
                {
                    int octetNum = 0;
                    octetNum = GetNum.GetNetAddress(incrementNum, oct3);
                    interval_textBox.Text = incrementNum.ToString();
                    octet_textBox.Text = "3";
                    networkAddress_textBox.Text = $"{oct_one.Text}.{oct_two.Text}.{octetNum}.0";
                    firstUseable_textBox.Text = $"{oct_one.Text}.{oct_two.Text}.{octetNum}.1";
                    lastUseable_textBox.Text = $"{oct_one.Text}.{oct_two.Text}.{(octetNum + incrementNum) - 1}.254";
                    broadcastAddress_textBox.Text = $"{oct_one.Text}.{oct_two.Text}.{(octetNum + incrementNum) - 1}.255";
                    if (octetNum + incrementNum > 255 && oct1 >= 255 && oct2 >= 255)
                    {
                        nextAddress_textBox.Text = $"Limit";
                    }
                    else if (octetNum + incrementNum > 255 && oct2 < 255)
                    {

                        nextAddress_textBox.Text = $"{oct1}.{oct2 + 1}.0.0";
                    }
                    else if (octetNum + incrementNum > 255 && oct2 < 255 && oct2 < 255)
                    {

                        nextAddress_textBox.Text = $"{oct1}.{oct2 + 1}.0.0";
                    }
                    else if (octetNum + incrementNum > 255 && oct2 >= 255 && oct2 < 255)
                    {

                        nextAddress_textBox.Text = $"{oct1 + 1}.0.0.0";
                    }
                    else
                    {
                        nextAddress_textBox.Text = $"{oct1}.{oct2}.{(octetNum + incrementNum)}.0";
                    }
                }
                if (cidr == 26)
                {
                    int octetNum = 0;
                    octetNum = GetNum.GetNetAddress(incrementNum, oct4);
                    interval_textBox.Text = incrementNum.ToString();
                    octet_textBox.Text = "4";
                    networkAddress_textBox.Text = $"{oct_one.Text}.{oct_two.Text}.{oct_three.Text}.{octetNum}";
                    firstUseable_textBox.Text = $"{oct_one.Text}.{oct_two.Text}.{oct_three.Text}.{octetNum + 1}";
                    lastUseable_textBox.Text = $"{oct_one.Text}.{oct_two.Text}.{oct_three.Text}.{(octetNum + incrementNum) - 2}";
                    broadcastAddress_textBox.Text = $"{oct_one.Text}.{oct_two.Text}.{oct_three.Text}.{(octetNum + incrementNum) - 1}";
                    if (octetNum + incrementNum > 255 && oct1 >= 255 && oct2 >= 255 && oct3 >= 255)
                    {
                        nextAddress_textBox.Text = $"Limit";
                    }
                    else if (octetNum + incrementNum > 255 && oct3 < 255)
                    {

                        nextAddress_textBox.Text = $"{oct1}.{oct2}.{oct3 + 1}.0";
                    }
                    else if (octetNum + incrementNum > 255 && oct3 >= 255 && oct2 < 255)
                    {

                        nextAddress_textBox.Text = $"{oct1}.{oct2 + 1}.0.0";
                    }
                    else if (octetNum + incrementNum > 255 && oct2 >= 255 && oct3 >= 255)
                    {

                        nextAddress_textBox.Text = $"{oct1 + 1}.0.0.0";
                    }
                    else
                    {
                        nextAddress_textBox.Text = $"{oct1}.{oct2}.{oct3}.{(octetNum + incrementNum)}";
                    }
                }
            }


            if (cidr == 3 || cidr == 11 || cidr == 19 || cidr == 27)
            {
                int incrementNum = 32;
                if (cidr == 3)
                {
                    int octetNum = 0;
                    octetNum = GetNum.GetNetAddress(incrementNum, oct1);
                    interval_textBox.Text = incrementNum.ToString();
                    octet_textBox.Text = "1";
                    networkAddress_textBox.Text = $"{octetNum}.0.0.0";
                    firstUseable_textBox.Text = $"{octetNum}.0.0.1";
                    lastUseable_textBox.Text = $"{(octetNum + incrementNum) - 1}.255.255.254";
                    broadcastAddress_textBox.Text = $"{(octetNum + incrementNum) - 1}.255.255.255";
                    if (octetNum + incrementNum > 255)
                    {
                        nextAddress_textBox.Text = $"Limit";
                    }
                    else
                    {
                        nextAddress_textBox.Text = $"{(octetNum + incrementNum)}.0.0.0";
                    }
                }
                if (cidr == 11)
                {
                    int octetNum = 0;
                    octetNum = GetNum.GetNetAddress(incrementNum, oct2);
                    interval_textBox.Text = incrementNum.ToString();
                    octet_textBox.Text = "2";
                    networkAddress_textBox.Text = $"{oct1}.{octetNum}.0.0";
                    firstUseable_textBox.Text = $"{oct1}.{octetNum}.0.1";
                    lastUseable_textBox.Text = $"{oct1}.{(octetNum + incrementNum) - 1}.255.254";
                    broadcastAddress_textBox.Text = $"{oct1}.{(octetNum + incrementNum) - 1}.255.255";
                    if (broadcastAddress_textBox.Text == "255.255.255.255")
                    {
                        nextAddress_textBox.Text = $"Limit";
                    }
                    else if (octetNum + incrementNum > 255 && oct1 < 255)
                    {

                        nextAddress_textBox.Text = $"{oct1 + 1}.0.0.0";
                    }
                    else
                    {
                        nextAddress_textBox.Text = $"{oct1}.{(octetNum + incrementNum)}.0.0";
                    }
                }
                if (cidr == 19)
                {
                    int octetNum = 0;
                    octetNum = GetNum.GetNetAddress(incrementNum, oct3);
                    interval_textBox.Text = incrementNum.ToString();
                    octet_textBox.Text = "3";
                    networkAddress_textBox.Text = $"{oct_one.Text}.{oct_two.Text}.{octetNum}.0";
                    firstUseable_textBox.Text = $"{oct_one.Text}.{oct_two.Text}.{octetNum}.1";
                    lastUseable_textBox.Text = $"{oct_one.Text}.{oct_two.Text}.{(octetNum + incrementNum) - 1}.254";
                    broadcastAddress_textBox.Text = $"{oct_one.Text}.{oct_two.Text}.{(octetNum + incrementNum) - 1}.255";
                    if (octetNum + incrementNum > 255 && oct1 >= 255 && oct2 >= 255)
                    {
                        nextAddress_textBox.Text = $"Limit";
                    }
                    else if (octetNum + incrementNum > 255 && oct2 < 255)
                    {

                        nextAddress_textBox.Text = $"{oct1}.{oct2 + 1}.0.0";
                    }
                    else if (octetNum + incrementNum > 255 && oct2 < 255 && oct2 < 255)
                    {

                        nextAddress_textBox.Text = $"{oct1}.{oct2 + 1}.0.0";
                    }
                    else if (octetNum + incrementNum > 255 && oct2 >= 255 && oct2 < 255)
                    {

                        nextAddress_textBox.Text = $"{oct1 + 1}.0.0.0";
                    }
                    else
                    {
                        nextAddress_textBox.Text = $"{oct1}.{oct2}.{(octetNum + incrementNum)}.0";
                    }
                }
                if (cidr == 27)
                {
                    int octetNum = 0;
                    octetNum = GetNum.GetNetAddress(incrementNum, oct4);
                    interval_textBox.Text = incrementNum.ToString();
                    octet_textBox.Text = "4";
                    networkAddress_textBox.Text = $"{oct_one.Text}.{oct_two.Text}.{oct_three.Text}.{octetNum}";
                    firstUseable_textBox.Text = $"{oct_one.Text}.{oct_two.Text}.{oct_three.Text}.{octetNum + 1}";
                    lastUseable_textBox.Text = $"{oct_one.Text}.{oct_two.Text}.{oct_three.Text}.{(octetNum + incrementNum) - 2}";
                    broadcastAddress_textBox.Text = $"{oct_one.Text}.{oct_two.Text}.{oct_three.Text}.{(octetNum + incrementNum) - 1}";
                    if (octetNum + incrementNum > 255 && oct1 >= 255 && oct2 >= 255 && oct3 >= 255)
                    {
                        nextAddress_textBox.Text = $"Limit";
                    }
                    else if (octetNum + incrementNum > 255 && oct3 < 255)
                    {

                        nextAddress_textBox.Text = $"{oct1}.{oct2}.{oct3 + 1}.0";
                    }
                    else if (octetNum + incrementNum > 255 && oct3 >= 255 && oct2 < 255)
                    {

                        nextAddress_textBox.Text = $"{oct1}.{oct2 + 1}.0.0";
                    }
                    else if (octetNum + incrementNum > 255 && oct2 >= 255 && oct3 >= 255)
                    {

                        nextAddress_textBox.Text = $"{oct1 + 1}.0.0.0";
                    }
                    else
                    {
                        nextAddress_textBox.Text = $"{oct1}.{oct2}.{oct3}.{(octetNum + incrementNum)}";
                    }
                }
            }
            if (cidr == 4 || cidr == 12 || cidr == 20 || cidr == 28)
            {
                int incrementNum = 16;
                if (cidr == 4)
                {
                    int octetNum = 0;
                    octetNum = GetNum.GetNetAddress(incrementNum, oct1);
                    interval_textBox.Text = incrementNum.ToString();
                    octet_textBox.Text = "1";
                    networkAddress_textBox.Text = $"{octetNum}.0.0.0";
                    firstUseable_textBox.Text = $"{octetNum}.0.0.1";
                    lastUseable_textBox.Text = $"{(octetNum + incrementNum) - 1}.255.255.254";
                    broadcastAddress_textBox.Text = $"{(octetNum + incrementNum) - 1}.255.255.255";
                    if (octetNum + incrementNum > 255)
                    {
                        nextAddress_textBox.Text = $"Limit";
                    }
                    else
                    {
                        nextAddress_textBox.Text = $"{(octetNum + incrementNum)}.0.0.0";
                    }
                }
                if (cidr == 12)
                {
                    int octetNum = 0;
                    octetNum = GetNum.GetNetAddress(incrementNum, oct2);
                    interval_textBox.Text = incrementNum.ToString();
                    octet_textBox.Text = "2";
                    networkAddress_textBox.Text = $"{oct1}.{octetNum}.0.0";
                    firstUseable_textBox.Text = $"{oct1}.{octetNum}.0.1";
                    lastUseable_textBox.Text = $"{oct1}.{(octetNum + incrementNum) - 1}.255.254";
                    broadcastAddress_textBox.Text = $"{oct1}.{(octetNum + incrementNum) - 1}.255.255";
                    if (broadcastAddress_textBox.Text == "255.255.255.255")
                    {
                        nextAddress_textBox.Text = $"Limit";
                    }
                    else if (octetNum + incrementNum > 255 && oct1 < 255)
                    {

                        nextAddress_textBox.Text = $"{oct1 + 1}.0.0.0";
                    }
                    else
                    {
                        nextAddress_textBox.Text = $"{oct1}.{(octetNum + incrementNum)}.0.0";
                    }
                }
                if (cidr == 20)
                {
                    int octetNum = 0;
                    octetNum = GetNum.GetNetAddress(incrementNum, oct3);
                    interval_textBox.Text = incrementNum.ToString();
                    octet_textBox.Text = "3";
                    networkAddress_textBox.Text = $"{oct_one.Text}.{oct_two.Text}.{octetNum}.0";
                    firstUseable_textBox.Text = $"{oct_one.Text}.{oct_two.Text}.{octetNum}.1";
                    lastUseable_textBox.Text = $"{oct_one.Text}.{oct_two.Text}.{(octetNum + incrementNum) - 1}.254";
                    broadcastAddress_textBox.Text = $"{oct_one.Text}.{oct_two.Text}.{(octetNum + incrementNum) - 1}.255";
                    if (octetNum + incrementNum > 255 && oct1 >= 255 && oct2 >= 255)
                    {
                        nextAddress_textBox.Text = $"Limit";
                    }
                    else if (octetNum + incrementNum > 255 && oct2 < 255)
                    {

                        nextAddress_textBox.Text = $"{oct1}.{oct2 + 1}.0.0";
                    }
                    else if (octetNum + incrementNum > 255 && oct2 < 255 && oct2 < 255)
                    {

                        nextAddress_textBox.Text = $"{oct1}.{oct2 + 1}.0.0";
                    }
                    else if (octetNum + incrementNum > 255 && oct2 >= 255 && oct2 < 255)
                    {

                        nextAddress_textBox.Text = $"{oct1 + 1}.0.0.0";
                    }
                    else
                    {
                        nextAddress_textBox.Text = $"{oct1}.{oct2}.{(octetNum + incrementNum)}.0";
                    }
                }
                if (cidr == 28)
                {
                    int octetNum = 0;
                    octetNum = GetNum.GetNetAddress(incrementNum, oct4);
                    interval_textBox.Text = incrementNum.ToString();
                    octet_textBox.Text = "4";
                    networkAddress_textBox.Text = $"{oct_one.Text}.{oct_two.Text}.{oct_three.Text}.{octetNum}";
                    firstUseable_textBox.Text = $"{oct_one.Text}.{oct_two.Text}.{oct_three.Text}.{octetNum + 1}";
                    lastUseable_textBox.Text = $"{oct_one.Text}.{oct_two.Text}.{oct_three.Text}.{(octetNum + incrementNum) - 2}";
                    broadcastAddress_textBox.Text = $"{oct_one.Text}.{oct_two.Text}.{oct_three.Text}.{(octetNum + incrementNum) - 1}";
                    if (octetNum + incrementNum > 255 && oct1 >= 255 && oct2 >= 255 && oct3 >= 255)
                    {
                        nextAddress_textBox.Text = $"Limit";
                    }
                    else if (octetNum + incrementNum > 255 && oct3 < 255)
                    {

                        nextAddress_textBox.Text = $"{oct1}.{oct2}.{oct3 + 1}.0";
                    }
                    else if (octetNum + incrementNum > 255 && oct3 >= 255 && oct2 < 255)
                    {

                        nextAddress_textBox.Text = $"{oct1}.{oct2 + 1}.0.0";
                    }
                    else if (octetNum + incrementNum > 255 && oct2 >= 255 && oct3 >= 255)
                    {

                        nextAddress_textBox.Text = $"{oct1 + 1}.0.0.0";
                    }
                    else
                    {
                        nextAddress_textBox.Text = $"{oct1}.{oct2}.{oct3}.{(octetNum + incrementNum)}";
                    }
                }
            }
            if (cidr == 5 || cidr == 13 || cidr == 21 || cidr == 29)
            {
                int incrementNum = 8;
                if (cidr == 5)
                {
                    int octetNum = 0;
                    octetNum = GetNum.GetNetAddress(incrementNum, oct1);
                    interval_textBox.Text = incrementNum.ToString();
                    octet_textBox.Text = "1";
                    networkAddress_textBox.Text = $"{octetNum}.0.0.0";
                    firstUseable_textBox.Text = $"{octetNum}.0.0.1";
                    lastUseable_textBox.Text = $"{(octetNum + incrementNum) - 1}.255.255.254";
                    broadcastAddress_textBox.Text = $"{(octetNum + incrementNum) - 1}.255.255.255";
                    if (octetNum + incrementNum > 255)
                    {
                        nextAddress_textBox.Text = $"Limit";
                    }
                    else
                    {
                        nextAddress_textBox.Text = $"{(octetNum + incrementNum)}.0.0.0";
                    }
                }
                if (cidr == 13)
                {
                    int octetNum = 0;
                    octetNum = GetNum.GetNetAddress(incrementNum, oct2);
                    interval_textBox.Text = incrementNum.ToString();
                    octet_textBox.Text = "2";
                    networkAddress_textBox.Text = $"{oct1}.{octetNum}.0.0";
                    firstUseable_textBox.Text = $"{oct1}.{octetNum}.0.1";
                    lastUseable_textBox.Text = $"{oct1}.{(octetNum + incrementNum) - 1}.255.254";
                    broadcastAddress_textBox.Text = $"{oct1}.{(octetNum + incrementNum) - 1}.255.255";
                    if (broadcastAddress_textBox.Text == "255.255.255.255")
                    {
                        nextAddress_textBox.Text = $"Limit";
                    }
                    else if (octetNum + incrementNum > 255 && oct1 < 255)
                    {

                        nextAddress_textBox.Text = $"{oct1 + 1}.0.0.0";
                    }
                    else
                    {
                        nextAddress_textBox.Text = $"{oct1}.{(octetNum + incrementNum)}.0.0";
                    }
                }
                if (cidr == 21)
                {
                    int octetNum = 0;
                    octetNum = GetNum.GetNetAddress(incrementNum, oct3);
                    interval_textBox.Text = incrementNum.ToString();
                    octet_textBox.Text = "3";
                    networkAddress_textBox.Text = $"{oct_one.Text}.{oct_two.Text}.{octetNum}.0";
                    firstUseable_textBox.Text = $"{oct_one.Text}.{oct_two.Text}.{octetNum}.1";
                    lastUseable_textBox.Text = $"{oct_one.Text}.{oct_two.Text}.{(octetNum + incrementNum) - 1}.254";
                    broadcastAddress_textBox.Text = $"{oct_one.Text}.{oct_two.Text}.{(octetNum + incrementNum) - 1}.255";
                    if (octetNum + incrementNum > 255 && oct1 >= 255 && oct2 >= 255)
                    {
                        nextAddress_textBox.Text = $"Limit";
                    }
                    else if (octetNum + incrementNum > 255 && oct2 < 255)
                    {

                        nextAddress_textBox.Text = $"{oct1}.{oct2 + 1}.0.0";
                    }
                    else if (octetNum + incrementNum > 255 && oct2 < 255 && oct2 < 255)
                    {

                        nextAddress_textBox.Text = $"{oct1}.{oct2 + 1}.0.0";
                    }
                    else if (octetNum + incrementNum > 255 && oct2 >= 255 && oct2 < 255)
                    {

                        nextAddress_textBox.Text = $"{oct1 + 1}.0.0.0";
                    }
                    else
                    {
                        nextAddress_textBox.Text = $"{oct1}.{oct2}.{(octetNum + incrementNum)}.0";
                    }
                }
                if (cidr == 29)
                {
                    int octetNum = 0;
                    octetNum = GetNum.GetNetAddress(incrementNum, oct4);
                    interval_textBox.Text = incrementNum.ToString();
                    octet_textBox.Text = "4";
                    networkAddress_textBox.Text = $"{oct_one.Text}.{oct_two.Text}.{oct_three.Text}.{octetNum}";
                    firstUseable_textBox.Text = $"{oct_one.Text}.{oct_two.Text}.{oct_three.Text}.{octetNum + 1}";
                    lastUseable_textBox.Text = $"{oct_one.Text}.{oct_two.Text}.{oct_three.Text}.{(octetNum + incrementNum) - 2}";
                    broadcastAddress_textBox.Text = $"{oct_one.Text}.{oct_two.Text}.{oct_three.Text}.{(octetNum + incrementNum) - 1}";
                    if (octetNum + incrementNum > 255 && oct1 >= 255 && oct2 >= 255 && oct3 >= 255)
                    {
                        nextAddress_textBox.Text = $"Limit";
                    }
                    else if (octetNum + incrementNum > 255 && oct3 < 255)
                    {

                        nextAddress_textBox.Text = $"{oct1}.{oct2}.{oct3 + 1}.0";
                    }
                    else if (octetNum + incrementNum > 255 && oct3 >= 255 && oct2 < 255)
                    {

                        nextAddress_textBox.Text = $"{oct1}.{oct2 + 1}.0.0";
                    }
                    else if (octetNum + incrementNum > 255 && oct2 >= 255 && oct3 >= 255)
                    {

                        nextAddress_textBox.Text = $"{oct1 + 1}.0.0.0";
                    }
                    else
                    {
                        nextAddress_textBox.Text = $"{oct1}.{oct2}.{oct3}.{(octetNum + incrementNum)}";
                    }
                }
            }
            if (cidr == 6 || cidr == 14 || cidr == 22 || cidr == 30)
            {
                int incrementNum = 4;
                if (cidr == 6)
                {
                    int octetNum = 0;
                    octetNum = GetNum.GetNetAddress(incrementNum, oct1);
                    interval_textBox.Text = incrementNum.ToString();
                    octet_textBox.Text = "1";
                    networkAddress_textBox.Text = $"{octetNum}.0.0.0";
                    firstUseable_textBox.Text = $"{octetNum}.0.0.1";
                    lastUseable_textBox.Text = $"{(octetNum + incrementNum) - 1}.255.255.254";
                    broadcastAddress_textBox.Text = $"{(octetNum + incrementNum) - 1}.255.255.255";
                    if (octetNum + incrementNum > 255)
                    {
                        nextAddress_textBox.Text = $"Limit";
                    }
                    else
                    {
                        nextAddress_textBox.Text = $"{(octetNum + incrementNum)}.0.0.0";
                    }
                }
                if (cidr == 14)
                {
                    int octetNum = 0;
                    octetNum = GetNum.GetNetAddress(incrementNum, oct2);
                    interval_textBox.Text = incrementNum.ToString();
                    octet_textBox.Text = "2";
                    networkAddress_textBox.Text = $"{oct1}.{octetNum}.0.0";
                    firstUseable_textBox.Text = $"{oct1}.{octetNum}.0.1";
                    lastUseable_textBox.Text = $"{oct1}.{(octetNum + incrementNum) - 1}.255.254";
                    broadcastAddress_textBox.Text = $"{oct1}.{(octetNum + incrementNum) - 1}.255.255";
                    if (broadcastAddress_textBox.Text == "255.255.255.255")
                    {
                        nextAddress_textBox.Text = $"Limit";
                    }
                    else if (octetNum + incrementNum > 255 && oct1 < 255)
                    {

                        nextAddress_textBox.Text = $"{oct1 + 1}.0.0.0";
                    }
                    else
                    {
                        nextAddress_textBox.Text = $"{oct1}.{(octetNum + incrementNum)}.0.0";
                    }
                }
                if (cidr == 22)
                {
                    int octetNum = 0;
                    octetNum = GetNum.GetNetAddress(incrementNum, oct3);
                    interval_textBox.Text = incrementNum.ToString();
                    octet_textBox.Text = "3";
                    networkAddress_textBox.Text = $"{oct_one.Text}.{oct_two.Text}.{octetNum}.0";
                    firstUseable_textBox.Text = $"{oct_one.Text}.{oct_two.Text}.{octetNum}.1";
                    lastUseable_textBox.Text = $"{oct_one.Text}.{oct_two.Text}.{(octetNum + incrementNum) - 1}.254";
                    broadcastAddress_textBox.Text = $"{oct_one.Text}.{oct_two.Text}.{(octetNum + incrementNum) - 1}.255";
                    if (octetNum + incrementNum > 255 && oct1 >= 255 && oct2 >= 255)
                    {
                        nextAddress_textBox.Text = $"Limit";
                    }
                    else if (octetNum + incrementNum > 255 && oct2 < 255)
                    {

                        nextAddress_textBox.Text = $"{oct1}.{oct2 + 1}.0.0";
                    }
                    else if (octetNum + incrementNum > 255 && oct2 < 255 && oct2 < 255)
                    {

                        nextAddress_textBox.Text = $"{oct1}.{oct2 + 1}.0.0";
                    }
                    else if (octetNum + incrementNum > 255 && oct2 >= 255 && oct2 < 255)
                    {

                        nextAddress_textBox.Text = $"{oct1 + 1}.0.0.0";
                    }
                    else
                    {
                        nextAddress_textBox.Text = $"{oct1}.{oct2}.{(octetNum + incrementNum)}.0";
                    }
                }
                if (cidr == 30)
                {
                    int octetNum = 0;
                    octetNum = GetNum.GetNetAddress(incrementNum, oct4);
                    interval_textBox.Text = incrementNum.ToString();
                    octet_textBox.Text = "4";
                    networkAddress_textBox.Text = $"{oct_one.Text}.{oct_two.Text}.{oct_three.Text}.{octetNum}";
                    firstUseable_textBox.Text = $"{oct_one.Text}.{oct_two.Text}.{oct_three.Text}.{octetNum + 1}";
                    lastUseable_textBox.Text = $"{oct_one.Text}.{oct_two.Text}.{oct_three.Text}.{(octetNum + incrementNum) - 2}";
                    broadcastAddress_textBox.Text = $"{oct_one.Text}.{oct_two.Text}.{oct_three.Text}.{(octetNum + incrementNum) - 1}";
                    if (octetNum + incrementNum > 255 && oct1 >= 255 && oct2 >= 255 && oct3 >= 255)
                    {
                        nextAddress_textBox.Text = $"Limit";
                    }
                    else if (octetNum + incrementNum > 255 && oct3 < 255)
                    {

                        nextAddress_textBox.Text = $"{oct1}.{oct2}.{oct3 + 1}.0";
                    }
                    else if (octetNum + incrementNum > 255 && oct3 >= 255 && oct2 < 255)
                    {

                        nextAddress_textBox.Text = $"{oct1}.{oct2 + 1}.0.0";
                    }
                    else if (octetNum + incrementNum > 255 && oct2 >= 255 && oct3 >= 255)
                    {

                        nextAddress_textBox.Text = $"{oct1 + 1}.0.0.0";
                    }
                    else
                    {
                        nextAddress_textBox.Text = $"{oct1}.{oct2}.{oct3}.{(octetNum + incrementNum)}";
                    }
                }
            }
            if (cidr == 7 || cidr == 15 || cidr == 23 || cidr == 31)
            {
                int incrementNum = 2;
                if (cidr == 7)
                {
                    int octetNum = 0;
                    octetNum = GetNum.GetNetAddress(incrementNum, oct1);
                    interval_textBox.Text = incrementNum.ToString();
                    octet_textBox.Text = "1";
                    networkAddress_textBox.Text = $"{octetNum}.0.0.0";
                    firstUseable_textBox.Text = $"{octetNum}.0.0.1";
                    lastUseable_textBox.Text = $"{(octetNum + incrementNum) - 1}.255.255.254";
                    broadcastAddress_textBox.Text = $"{(octetNum + incrementNum) - 1}.255.255.255";
                    if (octetNum + incrementNum > 255)
                    {
                        nextAddress_textBox.Text = $"Limit";
                    }
                    else
                    {
                        nextAddress_textBox.Text = $"{(octetNum + incrementNum)}.0.0.0";
                    }
                }
                if (cidr == 15)
                {
                    int octetNum = 0;
                    octetNum = GetNum.GetNetAddress(incrementNum, oct2);
                    interval_textBox.Text = incrementNum.ToString();
                    octet_textBox.Text = "2";
                    networkAddress_textBox.Text = $"{oct1}.{octetNum}.0.0";
                    firstUseable_textBox.Text = $"{oct1}.{octetNum}.0.1";
                    lastUseable_textBox.Text = $"{oct1}.{(octetNum + incrementNum) - 1}.255.254";
                    broadcastAddress_textBox.Text = $"{oct1}.{(octetNum + incrementNum) - 1}.255.255";
                    if (broadcastAddress_textBox.Text == "255.255.255.255")
                    {
                        nextAddress_textBox.Text = $"Limit";
                    }
                    else if (octetNum + incrementNum > 255 && oct1 < 255)
                    {

                        nextAddress_textBox.Text = $"{oct1 + 1}.0.0.0";
                    }
                    else
                    {
                        nextAddress_textBox.Text = $"{oct1}.{(octetNum + incrementNum)}.0.0";
                    }
                }
                if (cidr == 23)
                {
                    int octetNum = 0;
                    octetNum = GetNum.GetNetAddress(incrementNum, oct3);
                    interval_textBox.Text = incrementNum.ToString();
                    octet_textBox.Text = "3";
                    networkAddress_textBox.Text = $"{oct_one.Text}.{oct_two.Text}.{octetNum}.0";
                    firstUseable_textBox.Text = $"{oct_one.Text}.{oct_two.Text}.{octetNum}.1";
                    lastUseable_textBox.Text = $"{oct_one.Text}.{oct_two.Text}.{(octetNum + incrementNum) - 1}.254";
                    broadcastAddress_textBox.Text = $"{oct_one.Text}.{oct_two.Text}.{(octetNum + incrementNum) - 1}.255";
                    if (octetNum + incrementNum > 255 && oct1 >= 255 && oct2 >= 255)
                    {
                        nextAddress_textBox.Text = $"Limit";
                    }
                    else if (octetNum + incrementNum > 255 && oct2 < 255)
                    {

                        nextAddress_textBox.Text = $"{oct1}.{oct2 + 1}.0.0";
                    }
                    else if (octetNum + incrementNum > 255 && oct2 < 255 && oct2 < 255)
                    {

                        nextAddress_textBox.Text = $"{oct1}.{oct2 + 1}.0.0";
                    }
                    else if (octetNum + incrementNum > 255 && oct2 >= 255 && oct2 < 255)
                    {

                        nextAddress_textBox.Text = $"{oct1 + 1}.0.0.0";
                    }
                    else
                    {
                        nextAddress_textBox.Text = $"{oct1}.{oct2}.{(octetNum + incrementNum)}.0";
                    }
                }
                if (cidr == 31)
                {
                    incrementNum = 0;
                    int octetNum = 0;
                    octetNum = GetNum.GetNetAddress(incrementNum, oct4);
                    interval_textBox.Text = incrementNum.ToString();
                    octet_textBox.Text = "4";
                    networkAddress_textBox.Text = $"{oct_one.Text}.{oct_two.Text}.{oct_three.Text}.{octetNum}";
                    firstUseable_textBox.Text = $"{oct_one.Text}.{oct_two.Text}.{oct_three.Text}.{octetNum + 1}";
                    lastUseable_textBox.Text = $"Limit";
                    broadcastAddress_textBox.Text = $"Limit";
                    if (octetNum + incrementNum > 255 && oct1 >= 255 && oct2 >= 255 && oct3 >= 255)
                    {
                        nextAddress_textBox.Text = $"Limit";
                    }
                    else if (octetNum + incrementNum > 255 && oct3 < 255)
                    {

                        nextAddress_textBox.Text = $"{oct1}.{oct2}.{oct3 + 1}.0";
                    }
                    else if (octetNum + incrementNum > 255 && oct3 >= 255 && oct2 < 255)
                    {

                        nextAddress_textBox.Text = $"{oct1}.{oct2 + 1}.0.0";
                    }
                    else if (octetNum + incrementNum > 255 && oct2 >= 255 && oct3 >= 255)
                    {

                        nextAddress_textBox.Text = $"{oct1 + 1}.0.0.0";
                    }
                    else
                    {
                        nextAddress_textBox.Text = $"{oct1}.{oct2}.{oct3}.{(octetNum + incrementNum)}";
                    }
                }
            }
            if (cidr == 8 || cidr == 16 || cidr == 24 || cidr == 32)
            {
                int incrementNum = 1;
                if (cidr == 8)
                {
                    int octetNum = 0;
                    octetNum = GetNum.GetNetAddress(incrementNum, oct1);
                    interval_textBox.Text = incrementNum.ToString();
                    octet_textBox.Text = "1";
                    networkAddress_textBox.Text = $"{octetNum}.0.0.0";
                    firstUseable_textBox.Text = $"{octetNum}.0.0.1";
                    lastUseable_textBox.Text = $"{(octetNum + incrementNum) - 1}.255.255.254";
                    broadcastAddress_textBox.Text = $"{(octetNum + incrementNum) - 1}.255.255.255";
                    if (octetNum + incrementNum > 255)
                    {
                        nextAddress_textBox.Text = $"Limit";
                    }
                    else
                    {
                        nextAddress_textBox.Text = $"{(octetNum + incrementNum)}.0.0.0";
                    }
                }
                if (cidr == 16)
                {
                    int octetNum = 0;
                    octetNum = GetNum.GetNetAddress(incrementNum, oct2);
                    interval_textBox.Text = incrementNum.ToString();
                    octet_textBox.Text = "2";
                    networkAddress_textBox.Text = $"{oct1}.{octetNum}.0.0";
                    firstUseable_textBox.Text = $"{oct1}.{octetNum}.0.1";
                    lastUseable_textBox.Text = $"{oct1}.{(octetNum + incrementNum) - 1}.255.254";
                    broadcastAddress_textBox.Text = $"{oct1}.{(octetNum + incrementNum) - 1}.255.255";
                    if (broadcastAddress_textBox.Text == "255.255.255.255")
                    {
                        nextAddress_textBox.Text = $"Limit";
                    }
                    else if (octetNum + incrementNum > 255 && oct1 < 255)
                    {

                        nextAddress_textBox.Text = $"{oct1 + 1}.0.0.0";
                    }
                    else
                    {
                        nextAddress_textBox.Text = $"{oct1}.{(octetNum + incrementNum)}.0.0";
                    }
                }
                if (cidr == 24)
                {
                    int octetNum = 0;
                    octetNum = GetNum.GetNetAddress(incrementNum, oct3);
                    interval_textBox.Text = incrementNum.ToString();
                    octet_textBox.Text = "3";
                    networkAddress_textBox.Text = $"{oct_one.Text}.{oct_two.Text}.{octetNum}.0";
                    firstUseable_textBox.Text = $"{oct_one.Text}.{oct_two.Text}.{octetNum}.1";
                    lastUseable_textBox.Text = $"{oct_one.Text}.{oct_two.Text}.{(octetNum + incrementNum) - 1}.254";
                    broadcastAddress_textBox.Text = $"{oct_one.Text}.{oct_two.Text}.{(octetNum + incrementNum) - 1}.255";
                    if (octetNum + incrementNum > 255 && oct1 >= 255 && oct2 >= 255)
                    {
                        nextAddress_textBox.Text = $"Limit";
                    }
                    else if (octetNum + incrementNum > 255 && oct2 < 255)
                    {

                        nextAddress_textBox.Text = $"{oct1}.{oct2 + 1}.0.0";
                    }
                    else if (octetNum + incrementNum > 255 && oct2 < 255 && oct2 < 255)
                    {

                        nextAddress_textBox.Text = $"{oct1}.{oct2 + 1}.0.0";
                    }
                    else if (octetNum + incrementNum > 255 && oct2 >= 255 && oct2 < 255)
                    {

                        nextAddress_textBox.Text = $"{oct1 + 1}.0.0.0";
                    }
                    else
                    {
                        nextAddress_textBox.Text = $"{oct1}.{oct2}.{(octetNum + incrementNum)}.0";
                    }
                }
                if (cidr == 32)
                {
                    incrementNum = 0;
                    int octetNum = 0;
                    octetNum = GetNum.GetNetAddress(incrementNum, oct4);
                    interval_textBox.Text = incrementNum.ToString();
                    octet_textBox.Text = "4";
                    networkAddress_textBox.Text = $"{oct_one.Text}.{oct_two.Text}.{oct_three.Text}.{octetNum}";
                    firstUseable_textBox.Text = $"Limit";
                    lastUseable_textBox.Text = $"Limit";
                    broadcastAddress_textBox.Text = $"Limit";
                    if (octetNum + incrementNum > 255 && oct1 >= 255 && oct2 >= 255 && oct3 >= 255)
                    {
                        nextAddress_textBox.Text = $"Limit";
                    }
                    else if (octetNum + incrementNum > 255 && oct3 < 255)
                    {

                        nextAddress_textBox.Text = $"{oct1}.{oct2}.{oct3 + 1}.0";
                    }
                    else if (octetNum + incrementNum > 255 && oct3 >= 255 && oct2 < 255)
                    {

                        nextAddress_textBox.Text = $"{oct1}.{oct2 + 1}.0.0";
                    }
                    else if (octetNum + incrementNum > 255 && oct2 >= 255 && oct3 >= 255)
                    {

                        nextAddress_textBox.Text = $"{oct1 + 1}.0.0.0";
                    }
                    else
                    {
                        nextAddress_textBox.Text = $"{oct1}.{oct2}.{oct3}.{(octetNum + incrementNum)}";
                    }
                }
                 
            }
             
        }

        private void next_button_Click(object sender, EventArgs e)
        {
            
            if (broadcastAddress_textBox.Text != "255.255.255.255" && nextAddress_textBox.Text != "Limit")
            {
                int subnetNumber = int.Parse(subnetNumber_textBox.Text);
                subnetNumber++;
                subnetNumber_textBox.Text = subnetNumber.ToString();
            }
            else
            {

            }


            string nextAddress = nextAddress_textBox.Text;
            string[] sepNextAddress = nextAddress.Split('.');
            string[] CheckBroadcast = broadcastAddress_textBox.Text.Split('.');
            try
            {
                if (oct_one.Text.Length <= 3 && oct_one.Text.Length >= 0 && oct_two.Text.Length <= 3 && oct_two.Text.Length >= 0
                    && oct_three.Text.Length <= 3 && oct_three.Text.Length >= 0 && oct_four.Text.Length <= 3 && oct_four.Text.Length >= 0)
                {
                    int oct1 = int.Parse(sepNextAddress[0]);
                    int oct2 = int.Parse(sepNextAddress[1]);
                    int oct3 = int.Parse(sepNextAddress[2]);
                    int oct4 = int.Parse(sepNextAddress[3]);
                    int cidr = int.Parse(cidrNotat.Text);

                    int keyNum = GetCidr(cidr);
                    GetNetAddress(cidr, oct1, oct2, oct3, oct4);
                    //if (cidrNotat.Text == "9" && int.Parse(CheckBroadcast[0]) < 255 && int.Parse(CheckBroadcast[1]) == 255)
                    //{
                    //    int oct1 = int.Parse(CheckBroadcast[0]) + 1;
                    //    int oct2 = 0;
                    //    int oct3 = 0;
                    //    int oct4 = 0;
                    //    int cidr = int.Parse(cidrNotat.Text);
                    //     int keyNum = GetCidr(cidr);
                    //    GetNetAddress(cidr, oct1, oct2, oct3, oct4);
                    //}
                     
                    //else
                    //{
                    //    int oct1 = int.Parse(sepNextAddress[0]);
                    //    int oct2 = int.Parse(sepNextAddress[1]);
                    //    int oct3 = int.Parse(sepNextAddress[2]);
                    //    int oct4 = int.Parse(sepNextAddress[3]);
                    //    int cidr = int.Parse(cidrNotat.Text);

                    //    int keyNum = GetCidr(cidr);
                    //    GetNetAddress(cidr, oct1, oct2, oct3, oct4);
                    //}
                     
                }
                else
                {
                    MessageBox.Show("Invalid Input!\n\nThe octet number length must not exceed 3 digits!");
                }

            }
            catch
            {
                MessageBox.Show("Invalid Input!");
            }
        }

        private void oct_one_TextChanged(object sender, EventArgs e)
        {

        }

         

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void printPreviewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintDialog print = new PrintDialog(); 
            PrintDocument printDocument = new PrintDocument();
            print.Document = printDocument;
            print.AllowSelection = true;

            print.AllowSomePages = true; ;
            print.ShowDialog();
            
        }

         





        //private void BroadcastDetermination(int octetSet)
        //{
        //    string[] CheckBroadcast = broadcastAddress_textBox.Text.Split('.');
        //    if (octetSet == 2)
        //    {
        //        if (int.Parse(CheckBroadcast[0]) < 255)
        //        {
        //            int oct1 = int.Parse(CheckBroadcast[0])+ 1;
        //            int oct2 = 0;
        //            int oct3 = 0;
        //            int oct4 = 0;
        //            int cidr = int.Parse(cidrNotat.Text);
        //            MessageBox.Show(oct1.ToString());
        //            int keyNum = GetCidr(cidr);
        //            GetNetAddress(cidr, oct1, oct2, oct3, oct4);
        //        }
        //    }
        //}




























    }
}




















































        
    

