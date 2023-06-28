using System;
using System.Linq;

namespace GetAverage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            int[] arr = { 1, 2, 3, 4 };
            Console.WriteLine(solution.solution(arr));
        }
    }

    public class Solution
    {
        public double solution(int[] arr)
        {
            return arr.Average();
        }
    }
}
