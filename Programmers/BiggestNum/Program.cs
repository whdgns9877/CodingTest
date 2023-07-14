using System;

namespace BiggestNum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            int[] numbers = { 3, 30, 34, 5, 9 };
            Console.WriteLine(solution.solution(numbers));
        }
    }

    public class Solution
    {
        public string solution(int[] numbers)
        {
            string[] numStrArr = Array.ConvertAll(numbers, x => x.ToString());

            Array.Sort(numStrArr, (a, b) => (b + a).CompareTo(a + b));

            string answer = string.Join("", numStrArr);

            if (int.TryParse(answer, out int result) == true)
            {
                if(result == 0)
                {
                    return "0";
                }
            }

            return answer;
        }
    }
}
