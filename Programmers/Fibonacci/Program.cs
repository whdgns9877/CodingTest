using System;

namespace Fibonacci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            Console.WriteLine(solution.solution(5));
        }
    }

    public class Solution
    {
        public int solution(int n)
        {
            int answer = Fibonacci(n);
            return answer;
        }

        //private int Fibonacci(int n)
        //{
        //    if (n <= 1)
        //        return n;

        //    int prev1 = 0;
        //    int prev2 = 1;
        //    int result = 0;

        //    for (int i = 2; i <= n; i++)
        //    {
        //        result = (prev1 + prev2) % 1234567;  // 나머지 연산 추가
        //        prev1 = prev2;
        //        prev2 = result;
        //    }

        //    return result;
        //}

        private int Fibonacci(int n)
        {
            if(n == 1)
            {
                return 1;
            }

            if(n == 0)
            {
                return 0;
            }

            return Fibonacci(n - 2) + Fibonacci(n - 1);
        }
    }
}
