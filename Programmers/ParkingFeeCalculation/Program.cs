using System;
using System.Collections.Generic;
using System.Linq;

namespace ParkingFeeCalculation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            int[] fees = { 180, 5000, 10, 600 };
            string[] records = { "05:34 5961 IN", "06:00 0000 IN", "06:34 0000 OUT", "07:59 5961 OUT", "07:59 0148 IN", "18:59 0000 IN", "19:09 0148 OUT", "22:59 5961 IN", "23:00 5961 OUT" };
            Console.WriteLine(solution.solution(fees, records));
        }
    }

    public class Solution
    {
        public int[] solution(int[] fees, string[] records)
        {
            List<int> answer = new List<int>();

            Dictionary<string, List<string>> recordDic = new Dictionary<string, List<string>>();

            int minTime = fees[0];
            int minFee = fees[1];
            int unitTime = fees[2];
            int unitFee = fees[3];

            for(int i = 0; i < records.Length; i++)
            {
                string[] split = records[i].Split(' ');

                if (!recordDic.ContainsKey(split[1]))
                {
                    List<string> list = new List<string>();
                    list.Add(split[0]);
                    recordDic.Add(split[1], list);
                }
                else
                {
                    recordDic[split[1]].Add(split[0]);
                }
            }

            string[] keys = recordDic.Keys.ToArray();

            Array.Sort(keys);

            for(int i = 0; i < keys.Length; i++)
            {
                List<string> curList = recordDic[keys[i]];

                int curEntireParkingTime = 0;

                for(int j = 0; j < curList.Count; j++)
                {
                    string[] timeStr = curList[j].Split(':');
                    int hour = int.Parse(timeStr[0]) * 60;
                    int min = int.Parse(timeStr[1]);

                    // 홀수 번째는 빼고
                    if(j % 2 == 0)
                    {
                        curEntireParkingTime -= (hour + min);
                    }
                    // 짝수 번째는 더한다
                    else
                    {
                        curEntireParkingTime += (hour + min);
                    }
                }

                // 입차 후 출차 하지 않은 차는 23 : 59에 출차로 계산
                if(curList.Count % 2 == 1)
                {
                    curEntireParkingTime += (23 * 60) + 59;
                }

                if(curEntireParkingTime < minTime)
                {
                    answer.Add(minFee);
                }
                else
                {
                    int fee = minFee + (int)Math.Ceiling((curEntireParkingTime - (decimal)minTime) / unitTime) * unitFee;
                    answer.Add(fee);
                }
            }

            return answer.ToArray();
        }
    }
}
