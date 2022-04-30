using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        public static bool CheckPalindrome(string userInput)
        {
            string firstHalf = userInput.Substring(0, userInput.Length / 2);
            char[] array = userInput.ToCharArray();

            Array.Reverse(array);

            string testText = new string(array);
            string secondText = testText.Substring(0,testText.Length / 2);

            return firstHalf.Equals(secondText);
             
        }
        public static bool checkPalindrome2(string mainString)
        {
            return mainString.SequenceEqual(mainString.Reverse());
        }
        static void Main(string[] args)
        {

            //string text = "madam";
            //Console.WriteLine("Enter word: ");
            //string userInput = Console.ReadLine();
            //bool palidrome = CheckPalindrome(userInput);
            //Console.WriteLine(palidrome);
            //Console.ReadLine();


            Console.WriteLine("Enter word: ");
            string userInput2 = Console.ReadLine();

            char[] array = userInput2.ToCharArray();
            string test1 = new string(array);

            Array.Reverse(array);
            string test2 = new string(array);



            if(test1 == test2)
            {

                Console.WriteLine("Is palindrome!");
            }
            else
            {
                Console.WriteLine("Is not palindrome!");
            }
            Console.ReadLine();
        }
    }
}
