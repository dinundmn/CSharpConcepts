class Program
    {
        static void Main(string[] args)
        {
            List<int> num = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8 };
            var evenNum = num.Where(x => x%2 == 0);

            num.AddRange(new int[] { 11, 12 });

            foreach (var item in evenNum)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }
