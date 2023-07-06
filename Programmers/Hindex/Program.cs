using System;

namespace Hindex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            int[] citations = { 3, 0, 6, 1, 5 };
            Console.WriteLine(solution.solution(citations));
        }
    }

    public class Solution
    {
        public int solution(int[] citations)
        {
            int answer = 0;
            Array.Sort(citations);

            for (int i = citations.Length - 1; i >= 0; i--)
            {
                int hIndex = citations.Length - i; // 현재 검사 중인 h-index
                int paperCount = citations[i]; // 현재 논문 인용 횟수

                if (paperCount >= hIndex) // h-index 조건을 만족하면
                {
                    answer = hIndex;
                }
                else
                {
                    break; // h-index 조건을 만족하지 않으면 더 이상 검사할 필요 없음
                }
            }

            return answer;
        }
    }

}
