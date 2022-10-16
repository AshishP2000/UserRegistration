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
            string[] arr = {"Ashishasd1@", "Ashisha1", "1256123", "1235"};
            string pattern = @"[A-Z][0-9]{0,1}[a-z]{6,}[0-9]{1,}[!@#$%^&*?-]{1}";

            string ErrorMessage = string.Empty;
            var hasNumber = new Regex(@"[0-9]+");
            var hasUpperChar = new Regex(@"[A-Z]+");
            var hasMiniMaxChars = new Regex(@".{8,15}");
            var hasLowerChar = new Regex(@"[a-z]+");
            var hasSymbols = new Regex(@"[!@#$%^&*()_+=\[{\]};:<>|./?,-]");

            foreach (string input in arr)
            {
                if (!hasLowerChar.IsMatch(input))
                {
                    ErrorMessage = "Password should contain at least one lower case letter.";
                    Console.WriteLine(ErrorMessage);
                }
                else if (!hasUpperChar.IsMatch(input))
                {
                    ErrorMessage = "Password should contain at least one upper case letter.";
                    Console.WriteLine(ErrorMessage);
                }
                else if (!hasMiniMaxChars.IsMatch(input))
                {
                    ErrorMessage = "Password should not be lesser than 8 or greater than 15 characters.";
                    Console.WriteLine(ErrorMessage);
                }
                else if (!hasNumber.IsMatch(input))
                {
                    ErrorMessage = "Password should contain at least one numeric value.";
                    Console.WriteLine(ErrorMessage);
                }

                else if (!hasSymbols.IsMatch(input))
                {
                    ErrorMessage = "Password should contain at least one special case character.";
                    Console.WriteLine(ErrorMessage);
                }
                else
                {
                    Console.WriteLine("{0} Valid", input);
                }
            }
        }
    }
}
