using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheThreeMusketeers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            int[] number = { -2, 3, 0, 2, -5 };
            Console.WriteLine(solution.solution(number));
        }
    }

    public class Solution
    {
        public int solution(int[] number)
        {
            int answer = 0;

            var combinations = number
            .SelectMany((x, i) => number.Skip(i + 1)
                .SelectMany((y, j) => number.Skip(i + j + 2)
                    .Select(z => new { X = x, Y = y, Z = z })))
            .Where(triple => triple.X + triple.Y + triple.Z == 0);

            answer = combinations.Count();

            return answer;
        }
    }
}
