using System;

namespace ExpectedBracket
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            Console.WriteLine(solution.solution(4, 1, 2));
        }
    }

    class Solution
    {
        public int solution(int n, int a, int b)
        {
            int answer = 0;
            a = a - 1;
            b = b - 1;
            while (a / 2 != b / 2)
            {
                a = a / 2;
                b = b / 2;
                answer += 1;
            }

            answer += 1;
            return answer;
        }
    }
}
