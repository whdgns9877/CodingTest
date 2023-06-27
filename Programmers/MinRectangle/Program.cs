using System;

namespace MinRectangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            int[,] sizes = { { 60, 50 }, { 30, 70 }, { 60, 30 }, { 80, 40 } };
            Console.WriteLine(solution.solution(sizes));
        }
    }

    public class Solution
    {
        public int solution(int[,] sizes)
        {
            int answer = 0;

            int minWidth = 0;
            int minHeight = 0;

            for (int i = 0; i < sizes.GetLength(0); i++)
            {
                if (sizes[i, 0] < sizes[i, 1])
                {
                    int temp = sizes[i, 1];
                    sizes[i, 1] = sizes[i, 0];
                    sizes[i, 0] = temp;
                }
                minWidth = minWidth < sizes[i, 0] ? sizes[i, 0] : minWidth;
                minHeight = minHeight < sizes[i, 1] ? sizes[i, 1] : minHeight;
            }

            answer = minWidth * minHeight;

            return answer;
        }
    }
}
