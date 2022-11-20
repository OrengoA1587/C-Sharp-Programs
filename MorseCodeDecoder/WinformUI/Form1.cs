using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml.Linq;

namespace WinformUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void on_button_Click(object sender, EventArgs e)
        {
            string dir = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            //MessageBox.Show(dir);
            System.Media.SoundPlayer player = new System.Media.SoundPlayer();
            // player.SoundLocation = "C:\\Users\\oreng\\OneDrive\\Documents\\Sound Recordings\\keep\\off.wav";
            player.SoundLocation = dir + @"\off.wav";
            player.Play();
            displayCode_textBox.AppendText(".");
        }

        private void off_button_Click(object sender, EventArgs e)
        {
            string dir = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            //MessageBox.Show(dir);
            System.Media.SoundPlayer player = new System.Media.SoundPlayer();
            // player.SoundLocation = "C:\\Users\\oreng\\OneDrive\\Documents\\Sound Recordings\\keep\\off.wav";
            player.SoundLocation = dir + @"\on.wav";
            player.Play();
            displayCode_textBox.AppendText("-");
        }

        private void send_button_Click(object sender, EventArgs e)
        {

            List<string> codeList = new List<string>();
            string text = displayCode_textBox.Text;

            codeList = text.Split(',').ToList();
            for (int i = 0; i < codeList.Count; i++)
            {
                if (codeList[i] == "")
                {
                    codeList.RemoveAt(i);
                }


            }
            //foreach (string code in codeList)
            //{
            //    if(code == " ")
            //    {
            //        code.Remove();
            //    }
            //}
            DecodeMorse(codeList);
            displayCode_textBox.Clear();
        }

        private void DecodeMorse(List<string> code)
        {
            List<string> decodeList = new List<string>();
            Dictionary<string, string> My_dict2 =
            new Dictionary<string, string>(){
              {".-","A"},{"-...","B" },{"-.-.","C" },{"-..","D" },{".","E"},{"..-.","F" },{"--.","G" },{"....","H" },{"..","I" },{".---","J" },{"-.-","K" },
              {".-..","L" },{"--","M"},{"-.","N"},{"---","O" },{".--.","P" },{"--.-","Q" },{".-.","R" },{"...","S"},{"-","T"},{"..-","U" },{"...-","V" },
              {".--","W" },{"-..-","X" },{"-.--","Y" },{"--..","Z" },{"-----","0" },{".----","1" },{"..---","2" },{"...--","3" },{"....-","4" },{".....","5" },{"-....","6" },
              {"--...","7" },{"---..","8" },{"----.","9" }};

            foreach (var element in code)
            {
                try
                {
                    decodeList.Add(My_dict2[element]);
                }
                catch(Exception e)
                {
                    decode_textBox.Text = "Invalid Code";
                } 
            }
            foreach (var element in decodeList)
            {
                decode_textBox.AppendText(element);
            }
        }

        private void space_button_Click(object sender, EventArgs e)
        {
            displayCode_textBox.AppendText(",");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            displayCode_textBox.Clear();
            decode_textBox.Clear();
        }

        private void decode_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void on_button_MouseHover(object sender, EventArgs e)
        {
             on_button.ForeColor = Color.Red;
        }

        private void on_button_MouseLeave(object sender, EventArgs e)
        {
            on_button.ForeColor = Color.Black;
        }

        private void off_button_MouseHover(object sender, EventArgs e)
        {
            off_button.ForeColor = Color.Red;
        }

        private void off_button_MouseLeave(object sender, EventArgs e)
        {
            off_button.ForeColor = Color.Black;
        }
    }
}