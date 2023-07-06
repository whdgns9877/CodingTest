using System;

namespace CropArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            Console.WriteLine(solution.solution(3, 2, 5));
        }
    }

    public class Solution
    {
        public long[] solution(int n, long left, long right)
        {
            long[] answer = new long[right - left + 1];

            long row, col;
            long count = 0;

            for (int i = 0; i < answer.Length; i++)
            {
                row = (left + count) / n;
                col = (left + count) % n;

                if (row >= col)
                {
                    answer[i] = row + 1;
                }
                else
                {
                    answer[i] = col + 1;
                }

                count++;
            }

            return answer;
        }
    }
}
