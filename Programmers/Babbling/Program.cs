using System;

namespace MakeHamburger
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            string[] babbling = { "ayaye", "uuu", "yeye", "yemawoo", "ayaayaa" };
            Console.WriteLine(solution.solution(babbling));
        }
    }

    class Solution
    {
        public int solution(string[] babblings)
        {
            int answer = 0;
            for (int i = 0; i < babblings.Length; i++)
            {
                // 동일한게 두번나오면 건너뜀
                if (babblings[i].Contains("ayaaya") || babblings[i].Contains("yeye") || babblings[i].Contains("woowoo") || babblings[i].Contains("mama"))
                {
                    continue;
                }

                // 발음 가능한 단어들을 공백으로 대체
                babblings[i] = babblings[i].Replace("aya", " ");
                babblings[i] = babblings[i].Replace("ye", " ");
                babblings[i] = babblings[i].Replace("woo", " ");
                babblings[i] = babblings[i].Replace("ma", " ");
                babblings[i] = babblings[i].Replace(" ", "");

                if (babblings[i].Length == 0)
                {
                    answer++;
                }
            }
            return answer;
        }
    }
}
