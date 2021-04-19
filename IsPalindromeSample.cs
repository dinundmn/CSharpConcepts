using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class IsPalindrome
    {
        private static bool IsPalindrome(string input)
        {
            IEnumerable<char> chaList = input.Reverse<char>();

            string result = new string(chaList.ToArray());
            return (string.Compare(input, result, true) == 0);
        }

        static void Main(string[] args)
        {
            string input = "MADAM";
            if (IsPalindrome(input))
                Console.WriteLine("string is polindrome");
            else
                Console.WriteLine("string is not polindrome");

            Console.ReadLine();
        }
    }
}
