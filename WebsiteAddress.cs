using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Day_8Practice
{
    internal class WebsiteAddress
    {
        public void CheckWebsiteAddress()
        {
            Console.WriteLine("Enter Website Address: ");
            string s5 = Console.ReadLine();
            string pattern6 = "(https:\\/\\/www\\.|http:\\/\\/www\\.|https:\\/\\/|http:\\/\\/)?[a-zA-Z0-9]{2,}(\\.[a-zA-Z0-9]{2,})(\\.[a-zA-Z0-9]{2,})?";
            Regex regex4 = new Regex(pattern6);
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
