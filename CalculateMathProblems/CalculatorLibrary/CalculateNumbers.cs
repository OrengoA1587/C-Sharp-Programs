using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorLibrary
{
    public class CalculateNumbers
    {
        public static double AddNumbers(ref double num1, ref double num2, ref double answer)
        {
            //Calculates numbers using addition
            answer = num1 + num2;            
            //Return answer to user
            return answer;
        }
    }
}
