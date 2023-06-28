using System;

namespace SumBetweenTwoIntegers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            Console.WriteLine(solution.solution(3, 5));
        }
    }

    public class Solution
    {
        public long solution(int a, int b)
        {
            long answer = 0;
            int low = 0;
            int high = 0;
            if(a < b)
            {
                low = a;
                high = b;
            }
            else
            {
                low = b;
                high = a;
            }

            for(int i = low; i <= high; i++)
            {
                answer += i;
            }
            return answer;
        }
    }
}
