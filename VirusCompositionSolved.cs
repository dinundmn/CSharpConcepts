using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class VirusCompositionSolved
    {
        public static string VirusComposition = string.Empty;

        public static bool IsPatientPositive(string bloodComposition)
        {
            int startIndex = 0;

            if (startIndex != -1)
            {
                int i = 0;
                int j = 0;

                do
                {
                    i = VirusComposition.IndexOf(bloodComposition[j], startIndex);

                    if (i != -1)
                    {
                        startIndex = i;
                    }
                    else
                    {
                        return false;
                    }

                    j++;

                } while (j < bloodComposition.Length);

                return (j == bloodComposition.Length);
            }
            else
            {
                return false;
            }
        }

        public static void Main()
        {
            VirusComposition = Console.ReadLine();

            int numberOfPeople = Convert.ToInt32(Console.ReadLine());

            List<string> bloodCompositions = new List<string>();

            for (int i = 0; i < numberOfPeople; i++)
            {
                bloodCompositions.Add(Console.ReadLine());
            }

            foreach (var bloodComposition in bloodCompositions)
            {
                Console.WriteLine(IsPatientPositive(bloodComposition) ? "POSITIVE" : "NEGATIVE");
            }

            Console.ReadLine();
        }
    }
}
