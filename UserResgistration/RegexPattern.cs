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

        public static void PhoneNumber()
        {
            string[] arr = { "91 9876234523", "85 6947235642", "8569472315", "1235" };
            string pattern = @"^[91\s]*[0-9]{10}";

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

        public static void Password()
        {
            string[] arr = {"ashish231", "ashish", "1256123", "1235"};
            string pattern = @"^[a-zA-Z0-9]{8,}";

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
