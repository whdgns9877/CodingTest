using System;
using System.Collections.Generic;
using System.Linq;

namespace TrainingSuit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            int[] lost = { 2, 3, 5 };
            int[] reserve = { 2, 3, 4 };
            Console.WriteLine(solution.solution(5, lost, reserve));
        }
    }

    public class Solution
    {
        public int solution(int n, int[] lost, int[] reserve)
        {
            List<int> lostList = new List<int>(lost);
            List<int> reserveList = new List<int>(reserve);

            int checkCount = lostList.Count;

            // 우선 여벌을 갖고있지만 나도 잃어버린상태라면
            // 나는 어디에도 영향을 줄수없는 상태이므로 양쪽 리스트에서 제외
            lostList = lost.Except(reserve).ToList();
            reserveList = reserve.Except(lost).ToList();

            lostList.Sort();
            reserveList.Sort();

            for (int i = 0; i < lostList.Count; i++)
            {
                // 앞사람한테 먼저 물어보고
                if (reserveList.Contains(lostList[i] - 1))
                {
                    reserveList[reserveList.IndexOf(lostList[i] - 1)] = 0;
                    lostList[i] = 0;
                    continue;
                }
                // 없으면 뒷사람 물어본다
                else if (reserveList.Contains(lostList[i] + 1))
                {
                    reserveList[reserveList.IndexOf(lostList[i] + 1)] = 0;
                    lostList[i] = 0;
                    continue;
                }
            }

            return n - lostList.Where(x => x != 0).Count();
        }
    }
}
