using System;

namespace CalculateShortFall
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            Console.WriteLine(solution.solution(3, 20, 4));
        }
    }

    class Solution
    {
        public long solution(int price, int money, int count)
        {
            long curUseMoney = 0;

            for(int i = 1; i <= count; i++)
            {
                curUseMoney += price * i;
            }

            return curUseMoney - money < 0 ? 0 : curUseMoney - money;
        }
    }
}
