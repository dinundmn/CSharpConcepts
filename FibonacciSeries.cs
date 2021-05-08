using System;
using System.Collections.Generic;

namespace ConsoleApp24
{
    class Program
    {
        private static Dictionary<int, int> fibResults = new Dictionary<int, int>();

        private static int Fib(int n)
        {
            if (!fibResults.ContainsKey(n))
            {
                if (n <= 1)
                {
                    fibResults[n] = n;
                }
                else
                {
                    fibResults[n]  = Fib(n - 1) + Fib(n - 2);
                }
            }

            return fibResults[n];
        }
        static void Main(string[] args)
        {
            for (int i = 0; i <= 6; i++)
            {
                Console.Write($"{Fib(i)} ");
            }

            Console.ReadLine();
        }
    }
}
