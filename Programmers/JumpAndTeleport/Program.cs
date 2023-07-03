using System;

namespace JumpAndTeleport
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            Console.WriteLine(solution.solution(5000));
        }
    }

    class Solution
    {
        public int solution(int n)
        {
            int answer = 1;

            while(n != 1)
            {
                if(n % 2 == 0)
                {
                    n /= 2;
                }
                else
                {
                    n--;
                    answer++;
                }
            }

            return answer;
        }
    }
}
