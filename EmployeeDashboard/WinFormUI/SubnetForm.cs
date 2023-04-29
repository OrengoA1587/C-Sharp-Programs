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
    public partial class SubnetForm : Form
    {
        public SubnetForm()
        {
            InitializeComponent();
        }
        private void submit_button_Click(object sender, EventArgs e)
        {
            try
            {
                if (oct_one.Text.Length <= 3 && oct_one.Text.Length >= 0 && oct_two.Text.Length <= 3 && oct_two.Text.Length >= 0
                    && oct_three.Text.Length <= 3 && oct_three.Text.Length >= 0 && oct_four.Text.Length <= 3 && oct_four.Text.Length >= 0)
                {
                    int oct1 = int.Parse(oct_one.Text);
                    int oct2 = int.Parse(oct_two.Text);
                    int oct3 = int.Parse(oct_three.Text);
                    int oct4 = int.Parse(oct_four.Text);
                    int cidr = int.Parse(cidrNotat.Text);

                    int keyNum = GetCidr(cidr);
                    GetNetAddress(cidr, oct1, oct2, oct3, oct4);
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
                    networkAddress_textBox.Text = $"{octetNum}.0.0.0";
                    firstUseable_textBox.Text = $"{octetNum}.0.0.1";
                    lastUseable_textBox.Text = $"{(octetNum + incrementNum)-1}.255.255.254";
                    broadcastAddress_textBox.Text = $"{(octetNum + incrementNum) - 1}.255.255.255";                    
                }
                if (cidr == 9)
                {
                    int octetNum = 0;
                    octetNum = GetNum.GetNetAddress(incrementNum, oct2);
                    networkAddress_textBox.Text = $"{oct_one.Text}.{octetNum}.0.0";
                    firstUseable_textBox.Text = $"{oct_one.Text}.{octetNum}.0.1";
                    lastUseable_textBox.Text = $"{oct_one.Text}.{(octetNum + incrementNum) - 1}.255.254";
                    broadcastAddress_textBox.Text = $"{oct_one.Text}.{(octetNum + incrementNum) - 1}.255.255";

                }
                if (cidr == 17)
                {
                    int octetNum = 0;
                    octetNum = GetNum.GetNetAddress(incrementNum, oct3);
                    networkAddress_textBox.Text = $"{oct_one.Text}.{oct_two.Text}.{octetNum}.0";
                    firstUseable_textBox.Text = $"{oct_one.Text}.{oct_two.Text}.{octetNum}.1";
                    lastUseable_textBox.Text = $"{oct_one.Text}.{oct_two.Text}.{(octetNum + incrementNum) - 1}.254";
                    broadcastAddress_textBox.Text = $"{oct_one.Text}.{oct_two.Text}.{(octetNum + incrementNum) - 1}.255";
                }
                if (cidr == 25)
                {
                    int octetNum = 0;
                    octetNum = GetNum.GetNetAddress(incrementNum, oct4);
                    networkAddress_textBox.Text = $"{oct_one.Text}.{oct_two.Text}.{oct_three.Text}.{octetNum}";
                    firstUseable_textBox.Text = $"{oct_one.Text}.{oct_two.Text}.{oct_three.Text}.{octetNum + 1}";
                    lastUseable_textBox.Text = $"{oct_one.Text}.{oct_two.Text}.{oct_three.Text}.{(octetNum + incrementNum) - 2}";
                    broadcastAddress_textBox.Text = $"{oct_one.Text}.{oct_two.Text}.{oct_three.Text}.{(octetNum + incrementNum) - 1}";
                }

            }
            if (cidr == 2 || cidr == 10 || cidr == 18 || cidr == 26)
            {
                int incrementNum = 64;
                if (cidr == 2)
                {
                    int octetNum = 0;
                    octetNum = GetNum.GetNetAddress(incrementNum, oct1);
                    networkAddress_textBox.Text = $"{octetNum}.0.0.0";
                    firstUseable_textBox.Text = $"{octetNum}.0.0.1";
                    lastUseable_textBox.Text = $"{(octetNum + incrementNum) - 1}.255.255.254";
                    broadcastAddress_textBox.Text = $"{(octetNum + incrementNum) - 1}.255.255.255";
                }
                if (cidr == 10)
                {
                    int octetNum = 0;
                    octetNum = GetNum.GetNetAddress(incrementNum, oct2);
                    networkAddress_textBox.Text = $"{oct_one.Text}.{octetNum}.0.0";
                    firstUseable_textBox.Text = $"{oct_one.Text}.{octetNum}.0.1";
                    lastUseable_textBox.Text = $"{oct_one.Text}.{(octetNum + incrementNum) - 1}.255.254";
                    broadcastAddress_textBox.Text = $"{oct_one.Text}.{(octetNum + incrementNum) - 1}.255.255";
                }
                if (cidr == 18)
                {
                    int octetNum = 0;
                    octetNum = GetNum.GetNetAddress(incrementNum, oct3);
                    networkAddress_textBox.Text = $"{oct_one.Text}.{oct_two.Text}.{octetNum}.0";
                    firstUseable_textBox.Text = $"{oct_one.Text}.{oct_two.Text}.{octetNum}.1";
                    lastUseable_textBox.Text = $"{oct_one.Text}.{oct_two.Text}.{(octetNum + incrementNum) - 1}.254";
                    broadcastAddress_textBox.Text = $"{oct_one.Text}.{oct_two.Text}.{(octetNum + incrementNum) - 1}.255";
                }
                if (cidr == 26)
                {
                    int octetNum = 0;
                    octetNum = GetNum.GetNetAddress(incrementNum, oct4);
                    networkAddress_textBox.Text = $"{oct_one.Text}.{oct_two.Text}.{oct_three.Text}.{octetNum}";
                    firstUseable_textBox.Text = $"{oct_one.Text}.{oct_two.Text}.{oct_three.Text}.{octetNum + 1}";
                    lastUseable_textBox.Text = $"{oct_one.Text}.{oct_two.Text}.{oct_three.Text}.{(octetNum + incrementNum) - 2}";
                    broadcastAddress_textBox.Text = $"{oct_one.Text}.{oct_two.Text}.{oct_three.Text}.{(octetNum + incrementNum) - 1}";
                }
            }


            if (cidr == 3 || cidr == 11 || cidr == 19 || cidr == 27)
            {
                int incrementNum = 32;
                if (cidr == 3)
                {
                    int octetNum = 0;
                    octetNum = GetNum.GetNetAddress(incrementNum, oct1);
                    networkAddress_textBox.Text = $"{octetNum}.0.0.0";
                    firstUseable_textBox.Text = $"{octetNum}.0.0.1";
                    lastUseable_textBox.Text = $"{(octetNum + incrementNum) - 1}.255.255.254";
                    broadcastAddress_textBox.Text = $"{(octetNum + incrementNum) - 1}.255.255.255";
                }
                if (cidr == 11)
                {
                    int octetNum = 0;
                    octetNum = GetNum.GetNetAddress(incrementNum, oct2);
                    networkAddress_textBox.Text = $"{oct_one.Text}.{octetNum}.0.0";
                    firstUseable_textBox.Text = $"{oct_one.Text}.{octetNum}.0.1";
                    lastUseable_textBox.Text = $"{oct_one.Text}.{(octetNum + incrementNum) - 1}.255.254";
                    broadcastAddress_textBox.Text = $"{oct_one.Text}.{(octetNum + incrementNum) - 1}.255.255";
                }
                if (cidr == 19)
                {
                    int octetNum = 0;
                    octetNum = GetNum.GetNetAddress(incrementNum, oct3);
                    networkAddress_textBox.Text = $"{oct_one.Text}.{oct_two.Text}.{octetNum}.0";
                    firstUseable_textBox.Text = $"{oct_one.Text}.{oct_two.Text}.{octetNum}.1";
                    lastUseable_textBox.Text = $"{oct_one.Text}.{oct_two.Text}.{(octetNum + incrementNum) - 1}.254";
                    broadcastAddress_textBox.Text = $"{oct_one.Text}.{oct_two.Text}.{(octetNum + incrementNum) - 1}.255";
                }
                if (cidr == 27)
                {
                    int octetNum = 0;
                    octetNum = GetNum.GetNetAddress(incrementNum, oct4);
                    networkAddress_textBox.Text = $"{oct_one.Text}.{oct_two.Text}.{oct_three.Text}.{octetNum}";
                    firstUseable_textBox.Text = $"{oct_one.Text}.{oct_two.Text}.{oct_three.Text}.{octetNum + 1}";
                    lastUseable_textBox.Text = $"{oct_one.Text}.{oct_two.Text}.{oct_three.Text}.{(octetNum + incrementNum) - 2}";
                    broadcastAddress_textBox.Text = $"{oct_one.Text}.{oct_two.Text}.{oct_three.Text}.{(octetNum + incrementNum) - 1}";
                }
            }
            if (cidr == 4 || cidr == 12 || cidr == 20 || cidr == 28)
            {
                int incrementNum = 16;
                if (cidr == 4)
                {
                    int octetNum = 0;
                    octetNum = GetNum.GetNetAddress(incrementNum, oct1);
                    networkAddress_textBox.Text = $"{octetNum}.0.0.0";
                    firstUseable_textBox.Text = $"{octetNum}.0.0.1";
                    lastUseable_textBox.Text = $"{(octetNum + incrementNum) - 1}.255.255.254";
                    broadcastAddress_textBox.Text = $"{(octetNum + incrementNum) - 1}.255.255.255";
                }
                if (cidr == 12)
                {
                    int octetNum = 0;
                    octetNum = GetNum.GetNetAddress(incrementNum, oct2);
                    networkAddress_textBox.Text = $"{oct_one.Text}.{octetNum}.0.0";
                    firstUseable_textBox.Text = $"{oct_one.Text}.{octetNum}.0.1";
                    lastUseable_textBox.Text = $"{oct_one.Text}.{(octetNum + incrementNum) - 1}.255.254";
                    broadcastAddress_textBox.Text = $"{oct_one.Text}.{(octetNum + incrementNum) - 1}.255.255";
                }
                if (cidr == 20)
                {
                    int octetNum = 0;
                    octetNum = GetNum.GetNetAddress(incrementNum, oct3);
                    networkAddress_textBox.Text = $"{oct_one.Text}.{oct_two.Text}.{octetNum}.0";
                    firstUseable_textBox.Text = $"{oct_one.Text}.{oct_two.Text}.{octetNum}.1";
                    lastUseable_textBox.Text = $"{oct_one.Text}.{oct_two.Text}.{(octetNum + incrementNum) - 1}.254";
                    broadcastAddress_textBox.Text = $"{oct_one.Text}.{oct_two.Text}.{(octetNum + incrementNum) - 1}.255";
                }
                if (cidr == 28)
                {
                    int octetNum = 0;
                    octetNum = GetNum.GetNetAddress(incrementNum, oct4);
                    networkAddress_textBox.Text = $"{oct_one.Text}.{oct_two.Text}.{oct_three.Text}.{octetNum}";
                    firstUseable_textBox.Text = $"{oct_one.Text}.{oct_two.Text}.{oct_three.Text}.{octetNum + 1}";
                    lastUseable_textBox.Text = $"{oct_one.Text}.{oct_two.Text}.{oct_three.Text}.{(octetNum + incrementNum) - 2}";
                    broadcastAddress_textBox.Text = $"{oct_one.Text}.{oct_two.Text}.{oct_three.Text}.{(octetNum + incrementNum) - 1}";
                }
            }
            if (cidr == 5 || cidr == 13 || cidr == 21 || cidr == 29)
            {
                int incrementNum = 8;
                if (cidr == 5)
                {
                    int octetNum = 0;
                    octetNum = GetNum.GetNetAddress(incrementNum, oct1);
                    networkAddress_textBox.Text = $"{octetNum}.0.0.0";
                    firstUseable_textBox.Text = $"{octetNum}.0.0.1";
                    lastUseable_textBox.Text = $"{(octetNum + incrementNum) - 1}.255.255.254";
                    broadcastAddress_textBox.Text = $"{(octetNum + incrementNum) - 1}.255.255.255";
                }
                if (cidr == 13)
                {
                    int octetNum = 0;
                    octetNum = GetNum.GetNetAddress(incrementNum, oct2);
                    networkAddress_textBox.Text = $"{oct_one.Text}.{octetNum}.0.0";
                    firstUseable_textBox.Text = $"{oct_one.Text}.{octetNum}.0.1";
                    lastUseable_textBox.Text = $"{oct_one.Text}.{(octetNum + incrementNum) - 1}.255.254";
                    broadcastAddress_textBox.Text = $"{oct_one.Text}.{(octetNum + incrementNum) - 1}.255.255";
                }
                if (cidr == 21)
                {
                    int octetNum = 0;
                    octetNum = GetNum.GetNetAddress(incrementNum, oct3);
                    networkAddress_textBox.Text = $"{oct_one.Text}.{oct_two.Text}.{octetNum}.0";
                    firstUseable_textBox.Text = $"{oct_one.Text}.{oct_two.Text}.{octetNum}.1";
                    lastUseable_textBox.Text = $"{oct_one.Text}.{oct_two.Text}.{(octetNum + incrementNum) - 1}.254";
                    broadcastAddress_textBox.Text = $"{oct_one.Text}.{oct_two.Text}.{(octetNum + incrementNum) - 1}.255";
                }
                if (cidr == 29)
                {
                    int octetNum = 0;
                    octetNum = GetNum.GetNetAddress(incrementNum, oct4);
                    networkAddress_textBox.Text = $"{oct_one.Text}.{oct_two.Text}.{oct_three.Text}.{octetNum}";
                    firstUseable_textBox.Text = $"{oct_one.Text}.{oct_two.Text}.{oct_three.Text}.{octetNum + 1}";
                    lastUseable_textBox.Text = $"{oct_one.Text}.{oct_two.Text}.{oct_three.Text}.{(octetNum + incrementNum) - 2}";
                    broadcastAddress_textBox.Text = $"{oct_one.Text}.{oct_two.Text}.{oct_three.Text}.{(octetNum + incrementNum) - 1}";
                }
            }
            if (cidr == 6 || cidr == 14 || cidr == 22 || cidr == 30)
            {
                int incrementNum = 4;
                if (cidr == 6)
                {
                    int octetNum = 0;
                    octetNum = GetNum.GetNetAddress(incrementNum, oct1);
                    networkAddress_textBox.Text = $"{octetNum}.0.0.0";
                    firstUseable_textBox.Text = $"{octetNum}.0.0.1";
                    lastUseable_textBox.Text = $"{(octetNum + incrementNum) - 1}.255.255.254";
                    broadcastAddress_textBox.Text = $"{(octetNum + incrementNum) - 1}.255.255.255";
                }
                if (cidr == 14)
                {
                    int octetNum = 0;
                    octetNum = GetNum.GetNetAddress(incrementNum, oct2);
                    networkAddress_textBox.Text = $"{oct_one.Text}.{octetNum}.0.0";
                    firstUseable_textBox.Text = $"{oct_one.Text}.{octetNum}.0.1";
                    lastUseable_textBox.Text = $"{oct_one.Text}.{(octetNum + incrementNum) - 1}.255.254";
                    broadcastAddress_textBox.Text = $"{oct_one.Text}.{(octetNum + incrementNum) - 1}.255.255";
                }
                if (cidr == 22)
                {
                    int octetNum = 0;
                    octetNum = GetNum.GetNetAddress(incrementNum, oct3);
                    networkAddress_textBox.Text = $"{oct_one.Text}.{oct_two.Text}.{octetNum}.0";
                    firstUseable_textBox.Text = $"{oct_one.Text}.{oct_two.Text}.{octetNum}.1";
                    lastUseable_textBox.Text = $"{oct_one.Text}.{oct_two.Text}.{(octetNum + incrementNum) - 1}.254";
                    broadcastAddress_textBox.Text = $"{oct_one.Text}.{oct_two.Text}.{(octetNum + incrementNum) - 1}.255";
                }
                if (cidr == 30)
                {
                    int octetNum = 0;
                    octetNum = GetNum.GetNetAddress(incrementNum, oct4);
                    networkAddress_textBox.Text = $"{oct_one.Text}.{oct_two.Text}.{oct_three.Text}.{octetNum}";
                    firstUseable_textBox.Text = $"{oct_one.Text}.{oct_two.Text}.{oct_three.Text}.{octetNum + 1}";
                    lastUseable_textBox.Text = $"{oct_one.Text}.{oct_two.Text}.{oct_three.Text}.{(octetNum + incrementNum) - 2}";
                    broadcastAddress_textBox.Text = $"{oct_one.Text}.{oct_two.Text}.{oct_three.Text}.{(octetNum + incrementNum) - 1}";
                }
            }
            if (cidr == 7 || cidr == 15 || cidr == 23 || cidr == 31)
            {
                int incrementNum = 2;
                if (cidr == 7)
                {
                    int octetNum = 0;
                    octetNum = GetNum.GetNetAddress(incrementNum, oct1);
                    networkAddress_textBox.Text = $"{octetNum}.0.0.0";
                    firstUseable_textBox.Text = $"{octetNum}.0.0.1";
                    lastUseable_textBox.Text = $"{(octetNum + incrementNum) - 1}.255.255.254";
                    broadcastAddress_textBox.Text = $"{(octetNum + incrementNum) - 1}.255.255.255";
                }
                if (cidr == 15)
                {
                    int octetNum = 0;
                    octetNum = GetNum.GetNetAddress(incrementNum, oct2);
                    networkAddress_textBox.Text = $"{oct_one.Text}.{octetNum}.0.0";
                    firstUseable_textBox.Text = $"{oct_one.Text}.{octetNum}.0.1";
                    lastUseable_textBox.Text = $"{oct_one.Text}.{(octetNum + incrementNum) - 1}.255.254";
                    broadcastAddress_textBox.Text = $"{oct_one.Text}.{(octetNum + incrementNum) - 1}.255.255";
                }
                if (cidr == 23)
                {
                    int octetNum = 0;
                    octetNum = GetNum.GetNetAddress(incrementNum, oct3);
                    networkAddress_textBox.Text = $"{oct_one.Text}.{oct_two.Text}.{octetNum}.0";
                    firstUseable_textBox.Text = $"{oct_one.Text}.{oct_two.Text}.{octetNum}.1";
                    lastUseable_textBox.Text = $"{oct_one.Text}.{oct_two.Text}.{(octetNum + incrementNum) - 1}.254";
                    broadcastAddress_textBox.Text = $"{oct_one.Text}.{oct_two.Text}.{(octetNum + incrementNum) - 1}.255";
                }
                if (cidr == 31)
                {
                    int octetNum = 0;
                    octetNum = GetNum.GetNetAddress(incrementNum, oct4);
                    networkAddress_textBox.Text = $"{oct_one.Text}.{oct_two.Text}.{oct_three.Text}.{octetNum}";
                    firstUseable_textBox.Text = $"{oct_one.Text}.{oct_two.Text}.{oct_three.Text}.{octetNum + 1}";
                    lastUseable_textBox.Text = $"{oct_one.Text}.{oct_two.Text}.{oct_three.Text}.{(octetNum + incrementNum) - 2}";
                    broadcastAddress_textBox.Text = $"{oct_one.Text}.{oct_two.Text}.{oct_three.Text}.{(octetNum + incrementNum) - 1}";
                }
            }
            if (cidr == 8 || cidr == 16 || cidr == 24 || cidr == 32)
            {
                int incrementNum = 1;
                if (cidr == 8)
                {
                    int octetNum = 0;
                    octetNum = GetNum.GetNetAddress(incrementNum, oct1);
                    networkAddress_textBox.Text = $"{octetNum}.0.0.0";
                    firstUseable_textBox.Text = $"{octetNum}.0.0.1";
                    lastUseable_textBox.Text = $"{(octetNum + incrementNum) - 1}.255.255.254";
                    broadcastAddress_textBox.Text = $"{(octetNum + incrementNum) - 1}.255.255.255";
                }
                if (cidr == 16)
                {
                    int octetNum = 0;
                    octetNum = GetNum.GetNetAddress(incrementNum, oct2);
                    networkAddress_textBox.Text = $"{oct_one.Text}.{octetNum}.0.0";
                    firstUseable_textBox.Text = $"{oct_one.Text}.{octetNum}.0.1";
                    lastUseable_textBox.Text = $"{oct_one.Text}.{(octetNum + incrementNum) - 1}.255.254";
                    broadcastAddress_textBox.Text = $"{oct_one.Text}.{(octetNum + incrementNum) - 1}.255.255";
                }
                if (cidr == 24)
                {
                    int octetNum = 0;
                    octetNum = GetNum.GetNetAddress(incrementNum, oct3);
                    networkAddress_textBox.Text = $"{oct_one.Text}.{oct_two.Text}.{octetNum}.0";
                    firstUseable_textBox.Text = $"{oct_one.Text}.{oct_two.Text}.{octetNum}.1";
                    lastUseable_textBox.Text = $"{oct_one.Text}.{oct_two.Text}.{(octetNum + incrementNum) - 1}.254";
                    broadcastAddress_textBox.Text = $"{oct_one.Text}.{oct_two.Text}.{(octetNum + incrementNum) - 1}.255";
                }
                if (cidr == 32)
                {
                    int octetNum = 0;
                    octetNum = GetNum.GetNetAddress(incrementNum, oct4);
                    networkAddress_textBox.Text = $"{oct_one.Text}.{oct_two.Text}.{oct_three.Text}.{octetNum}";
                    firstUseable_textBox.Text = $"{oct_one.Text}.{oct_two.Text}.{oct_three.Text}.{octetNum + 1}";
                    lastUseable_textBox.Text = $"{oct_one.Text}.{oct_two.Text}.{oct_three.Text}.{(octetNum + incrementNum) - 2}";
                    broadcastAddress_textBox.Text = $"{oct_one.Text}.{oct_two.Text}.{oct_three.Text}.{(octetNum + incrementNum) - 1}";
                }
            }
            
        }
        































        //    //-------------------------------------------------------------------------------------------
        //    if (cidr == 24)
        //    {
        //        netAddress = $"{oct_one.Text}.{oct_two.Text}.{oct_three.Text}.{ _NUM0}";

        //    }
        //    if (cidr == 16)
        //    {
        //        netAddress = $"{oct_one.Text}.{oct_two.Text}.{_NUM0}.{ _NUM0}";

        //    }
        //    if (cidr == 8)
        //    {
        //        netAddress = $"{oct_one.Text}.{_NUM0}.{_NUM0}.{ _NUM0}";

        //    }
        //    if (cidr == 0 || cidr == 1 && oct1 < 128)
        //    {
        //        netAddress = $"{_NUM0}.{_NUM0}.{_NUM0}.{ _NUM0}";
        //    }

        //    //if (cidr == 1 && oct1 < 128)
        //    //{

        //    //}
        //    //----------------------------------------------------------------------------------------------------


        //    //CIDR 1-8
        //    if (cidr == 1)
        //    {

        //        if (oct1 >= 128)
        //        {
        //            networkAddress_textBox.Text = "128.0.0.0";
        //            firstUseable_textBox.Text = "128.0.0.1";
        //            lastUseable_textBox.Text = "128.255.255.254";
        //            broadcastAddress_textBox.Text = "128.255.255.255";
        //        }
        //        else
        //        {
        //            networkAddress_textBox.Text = "0.0.0.0";
        //            firstUseable_textBox.Text = "0.0.0.1";
        //            lastUseable_textBox.Text = "127.255.255.254";
        //            broadcastAddress_textBox.Text = "127.255.255.255";
        //        }
        //    }
        //    if (cidr == 2)
        //    {

        //        if (oct1 >= 64)
        //        {
        //            networkAddress_textBox.Text = "64.0.0.0";
        //            firstUseable_textBox.Text = "64.0.0.1";
        //            lastUseable_textBox.Text = "127.255.255.254";
        //            broadcastAddress_textBox.Text = "127.255.255.255";
        //        }
        //        else if (oct1 >= 128)
        //        {
        //            networkAddress_textBox.Text = "128.0.0.0";
        //            firstUseable_textBox.Text = "128.0.0.1";
        //            lastUseable_textBox.Text = "191.255.255.254";
        //            broadcastAddress_textBox.Text = "191.255.255.255";
        //        }
        //        else if (oct1 >= 192)
        //        {
        //            networkAddress_textBox.Text = "192.0.0.0";
        //            firstUseable_textBox.Text = "192.0.0.1";
        //            lastUseable_textBox.Text = "255.255.255.254";
        //            broadcastAddress_textBox.Text = "255.255.255.255";
        //        }                
        //        else
        //        {
        //            networkAddress_textBox.Text = "0.0.0.0";
        //            firstUseable_textBox.Text = "0.0.0.1";
        //            lastUseable_textBox.Text = "63.255.255.254";
        //            broadcastAddress_textBox.Text = "63.255.255.255";
        //        }
        //    }
        //    if (cidr == 3)
        //    {

        //        if (oct1 >= 32 && oct1 <= 63)
        //        {
        //            networkAddress_textBox.Text = "32.0.0.0";
        //            firstUseable_textBox.Text = "32.0.0.1";
        //            lastUseable_textBox.Text = "63.255.255.254";
        //            broadcastAddress_textBox.Text = "63.255.255.255";
        //        }
        //        else if (oct1 >= 64 && oct1 <= 95)
        //        {
        //            networkAddress_textBox.Text = "64.0.0.0";
        //            firstUseable_textBox.Text = "64.0.0.1";
        //            lastUseable_textBox.Text = "95.255.255.254";
        //            broadcastAddress_textBox.Text = "95.255.255.255";
        //        }
        //        else if (oct1 >= 96 && oct1 <= 127)
        //        {
        //            networkAddress_textBox.Text = "96.0.0.0";
        //            firstUseable_textBox.Text = "96.0.0.1";
        //            lastUseable_textBox.Text = "127.255.255.254";
        //            broadcastAddress_textBox.Text = "127.255.255.255";
        //        }
        //        else if (oct1 >= 128 && oct1 <= 159)
        //        {
        //            networkAddress_textBox.Text = "128.0.0.0";
        //            firstUseable_textBox.Text = "128.0.0.1";
        //            lastUseable_textBox.Text = "159.255.255.254";
        //            broadcastAddress_textBox.Text = "159.255.255.255";
        //        }
        //        else if (oct1 >= 160 && oct1 <= 191)
        //        {
        //            networkAddress_textBox.Text = "160.0.0.0";
        //            firstUseable_textBox.Text = "160.0.0.1";
        //            lastUseable_textBox.Text = "191.255.255.254";
        //            broadcastAddress_textBox.Text = "191.255.255.255";
        //        }
        //        else if (oct1 >= 192 && oct1 <= 223)
        //        {
        //            networkAddress_textBox.Text = "192.0.0.0";
        //            firstUseable_textBox.Text = "192.0.0.1";
        //            lastUseable_textBox.Text = "223.255.255.254";
        //            broadcastAddress_textBox.Text = "223.255.255.255";
        //        }
        //        else if (oct1 >= 224 && oct1 <= 255)
        //        {
        //            networkAddress_textBox.Text = "224.0.0.0";
        //            firstUseable_textBox.Text = "224.0.0.1";
        //            lastUseable_textBox.Text = "255.255.255.254";
        //            broadcastAddress_textBox.Text = "255.255.255.255";
        //        }
        //        else
        //        {
        //            networkAddress_textBox.Text = "0.0.0.0";
        //            firstUseable_textBox.Text = "0.0.0.1";
        //            lastUseable_textBox.Text = "31.255.255.254";
        //            broadcastAddress_textBox.Text = "31.255.255.255";
        //        }
        //    }
        //    //25-32------------------------------------------------------------------------------------------------------------
        //    if (cidr == 25)
        //    {
               
        //        if (oct4 >= 128)
        //        {
        //            networkAddress_textBox.Text = $"{oct_one.Text}.{oct_two.Text}.{oct_three.Text}.{128}";
        //            firstUseable_textBox.Text = $"{oct_one.Text}.{oct_two.Text}.{oct_three.Text}.{129}";
        //            lastUseable_textBox.Text = $"{oct_one.Text}.{oct_two.Text}.{oct_three.Text}.{128 + 126}";
        //            broadcastAddress_textBox.Text = $"{oct_one.Text}.{oct_two.Text}.{oct_three.Text}.{128 + 127}";
        //        }
        //        else
        //        {
        //            networkAddress_textBox.Text = $"{oct_one.Text}.{oct_two.Text}.{oct_three.Text}.{0}";
        //            firstUseable_textBox.Text = $"{oct_one.Text}.{oct_two.Text}.{oct_three.Text}.{1}";
        //            lastUseable_textBox.Text = $"{oct_one.Text}.{oct_two.Text}.{oct_three.Text}.{126}";
        //            broadcastAddress_textBox.Text = $"{oct_one.Text}.{oct_two.Text}.{oct_three.Text}.{127}";
        //        }
        //    }
        //    //CIDR 26------------------------------------------------------------------------------------------------------------
        //    if (cidr == 26)
        //    {
        //        if (oct4 >= 64 && oct4 <= 127)
        //        {
        //            networkAddress_textBox.Text = $"{oct_one.Text}.{oct_two.Text}.{oct_three.Text}.{Math.Pow(2, 6)}";
        //            firstUseable_textBox.Text = $"{oct_one.Text}.{oct_two.Text}.{oct_three.Text}.{Math.Pow(2, 6) + 1}";
        //            lastUseable_textBox.Text = $"{oct_one.Text}.{oct_two.Text}.{oct_three.Text}.{Math.Pow(2, 6) + 62}";
        //            broadcastAddress_textBox.Text = $"{oct_one.Text}.{oct_two.Text}.{oct_three.Text}.{Math.Pow(2, 6) + 63}";
        //        }
        //        else if (oct4 >= 128 && oct4 <= 191)
        //        {
        //            networkAddress_textBox.Text = $"{oct_one.Text}.{oct_two.Text}.{oct_three.Text}.{Math.Pow(2, 7)}";
        //            firstUseable_textBox.Text = $"{oct_one.Text}.{oct_two.Text}.{oct_three.Text}.{ Math.Pow(2, 7) + 1}";
        //            lastUseable_textBox.Text = $"{oct_one.Text}.{oct_two.Text}.{oct_three.Text}.{ Math.Pow(2, 7) + 62}";
        //            broadcastAddress_textBox.Text = $"{oct_one.Text}.{oct_two.Text}.{oct_three.Text}.{ Math.Pow(2, 7) + 63}";
        //        }
        //        else if (oct4 >= 192 && oct4 <= 254)
        //        {
        //            networkAddress_textBox.Text = $"{oct_one.Text}.{oct_two.Text}.{oct_three.Text}.{ Math.Pow(2, 7) + 64}";
        //            firstUseable_textBox.Text = $"{oct_one.Text}.{oct_two.Text}.{oct_three.Text}.{Math.Pow(2, 7) + 65}";
        //            lastUseable_textBox.Text = $"{oct_one.Text}.{oct_two.Text}.{oct_three.Text}.{ _NUM192 + 62}";
        //            broadcastAddress_textBox.Text = $"{oct_one.Text}.{oct_two.Text}.{oct_three.Text}.{ _NUM192 + 63}";
        //        }
        //        else
        //        {
        //            networkAddress_textBox.Text = $"{oct_one.Text}.{oct_two.Text}.{oct_three.Text}.{0}";
        //            firstUseable_textBox.Text = $"{oct_one.Text}.{oct_two.Text}.{oct_three.Text}.{1}";
        //            lastUseable_textBox.Text = $"{oct_one.Text}.{oct_two.Text}.{oct_three.Text}.{62}";
        //            broadcastAddress_textBox.Text = $"{oct_one.Text}.{oct_two.Text}.{oct_three.Text}.{63}";
        //        }

        //    }
        //    //CIDR 27------------------------------------------------------------------------------------------------------------
        //    if (cidr == 27)
        //    {
        //        if (oct4 >= 32 && oct4 <= 63)
        //        {
        //            networkAddress_textBox.Text = $"{oct_one.Text}.{oct_two.Text}.{oct_three.Text}.{Math.Pow(2, 5)}";
        //            firstUseable_textBox.Text = $"{oct_one.Text}.{oct_two.Text}.{oct_three.Text}.{Math.Pow(2, 5) + 1}";
        //            lastUseable_textBox.Text = $"{oct_one.Text}.{oct_two.Text}.{oct_three.Text}.{Math.Pow(2, 5) + 30}";
        //            broadcastAddress_textBox.Text = $"{oct_one.Text}.{oct_two.Text}.{oct_three.Text}.{Math.Pow(2, 5) + 31}";
        //        }
        //        else if (oct4 >= 64 && oct4 <= 95)
        //        {
        //            networkAddress_textBox.Text = $"{oct_one.Text}.{oct_two.Text}.{oct_three.Text}.{Math.Pow(2, 6)}";
        //            firstUseable_textBox.Text = $"{oct_one.Text}.{oct_two.Text}.{oct_three.Text}.{Math.Pow(2, 6) + 1}";
        //            lastUseable_textBox.Text = $"{oct_one.Text}.{oct_two.Text}.{oct_three.Text}.{Math.Pow(2, 6) + 30}";
        //            broadcastAddress_textBox.Text = $"{oct_one.Text}.{oct_two.Text}.{oct_three.Text}.{Math.Pow(2, 6) + 31}";
        //        }
        //        else if (oct4 >= 96 && oct4 <= 127)
        //        {
        //            networkAddress_textBox.Text = $"{oct_one.Text}.{oct_two.Text}.{oct_three.Text}.{Math.Pow(2, 6) + 32}";
        //            firstUseable_textBox.Text = $"{oct_one.Text}.{oct_two.Text}.{oct_three.Text}.{Math.Pow(2, 6) + 33}";
        //            lastUseable_textBox.Text = $"{oct_one.Text}.{oct_two.Text}.{oct_three.Text}.{Math.Pow(2, 6) + 62}";
        //            broadcastAddress_textBox.Text = $"{oct_one.Text}.{oct_two.Text}.{oct_three.Text}.{Math.Pow(2, 6) + 63}";
        //        }
        //        else if (oct4 >= 128 && oct4 <= 159)
        //        {
        //            networkAddress_textBox.Text = $"{oct_one.Text}.{oct_two.Text}.{oct_three.Text}.{Math.Pow(2, 7)}";
        //            firstUseable_textBox.Text = $"{oct_one.Text}.{oct_two.Text}.{oct_three.Text}.{Math.Pow(2, 7) + 1}";
        //            lastUseable_textBox.Text = $"{oct_one.Text}.{oct_two.Text}.{oct_three.Text}.{Math.Pow(2, 7) + 30}";
        //            broadcastAddress_textBox.Text = $"{oct_one.Text}.{oct_two.Text}.{oct_three.Text}.{Math.Pow(2, 7) + 31}";
        //        }
        //        else if (oct4 >= 160 && oct4 <= 191)
        //        {
        //            networkAddress_textBox.Text = $"{oct_one.Text}.{oct_two.Text}.{oct_three.Text}.{Math.Pow(2, 7) + 32}";
        //            firstUseable_textBox.Text = $"{oct_one.Text}.{oct_two.Text}.{oct_three.Text}.{Math.Pow(2, 7) + 33}";
        //            lastUseable_textBox.Text = $"{oct_one.Text}.{oct_two.Text}.{oct_three.Text}.{Math.Pow(2, 7) + 62}";
        //            broadcastAddress_textBox.Text = $"{oct_one.Text}.{oct_two.Text}.{oct_three.Text}.{Math.Pow(2, 7) + 63}";
        //        }
        //        else if (oct4 >= 192 && oct4 <= 223)
        //        {
        //            networkAddress_textBox.Text = $"{oct_one.Text}.{oct_two.Text}.{oct_three.Text}.{Math.Pow(2, 7) + 64}";
        //            firstUseable_textBox.Text = $"{oct_one.Text}.{oct_two.Text}.{oct_three.Text}.{Math.Pow(2, 7) + 65}";
        //            lastUseable_textBox.Text = $"{oct_one.Text}.{oct_two.Text}.{oct_three.Text}.{Math.Pow(2, 7) + 94}";
        //            broadcastAddress_textBox.Text = $"{oct_one.Text}.{oct_two.Text}.{oct_three.Text}.{Math.Pow(2, 7) + 95}";
        //        }
        //        else if (oct4 >= 224 && oct4 <= 254)
        //        {
        //            networkAddress_textBox.Text = $"{oct_one.Text}.{oct_two.Text}.{oct_three.Text}.{Math.Pow(2, 7) + 96}";
        //            firstUseable_textBox.Text = $"{oct_one.Text}.{oct_two.Text}.{oct_three.Text}.{Math.Pow(2, 7) + 97}";
        //            lastUseable_textBox.Text = $"{oct_one.Text}.{oct_two.Text}.{oct_three.Text}.{Math.Pow(2, 7) + 126}";
        //            broadcastAddress_textBox.Text = $"{oct_one.Text}.{oct_two.Text}.{oct_three.Text}.{Math.Pow(2, 7) + 127}";
        //        }
        //        else
        //        {
        //            networkAddress_textBox.Text = $"{oct_one.Text}.{oct_two.Text}.{oct_three.Text}.{0}";
        //            firstUseable_textBox.Text = $"{oct_one.Text}.{oct_two.Text}.{oct_three.Text}.{1}";
        //            lastUseable_textBox.Text = $"{oct_one.Text}.{oct_two.Text}.{oct_three.Text}.{30}";
        //            broadcastAddress_textBox.Text = $"{oct_one.Text}.{oct_two.Text}.{oct_three.Text}.{31}";
        //        }

        //    }
        //    if (cidr == 28)
        //    {
        //        if (oct4 >= 16 && oct4 <= 31)
        //        {
        //            networkAddress_textBox.Text = $"{oct_one.Text}.{oct_two.Text}.{oct_three.Text}.{16}";
        //            firstUseable_textBox.Text = $"{oct_one.Text}.{oct_two.Text}.{oct_three.Text}.{17}";
        //            lastUseable_textBox.Text = $"{oct_one.Text}.{oct_two.Text}.{oct_three.Text}.{30}";
        //            broadcastAddress_textBox.Text = $"{oct_one.Text}.{oct_two.Text}.{oct_three.Text}.{31}";
        //        }
        //        else if (oct4 >= 32 && oct4 <= 47)
        //        {
        //            networkAddress_textBox.Text = $"{oct_one.Text}.{oct_two.Text}.{oct_three.Text}.{32}";
        //            firstUseable_textBox.Text = $"{oct_one.Text}.{oct_two.Text}.{oct_three.Text}.{33}";
        //            lastUseable_textBox.Text = $"{oct_one.Text}.{oct_two.Text}.{oct_three.Text}.{46}";
        //            broadcastAddress_textBox.Text = $"{oct_one.Text}.{oct_two.Text}.{oct_three.Text}.{47}";
        //        }
        //        else if (oct4 >= 48 && oct4 <= 63)
        //        {
        //            networkAddress_textBox.Text = $"{oct_one.Text}.{oct_two.Text}.{oct_three.Text}.{48}";
        //            firstUseable_textBox.Text = $"{oct_one.Text}.{oct_two.Text}.{oct_three.Text}.{49}";
        //            lastUseable_textBox.Text = $"{oct_one.Text}.{oct_two.Text}.{oct_three.Text}.{62}";
        //            broadcastAddress_textBox.Text = $"{oct_one.Text}.{oct_two.Text}.{oct_three.Text}.{ 63}";
        //        }
        //        else if (oct4 >= 64 && oct4 <= 79)
        //        {
        //            networkAddress_textBox.Text = $"{oct_one.Text}.{oct_two.Text}.{oct_three.Text}.{64}";
        //            firstUseable_textBox.Text = $"{oct_one.Text}.{oct_two.Text}.{oct_three.Text}.{65}";
        //            lastUseable_textBox.Text = $"{oct_one.Text}.{oct_two.Text}.{oct_three.Text}.{78}";
        //            broadcastAddress_textBox.Text = $"{oct_one.Text}.{oct_two.Text}.{oct_three.Text}.{79}";
        //        }
        //        else if (oct4 >= 80 && oct4 <= 95)
        //        {
        //            networkAddress_textBox.Text = $"{oct_one.Text}.{oct_two.Text}.{oct_three.Text}.{80}";
        //            firstUseable_textBox.Text = $"{oct_one.Text}.{oct_two.Text}.{oct_three.Text}.{81}";
        //            lastUseable_textBox.Text = $"{oct_one.Text}.{oct_two.Text}.{oct_three.Text}.{94}";
        //            broadcastAddress_textBox.Text = $"{oct_one.Text}.{oct_two.Text}.{oct_three.Text}.{95}";
        //        }
        //        else if (oct4 >= 96 && oct4 <= 111)
        //        {
        //            networkAddress_textBox.Text = $"{oct_one.Text}.{oct_two.Text}.{oct_three.Text}.{96}";
        //            firstUseable_textBox.Text = $"{oct_one.Text}.{oct_two.Text}.{oct_three.Text}.{97}";
        //            lastUseable_textBox.Text = $"{oct_one.Text}.{oct_two.Text}.{oct_three.Text}.{110}";
        //            broadcastAddress_textBox.Text = $"{oct_one.Text}.{oct_two.Text}.{oct_three.Text}.{111}";
        //        }
        //        else if (oct4 >= 112 && oct4 <= 127)
        //        {
        //            networkAddress_textBox.Text = $"{oct_one.Text}.{oct_two.Text}.{oct_three.Text}.{112}";
        //            firstUseable_textBox.Text = $"{oct_one.Text}.{oct_two.Text}.{oct_three.Text}.{113}";
        //            lastUseable_textBox.Text = $"{oct_one.Text}.{oct_two.Text}.{oct_three.Text}.{126}";
        //            broadcastAddress_textBox.Text = $"{oct_one.Text}.{oct_two.Text}.{oct_three.Text}.{127}";
        //        }
        //        else if (oct4 >= 128 && oct4 <= 143)
        //        {
        //            networkAddress_textBox.Text = $"{oct_one.Text}.{oct_two.Text}.{oct_three.Text}.{128}";
        //            firstUseable_textBox.Text = $"{oct_one.Text}.{oct_two.Text}.{oct_three.Text}.{129}";
        //            lastUseable_textBox.Text = $"{oct_one.Text}.{oct_two.Text}.{oct_three.Text}.{142}";
        //            broadcastAddress_textBox.Text = $"{oct_one.Text}.{oct_two.Text}.{oct_three.Text}.{143}";
        //        }
        //        else if (oct4 >= 144 && oct4 <= 159)
        //        {
        //            networkAddress_textBox.Text = $"{oct_one.Text}.{oct_two.Text}.{oct_three.Text}.{144}";
        //            firstUseable_textBox.Text = $"{oct_one.Text}.{oct_two.Text}.{oct_three.Text}.{145}";
        //            lastUseable_textBox.Text = $"{oct_one.Text}.{oct_two.Text}.{oct_three.Text}.{158}";
        //            broadcastAddress_textBox.Text = $"{oct_one.Text}.{oct_two.Text}.{oct_three.Text}.{159}";
        //        }
        //        else if (oct4 >= 160 && oct4 <= 175)
        //        {
        //            networkAddress_textBox.Text = $"{oct_one.Text}.{oct_two.Text}.{oct_three.Text}.{160}";
        //            firstUseable_textBox.Text = $"{oct_one.Text}.{oct_two.Text}.{oct_three.Text}.{161}";
        //            lastUseable_textBox.Text = $"{oct_one.Text}.{oct_two.Text}.{oct_three.Text}.{174}";
        //            broadcastAddress_textBox.Text = $"{oct_one.Text}.{oct_two.Text}.{oct_three.Text}.{175}";
        //        }
        //        else if (oct4 >= 176 && oct4 <= 191)
        //        {
        //            networkAddress_textBox.Text = $"{oct_one.Text}.{oct_two.Text}.{oct_three.Text}.{176}";
        //            firstUseable_textBox.Text = $"{oct_one.Text}.{oct_two.Text}.{oct_three.Text}.{177}";
        //            lastUseable_textBox.Text = $"{oct_one.Text}.{oct_two.Text}.{oct_three.Text}.{190}";
        //            broadcastAddress_textBox.Text = $"{oct_one.Text}.{oct_two.Text}.{oct_three.Text}.{191}";
        //        }
        //        else if (oct4 >= 192 && oct4 <= 207)
        //        {
        //            networkAddress_textBox.Text = $"{oct_one.Text}.{oct_two.Text}.{oct_three.Text}.{192}";
        //            firstUseable_textBox.Text = $"{oct_one.Text}.{oct_two.Text}.{oct_three.Text}.{193}";
        //            lastUseable_textBox.Text = $"{oct_one.Text}.{oct_two.Text}.{oct_three.Text}.{206}";
        //            broadcastAddress_textBox.Text = $"{oct_one.Text}.{oct_two.Text}.{oct_three.Text}.{207}";
        //        }
        //        else if (oct4 >= 208 && oct4 <= 223)
        //        {
        //            networkAddress_textBox.Text = $"{oct_one.Text}.{oct_two.Text}.{oct_three.Text}.{208}";
        //            firstUseable_textBox.Text = $"{oct_one.Text}.{oct_two.Text}.{oct_three.Text}.{209}";
        //            lastUseable_textBox.Text = $"{oct_one.Text}.{oct_two.Text}.{oct_three.Text}.{222}";
        //            broadcastAddress_textBox.Text = $"{oct_one.Text}.{oct_two.Text}.{oct_three.Text}.{223}";
        //        }
        //        else if (oct4 >= 224 && oct4 <= 239)
        //        {
        //            networkAddress_textBox.Text = $"{oct_one.Text}.{oct_two.Text}.{oct_three.Text}.{224}";
        //            firstUseable_textBox.Text = $"{oct_one.Text}.{oct_two.Text}.{oct_three.Text}.{225}";
        //            lastUseable_textBox.Text = $"{oct_one.Text}.{oct_two.Text}.{oct_three.Text}.{238}";
        //            broadcastAddress_textBox.Text = $"{oct_one.Text}.{oct_two.Text}.{oct_three.Text}.{239}";
        //        }
        //        else if (oct4 >= 240 && oct4 <= 254)
        //        {
        //            networkAddress_textBox.Text = $"{oct_one.Text}.{oct_two.Text}.{oct_three.Text}.{240}";
        //            firstUseable_textBox.Text = $"{oct_one.Text}.{oct_two.Text}.{oct_three.Text}.{241}";
        //            lastUseable_textBox.Text = $"{oct_one.Text}.{oct_two.Text}.{oct_three.Text}.{254}";
        //            broadcastAddress_textBox.Text = $"{oct_one.Text}.{oct_two.Text}.{oct_three.Text}.{255}";
        //        }
                  
        //        else
        //        {
        //            networkAddress_textBox.Text = $"{oct_one.Text}.{oct_two.Text}.{oct_three.Text}.{0}";
        //            firstUseable_textBox.Text = $"{oct_one.Text}.{oct_two.Text}.{oct_three.Text}.{1}";
        //            lastUseable_textBox.Text = $"{oct_one.Text}.{oct_two.Text}.{oct_three.Text}.{14}";
        //            broadcastAddress_textBox.Text = $"{oct_one.Text}.{oct_two.Text}.{oct_three.Text}.{15}";
        //        }

        //        if (cidr == 29)
        //        {
        //            if (oct4 >= 8)
        //            {
        //                netAddress = $"{oct_one.Text}.{oct_two.Text}.{oct_three.Text}.{ _NUM8}";

        //            }
        //            else
        //            {
        //                netAddress = $"{oct_one.Text}.{oct_two.Text}.{oct_three.Text}.{ _NUM0}";

        //            }
        //        }

        //        if (cidr == 30)
        //        {
        //            if (oct4 >= 4)
        //            {
        //                netAddress = $"{oct_one.Text}.{oct_two.Text}.{oct_three.Text}.{ _NUM4}";

        //            }
        //            else
        //            {
        //                netAddress = $"{oct_one.Text}.{oct_two.Text}.{oct_three.Text}.{ _NUM0}";

        //            }

        //        }










        //        if (cidr == 31)
        //        {
        //            if (oct4 >= 2)
        //            {
        //                netAddress = $"{oct_one.Text}.{oct_two.Text}.{oct_three.Text}.{ _NUM2}";

        //            }
        //            else
        //            {
        //                netAddress = $"{oct_one.Text}.{oct_two.Text}.{oct_three.Text}.{ _NUM0}";

        //            }
        //        }

        //        if (cidr == 32)
        //        {
        //            if (oct4 >= 1)
        //            {
        //                netAddress = $"{oct_one.Text}.{oct_two.Text}.{oct_three.Text}.{ _NUM1}";

        //            }
        //            else
        //            {
        //                netAddress = $"{oct_one.Text}.{oct_two.Text}.{oct_three.Text}.{ _NUM0}";

        //            }
        //        }


        //    }
        

        
    }
}




















































        
    

