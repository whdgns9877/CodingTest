using System;
using System.Collections.Generic;
using System.Linq;

namespace FindPrimeNum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            Console.WriteLine(solution.solution(120));
        }
    }

    public class Solution
    {
        public int solution(int n)
        {
            int answer = 0;
            bool[] isPrime = new bool[n + 1]; // 소수 여부를 저장하는 배열

            // 초기화: 모든 수를 소수로 가정
            for (int i = 2; i <= n; i++)
            {
                isPrime[i] = true;
            }

            // 에라토스테네스의 체 알고리즘 적용
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (isPrime[i])
                {
                    for (int j = i * i; j <= n; j += i)
                    {
                        isPrime[j] = false;
                    }
                }
            }

            answer = isPrime.Where(x => x == true).Count();

            return answer;
        }
    }
}
