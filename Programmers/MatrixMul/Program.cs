using System;

namespace MatrixMul
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            int[,] arr1 = { { 2, 3, 2 }, { 4, 2, 4 }, { 3, 1, 4 } };
            int[,] arr2 = { { 5, 4, 3 }, { 2, 4, 1 }, { 3, 1, 1 } };
            Console.WriteLine(solution.solution(arr1, arr2));
        }
    }

    public class Solution
    {
        public int[,] solution(int[,] arr1, int[,] arr2)
        {
            int[,] answer = new int[arr1.GetLength(0), arr2.GetLength(1)];

            for(int i = 0; i < answer.GetLength(0); i++)
            {
                for(int j = 0; j < answer.GetLength(1); j++)
                {
                    int sum = 0;

                    for (int k = 0; k < arr1.GetLength(1); k++)
                    {
                        sum += arr1[i, k] * arr2[k, j];
                    }

                    answer[i, j] = sum;
                }
            }

            return answer;
        }
    }
}
