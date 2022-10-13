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
            //UC-6 Rule 2 should have atleast 1 uppercase
            Console.WriteLine("Welcome to User Registration!...");

            RegexPattern.Password();
            Console.ReadLine();
        }
    }
}
