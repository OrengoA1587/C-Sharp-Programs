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
    public partial class AreaOfCircle : Form
    {
        //const double PIE = 3.1415926535898;
        double cirRadius;
        double diameter;
        double circum;
        double area;
        public AreaOfCircle()
        {
            InitializeComponent();
        }
         
        private void calculate_button_Click_1(object sender, EventArgs e)
        {
            
            cirRadius = double.Parse(radius_textBox.Text);

            // FInd Area/Diameter/Circumference
            diameter = 2 * cirRadius;
            circum = 2 * Math.PI * 12;
            area = Math.PI * (cirRadius * cirRadius);     

           
            //Display
            area_textBox.Text = area.ToString();
            Circum_textBox.Text = circum.ToString();
            diameter_textBox.Text = diameter.ToString();

            //Reduce Decimal to 2
            area_textBox2.Text = Math.Round(area, 2).ToString();
            circum_textBox2.Text = Math.Round(circum, 2).ToString();
            diameter_textBox2.Text = Math.Round(diameter, 2).ToString();
        }
 
        private void Clear_Button_Click(object sender, EventArgs e)
        {
            area_textBox.Clear();
            Circum_textBox.Clear();
            diameter_textBox.Clear();
            radius_textBox.Clear();
        }
    }
}
