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
            //UC-3 Validate Email
            Console.WriteLine("Welcome to User Registration!...");

            RegexPattern.Email();
            Console.ReadLine();
        }
    }
}
