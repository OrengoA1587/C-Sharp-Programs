using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public class GetNumbers
    {
        public static void GetNumbersForAddition(ref double num1, ref double num2, ref double answer)
        {
            Console.Clear();
            //DisplayDocuments.DisplayAdditionPage();
            string input = "";

            Console.WriteLine("Enter Num1: ");
            input = Console.ReadLine();
            if(double.TryParse(input, out num1)){
                Console.WriteLine("Enter Num2: ");
                input = Console.ReadLine();
                if (double.TryParse(input, out num2))
                {
                    
                    CalculatorLibrary.CalculateNumbers.AddNumbers(ref num1, ref num2, ref answer);
                    Console.WriteLine($"The Answer is: " + answer);
                    Console.ReadLine();
                }
                else
                {

                }
            }
            else
            {

            }

        }
    }
}
