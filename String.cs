using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Day_8Practice
{
    internal class String
    {
        public void checkstring()
        {
            Console.WriteLine("Enter string : ");
            string s = Console.ReadLine();
            string pattern1 = "^[a]{1}[b]{2,3}$";
            Regex regex = new Regex(pattern1);
            if (regex.IsMatch(s))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Valid String");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Invalid String");
                Console.ResetColor();
            }
        }
    }
}
