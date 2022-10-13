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
            //UC-7 Rule 3 should have atleast 1 numeric number
            Console.WriteLine("Welcome to User Registration!...");

            RegexPattern.Password();
            Console.ReadLine();
        }
    }
}
