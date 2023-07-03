using System;
using System.Linq;

namespace NextBigNum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            Console.WriteLine(solution.solution(78));
        }
    }

    class Solution
    {
        public int solution(int n)
        {
            string numStr = Convert.ToString(n, 2);

            int oneNum = Array.FindAll(numStr.ToCharArray(), x => x == '1').Count();

            int nextOneNum = 0;

            int idx = 1;
            
            while(true)
            {
                string nextNumStr = Convert.ToString(n + idx, 2);
                nextOneNum = Array.FindAll(nextNumStr.ToCharArray(), x => x == '1').Count();
                if(nextOneNum == oneNum)
                {
                    break;
                }
                idx++;
            }

            return n + idx;
        }
    }
}
