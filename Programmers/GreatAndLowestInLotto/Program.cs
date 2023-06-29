using System;
using System.Collections.Generic;
using System.Linq;

namespace GreatAndLowestInLotto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            int[] lottos = { 0, 0, 0, 0, 0, 0 };
            int[] win_nums = { 38, 19, 20, 40, 15, 25 };
            Console.WriteLine(solution.solution(lottos, win_nums));
        }
    }

    public class Solution
    {
        public int[] solution(int[] lottos, int[] win_nums)
        {
            int[] answer = new int[2];
            List<int> numList = new List<int>(lottos);
            int zeroCount = lottos.Where(x => x == 0).Count();
            int checkCount = 0;

            numList.RemoveAll(num => num == 0);

            for (int i = 0; i < numList.Count; i++)
            {
                if (win_nums.Contains(numList[i]))
                {
                    checkCount++;
                }
            }

            int rank = 0;

            switch (checkCount)
            {
                case 6:
                    rank = 1;
                    break;

                case 5:
                    rank = 2;
                    break;

                case 4:
                    rank = 3;
                    break;

                case 3:
                    rank = 4;
                    break;

                case 2:
                    rank = 5;
                    break;

                case 0:
                case 1:
                    rank = 6;
                    break;
            }

            answer[0] = rank - zeroCount > 0 ? rank - zeroCount : 1;
            answer[1] = rank;

            return answer;
        }
    }
}
