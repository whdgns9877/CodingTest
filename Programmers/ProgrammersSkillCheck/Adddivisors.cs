using System;

namespace ProgrammersSkillCheck
{
    public class Adddivisors
    {
        public int solution(int left, int right)
        {
            int answer = 0;

            for (int i = left; i <= right; i++)
            {
                int count = GetDivisorCount(i);

                answer += (count % 2 == 0) ? i : -i;
            }

            return answer;
        }

        private int GetDivisorCount(int number)
        {
            int count = 0;
            int sqrt = (int)Math.Sqrt(number);

            for (int i = 1; i <= sqrt; i++)
            {
                if (number % i == 0)
                {
                    count += 2; // 짝수 약수 개수 카운트 (i와 number/i)
                }
            }

            // 제곱수인 경우 중복 카운트 방지
            if (sqrt * sqrt == number)
            {
                count--;
            }

            return count;
        }

    }
}
