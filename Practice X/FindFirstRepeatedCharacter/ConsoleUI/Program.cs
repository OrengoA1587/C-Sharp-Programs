using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {

        public static char GetRepeatedChar(char[]wordCharArray)
        {
            HashSet<char> h = new HashSet<char>();
            for(int i = 0; i<= wordCharArray.Length - i;i++)
            {
                char c = wordCharArray[i];

                if (h.Contains(c))
                {
                    return c;
                }
                else
                {
                    h.Add(c);
                }
            }
            return '\0';
        }
        static void Main(string[] args)
        {
            string word = "abbcde";
            char[] wordCharArray = word.ToCharArray();

            Console.WriteLine(GetRepeatedChar(wordCharArray));
            Console.ReadLine();
        }
    }
}
