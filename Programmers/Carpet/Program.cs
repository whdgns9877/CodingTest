using System;
using System.Collections.Generic;

namespace Carpet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            Console.WriteLine(solution.solution(24, 24));
        }
    }

    public class Solution
    {
        public int[] solution(int brown, int yellow)
        {
            int[] answer = new int[2];

            int square = brown + yellow;

            List<int> measure = new List<int>();
            int sqrt = 0;
            for(int i = 3; i * i <= square; ++i)
            {
                if(square % i == 0)
                {
                    measure.Add(i);
                    int curNum = square / i;
                    if (i != curNum)
                    {
                        measure.Add(curNum);
                    }
                    else
                    {
                        sqrt = curNum;
                    }
                }
            }

            for(int i = 0; i < measure.Count; i += 2)
            {
                if (measure[i] == sqrt)
                {
                    if( (measure[i] * 2) + (measure[i] - 2) * 2 == brown)
                    {
                        answer[0] = measure[i];
                        answer[1] = measure[i];
                    }
                }
                else
                {
                    if((measure[i + 1] * 2) + (measure[i] - 2) * 2 == brown)
                    {
                        answer[0] = measure[i + 1];
                        answer[1] = measure[i];
                    }
                }
            }

            return answer;
        }
    }
}
