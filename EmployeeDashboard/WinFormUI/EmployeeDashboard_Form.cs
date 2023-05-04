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

        
    }
}
