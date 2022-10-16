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
            //UC-8 Rule 4 should have atleast 1 special character
            Console.WriteLine("Welcome to User Registration!...");

            RegexPattern.Password();
            Console.ReadLine();
        }
    }
}
