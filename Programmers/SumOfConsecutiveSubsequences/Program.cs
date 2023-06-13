using System;
using System.Collections.Generic;
using System.Linq;

namespace SumOfConsecutiveSubsequences
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            int[] sequence = { 2, 2, 2, 2, 2 };
            int[] result = solution.solution(sequence, 6);

            for(int i = 0; i < result.Length; i++) 
            { 
                Console.Write(result[i] + " ");
            }
        }
    }

    public class Solution
    {
        public int[] solution(int[] sequence, int k)
        {
            List<int[]> tempList = new List<int[]>();
            for (int i = 0; i < sequence.Length; ++i)
            {
                if (sequence[i] == k)
                {
                    tempList.Add(new int[2] { i, i });
                }
                int sum = sequence[i];
                for (int j = i + 1; j < sequence.Length; ++j)
                {
                    sum += sequence[j];

                    if (sum < k)
                    {
                        continue;
                    }
                    else if (sum == k)
                    {
                        int[] tempArr = new int[j - i + 1];
                        for (int idx = 0; idx < tempArr.Length; ++idx)
                        {
                            tempArr[idx] = i++;
                        }
                        tempList.Add(tempArr);
                        break;
                    }
                    else
                    {
                        break;
                    }
                }
            }

            int min = 0;

            if (tempList.Count > 1)
            {
                for (int i = 0; i < tempList.Count - 1; ++i)
                {
                    if (tempList[i].Length > tempList[i + 1].Length)
                    {
                        min = i + 1;
                    }
                }
            }

            int[] resultArr = { tempList[min].Min(), tempList[min].Max() };

            return resultArr;
        }
    }
}
