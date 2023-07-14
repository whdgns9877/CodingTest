using System;
using System.Collections.Generic;

namespace CutRollCake
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            int[] topping = {5,4,3,2, 1, 2, 1, 3, 1, 4, 1, 2 };
            Console.WriteLine(solution.solution(topping));
        }
    }

    public class Solution
    {
        public int solution(int[] topping)
        {
            int[] leftCumulativeSum = GetLeftCumulativeSum(topping);
            int[] rightCumulativeSum = GetRightCumulativeSum(topping);
            int answer = GetCount(leftCumulativeSum, rightCumulativeSum);
            return answer;
        }

        private int GetCount(int[] leftCumulativeSum, int[] rightCumulativeSum)
        {
            int count = 0;
            for (int idx = 0; idx < leftCumulativeSum.Length - 1; idx++)
            {
                if (leftCumulativeSum[idx] == rightCumulativeSum[idx + 1])
                {
                    count++;
                }
            }
            return count;
        }

        // 0~i idx까지의 조각의 종류 개수
        private int[] GetLeftCumulativeSum(int[] topping)
        {
            int[] arr = new int[topping.Length];
            HashSet<int> alreadyIn = new HashSet<int>();
            for (int i = 0, count = 0; i < topping.Length; i++)
            {
                int num = topping[i];
                if (!alreadyIn.Contains(num))
                {
                    alreadyIn.Add(num);
                    count++;
                }
                arr[i] = count;
            }
            return arr;
        }

        //N-1 ~ i idx까지의 조각의 종류의 개수
        private int[] GetRightCumulativeSum(int[] topping)
        {
            int[] arr = new int[topping.Length];
            HashSet<int> alreadyIn = new HashSet<int>();
            for (int i = topping.Length - 1, count = 0; i >= 0; i--)
            {
                int num = topping[i];
                if (!alreadyIn.Contains(num))
                {
                    alreadyIn.Add(num);
                    count++;
                }
                arr[i] = count;
            }
            return arr;
        }
    }
}
