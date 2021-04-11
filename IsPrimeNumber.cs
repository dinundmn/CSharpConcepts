using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp21
{
    class Program
    {
        private static bool IsPrime(int number)
        {
            for (int i = 2; i <= (int)Math.Ceiling(Math.Sqrt(number)); i++)
            {
                if (number != i && number % i == 0)
                {
                    return false;
                }
            }

            return true;
        }

        private static string CheckAndDisplayPrimeResult(int number)
        {
            string msg = IsPrime(number) ? "\b" : "not";
            return $"{number} is {msg} a prime number";
        }

        public static void Main()
        {
            Console.WriteLine(CheckAndDisplayPrimeResult(1123));
            Console.WriteLine(CheckAndDisplayPrimeResult(3187));
            Console.WriteLine(CheckAndDisplayPrimeResult(7919));
            Console.WriteLine(CheckAndDisplayPrimeResult(899));
        }
    }
}
