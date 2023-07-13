using System;

namespace TransformNum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            Console.WriteLine(solution.solution(10, 40, 5));
        }
    }

    public class Solution
    {
        public int solution(int x, int y, int n)
        {
            int[] dp = new int[y + 1];
            for (int i = x; i < y + 1; i++)
            {
                if (i != x && dp[i] == 0)
                {
                    dp[i] = -1;
                    continue;
                }
                if (i * 2 <= y)
                {
                    dp[i * 2] = (dp[i * 2] == 0) ? dp[i] + 1 : Math.Min(dp[i] + 1, dp[i * 2]);
                }
                if (i * 3 <= y)
                {
                    dp[i * 3] = (dp[i * 3] == 0) ? dp[i] + 1 : Math.Min(dp[i] + 1, dp[i * 3]);
                }
                if (i + n <= y)
                {
                    dp[i + n] = (dp[i + n] == 0) ? dp[i] + 1 : Math.Min(dp[i] + 1, dp[i + n]);
                }
            }
            return dp[y];
        }
    }

}
