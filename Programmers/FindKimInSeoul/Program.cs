using System;

namespace FindKimInSeoul
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            string[] seoul = { "Jane", "Kim" };
            Console.WriteLine(solution.solution(seoul));
        }
    }

    public class Solution
    {
        public string solution(string[] seoul)
        {
            const string KIM = "Kim";
            int index = 0;
            for (int i = 0; i < seoul.Length; i++)
            {
                if (seoul[i].Equals(KIM))
                {
                    index = i;
                }
            }

            return $"김서방은 {index}에 있다";
        }
    }
}
