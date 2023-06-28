using System;
using System.Linq;

namespace SignPlus
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            int[] absolutes = { 4, 7, 12 };
            bool[] signs = { true, false, true };
            Console.WriteLine(solution.solution(absolutes, signs));
        }
    }

    public class Solution
    {
        public int solution(int[] absolutes, bool[] signs)
        {
            for(int i = 0; i < absolutes.Length; i++)
            {
                if (signs[i] == false)
                {
                    absolutes[i] *= -1;
                }
            }

            return absolutes.Sum();
        }
    }
}
