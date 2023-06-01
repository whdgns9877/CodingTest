using System.Collections.Generic;

namespace RearBigNum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            int[] numbers = new int[] { 9, 1, 5, 3, 6, 2 };
            solution.solution(numbers);
        }
    }


    public class Solution
    {
        public int[] solution(int[] numbers)
        {
            int[] answer = new int[numbers.Length];
            Stack<int> stack = new Stack<int>();

            for (int i = 0; i < numbers.Length; i++)
            {
                while (stack.Count > 0 && numbers[stack.Peek()] < numbers[i])
                {
                    answer[stack.Pop()] = numbers[i];
                }
                stack.Push(i);
            }

            while (stack.Count > 0)
            {
                answer[stack.Pop()] = -1;
            }

            return answer;
        }
    }
}
