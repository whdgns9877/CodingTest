using System;

namespace NCountsSpacedByX
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            Console.WriteLine(solution.solution(2,5));
        }
    }

    public class Solution
    {
        public long[] solution(int x, int n)
        {
            long[] answer = new long[n];
            long num = 0;
            for(int i = 0; i < n; i++)
            {
                num += (long)x;
                answer[i] = num;
            }
            return answer;
        }
    }
}
