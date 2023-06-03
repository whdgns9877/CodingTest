using System.Linq;

namespace AddMissingNums
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            int[] numbers = { 1, 2, 3, 4, 6, 7, 8, 0 };
            solution.solution(numbers);
        }
    }

    public class Solution
    {
        public int solution(int[] numbers)
        {
            int answer = 0;
            for (int i = 0; i <= 9; ++i)
            {
                if (!numbers.Contains(i))
                {
                    answer += i;
                }
            }
            return answer;
        }
    }
}
