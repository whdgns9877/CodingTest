using System;

namespace EvenAndOdd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            Console.WriteLine(solution.solution(3));
        }
    }

    public class Solution
    {
        public string solution(int num)
        {
            return num % 2 == 0 ? "Even" : "Odd";
        }
    }
}
