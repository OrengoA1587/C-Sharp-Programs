using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinformUI
{
    public partial class DatamanGame : Form
    {
        int count = 0;
        double timerCount = 0.0;
        bool gameOnMode = false;
        bool answerChecker = false;
        string problem = "";
        List<string> problemList;
        public DatamanGame()
        {             
              InitializeComponent();           
             
        }

        private void on_button_click(object sender, EventArgs e)
        {
            Font font = new Font("Microsoft Himalyan", 32.0f,
                       FontStyle.Bold | FontStyle.Italic);
            input_textBox.Font = font;
            input_textBox.Text = "Welcome To Dataman";
            gameOnMode = true;
            timer1.Enabled = true;
            //input_textBox.Text = "           Welcome\n" +
            //                     "                          To\n" +
            //                     "                          Dataman";   
        }
        private void off_button_Click(object sender, EventArgs e)
        {
            if(gameOnMode == true)
            {
                Font font = new Font("Microsoft Himalyan", 32.0f,
                       FontStyle.Bold | FontStyle.Italic);
                input_textBox.Font = font;
                input_textBox.Text = "Goodbye";
                gameOnMode = false;
                timer1.Enabled = true;
            }
            
        }
        private void buttonClickedText(object sender, EventArgs e)
        {
            if(gameOnMode == true)
            {
                //Microsoft YaHei, 36pt, style=Bold
                Font font = new Font("Microsoft YaHei", 30.0f,
                           FontStyle.Bold);
                input_textBox.Font = font;
                if (input_textBox.Text == "Great Job!" || input_textBox.Text == "EEEE" || input_textBox.Text == "Welcome To Dataman" || input_textBox.Text == "Invalid Entry!")
                {
                    input_textBox.Clear();
                }
                var buttonText = ((Button)sender).Text;
                input_textBox.AppendText(buttonText);
                 
                 
            }
            else
            {

            }
             
        }

        private void buttonEquals_Click(object sender, EventArgs e)
        {

            problem = input_textBox.Text;
            string[] problemList = Regex.Split(problem, @"([*()\^\/]|(?<!E)[\+\-]|[/\=])");            

            try
            {
                int num1 = int.Parse(problemList[0].ToString());
                int num2 = int.Parse(problemList[2].ToString());
                int userAnswer = int.Parse(problemList[4].ToString());
                int trueAnswer = GetOperators(problemList[1].ToString(), num1, num2);
                if (userAnswer == trueAnswer)
                {
                    input_textBox.Text = "Great Job!";
                    timer1.Enabled = true;
                    count = 0;
                }
                else
                {                    
                     
                    if (count == 0)
                    {                         
                        input_textBox.Text = problemList[0].ToString() + problemList[1].ToString() + problemList[2].ToString() + problemList[3].ToString();
                        count++;                       
                         
                    }
                     
                    else if (count == 1)
                    {
                        timer1.Enabled = true;
                        input_textBox.Text = "EEE";
                        input_textBox.Text = problemList[0].ToString() + problemList[1].ToString() + problemList[2].ToString() + problemList[3].ToString() + trueAnswer.ToString();
                        count = 0;
                    }
                }
            }
            catch (Exception x)
            {
                input_textBox.Clear();
                input_textBox.Text = "Invalid Entry!";
                 
                
            }
        }

        private int GetOperators(string op, int num1, int num2)
        {

            switch (op)
            {
                case "+":
                    return num1 + num2; 
                case "-":
                    return num1 - num2;
                     
                case "x":
                    return num1 * num2;
                     
                case "/":
                    return num1 / num2;
                     
                default:
                    return num1 + num2;
                     
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            timerCount++;

            if (timerCount == 1)
            {
                input_textBox.Clear();
                timerCount = 0;
                timer1.Enabled=false;
            }
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            timerCount++;
            input_textBox.Text = "EEE";
            if (timerCount == 1)
            {
                 
                timerCount = 0;
                timer1.Enabled = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

       
    }
}
