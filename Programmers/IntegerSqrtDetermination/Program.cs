using System;

namespace IntegerSqrtDetermination
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            Console.WriteLine(solution.solution(121));
        }
    }

    public class Solution
    {
        public long solution(long n)
        {
            long sqrt =  (int)Math.Sqrt(n);
            return sqrt * sqrt == n ? (sqrt + 1) * (sqrt + 1) : -1;
        }
    }
}
