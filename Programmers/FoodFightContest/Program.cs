using System;
using System.Linq;
using System.Text;

namespace FoodFightContest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            int[] food = { 1, 7, 1, 2 };
            Console.WriteLine(solution.solution(food));
        }
    }

    public class Solution
    {
        public string solution(int[] food)
        {
            string answer = "";

            StringBuilder sb = new StringBuilder();

            for(int i = 1; i < food.Length; ++i)
            {
                for(int j = 0; j < food[i] / 2; ++j)
                {
                    sb.Append(i);
                }
            }

            sb.Append("0");

            for (int i = food.Length - 1; i >= 0; --i)
            {
                for (int j = 0; j < food[i] / 2; ++j)
                {
                    sb.Append(i);
                }
            }

            answer = sb.ToString();
            return answer;
        }
    }
}
