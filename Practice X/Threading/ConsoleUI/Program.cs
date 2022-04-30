using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace ConsoleUI
{
    class Program
    {
        public static char FindRecurrentChar(char[] array)
        {
            HashSet<char> hashSet = new HashSet<char>();

            for(int i = 0; i <= array.Length - 1; i++)
            {
                char c = array[i];
                if (hashSet.Contains(c))
                {
                    return c;
                }
                else
                {
                    hashSet.Add(c);
                }


            }
            return '\0';
        }

        static void Main(string[] args)
        {

            string recurrentChar = "apple";
            char[] array = recurrentChar.ToCharArray();
            Console.WriteLine(FindRecurrentChar(array));
            Console.ReadLine();


            Thread one = Thread.CurrentThread;
            
            one.Name = "Main Thread";
            Console.WriteLine(one.Name);


           // CountDown();
            
            Console.ReadLine();


        }
        public static void CountDown()
        {
            for(int i = 10; i >= 0; i--)
            {
                Console.WriteLine("Timer# 1 " + i + " seconds");
                Thread.Sleep(1000);
                Console.Clear();
            }
            Console.WriteLine("Timer is complete");
        }
    }
}
