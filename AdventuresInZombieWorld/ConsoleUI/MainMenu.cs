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
        WMPLib.WindowsMediaPlayer player = new WMPLib.WindowsMediaPlayer();

        LoginForm loginFM = new LoginForm();
        CreatePlayerForm createPlayer = new CreatePlayerForm();

        public MainMenu()
        {
            InitializeComponent();
            player.URL = @"C:\Users\oreng\Downloads\zapsplat_science_fiction_computer_button_press_003_83252.mp3";

        }

         

        private void exit_button_Click(object sender, EventArgs e)
        {
            player.controls.play();
            DialogResult result = MessageBox.Show("Do you wish to continue?", "Warning",
                MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            if(result == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {

            }
        }

        private void startAdventure_button_Click(object sender, EventArgs e)
        {
            player.controls.play();
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
            player.controls.play();
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
