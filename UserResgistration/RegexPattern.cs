using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserResgistration
{
    public class RegexPattern
    {
        

        public static void FirstName()
        {
            string[] arr = { "Ashish", "ashish", "as23", "AShish334" };
            string pattern = "^[A-Z][a-z]{3}";

            foreach (string input in arr)
            {
                if (Regex.IsMatch(input, pattern))
                {
                    Console.WriteLine("{0} is valid", input);
                }
                else
                {
                    Console.WriteLine("{0} is Invalid", input);
                }
            }
        }

        public static void LastName()
        {
            string[] arr = { "Patil", "patil", "pa23", "PAtil334" };
            string pattern = "^[A-Z][a-z]{3}";

            foreach (string input in arr)
            {
                if (Regex.IsMatch(input, pattern))
                {
                    Console.WriteLine("{0} is valid", input);
                }
                else
                {
                    Console.WriteLine("{0} is Invalid", input);
                }
            }
        }

        public static void Email()
        {
            string[] arr = { "ashish2000patil@gmail.com", "Ashishpatil", "ashish.come", "ashish2000patil@gmail" };
            string pattern = @"^[a-z0-9_\-\.]+[@][a-z]+[\.][a-z]{2,3}";

            foreach (string input in arr)
            {
                if (Regex.IsMatch(input, pattern))
                {
                    Console.WriteLine("{0} is valid", input);
                }
                else
                {
                    Console.WriteLine("{0} is Invalid", input);
                }
            }
        }
    }
}
