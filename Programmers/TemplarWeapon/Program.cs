using System;

namespace TemplarWeapon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            Console.WriteLine(solution.solution(5, 3, 2));
        }
    }

    public class Solution
    {
        public int solution(int number, int limit, int power)
        {
            int answer = 0;

            for(int i = 1; i <= number; ++i)
            {
                int curNum = GetMeasure(i);
                answer += curNum > limit ? power : curNum;
            }

            return answer;
        }

        private int GetMeasure(int num)
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

            return count;
        }

    }
}
