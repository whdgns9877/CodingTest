using System;

namespace HarshadNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            Console.WriteLine(solution.solution(12));
        }
    }

    public class Solution
    {
        public bool solution(int x)
        {
            char[] xToCharArr = x.ToString().ToCharArray();

            int sum = 0;
            for(int i = 0; i < xToCharArr.Length; i++)
            {
                sum += int.Parse(xToCharArr[i].ToString());
            }

            return x % sum == 0 ? true : false;
        }
    }
}
