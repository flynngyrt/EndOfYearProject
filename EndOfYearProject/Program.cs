using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EndOfYearProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userName;
            string password;
            Console.WriteLine("--------------------------Welcometo the Bus App--------------------------------------");
            Console.WriteLine("This app will let you search for bus routes and get Prices for those respected routes");
            Console.WriteLine("Enter yo name");
            userName = Console.ReadLine();
            Console.WriteLine("Enter your password");
            password = Console.ReadLine();
            
            if (userName = true)
            {
                Console.WriteLine("Welcome admin!");
            }
            else
            {
                Console.WriteLine("Welcome user!");
            }

        }
    }
}