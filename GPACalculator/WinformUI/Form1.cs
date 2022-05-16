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
using System.Data.SqlClient;
using System.Security.Cryptography;
namespace WinformUI
{
    public partial class Form1 : Form
    {
        int trackNum = 1;
        Student stu = new Student();
        public Form1()
        {
            InitializeComponent();
             //Load Combo boxes
            string[] comboClassGrade = { " ","A", "B", "C", "D", "F" };
            object[] creditsComboBox = { 0,1, 2, 3, 4 };

            //Load class grade combo boxes
            Class1_comboBox.Items.AddRange(comboClassGrade);
            Class2_comboBox.Items.AddRange(comboClassGrade);
            Class3_comboBox.Items.AddRange(comboClassGrade);
            Class4_comboBox.Items.AddRange(comboClassGrade);
            Class5_comboBox.Items.AddRange(comboClassGrade);
            Class6_comboBox.Items.AddRange(comboClassGrade);
            Class7_comboBox.Items.AddRange(comboClassGrade);
            Class8_comboBox.Items.AddRange(comboClassGrade);
            //Load class credits combo boxes
            credits1_comboBox.Items.AddRange(creditsComboBox);
            credits2_comboBox.Items.AddRange(creditsComboBox);
            credits3_comboBox.Items.AddRange(creditsComboBox);
            credits4_comboBox.Items.AddRange(creditsComboBox);
            credits5_comboBox.Items.AddRange(creditsComboBox);
            credits6_comboBox.Items.AddRange(creditsComboBox);
            credits7_comboBox.Items.AddRange(creditsComboBox);
            credits8_comboBox.Items.AddRange(creditsComboBox);
         }

        private void reset_button_Click(object sender, EventArgs e)
        {
            //Resets class/credit combo boxes
            Class1_comboBox.Text = " ";
            Class2_comboBox.Text = " ";
            Class3_comboBox.Text = " ";
            Class4_comboBox.Text = " ";
            Class5_comboBox.Text = " ";
            Class6_comboBox.Text = " ";
            Class7_comboBox.Text = " ";
            Class8_comboBox.Text = " ";

            credits1_comboBox.Text = "0";
            credits2_comboBox.Text = "0";
            credits3_comboBox.Text = "0";
            credits4_comboBox.Text = "0";
            credits5_comboBox.Text = "0";
            credits6_comboBox.Text = "0";
            credits7_comboBox.Text = "0";
            credits8_comboBox.Text = "0";
            studentName_textBox.Text = "";
            trackNum = 1; //Reset track number
        }

        private void resetStudInfo_button_Click(object sender, EventArgs e)
        {
            //Clears list box
            studentInfo_listBox.Items.Clear();
        }

        private void calculate_button_Click(object sender, EventArgs e)
        {
            string[] letterGradeArray = new string[8];
            int[] creditsArray = new int[8];            
            AddLetterGradeToArray(ref letterGradeArray);
            AddCreditsToArray(ref creditsArray);

            string semester = GetSemester();
            studentInfo_listBox.Items.Add("Entry: " + trackNum.ToString());
            studentInfo_listBox.Items.Add("Semester: " + semester);
            studentInfo_listBox.Items.Add("Student Name: " + studentName_textBox.Text);
            studentInfo_listBox.Items.Add("GPA: " + CalculateGPA(letterGradeArray, creditsArray));
            studentInfo_listBox.Items.Add("");//Line of separation
            stu.GPA = CalculateGPA(letterGradeArray, creditsArray);
            trackNum++;
        }
        private void AddLetterGradeToArray(ref string[] letterGradeArray)
        {
            letterGradeArray[0] = Class1_comboBox.Text;
            letterGradeArray[1] = Class2_comboBox.Text;
            letterGradeArray[2] = Class3_comboBox.Text;
            letterGradeArray[3] = Class4_comboBox.Text;
            letterGradeArray[4] = Class5_comboBox.Text;
            letterGradeArray[5] = Class6_comboBox.Text;
            letterGradeArray[6] = Class7_comboBox.Text;
            letterGradeArray[7] = Class8_comboBox.Text;
        }
        private void AddCreditsToArray(ref int[] creditsArray)
        {
            if(Class1_comboBox.Text == "" || credits1_comboBox.Text == "")
            {

            }
            else 
            {
                creditsArray[0] = int.Parse(credits1_comboBox.Text);
                 
            }
            if (Class2_comboBox.Text == "" || credits2_comboBox.Text == "")
            {

            }
            else
            {
                creditsArray[1] = int.Parse(credits2_comboBox.Text);
                 
            }
            if (Class3_comboBox.Text == "" || credits3_comboBox.Text == "")
            {

            }
            else
            {
                creditsArray[2] = int.Parse(credits3_comboBox.Text);
                 
            }
            if (Class4_comboBox.Text == "" || credits4_comboBox.Text == "")
            {

            }
            else
            {
                creditsArray[3] = int.Parse(credits4_comboBox.Text);
                 
            }
            if (Class5_comboBox.Text == "" || credits5_comboBox.Text == "")
            {

            }
            else
            {
                creditsArray[4] = int.Parse(credits5_comboBox.Text);
                 
            }
            if (Class6_comboBox.Text == "" || credits6_comboBox.Text == "")
            {

            }
            else
            {
                creditsArray[5] = int.Parse(credits6_comboBox.Text);
                 
            }
            if (Class7_comboBox.Text == "" || credits7_comboBox.Text == "")
            {

            }
            else
            {
                creditsArray[6] = int.Parse(credits7_comboBox.Text);
                
            }
            if (Class8_comboBox.Text == "" || credits8_comboBox.Text == "")
            {

            }
            else
            {
                creditsArray[7] = int.Parse(credits8_comboBox.Text);
                 
            }


        }
        private double CalculateGPA(string[] letterGradeArray, int[] creditsArray)
        {
            double points = 0;            
            double credits = 0;
            double gpa = 0;
            for(int i = 0; i < letterGradeArray.Length; i++)
            {
                
                switch (letterGradeArray[i])
                {
                    case "A":
                        points += creditsArray[i] * 4;
                        break;
                    case "B":
                        points += creditsArray[i] * 3;
                        break;
                    case "C":
                        points += creditsArray[i] * 2;
                        break;
                    case "D":
                        points += creditsArray[i] * 1;
                        break;
                    case "F":
                        points += creditsArray[i] * 0;
                        break;
                    default:
                        break;
                }
                credits += creditsArray[i];
                
            }     
            gpa = Math.Round(points / credits,2);             
            return gpa;
        }

