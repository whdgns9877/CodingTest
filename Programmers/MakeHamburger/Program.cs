using System;
using System.Text;

namespace MakeHamburger
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            int[] ingredient = { 2, 1, 1, 2, 3, 1, 2, 3, 1 };
            Console.WriteLine(solution.solution(ingredient));
        }
    }

    class Solution
    {
        public int solution(int[] ingredients)
        {
            StringBuilder sb = new StringBuilder();
            int count = 0;

            foreach (int ingredient in ingredients)
            {
                sb.Append(ingredient);

                if (sb.Length >= 4 && sb.ToString(sb.Length - 4, 4) == "1231")
                {
                    sb.Remove(sb.Length - 4, 4);
                    count++;
                }
            }

            return count;
        }
    }
}
