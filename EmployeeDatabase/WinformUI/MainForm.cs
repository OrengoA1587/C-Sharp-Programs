using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
 

namespace WinformUI
{
    public partial class MainForm : Form
    {
        SelectOptionForm selectOption = new SelectOptionForm();  //Create new form 
        public MainForm()
        {
            InitializeComponent();
        }
 
        private void start_button_Click(object sender, EventArgs e)
        {
            start_button.Visible = false;
            this.progressBar_timer.Start(); //Start timer for progress bar
            mainForm_progressBar.Visible = true; //Set visibility to true for progress bar
            
        }
        private void progressBar_timer_Tick(object sender, EventArgs e)
        {
            this.mainForm_progressBar.Increment(5);
            if (mainForm_progressBar.Value >= 100)
            {
                enter_button.Visible = true;

            }
            else 
            {
                
            }
        }

        private void enter_button_Click(object sender, EventArgs e)
        {
             
            selectOption.Show();           

        }

        private void appExit_button_Click(object sender, EventArgs e)
        {
            Application.Exit();//Exits application
        }

        private void excelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExportToExcelForm excelExport = new ExportToExcelForm();
            excelExport.Show();
//           
        }

         
    }
}
