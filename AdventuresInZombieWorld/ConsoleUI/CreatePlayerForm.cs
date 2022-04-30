using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GameLibrary;
using System.IO;
using Xamarin.Forms;
using System.Runtime.InteropServices;
using System.Data.SqlClient;
using System.Security.Cryptography;
namespace ConsoleUI
{
    public partial class CreatePlayerForm : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "DeleteObject")]
        public static extern bool DeleteObject(IntPtr hObject);
        //data base C:\Users\oreng\source\repos\AdventuresInZombieWorld\ZombieAdventureDB\PlayerTable.sql
        StartAdventureForm StartAdventureForm = new StartAdventureForm();

        //
        //Soldier Images
        Bitmap soldierImage1 = Properties.Resources.SoldierImage;
        Bitmap soldierImage2 = Properties.Resources.SoldierImage2;
        Bitmap soldierImage3 = Properties.Resources.SoldierImage3;
        Bitmap soldierImage4 = Properties.Resources.SoldierImage4;
        Bitmap soldierImage5a = Properties.Resources.SoldierImage5a;
        Bitmap soldierImage6 = Properties.Resources.SoldierImage6;
        Bitmap soldierImage7 = Properties.Resources.SoldierImage7;
        //Soldier Stats
        Bitmap ryanCrossStats = Properties.Resources.SGTRyanCrossStatsImage__2_;
        Bitmap chrisAveryStats = Properties.Resources.SGTChrisAveryStatsImage;
        Bitmap sarahWoodStats = Properties.Resources.SSGTSarahWoodImage;
        Bitmap jasonCraneStats = Properties.Resources.SSGCraneStatsImage;
        Bitmap steveWestoverStats = Properties.Resources.LTWestlakeStatsImage;
        Bitmap commanderWestlakeStats = Properties.Resources.CMDWestlakeStatsImage;
        Bitmap cptLangley = Properties.Resources.CMDLangleyStatsImage;
        string playerStatType = "ryanCross";
        string playerType = "ryanCross";
        //Player player;
        public CreatePlayerForm()
        {
            InitializeComponent();
            player_imageBox.Image = soldierImage1;
            playerStat_pictureBox.Image = ryanCrossStats;
            
        }
        //Get player data
        //Save data to text doc
        //Read data from text doc/or excel to create player object

        private void next_button_Click(object sender, EventArgs e)
        {
             
            if (player_imageBox.Image == soldierImage1)
            {
                playerStat_pictureBox.Image = chrisAveryStats;
                player_imageBox.Image = soldierImage2;
                playerStatType = "chrisAvery";
                playerType = "chrisAvery";                
            }
            else if (player_imageBox.Image == soldierImage2)
            {
                playerStat_pictureBox.Image = sarahWoodStats;
                player_imageBox.Image = soldierImage3;
                playerStatType = "sarahWood";
                playerType = "sarahWood";
            }
            else if (player_imageBox.Image == soldierImage3)
            {
                playerStat_pictureBox.Image = jasonCraneStats;
                player_imageBox.Image = soldierImage4;
                playerStatType = "jasonCrane";
                playerType = "jasonCrane";
            }
            else if (player_imageBox.Image == soldierImage4)
            {
                playerStat_pictureBox.Image = steveWestoverStats;
                player_imageBox.Image = soldierImage5a;
                playerStatType = "steveWestover";
                playerType = "steveWestover";
            }
            else if (player_imageBox.Image == soldierImage5a)
            {
                playerStat_pictureBox.Image = cptLangley;
                player_imageBox.Image = soldierImage6;
                playerStatType = "langley";
                playerType = "langley";
            }
            else if (player_imageBox.Image == soldierImage6)
            {
                playerStat_pictureBox.Image = commanderWestlakeStats;
                player_imageBox.Image = soldierImage7;
                playerStatType = "westlake";
                playerType = "westlake";
            }
        }

        private void prev_button_Click(object sender, EventArgs e)
        {
            if (player_imageBox.Image == soldierImage7)
            {
                playerStat_pictureBox.Image = cptLangley;
                player_imageBox.Image = soldierImage6;
                playerStatType = "steveWestover";
                playerType = "steveWestover";
            }
            else if (player_imageBox.Image == soldierImage6)
            {
                playerStat_pictureBox.Image = steveWestoverStats;
                player_imageBox.Image = soldierImage5a;
                playerStatType = "steveWestover";
                playerType = "steveWestover";
            }
            else if (player_imageBox.Image == soldierImage5a)
            {
                playerStat_pictureBox.Image = jasonCraneStats;
                player_imageBox.Image = soldierImage4;
                playerStatType = "jasonCrane";
                playerType = "jasonCrane";
            }
            else if (player_imageBox.Image == soldierImage4)
            {
                playerStat_pictureBox.Image = sarahWoodStats;
                player_imageBox.Image = soldierImage3;
                playerStatType = "sarahWood";
                playerType = "sarahWood";
            }
            else if (player_imageBox.Image == soldierImage3)
            {
                playerStat_pictureBox.Image = chrisAveryStats;
                player_imageBox.Image = soldierImage2;
                playerStatType = "chrisAvery";
                playerType = "chrisAvery";
            }
            else if (player_imageBox.Image == soldierImage2)
            {
                player_imageBox.Image = soldierImage1;
                playerStat_pictureBox.Image = ryanCrossStats;
                playerStatType = "ryanCross";
                playerType = "ryanCross";
            }

        }
        private void submit_button_Click(object sender, EventArgs e)
        {
             
            //SqlDataConString.txt
            string dir = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            string connnectionString = "";
            using (StreamReader readDoc = new StreamReader(dir + "/SqlDataConString.txt"))
            {
                connnectionString = readDoc.ReadToEnd();
            }
            SqlConnection sqlcon = new SqlConnection($@"{connnectionString}");

            if (password2_textBox.Text == password_textBox.Text)
            {
                string password;
                DialogResult result = MessageBox.Show("Do you wish to continue?", "Warning",
                MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    //Encrypt Password
                    password = Convert.ToBase64String(GenerateEncryptionKeys(password_textBox.Text));
                    //Add to database
                    string sqlStatement = "INSERT INTO dbo.PlayerTable(UserName,Password,PlayerType,PlayerStat)values('" + name_textBox.Text + "','" + password + "','" + playerType + "','" + playerStatType + "')";
                    sqlcon.Open();
                    using (SqlCommand sqlcom = new SqlCommand(sqlStatement, sqlcon))
                    {
                        sqlcom.Parameters.AddWithValue("@UserName", name_textBox.Text);
                        sqlcom.Parameters.AddWithValue("@Password", password);
                        sqlcom.Parameters.AddWithValue("@PlayerType", playerType);
                        sqlcom.Parameters.AddWithValue("@PlayerStat", playerStatType);
                        sqlcom.ExecuteNonQuery();
                        sqlcon.Close();

                        MessageBox.Show("Added Successfully!");
                    }
                      StartAdventureForm.Show();
                }
                else if (result == DialogResult.No)
                {
                    //Return
                }
                else if (result == DialogResult.Cancel)
                {
                    //code for Cancel
                }
            }
            else
            {
                 DialogResult result = MessageBox.Show("Passwords do not match!", "Warning",
                 MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }
        static byte[] GenerateEncryptionKeys(string plainText)
        {
            string dir = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            SHA512Managed algorithm = new SHA512Managed();
            var pt = Encoding.ASCII.GetBytes(plainText);
            string getHash;
            using (StreamReader readLine = new StreamReader(dir + $@"/CrytKHS.txt"))
            {
                getHash = readLine.ReadToEnd();
            }
            var salt = Encoding.ASCII.GetBytes(getHash);
            byte[] EncryptedKeys = new byte[plainText.Length + salt.Length];

            for(int i = 0; i < pt.Length; i++)
            {
                EncryptedKeys[i] = pt[i];
            }
            for (int i = 0; i < salt.Length; i++)
            {
                EncryptedKeys[pt.Length + i] = salt[i];
            }
            return algorithm.ComputeHash(EncryptedKeys);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
