using System;

namespace DeckOfCards
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();

            string[] cards1 = { "a", "b", "c" };
            string[] cards2 = { "d", "e", "f" };
            string[] goal = { "a", "d", "f" };

            Console.WriteLine(solution.solution(cards1, cards2, goal));
        }
    }

    public class Solution
    {
        public string solution(string[] cards1, string[] cards2, string[] goal)
        {
            string answer = "Yes";

            int one = 0;
            int two = 0;

            int i = 0;
            while (i < goal.Length)
            {
                if (one < cards1.Length && goal[i].Equals(cards1[one]))
                {
                    one++;
                }
                else if (two < cards2.Length && goal[i].Equals(cards2[two]))
                {
                    two++;
                }
                else
                {
                    answer = "No";
                    break;
                }
                i++;
            }

            return answer;
        }
    }

}
