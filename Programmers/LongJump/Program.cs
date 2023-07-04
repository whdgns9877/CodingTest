using System;

namespace LongJump
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            Console.WriteLine(solution.solution(4));
        }
    }

    public class Solution
    {
        public long solution(int n)
        {
            long[] dp = new long[2001];

            dp[1] = 1;
            dp[2] = 2;

            if (n  == 1)
            {
                return dp[1];
            }

            if (n == 1)
            {
                return dp[2];
            }
            
            for (int i = 3; i <= n; i++)
            {
                dp[i] = (dp[i - 2] + dp[i - 1]) % 1234567;
            }
            return dp[n];
        }
    }
}
