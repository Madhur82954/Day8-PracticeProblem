using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Day_8Practice
{
    internal class ImageFileExtension
    {
        public void CheckImageFileExtension()
        {
            Console.WriteLine("Enter File Name: ");
            string s4 = Console.ReadLine();
            string pattern5 = "^[a-zA-Z0-9]{1,}.(jpg|jpeg|png|gif|bim)$";
            Regex regex3 = new Regex(pattern5);
            if (regex3.IsMatch(s4))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Valid File Name");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Invalid File Name");
                Console.ResetColor();
            }
        }
    }
}
