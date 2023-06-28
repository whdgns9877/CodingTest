using System;

namespace MatrixAddition
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            int[,] arr1 = { { 1, 2 }, { 2, 3 } };
            int[,] arr2 = { { 3, 4 }, { 5, 6 } };

            Console.WriteLine(solution.solution(arr1, arr2));
        }
    }

    public class Solution
    {
        public int[,] solution(int[,] arr1, int[,] arr2)
        {
            int[,] answer = new int[arr1.GetLength(0), arr1.GetLength(1)];

            for (int i = 0; i < answer.GetLength(0); i++)
            {
                for (int j = 0; j < answer.GetLength(1); j++)
                {
                    answer[i, j] = arr1[i, j] + arr2[i, j];
                }
            }

            return answer;
        }
    }
}
