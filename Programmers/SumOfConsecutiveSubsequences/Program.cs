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
            int lt = 0;
            int rt = 0;
            int ptrLen = int.MaxValue;
            int sum = 0;
            int[] answer = new int[2];

            while (rt < sequence.Length && lt <= rt)
            {
                if (lt == rt)
                {
                    sum = sequence[lt];
                }

                if (sum == k)
                {
                    if (ptrLen > rt - lt + 1)
                    {
                        ptrLen = rt - lt + 1;
                        answer[0] = lt;
                        answer[1] = rt;
                    }

                    sum -= sequence[lt];

                    if (rt + 1 < sequence.Length)
                    {
                        sum += sequence[rt + 1];
                    }

                    if (lt == rt)
                    {
                        break;
                    }

                    lt++;
                    rt++;
                }
                else if (sum > k)
                {
                    sum -= sequence[lt];
                    lt++;
                }
                else if (sum < k)
                {
                    if (rt + 1 < sequence.Length)
                    {
                        sum += sequence[rt + 1];
                    }
                    rt++;
                }
            }

            return answer;
        }
    }
}
