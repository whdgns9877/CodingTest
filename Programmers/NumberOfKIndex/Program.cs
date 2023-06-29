using System;

namespace NumberOfKIndex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            int[] array = { 1, 5, 2, 6, 3, 7, 4 };
            int[,] commands = { { 2, 5, 3 }, { 4, 4, 1 }, { 1, 7, 3 } };
            Console.WriteLine(solution.solution(array, commands));
        }
    }

    public class Solution
    {
        public int[] solution(int[] array, int[,] commands)
        {
            int[] answer = new int[commands.GetLength(0)];
            // commands의 a,b,c 가있을때 array를 a~b까지 자르고 정렬한 뒤 c번째 요소

            for (int i = 0; i < commands.GetLength(0); i++)
            {
                int[] tempArr = new int[commands[i, 1] - commands[i, 0] + 1];
                Array.ConstrainedCopy(array, commands[i, 0] - 1, tempArr, 0, commands[i, 1] - commands[i, 0] + 1);
                Array.Sort(tempArr);
                answer[i] = tempArr[commands[i, 2] - 1];
            }

            return answer;
        }
    }
}
