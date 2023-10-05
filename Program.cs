using System;
using System.Text.RegularExpressions;
namespace Day_8Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter string : ");
            string s = Console.ReadLine();
            Console.WriteLine("Enter LowerCase : ");
            string s1 = Console.ReadLine();
            Console.WriteLine("Enter Html Tags : ");
            string s2 = Console.ReadLine();
            Console.WriteLine("Enter string to find Number Of Occurences:");
            string s3 = Console.ReadLine();
            Console.WriteLine("Enter File Name: ");
            string s4 = Console.ReadLine();
            Console.WriteLine("Enter Website Address: ");
            string s5 = Console.ReadLine();
            string pattern1 = "^[a]{1}[b]{2,3}$";
            string pattern2 = "^[a-z]{4,}[_]{1}$";
            string pattern3 = "<([a-z]+)(?![^>]*/>)[^>]*";
            string pattern4 = "fox(es)?";
            string pattern5 = "^[^\\s]+\\.(jpg|jpeg|png|gif|bim)$";
            string pattern6 = "(https:\\/\\/www\\.|http:\\/\\/www\\.|https:\\/\\/|http:\\/\\/)?[a-zA-Z0-9]{2,}(\\.[a-zA-Z0-9]{2,})(\\.[a-zA-Z0-9]{2,})?";
            Regex regex = new Regex(pattern1);
            Regex regex1 = new Regex(pattern2);
            Regex regex2 = new Regex(pattern3);
            Regex regex3 = new Regex(pattern5);
            Regex regex4 = new Regex(pattern6);
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
            if (regex1.IsMatch(s1))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Valid LowerCase");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Invalid LowerCase");
                Console.ResetColor();
            }
            if (regex2.IsMatch(s2))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Valid Html Tags");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Invalid Html Tags");
                Console.ResetColor();
            }
            int count = Regex.Matches(s3, pattern4).Count;
            Console.WriteLine("There are "+count+" Occurences");
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
            if (regex4.IsMatch(s5))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Valid Website Address");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Invalid Website Address");
                Console.ResetColor();
            }
        }
    }
}
