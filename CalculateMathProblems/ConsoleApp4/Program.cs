using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalculatorLibrary;
using System.Data.SqlClient;
 namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            //Declare loop sentinel
            bool mainMenuLoop = false;
            double num1 = 0.0;
            double num2 = 0.0;
            double answer = 0.0;
            //string connection = @"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = master; Integrated Security = True";
            string connection = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\oreng\source\repos\CalculateMathProblems\ConsoleApp4\Database1.mdf; Integrated Security = True";
            string name;
            string age;
            
             //Get user information
            Console.WriteLine("Enter you Name: ");
            name = Console.ReadLine();

            Console.WriteLine("Enter your age: ");
            age = Console.ReadLine();
            string insStmt = "INSERT INTO dbo.UserTable (name,age) values ('" + name + "','" + age + "')";
            using (SqlConnection sqlCon = new SqlConnection(connection))
            {
                try
                {
                    sqlCon.Open();
                    SqlCommand insCmd = new SqlCommand(insStmt, sqlCon);
                    
                    insCmd.Parameters.AddWithValue("@name", name);
                    insCmd.Parameters.AddWithValue("@age", age);
                    insCmd.ExecuteNonQuery();                

                }
                catch(SqlException sqlEx)
                {
                    Console.WriteLine(sqlEx);
                }
                
            }
            do
            {
                Console.WriteLine($" C \u2082 ");

                //Get input from user by keyboard method
                ConsoleKeyInfo kb = new ConsoleKeyInfo();
                //Display Main Menu to the user
                Console.WriteLine(CalculatorLibrary.StandardMessages.DisplayMainMenu());
                kb = Console.ReadKey();
                switch (kb.Key)
                {
                    case ConsoleKey.D1:
                        //Method to get numbers from user
                        GetNumbers.GetNumbersForAddition(ref num1, ref num2, ref answer);
                         
                        break;
                    case ConsoleKey.D2:
                        Formulas.SolveSlopeFormula();
                        //Formulas.SolveQuadraticEquation();
                        break;
                    case ConsoleKey.D3:
                        Formulas.GeometryFormulas(ref mainMenuLoop);
                        break;
                    case ConsoleKey.D4:
                        
                        break;
                    case ConsoleKey.Escape:
                        mainMenuLoop = true;
                        Console.WriteLine("Press Enter to exit!");
                        break;
                    default:



                        break;
                }
                Console.ReadLine();


            } while (mainMenuLoop == false);
        }
    }
}
