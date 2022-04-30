using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsoleUI
{
    public partial class MainMenu : Form
    {
        LoginForm loginFM = new LoginForm();
        CreatePlayerForm createPlayer = new CreatePlayerForm();

        public MainMenu()
        {
            InitializeComponent();
             

        }

         

        private void exit_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void startAdventure_button_Click(object sender, EventArgs e)
        {
            //startAdventure_button.Visible = false;
            //setting_button.Visible = false;
            //exit_button.Visible = false;
            //continueAdventure_button.Visible = false;
            //playerStat_button.Visible = false;
            //begin_button.Visible = true;            
            createPlayer.ShowDialog();             
            
        }

        private void continueAdventure_button_Click(object sender, EventArgs e)
        {
            loginFM.ShowDialog();
        }

        private void startAdv_MouseHover(object sender, EventArgs e)
        {
            startAdventure_button.ForeColor = Color.White;
        }

        private void startAdv_MouseLeave(object sender, EventArgs e)
        {
            startAdventure_button.ForeColor = Color.Red;
        }
    }
}