        private string GetSemester()
        {
            string semester = "";
            if(spring_radioButton.Checked == true)
            {
                semester = "Spring";
            }
            if (fall_radioButton.Checked == true)
            {
                semester = "Fall";
            }
            if (summer_radioButton.Checked == true)
            {
                semester = "Summer";
            }

            return semester;
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveDoc_panel.Visible = true;
            
        }

        private void save_button_Click(object sender, EventArgs e)
        {
            string dir = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            string fileName = "/" + saveDoc_textBox.Text;
            using (StreamWriter write = new StreamWriter(dir + fileName))
            {
                try
                {
                    foreach(var element in studentInfo_listBox.Items)
                    {
                        write.WriteLine(element.ToString());
                    }
                    
                }
                catch(FileLoadException fileEx)
                {
                    MessageBox.Show(fileEx.ToString());
                }
                
            }
            saveDoc_panel.Visible = false;
            MessageBox.Show("Document saved successfully!");
        }

        private void cancel_button_Click(object sender, EventArgs e)
        {
            saveDoc_panel.Visible = false;
        }

        private void saveToDatabaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveToDB_panel.Visible = true;
        }

        private void saveToDBSave_button_Click(object sender, EventArgs e)
        {
            SqlConnection sqlCon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\oreng\source\repos\GPACalculator\WinformUI\StudentGPADatabase.mdf;Integrated Security=True");
            string password = Convert.ToBase64String(GetEncryptedKeys(saveToDBPassword_textBox.Text));
            string statement = "INSERT INTO StuGPATable(Name,Semester,GPA,Password)values('" + studentName_textBox.Text + "','" + GetSemester() + "','" + stu.GPA + "','" +password+ "')";
            sqlCon.Open();
            using(SqlCommand sqlCom = new SqlCommand(statement, sqlCon))
            {
                sqlCom.Parameters.AddWithValue(@"Name",studentName_textBox.Text);
                sqlCom.Parameters.AddWithValue(@"Semester", GetSemester());
                sqlCom.Parameters.AddWithValue(@"GPA", stu.GPA);
                sqlCom.Parameters.AddWithValue(@"Password", password );
                sqlCom.ExecuteNonQuery();

                sqlCon.Close();
                saveToDB_panel.Visible = false;

            }
        }

        private void saveToDBCancel_button_Click(object sender, EventArgs e)
        {
            saveToDB_panel.Visible = false;
        }

        static byte[] GetEncryptedKeys(string text)
        {
            var plainText = Encoding.ASCII.GetBytes(text);
            var hash = Encoding.ASCII.GetBytes("ShaFiveTwelve");
            byte[] encryptedKeys = new byte[plainText.Length + hash.Length];
            SHA512Managed algo = new SHA512Managed();
            for(int i = 0;i < plainText.Length; i++)
            {
                encryptedKeys[i] = plainText[i];
            }
            for(int i = 0; i <  hash.Length; i++)
            {
                encryptedKeys[plainText.Length + i] = hash[i];
            }

            return algo.ComputeHash(encryptedKeys);
        }

        private void openGPAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openGPA_Panel.Visible = true;
            dataGridViewBox.Visible = true;
        }

        private void OpenGPACancel_button_Click(object sender, EventArgs e)
        {
            openGPA_Panel.Visible = false;
            dataGridViewBox.Visible = false;
        }

        private void openGPA_button_Click(object sender, EventArgs e)
        {
             
            string connection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\oreng\source\repos\GPACalculator\WinformUI\StudentGPADatabase.mdf;Integrated Security=True";
            string password = Convert.ToBase64String(GetEncryptedKeys(openGPA_textBox.Text));

            string statement = "SELECT Name,Semester,GPA FROM StuGPATable WHERE Name = '"+studentsFullName_textBox.Text+"' And Password = '"+password+"'";
            using (SqlConnection sqlCon = new SqlConnection(connection))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDisplayAdapter = new SqlDataAdapter(statement,sqlCon);

                DataTable dataTable = new DataTable();
                sqlDisplayAdapter.Fill(dataTable);


                dataGridViewBox.DataSource = dataTable;
                 
            }
        }
          
    }
}
