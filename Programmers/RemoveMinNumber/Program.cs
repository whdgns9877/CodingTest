using System;
using System.Collections.Generic;
using System.Linq;

namespace RemoveMinNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            int[] arr = { 4, 3, 2, 1 };
            Console.WriteLine(solution.solution(arr));
        }
    }

    public class Solution
    {
        public int[] solution(int[] arr)
        {
            List<int> list = new List<int>(arr);
            list.Remove(list.Min());

            if(list.Count == 0) list.Add(-1);

            return list.ToArray();
        }
    }
}
