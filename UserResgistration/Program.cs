using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserResgistration
{
    public class Program
    {
        static void Main(string[] args)
        {
            //UC-4 Validate Phone Number
            Console.WriteLine("Welcome to User Registration!...");

            RegexPattern.PhoneNumber();
            Console.ReadLine();
        }
    }
}
