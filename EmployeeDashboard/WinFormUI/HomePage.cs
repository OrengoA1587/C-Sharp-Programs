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
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void Login_Button_Click(object sender, EventArgs e)
        {
            LoginPage login = new LoginPage();
            login.Show();
        }
  

        private void Login_Button_MouseHover(object sender, EventArgs e)
        {
            Login_Button.BackgroundImage = Properties.Resources.Orange_image;
        }

        private void Login_Button_MouseLeave(object sender, EventArgs e)
        {
            Login_Button.BackgroundImage = Properties.Resources.Untitled_design_15_;
        }
    }
}
