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
            //UC-5 Rule 1 Minumum 8 Characters
            Console.WriteLine("Welcome to User Registration!...");

            RegexPattern.Password();
            Console.ReadLine();
        }
    }
}
