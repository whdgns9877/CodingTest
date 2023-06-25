using System;

namespace FruitSeller
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            int[] score = { 4, 1, 2, 2, 4, 4, 4, 4, 1, 2, 4, 2 };
            Console.WriteLine(solution.solution(4, 3, score));
        }
    }

    public class Solution
    {
        public int solution(int k, int m, int[] score)
        {
            int answer = 0;

            Array.Sort(score);
            int curIdx = score.Length;

            for(int i = 0; i < score.Length / m; ++i)
            {
                curIdx -= m;
                int groupScore = score[curIdx];
                answer += groupScore * m;
            }

            return answer;
        }
    }


}
