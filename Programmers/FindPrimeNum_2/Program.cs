using System;
using System.Collections.Generic;

namespace FindPrimeNum_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            string numbers = "17";
            Console.WriteLine(solution.solution(numbers));
        }
    }

    public class Solution
    {
        HashSet<int> numberSet = new HashSet<int>();

        public int solution(string numbers)
        {
            int answer = 0;

            // HashSet을 통해 모든 숫자 조합을 만듦
            recursive("", numbers);

            // numbers의 숫자만큼 최대수 갱신
            string s_maxVal = "";
            // 각 자리수에 9를 채운다.
            for (int i = 0; i < numbers.Length; i++)
            {
                s_maxVal += "9";
            }
            int maxVal = int.Parse(s_maxVal);

            // 에라토스테네스의 체
            int[] S = new int[maxVal + 1];
            for (int i = 2; i < S.Length; i++)
            {
                S[i] = i;
            }
            for (int i = 2; i < Math.Sqrt(S.Length); i++)
            {
                if (S[i] == 0)
                {
                    continue;
                }
                for (int j = i + i; j < S.Length; j = i + j)
                {
                    S[j] = 0;
                }
            }

            // HashSet에 저장된 값을 체에 걸러 값이 0이 아니면 answer++
            foreach (int num in numberSet)
            {
                if (S[num] != 0)
                {
                    answer++;
                }
            }

            return answer;
        }

        // 숫자 조합을 만드는 재귀함수
        private void recursive(string comb, string other)
        {
            if (!comb.Equals(""))
            {
                numberSet.Add(int.Parse(comb));
            }

            for (int i = 0; i < other.Length; i++)
            {
                recursive(comb + other[i], other.Substring(0, i) + other.Substring(i + 1));
            }

        }
    }
}
