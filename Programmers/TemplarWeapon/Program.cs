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
            int sqrt = (int)Math.Sqrt(num);

            for (int i = 1; i <= sqrt; i++)
            {
                if (num % i == 0)
                {
                    count++;

                    // 제곱수인 경우, 제곱근을 중복으로 세지 않도록 처리
                    if (i != sqrt)
                    {
                        count++;
                    }
                }
            }

            return count;
        }
    }
}
