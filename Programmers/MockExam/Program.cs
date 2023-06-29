using System;
using System.Collections.Generic;

namespace MockExam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            int[] answers = { 1, 3, 2, 4, 2 };
            Console.WriteLine(solution.solution(answers));
        }
    }

    public class Solution
    {
        public int[] solution(int[] answers)
        {
            int[] answer = new int[3];
            //1번 수포자가 찍는 방식: 1, 2, 3, 4, 5, 1, 2, 3, 4, 5, ...
            //2번 수포자가 찍는 방식: 2, 1, 2, 3, 2, 4, 2, 5, 2, 1, 2, 3, 2, 4, 2, 5, ...
            //3번 수포자가 찍는 방식: 3, 3, 1, 1, 2, 2, 4, 4, 5, 5, 3, 3, 1, 1, 2, 2, 4, 4, 5, 5, ...

            int[] firstPattern = { 1, 2, 3, 4, 5 };
            int[] secondPattern = { 2, 1, 2, 3, 2, 4, 2, 5 };
            int[] thirdPattern = { 3, 3, 1, 1, 2, 2, 4, 4, 5, 5 };

            int firstIdx = 0;
            int secondIdx = 0;
            int thirdIdx = 0;

            for (int i = 0; i < answers.Length; i++)
            {
                if (answers[i] == firstPattern[firstIdx])
                {
                    answer[0] += 1;
                }

                if (answers[i] == secondPattern[secondIdx])
                {
                    answer[1] += 1;
                }

                if (answers[i] == thirdPattern[thirdIdx])
                {
                    answer[2] += 1;
                }

                firstIdx++;
                if (firstIdx == firstPattern.Length)
                {
                    firstIdx = 0;
                }

                secondIdx++;
                if (secondIdx == secondPattern.Length)
                {
                    secondIdx = 0;
                }

                thirdIdx++;
                if (thirdIdx == thirdPattern.Length)
                {
                    thirdIdx = 0;
                }
            }

            int max = 0;

            for (int i = 0; i < 3; ++i)
            {
                if (answer[i] > max) max = answer[i];
            }

            List<int> result = new List<int>();

            if (max == answer[0]) result.Add(1);
            if (max == answer[1]) result.Add(2);
            if (max == answer[2]) result.Add(3);

            return result.ToArray();
        }
    }
}
