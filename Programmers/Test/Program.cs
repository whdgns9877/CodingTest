using System;

namespace Test
{
    internal class Program
    {
        public static void Main()
        {
            int s = int.Parse(Console.ReadLine());

            for (int i = 0; i < s; ++i)
            {
                for (int j = 0; j <= i; ++j)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
