using System;

namespace MakeMin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            int[] A = { 1, 4, 2 };
            int[] B = { 5, 4, 4 };
            Console.WriteLine(solution.solution(A, B));
        }
    }

    public class Solution
    {
        public int solution(int[] A, int[] B)
        {
            int answer = 0;
            Array.Sort(A);
            Array.Sort(B, (x,y) => y.CompareTo(x));

            int length = A.Length;

            for(int i = 0; i < length; i++)
            {
                answer += A[i] * B[i];
            }

            return answer;
        }
    }
}
