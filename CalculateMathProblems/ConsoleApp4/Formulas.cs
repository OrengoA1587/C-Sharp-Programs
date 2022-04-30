using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalculatorLibrary;
namespace ConsoleApp4
{
    public class Formulas
    {
        public static void SolveQuadraticEquation()
        { 
            double a, b, c;
            double disc, deno, x1, x2;
            Console.WriteLine("ENTER THE VALUES OF A,B,C...");
            a = Convert.ToDouble(Console.ReadLine());
            b = Convert.ToDouble(Console.ReadLine());
            c = Convert.ToDouble(Console.ReadLine());
            if (a == 0)
            {
                x1 = -c / b;
                Console.WriteLine("The roots are Linear:", x1);
            }
            else
            {
                disc = (b * b) - (4 * a * c);
                deno = 2 * a;
                if (disc > 0)
                {
                    Console.WriteLine("THE ROOTS ARE REAL AND DISTINCT ROOTS");
                    x1 = (-b / deno) + (Math.Sqrt(disc) / deno);
                    x2 = (-b / deno) - (Math.Sqrt(disc) / deno);
                    Console.WriteLine("THE ROOTS ARE... " + x1 + " and " + x2);
                }
                else if (disc == 0)
                {
                    Console.WriteLine("THE ROOTS ARE REPEATED ROOTS");
                    x1 = -b / deno;
                    Console.WriteLine("THE ROOT IS...: " + x1);
                }
                else
                {
                    Console.WriteLine("THE ROOTS ARE IMAGINARY ROOTS\n");
                    x1 = -b / deno;
                    x2 = ((Math.Sqrt((4 * a * c) - (b * b))) / deno);
                    Console.WriteLine("THE ROOT 1: " + x1 + "+i" + x2);
                    Console.WriteLine("THE ROOT 2:" + x1 + "-i" + x2);
                }
            }
            Console.ReadLine();

        }
        //----------------------------------------------------SLOPE Formulas---------------------------------------------------------//
        public static void SolveSlopeFormula()
        {
            Console.Clear();
            //Slope Formula: M = (y2-y1) / (x2 - x1)

            //Declare variables
            double x1 = 0.0;
            double x2 = 0.0;
            double y1 = 0.0;
            double y2 = 0.0;
            double m = 0.0;
            double m1 = 0.0;
            double m2 = 0.0;
            string input;
            string coordinates;
            //Declare string array for user input
            string[] arrayNum;
            //Get coordinates from user
            Console.WriteLine("Enter x1,y1 coordinates (ex. 2,9)");
            input = Console.ReadLine();
            
            Console.WriteLine("Enter X2, Y2 coordinates (ex. 4,1)");
            input = input + "," + Console.ReadLine();

            Console.WriteLine(input);//Used for testing purposes. Will be removed on final launch.

            //Split array by specified characters
            arrayNum = input.Split(' ', '.', ',', '!', '\n', '?');
            //Used by developer to check the array subscripts. Will be removed on final launch.



            //Convert string subscripts to doublestry
            try
            {
                x1 = double.Parse(arrayNum[0]);
                y1 = double.Parse(arrayNum[1]);
                x2 = double.Parse(arrayNum[2]);
                y2 = double.Parse(arrayNum[3]);
            }
            catch(Exception e)
            {
                Console.WriteLine("Invalid Coordinates!");
            }
            Console.ReadLine();
            //Calculate Slope Formula
            m = (y2 - y1) / (x2 - x1);
            m1 = m;
            m2 = m;
            //Calculate Slope Intercept for y
            double b = 0.0;
            //y= MX + b

            //X1,Y1

            m = m * x1 + b;
            if (m < 0)
            {
                y1 = y1 + (m * -1);
            }
            //Slope Intercept

            //Check coordinates for same points
            if (x1 == x2 && y1 == y2 || x2 == x1 && y2 == y1)
            {
                Console.WriteLine($"Invalid Coordinates! These two point are the same\n" +
                                  $"X1 = X2 and Y1 = Y2\n" +
                                  $"{x1},{x2}   {y1},{y2}");
                Console.WriteLine("Press Enter to continue...");
            }
            else
            {
                Console.WriteLine($"Slope of the given line = {m2}");
                Console.WriteLine($"Y Intercept {y1}");
                Console.WriteLine($"Slope Intercept: y = {m1}x + {y1}");
                Console.WriteLine("\nPress Enter to continue...");
                
            }  

             
        }
        //----------------------------------------------------GEOMETRY Formulas---------------------------------------------------------//
        public static void GeometryFormulas(ref bool mainMenuLoop)
        {
            Console.Clear();


            do
            {
                //Get input from user by keyboard method
                ConsoleKeyInfo kb = new ConsoleKeyInfo();
                //Display Main Menu to the user
                Console.WriteLine(CalculatorLibrary.StandardMessages.DisplayGeometryMenu());
                kb = Console.ReadKey();
                switch (kb.Key)
                {
                    case ConsoleKey.D1:
                        SolveGeometryFormulas.SolveAreaOfTriangle();
                        break;
                    case ConsoleKey.D2:
                        SolveGeometryFormulas.SolvePythagoreaTheorem();
                        break;
                    case ConsoleKey.D3:

                        break;
                    case ConsoleKey.D4:

                        break;
                    case ConsoleKey.Escape:
                        
                        break;
                    default:



                        break;
                }
                Console.ReadLine();


            } while (mainMenuLoop == false);
            Console.WriteLine(StandardMessages.DisplayGeometryMenu());

        }

        
    }
}
