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
    public partial class StartAdventureForm : Form
    {
        public StartAdventureForm()
        {
            InitializeComponent();
        }

        private void start_button_Click(object sender, EventArgs e)
        {
            this.timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar.Increment(5);
            if(progressBar.Value >= 100)
            {
                start_button.Visible = false;
            }
            else
            {

            }
        }

        private void enter_Button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
