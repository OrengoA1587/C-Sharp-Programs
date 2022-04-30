using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Given a string s consisting of some words separated by some number of spaces, return the length of the last word in the string.

A word is a maximal substring consisting of non-space characters only.*/ 
 
namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "Hello World     john";
            string target;
            string[] array = s.Split(' ');

            int i = array.Length;

            target = array[i - 1];

            char[] charArray = target.ToCharArray();
            int x = charArray.Length;
            Console.WriteLine($"{target}  {x}");
            Console.ReadLine();

        }
       
 
    }
}
