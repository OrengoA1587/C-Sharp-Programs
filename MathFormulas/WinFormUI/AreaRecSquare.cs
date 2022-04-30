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
    public partial class AreaRecSquare : Form
    {
        public AreaRecSquare()
        {
            InitializeComponent();
        }

        private void calculate_AreaTriangle_button_Click(object sender, EventArgs e)
        {
            double length;
            double width;
            //Convert textbox input to double
            length = double.Parse(length_textBox1.Text);
            width = double.Parse(width_textBox1.Text);
            //Calculate answer
            double area = length * width;
            //Display answer
            answer_textBox1.Text = area.ToString();
            //Display reset button and label
            reset_button.Visible = true;
            startOver_label.Visible = true;
        }
        
        private void reset_button_Click(object sender, EventArgs e)
        {
            //Clear all text boxes and set visibility to false for reset button and label
            length_textBox1.Clear();
            width_textBox1.Clear();
            answer_textBox1.Clear();
            reset_button.Visible = false;
            startOver_label.Visible = false;
        }

        
    }
}
