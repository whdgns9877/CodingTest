using System;

namespace DifferentBitsUnderTwo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            long[] numbers = { 2, 7 };
            Console.WriteLine(solution.solution(numbers));
        }
    }

    public class Solution
    {
        public long[] solution(long[] numbers)
        {
            long[] answer = new long[numbers.Length];

            for (int i = 0; i < numbers.Length; i++)
            {
                long curNum = numbers[i];
                long curNumPlusOne = curNum + 1;

                while (CountDifferentBits(curNum, curNumPlusOne) > 2)
                {
                    curNumPlusOne++;
                }

                answer[i] = curNumPlusOne;
            }

            return answer;
        }

        private int CountDifferentBits(long num1, long num2)
        {
            long xorResult = num1 ^ num2;
            int diffCount = 0;

            while (xorResult > 0)
            {
                diffCount += (int)(xorResult & 1);
                xorResult >>= 1;
            }

            return diffCount;
        }
    }
}
