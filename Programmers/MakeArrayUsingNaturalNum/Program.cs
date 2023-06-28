using System;

namespace MakeArrayUsingNaturalNum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            Console.WriteLine(solution.solution(12345));
        }
    }

    public class Solution
    {
        public int[] solution(long n)
        {
            char[] nToCharArr = n.ToString().ToCharArray();
            Array.Reverse(nToCharArr);
            int[] answer = new int[nToCharArr.Length];

            for(int i = 0; i < nToCharArr.Length; i++)
            {
                answer[i] = int.Parse(nToCharArr[i].ToString());
            }

            return answer;
        }
    }
}
