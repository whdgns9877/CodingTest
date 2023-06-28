using System;

namespace NumOfDivisorsAndPlus
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            Console.WriteLine(solution.solution(13, 17));
        }
    }

    public class Solution
    {
        public int solution(int left, int right)
        {
            int answer = 0;

            for (int i = left; i <= right; i++)
            {
                answer += GetNumOfDivisors(i) * i;
            }

            return answer;
        }

        private int GetNumOfDivisors(int num)
        {
            int count = 0;
            for (int i = 1; i * i <= num; i++)
            {
                if (num % i == 0)
                {
                    // i가 num의 약수인 경우
                    count++;

                    // i와 num/i가 서로 다른 약수인 경우
                    if (i != num / i)
                    {
                        count++;
                    }
                }
            }
            return (count % 2 == 0 ? 1 : -1);
        }
    }
}
