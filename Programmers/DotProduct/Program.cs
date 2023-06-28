using System;

namespace DotProduct
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            int[] a = { 1, 2, 3, 4 };
            int[] b = { -3, -1, 0, 2 };
            Console.WriteLine(solution.solution(a, b));
        }
    }


    public class Solution
    {
        public int solution(int[] a, int[] b)
        {
            int answer = 0;

            for(int i = 0; i < a.Length; i++)
            {
                answer += a[i] * b[i];
            }

            return answer;
        }
    }
}
