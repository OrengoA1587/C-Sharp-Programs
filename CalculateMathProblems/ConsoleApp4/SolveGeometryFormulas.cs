using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalculatorLibrary;
namespace ConsoleApp4
{
    public class SolveGeometryFormulas
    {
        public static void SolveAreaOfTriangle()
        {

            //A=1/2 x base x height
            //Declare Variables
            double A = 0.0;
            double b = 0.0;
            double h = 0.0;
            string input;
            string[] numArray;
            //get input from user
            Console.WriteLine("Enter the base and height (ex. 2(base),5(height");
            input = Console.ReadLine();

            //Split input into separate subscripts
            numArray = input.Split(' ', '.', ',', '!', '\n', '?');
            try
            {
                b = double.Parse(numArray[0]);
                h = double.Parse(numArray[1]);

                Console.WriteLine($"The Area of the Triangle is: {A = .5 * b * h}");



            }
            catch(Exception e)
            {
                Console.WriteLine("Invalid input!");

            }

            Console.ReadLine();


        }

        public static void SolvePythagoreaTheorem()
        {
            Console.Clear();
            Console.WriteLine("PYTHAGOREAN THEOREM\n");
            string a1 = "\u00B2";
            //A=1/2 x base x height
            //Declare Variables
            double C = 0.0;
            double a = 0.0;
            double b = 0.0;
            string input;
            string[] numArray;
            //get input from user
            Console.WriteLine("Enter a and b (ex. 2,8");
            input = Console.ReadLine();

            //Split input into separate subscripts
            numArray = input.Split(' ', '.', ',', '!', '\n', '?');
            try
            {
                a = double.Parse(numArray[0]);
                b = double.Parse(numArray[1]);

                Console.WriteLine($"The Hypotenus is = {C = Math.Sqrt((a*a) + (b*b))}\n" +
                    $"The Area is: ");
            }
            catch (Exception e)
            {
                Console.WriteLine("Invalid input!");

            }

            Console.ReadLine();


        }
    }
}
