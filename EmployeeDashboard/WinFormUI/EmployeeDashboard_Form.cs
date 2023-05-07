using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Security.Permissions;
using System.Drawing.Printing;

namespace WinFormUI
{
    public partial class EmployeeDashboard_Form : Form
    {
        [PermissionSet(SecurityAction.Demand, Name = "FullTrust")]
         
        public EmployeeDashboard_Form()
        {
            InitializeComponent();
            // WebBrowser Configuration:
            cisco_webBrowser.ObjectForScripting = new ObjectForScripting();
            cisco_webBrowser.AllowWebBrowserDrop = false;
            cisco_webBrowser.ScriptErrorsSuppressed = true;
            cisco_webBrowser.WebBrowserShortcutsEnabled = false;
            cisco_webBrowser.IsWebBrowserContextMenuEnabled = false;

            cisco_webBrowser.Navigate("https://www.netacad.com/");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute(true)]
        public class ObjectForScripting
        {

            // User Code to handle events..

        }

        private void subnetCalculatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SubnetForm subForm = new SubnetForm();
            subForm.Show();
        }

        private void hostCalculatorToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            HostCalculatorForm hostForm = new HostCalculatorForm();
            hostForm.Show();
        }

        private void bitCalculatorToolStripMenuItem2_Click_1(object sender, EventArgs e)
        {
            SubnetCalculatorForm subCalForm = new SubnetCalculatorForm();
            subCalForm.Show();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            cisco_webBrowser.GoBack();
        }

        private void forward_button_Click(object sender, EventArgs e)
        {
            cisco_webBrowser.GoForward();
        }

        private void refresh_button_Click(object sender, EventArgs e)
        {
            cisco_webBrowser.Refresh();
        }

        private void go_button_Click(object sender, EventArgs e)
        {
            cisco_webBrowser.Navigate(url_textBox.Text);
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {

        }

        private void x_Button_MouseHover(object sender, EventArgs e)
        {
            x_Button.BackColor = Color.Red;
            x_Button.ForeColor = Color.White;
        }

        private void x_Button_MouseLeave(object sender, EventArgs e)
        {
            x_Button.BackColor = Color.LightGray;
            x_Button.ForeColor = Color.Black;
        }

        private void x_Button_Click(object sender, EventArgs e)
        {
            Close();
        }

        
        
        
        private void minimized_button_Click_1(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
            MinimumSize = new Size(500,500);
        }

        private void maximize_button_Click_1(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

       
        private void url_textBox_MouseEnter(object sender, EventArgs e)
        {
            cisco_webBrowser.Navigate(url_textBox.Text);
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

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintDialog print = new PrintDialog();
            PrintDocument printDocument = new PrintDocument();
            print.Document = printDocument;
            print.AllowSelection = true;

            print.AllowSomePages = true; ;
            print.ShowDialog();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm about = new AboutForm();
            about.ShowDialog();
        }
    }
}
