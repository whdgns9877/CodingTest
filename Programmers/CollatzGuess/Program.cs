using System;

namespace CollatzGuess
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            Console.WriteLine(solution.solution(626331));
        }
    }

    public class Solution
    {
        public int solution(int num)
        {
            if (num == 1) return 0;
            int count = 0;
            long curNum = num;
            while (count < 500)
            {
                if (curNum % 2 == 0)
                {
                    curNum /= 2;
                }
                else
                {
                    curNum = (curNum * 3) + 1;
                }
                count++;
                if (curNum == 1) return count;
            }

            return -1;
        }
    }
}
