using System;

namespace RectangleStar
{
    internal class Program
    {
        public static void Main()
        {
            string[] s;
            s = Console.ReadLine().Split(' ');

            int a = int.Parse(s[0]);
            int b = int.Parse(s[1]);

            for(int i = 0; i < b; i++) 
            {
                for(int j = 0; j < a; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
