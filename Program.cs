using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program1
    {
        private static bool IsPrimeNumber(int number)
        {
            for (int i = 2; i <= Math.Ceiling(Math.Sqrt(number)); i++)
            {
                if (number != i && number % i == 0)
                {
                    return false;
                }
            }

            return true;
        }

        private static int GetDiff(int low, int high)
        {
            IEnumerable<int> array = Enumerable.Range(low, high - low + 1).Select(x => x);
            var a = array.FirstOrDefault(x => IsPrimeNumber(x) == true);
            var b = array.Reverse().FirstOrDefault(x => IsPrimeNumber(x) == true);
            return a>0 && b> 0 ? b - a : -1;
        }

        public static void Main()
        {
            int numberOfInputs = Convert.ToInt32(Console.ReadLine());
            List<IEnumerable<int>> values = new List<IEnumerable<int>>();

            int i = 0;

            for (i = 0; i < numberOfInputs; i++)
            {
                string input = Console.ReadLine();

                values.Add(input.Split(' ').Select(x => Convert.ToInt32(x)));
            }

            foreach (var item in values)
            {
                Console.WriteLine(GetDiff(item.First(), item.Last()));
            }

            Console.ReadLine();
        }
    }
}
